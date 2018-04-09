using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Data.SqlClient;
using System.IO;


namespace toolLibraryCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        DataSet result;

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {

                    FileStream fs = File.Open(of.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (of.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);



                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true  // set to true to use excel first row as column in datagridview
                        }

                    });

                    cboSheet.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                    {
                        cboSheet.Items.Add(dt.TableName);

                    }
                    reader.Close();


                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = result.Tables[cboSheet.SelectedIndex];
        }
    }
}
