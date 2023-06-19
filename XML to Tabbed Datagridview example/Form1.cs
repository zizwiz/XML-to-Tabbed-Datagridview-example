using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Xml.Linq;
using XML_to_Tabbed_Datagridview_example.functions;

namespace XML_to_Tabbed_Datagridview_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            //set up datagridviews
            DGV_Functions.SetUpViews(dgv_tab1, 2);
            DGV_Functions.SetUpViews(dgv_tab2, 2);
            DGV_Functions.SetUpViews(dgv_tab3, 3);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            DGV_Functions.ClearData(dgv_tab1, dgv_tab2, dgv_tab3); //clear all old data from dataviewgrids

            XDocument doc = XDocument.Load("data.xml"); //read in the file

            foreach (XElement dip in doc.Root.Elements()) // Looking for <DataType> tags
            {
                if ((string)dip.Element("DataType") == "Tab1") // work out which tab these need to go into
                {
                    //add in the data
                    dgv_tab1.Rows.Add(
                        (string)dip.Element("Name"),
                        (decimal)dip.Element("Amount"));
                }
                else if ((string)dip.Element("DataType") == "Tab2")
                {
                    dgv_tab2.Rows.Add(
                        (string)dip.Element("Name"),
                        (decimal)dip.Element("Monthly"));
                }
                else if ((string)dip.Element("DataType") == "Tab3")
                {
                    dgv_tab3.Rows.Add(
                        (string)dip.Element("Year"),
                        (string)dip.Element("Name"),
                        (decimal)dip.Element("Amount"));
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //DataTable dst = new DataTable();
            //dst = (DataTable)dgv_tab1.DataSource;
            //dst.TableName = "dgv_tab1";
            //dst.WriteXml(@"myxml.xml", true);
            //---------------------------------------------------------------------------------

            //DataSet dataSet = (DataSet)dgv_tab1.DataSource;
            //dataSet.WriteXml("myxml.xml");
            //---------------------------------------------------------------------------------

            //DataSet ds = (DataSet)dgv_tab1.DataSource;
            //XmlTextWriter newXml = new XmlTextWriter("newXML.xml", Encoding.UTF8);
            //ds.WriteXml(newXml);
            //---------------------------------------------------------------------------------

            string file = "newxml.xml";

            //using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            using (TextWriter tw = new StreamWriter(file))
            {
                int count = 1;
                DataGridView dgv = dgv_tab1;
                string name = "Tab1";

                string tag = "";
                string tag1 = "Name";
                string tag2 = "Amount";
                string tag3 = "";

                tw.Write("<MyDataFile>\r");
                while (count < 4)
                {
                    foreach (DataGridViewRow dgvR in dgv.Rows)
                    {
                        tw.Write("\t<DataBlock>\r");
                        tw.Write("\t\t<DataType>" + name + "</DataType>\r");
                        for (int j = 1; j < dgv.Columns.Count + 1; ++j)
                        {
                            if (j == 1) tag = tag1;
                            if (j == 2) tag = tag2;
                            if (j == 3) tag = tag3;

                            object val = dgvR.Cells[j - 1].Value;
                            if (val == null)
                            {
                                tw.Write(" \r");
                            }
                            else
                            {
                                tw.Write("\t\t<" + tag + ">");
                                tw.Write(val);
                                tw.Write("</" + tag + ">\r");
                            }
                        }
                        tw.Write("\t</DataBlock>\r");
                    }

                    count++;

                    if (count == 2)
                    {
                        dgv = dgv_tab2;
                        name = "Tab2";

                        tag1 = "Name";
                        tag2 = "Monthly";
                    }
                    else if (count == 3)
                    {
                        dgv = dgv_tab3;
                        name = "Tab3";

                        tag1 = "Year";
                        tag2 = "Name";
                        tag3 = "Amount";
                    }
                }
                tw.Write("</MyDataFile>");

                //---------------------------------------------------------------------------------

                //bw.Write(dgv_tab1.Columns.Count);
                //bw.Write(dgv_tab1.Rows.Count);
                //foreach (DataGridViewRow dgvR in dgv_tab1.Rows)
                //{
                //    for (int j = 0; j < dgv_tab1.Columns.Count; ++j)
                //    {
                //        object val = dgvR.Cells[j].Value;
                //        if (val == null)
                //        {
                //            bw.Write(false);
                //            bw.Write(false);
                //        }
                //        else
                //        {
                //            bw.Write(true);
                //            bw.Write(val.ToString());
                //        }
                //    }
                //}
                //---------------------------------------------------------------------------------

            }


        }


    }
}
