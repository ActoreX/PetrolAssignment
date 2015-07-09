using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;



namespace Naloga3
{
    // Using Selenium dlls and PhantomJS executable
    using OpenQA.Selenium;
    using OpenQA.Selenium.PhantomJS;
    using OpenQA.Selenium.Support.UI;
    using System.Threading;
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // properly initialize some of default values
            this.pictureBoxCubeGif.ImageLocation = string.Format("{0}\\{1}", Directory.GetCurrentDirectory(), "Cube.gif"); // Cube.gif must be in same folder as executable
            
            comboBox_market.SelectedIndex = 0;
            textBoxLTGlavnaPath.Text = string.Format("{0}\\{1}.cvs", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kapar-LT-Glavna");
            textBoxLTPodpornaPath.Text = string.Format("{0}\\{1}.cvs", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kapar-LT-Podporna");
            //
        }
        
        // delegate for fetch data
        public delegate void DelegateFetchData(ref PhantomJSDriver driver, ref IWebElement myContent, ref IWebElement bidDetails, ref string[] enteredData);
        // delegate for write data to file
        public delegate void DelegateWriteData(ref IWebElement content, ref StreamWriter outputFileStream);

        private void btn_fetchData_Click(object sender, EventArgs e)
        {
            string[] enteredData = new string[5];
            enteredData[0] = comboBox_market.SelectedItem.ToString();
            enteredData[1] = string.Format("{0}/{1}/{2}", dateTimePickerFrom.Value.Day, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Year);
            enteredData[2] = string.Format("{0}/{1}/{2}", dateTimePickerTo.Value.Day, dateTimePickerTo.Value.Month, dateTimePickerTo.Value.Year);
            enteredData[3] = textBoxLTGlavnaPath.Text;
            enteredData[4] = textBoxLTPodpornaPath.Text;

            PhantomJSDriver driver = null;
            IWebElement myContent = null;
            IWebElement bidDetails = null;
            
            

            // prepare delegate for fetchData function call
            DelegateFetchData fetchDataInvoker = new DelegateFetchData(fetchData);

            
            // invoke delegate fetchDataInvoker (start with fetchData execution) 
            try
            {
                fetchDataInvoker.BeginInvoke(ref driver, ref myContent, ref bidDetails, ref enteredData, new AsyncCallback(saveDataCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private PhantomJSDriver getWebBrowserDriverInit()
        {
            // to run service in the bg - more convenient for end user (BUT, phatomjs.exe must be in same directory as WF executable)
            var driverService = PhantomJSDriverService.CreateDefaultService(Directory.GetCurrentDirectory(), "phantomjs.exe");
            driverService.HideCommandPromptWindow = true;

            // emulate Mozzila/Chrome behaviour (env)
            PhantomJSOptions options = new PhantomJSOptions();
            options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.94 Safari/537.36");

            return new PhantomJSDriver(driverService, options);
        } 


        // get data from website using webdriver and save its contents into given IWebElement arguments.
        void fetchData(ref PhantomJSDriver driver, ref IWebElement myContent, ref IWebElement bidDetails, ref string[] enteredData)
        {
            driver = getWebBrowserDriverInit();
            string market = enteredData[0];
            string enteredDateFrom = enteredData[1];
            string enteredDateTo = enteredData[2];

            Exception tmpEx = null; // for possible exception recognition 

            try
            {
                driver.Navigate().GoToUrl("https://kapalk1.mavir.hu/kapar/lt-publication.jsp?locale=en_GB");

                // TODO edit/delete if needed - this is not best approach (webpage can change) 
                if (!(driver.Title.CompareTo("Kapar") == 0))
                {
                    driver.Quit();
                    throw new Exception("Error, webpage is not accessable or there is something wrong with your connection.");
                }

                driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/div/table/tbody/tr/td[2]/input").Clear();

                driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/div/table/tbody/tr/td[2]/input").SendKeys(enteredDateFrom); //SendKeys("12/4/2015");

                driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/div/table/tbody/tr/td[4]/input").Clear();
                driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/div/table/tbody/tr/td[4]/input").SendKeys(enteredDateTo); //SendKeys("12/10/2015");

                driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/div/table/tbody/tr/td[6]/select").SendKeys(market); //SendKeys("All");

                driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/div/table/tbody/tr/td[8]/button").Click();

                WebDriverWait waitForContent = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                myContent = waitForContent.Until<IWebElement>((d) =>
                {
                    return d.FindElement(By.XPath("/html/body/table/tbody/tr[3]/td/table"));
                });

                // xpath for 1st row in table 
                driver.FindElementByXPath("/html/body/table/tbody/tr[3]/td/table/tbody/tr[2]/td[21]/a").Click();

                WebDriverWait waitForBidDetails = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                bidDetails = waitForContent.Until<IWebElement>((d) =>
                {
                    return d.FindElement(By.XPath("//html/body/div/div/table/tbody/tr[2]/td[2]/div/div/table/tbody/tr[1]/td/table"));
                });

            }
            catch (Exception e)
            {
                tmpEx = e;
            }


            if(tmpEx != null)
                throw new Exception(tmpEx.Message);

        }


        // Callback function that is triggered after fetchData function execution.
        private void saveDataCallback(IAsyncResult iar)
        {
            PhantomJSDriver driver = null;
            IWebElement myContent = null, bidDetails = null;
            AsyncResult ar = (AsyncResult)iar;
            string[] enteredData = null;
            DelegateFetchData dfd = (DelegateFetchData)ar.AsyncDelegate;

            try
            {
                dfd.EndInvoke(ref  driver, ref myContent, ref bidDetails, ref enteredData, iar);

                DelegateWriteData myContentDwd = new DelegateWriteData(writeCVSContent);
                DelegateWriteData bidDetailsDwd = new DelegateWriteData(writeCVSContent);


                string fileNameContent = enteredData[3];    // LT-Glavna
                string fileNameBidDetails = enteredData[4]; // LT-Podporna


                StreamWriter outputFile = File.CreateText(fileNameContent);
                StreamWriter outputFileBD = File.CreateText(fileNameBidDetails);

                // write table contents for selected date range to output file
                //writeCVSContent(myContent, outputFile);
                IAsyncResult ar1 = (IAsyncResult)myContentDwd.BeginInvoke(ref myContent, ref outputFile, null, null);

                // get selected element information for first row in bidDetails output file
                IWebElement selectedRow = driver.FindElementByCssSelector("body > table > tbody > tr:nth-child(3) > td > table > tbody > tr.astron-gwTable-selected-row");
                IReadOnlyCollection<IWebElement> tmp = selectedRow.FindElements(By.TagName("td"));
                // write first row to bidDetails output file 
                outputFileBD.WriteLine(string.Format("{0};{1};;;", tmp.ElementAt(0).Text, tmp.ElementAt(1).Text));

                // write bid details table contents for selected element
                //writeCVSContent(bidDetails, outputFileBD);
                IAsyncResult ar2 = (IAsyncResult)bidDetailsDwd.BeginInvoke(ref bidDetails, ref outputFileBD, null, null);

                bidDetailsDwd.EndInvoke(ref bidDetails, ref outputFileBD, ar2);
                myContentDwd.EndInvoke(ref myContent, ref outputFile, ar1);

                
                // free used resources
                driver.Quit();
                outputFile.Close();
                outputFileBD.Close();

                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void writeCVSContent(ref IWebElement myContent, ref StreamWriter outputFile)
        {
            IWebElement[] allRows = myContent.FindElements(By.TagName("tr")).ToArray();
            IWebElement[] firstRow = allRows.ElementAt(0).FindElements(By.TagName("td")).ToArray();
            IWebElement[] allColumns = myContent.FindElements(By.TagName("td")).ToArray();
                        
            int numberOfRows = allRows.Count();
            int numberOfColumesInRow = firstRow.Count();
            int numberOfColumns = numberOfRows * numberOfColumesInRow;

            string lastHeadTitle = firstRow.Last().Text;
            // update numberOfColumesInRow (-1 because we dont need big details column in our csv)
            if (lastHeadTitle.CompareTo("Bid details") == 0)
                numberOfColumesInRow = numberOfColumesInRow - 1;


            Stopwatch t1 = new Stopwatch();
            t1.Start();
            
            // (counter)variable which tells us how many columns have left in current row (when 0, it means that we are at last column in row)
            int i = numberOfColumesInRow;
            // used for construct new line for csv file
            StringBuilder sb = new StringBuilder();

            for(int j = 0; j < numberOfColumns; j++)
            {
                
                // decrease counter and check if we are at last column
                i--; 
                if (i == 0)
                {
                    // we are at last column
                    // write new line and reset counter i to numberOfColumesInRow
                    sb.AppendFormat("{0}{1}", allColumns[j].Text, Environment.NewLine);

                    i = numberOfColumesInRow;
                    if (numberOfColumesInRow != (numberOfColumns/numberOfRows))
                        j++; // increment index for current column and by that skip last column in row
                }
                else
                {
                    sb.AppendFormat("{0};", allColumns[j].Text);
                }           
            }
            outputFile.WriteLine(sb.ToString());
            t1.Stop();

           
            Console.WriteLine(string.Format("Time elapsed: {0}", t1.Elapsed));
    
        }

        private void comboBox_market_Leave(object sender, EventArgs e)
        {
            // make sure that input in ok
            string selectedTxt = comboBox_market.Text;
            int selectedInd = comboBox_market.Items.IndexOf(selectedTxt);
            if (selectedInd >= 0)
                comboBox_market.SelectedIndex = selectedInd;
            else
                comboBox_market.SelectedIndex = 0; // default value 
     
        }

        private void btn_chooseLTGlavna_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CVS File (.cvs) | *.cvs";
            sfd.FilterIndex = 0;

            sfd.InitialDirectory = Path.GetDirectoryName(textBoxLTGlavnaPath.Text);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // TODO message to user
                if (sfd.FileName.CompareTo(textBoxLTPodpornaPath.Text) == 0)
                    return;

                textBoxLTGlavnaPath.Text = sfd.FileName;
            }
        }

        private void btn_chooseLTPodporna_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CVS File (.cvs) | *.cvs";
            sfd.FilterIndex = 0;

            sfd.InitialDirectory = Path.GetDirectoryName(textBoxLTPodpornaPath.Text);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // TODO message to user
                if (sfd.FileName.CompareTo(textBoxLTGlavnaPath.Text) == 0)
                {
                    MessageBox.Show("Filenames for Glavna and Podporna shoud not be equal!");
                    return;
                }
                textBoxLTPodpornaPath.Text = sfd.FileName;
            }
        }
    }
}
