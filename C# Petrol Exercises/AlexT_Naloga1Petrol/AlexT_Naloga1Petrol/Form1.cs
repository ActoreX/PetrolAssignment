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

using System.Xml;
using System.Xml.XPath;

namespace MojaPrvaWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String sourceUrl = textBox1.Text;
            try
            {
                if (sourceUrl == null)
                    throw new Exception("Polje za URL naslov je obvezno!");

                var selectedCountries = checkedListBoxCountrySelection.CheckedItems;

                if (selectedCountries.Count == 0)
                    throw new Exception("Izberite vsaj eno državo!");



                XmlDocument doc = new XmlDocument();
                doc.Load(sourceUrl);
                XmlNode root = doc.DocumentElement;


                XmlNamespaceManager xnsm = new XmlNamespaceManager(doc.NameTable);
                xnsm.AddNamespace("env", "http://www.ecb.int/vocabulary/2002-08-01/eurofxref");

                // for how long ago user want to collect the data
                int X = (int)numericUpDownBackDays.Value; // read entered value
                DateTime XDaysAgo = DateTime.Now.Subtract(new TimeSpan(X, 0, 0, 0));
                String dateX = string.Format("{0}{1}{2}{3}{4}", XDaysAgo.Year, XDaysAgo.Month / 10, XDaysAgo.Month % 10, XDaysAgo.Day / 10, XDaysAgo.Day % 10);


                XmlNodeList nodeList = root.SelectNodes(
                "descendant::env:Cube/env:Cube[translate(@time, '-', '') > " + dateX + " ]/env:Cube[@currency='USD' or @currency='PLN' or @currency='RON']", xnsm);


                // fix - dates added
                XmlNodeList dateList = root.SelectNodes(
               "descendant::env:Cube/env:Cube[translate(@time, '-', '') > " + dateX + " ]", xnsm);
                // fix end
                

                StringBuilder outData = new StringBuilder();

                
                XmlNode iterDate = null;
                int i = 0, j = 0;

                foreach (XmlNode iter in nodeList)
                {
                    if (j % 3 == 0) // because at each step we have selected three nodes with following currencies: USD, PLN and RON(see Xpath)
                    {
                        iterDate = dateList.Item(i);
                        i++;
                    }

                    string date = iterDate.Attributes.GetNamedItem("time").Value;
                    string currency = iter.Attributes.GetNamedItem("currency").Value;
                    string rate = iter.Attributes.GetNamedItem("rate").Value;

                    // check if currency is selected in UI form (In that case, append it to outData variable) 
                    if (selectedCountries.Contains("ZDA") && currency.Equals("USD"))
                        outData.AppendFormat("{0};{1};{2}{3}", date, currency, rate, Environment.NewLine);
                    else if (selectedCountries.Contains("Poljska") && currency.Equals("PLN"))
                        outData.AppendFormat("{0};{1};{2}{3}", date, currency, rate, Environment.NewLine);
                    else if (selectedCountries.Contains("Romunija") && currency.Equals("RON"))
                        outData.AppendFormat("{0};{1};{2}{3}", date, currency, rate, Environment.NewLine);
                    j++;

            
                }
                

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "csv";
                sfd.Filter = "csv files (*.csv)|*.*";
                sfd.FilterIndex = 0;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, outData.ToString());
                    sfd.Dispose();
                }
                else
                {
                    throw new Exception("Datoteke niste shranili!");
                }

   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
        }

        
    }
}