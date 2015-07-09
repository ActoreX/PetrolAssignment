using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

using System.Net;
using System.Xml;

namespace PetrolScappngNaloga2
{
    public partial class Naloga2 : Form
    {
        public Naloga2()
        {
            InitializeComponent();
        }

        // fetch the data from website and save it to fileName path.
        private void fetchAndSaveData(String fileName)
        {
            string input_day = string.Format("{0}{1}", dateTimePicker1.Value.Day / 10, dateTimePicker1.Value.Day % 10);
            string input_month = string.Format("{0}{1}", dateTimePicker1.Value.Date.Month / 10, dateTimePicker1.Value.Date.Month % 10);
            string input_year = string.Format("{0}", dateTimePicker1.Value.Year);


            using (WebClient myWC = new WebClient())
            {
               
                // split filename to name and extension
                string[] file_info = fileName.Split('.');
               
                // omg!!! almost lost my nerve debugging this :) 
                // - URL must begin either with http or https (just www.andtherestofurl did not work)

                // compare if extension of file is cvs or not !
                String myURI = (file_info[1].CompareTo("cvs") == 0)?
                    String.Format("http://www.opcom.ro/rapoarte/export_csv_raportPIPsiVolumTranzactionat_PI.php?zi={0}&luna={1}&an={2}&limba=en", input_day, input_month, input_year)
                :
                    String.Format("http://www.opcom.ro/rapoarte/export_xml_PIPsiVolTranPI.php?zi={0}&luna={1}&an={2}&limba=en", input_day, input_month, input_year);
                    
                try
                {
                    myWC.DownloadFile(myURI, fileName);
                    MessageBox.Show("File downloaded!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Exception caught ! {0}", ex.Message));
                }


            }
        }

        private void loadCVS(string fileName)
        {
            string[] data_array = System.IO.File.ReadAllLines(fileName);


            Console.WriteLine("asd");


            // used by datagridview
            DataTable myDataTbl = new DataTable();

            // header is at index 3
            string[] headerRow = data_array[3].Split(',');
            foreach (string col in headerRow)
            {
                myDataTbl.Columns.Add(col);
            }


            for (int i = 4; i < data_array.Length; i++)
            {
                string[] currRow = data_array[i].Split(',');
                myDataTbl.Rows.Add(currRow);
            }

            dataGridView1.DataSource = myDataTbl;
        }

        private void loadXML(string fileName)
        {
            DataSet data = new DataSet();
            data.ReadXml(fileName);
            dataGridView1.DataSource = data.Tables[0];
        }

        private  void btn_fetchData_Click(object sender, EventArgs e)
        {
            string fileName = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CVS and XML files (*.cvs, *.xml)| *.cvs;*.xml|Comma delimited format(*.cvs)|*.cvs|XML format (*.xml) |*.xml";
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        // everything is ok, chose cvs file
                        fileName = ofd.FileName;
                    }
                }
                catch (Exception eofd)
                {
                    MessageBox.Show(string.Format("Exception caught!{0}", eofd.Message));
                }
            }

            
            try
            {
                string[] file_info = fileName.Split('.');
                if (file_info[1].CompareTo("cvs") == 0)
                {
                    loadCVS(fileName);
                }
                else
                {
                    loadXML(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Exception caught! {0}", ex.Message));
            }
            
        }

        private void btn_saveDialog_Click(object sender, EventArgs e)
        {


            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "cvs";
                sfd.Filter = "Comma delimited format(*.cvs)|*.cvs|XML format (*.xml) |*.xml";
                sfd.FilterIndex = 1;

                try
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // do stuff here
                        fetchAndSaveData(sfd.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception caught - {0}", ex.Message));
                }
            }
        }
     
        
    }
}
