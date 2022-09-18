using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace ExcelVeriOkumaveYazdirma
{
    public partial class Form1 : Form
    {
        List<EmployeePolivans> _empPolivans = new List<EmployeePolivans>();
         
        public Form1()
        {
            InitializeComponent();
        }
        DataTableCollection dtc;
        private void btnDosyasec_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*", Title = "Excel Dosyaları" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtDosyaAdi.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader excelreader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = excelreader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (x) => new ExcelDataTableConfiguration() { UseHeaderRow = true },
                                }
                                );
                                dataGridView1.AllowUserToResizeColumns = true;
                                dtc = result.Tables;
                                comboBoxSayfalar.Items.Clear();
                                foreach (System.Data.DataTable table in dtc) comboBoxSayfalar.Items.Add(table.TableName);
                                {

                                }
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Dosya Acılırken Bir sorun oluştu.");
            }
        }
            
        

        private void comboBoxSayfalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = dtc[comboBoxSayfalar.SelectedIndex];
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTümKayitlariAktar_Click(object sender, EventArgs e)
        {
            try
            {


                for (int j = 1; j < dataGridView1.Rows.Count; j++)
                {
                    //if (dataGridView1.Rows[j].Cells[0].Value == null) continue;
                    if (string.IsNullOrWhiteSpace(dataGridView1.Rows[j].Cells[0].Value?.ToString())) continue;
                    for (int i = 3; i < dataGridView1.Columns.Count; i++)
                    {
                        if (dataGridView1.Rows[3].Cells[i].Value == null) continue;
                        _empPolivans.Add(new EmployeePolivans()
                        {
                            EmployeeName = dataGridView1.Rows[j].Cells[0].Value.ToString(),
                            Type = string.IsNullOrWhiteSpace(dataGridView1.Rows[j].Cells[i].Value.ToString()) ? "0" : dataGridView1.Rows[j].Cells[i].Value.ToString(),
                            StockNo = dataGridView1.Rows[0].Cells[i].Value.ToString()
                        });
                    }
                    //Range alan2 = (Range)sayfa.Cells[j, i];
                    //alan2.Cells[j, i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }

                dataGridView1.DataSource = _empPolivans.ToList();


                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeciliKayitlariAktar_Click(object sender, EventArgs e)
        {
            try
            {
                //excel.Application app = new excel.Application();
                //app.Visible = true;
                //Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
                //Worksheet sayfa = (Works8heet)kitap.Sheets[1];
                int Veri1 = Convert.ToInt32 (tbVeri1.Text);
                for (int j = 1; j < dataGridView1.Rows.Count; j++)
                {
                    //if (dataGridView1.Rows[j].Cells[0].Value == null) continue;
                    if (string.IsNullOrWhiteSpace(dataGridView1.Rows[j].Cells[0].Value?.ToString())) continue;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[6].Cells[i].Value == null) continue;
                        _empPolivans.Add(new EmployeePolivans()
                        {
                            EmployeeName = dataGridView1.Rows[j].Cells[Veri1].Value.ToString(),
                            Type = string.IsNullOrWhiteSpace(dataGridView1.Rows[j].Cells[i].Value.ToString()) ? "0" : dataGridView1.Rows[j].Cells[3].Value.ToString(),
                            StockNo = dataGridView1.Rows[3].Cells[i].Value.ToString()
                        });
                    }                  
                    //Range alan2 = (Range)sayfa.Cells[j, i];
                    //alan2.Cells[j, i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }

                dataGridView1.DataSource = _empPolivans.ToList();



                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
