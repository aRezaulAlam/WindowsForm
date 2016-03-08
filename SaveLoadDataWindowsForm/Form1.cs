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

namespace SaveLoadDataWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void addButton_Click(object sender, EventArgs e)
        {
            if (rowNameTextBox.Text == "")
            {

            }
            else
            {
                mainDataGridView.Rows.Add(1);
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[0].Value = false;
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[1].Value = rowNameTextBox.Text;
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[2].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[3].Value = "Browse";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[4].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[5].Value = "Browse";  
            }
            
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {


            string line;
            mainDataGridView.AllowUserToAddRows = false;

            StreamReader fileN = new StreamReader("..\\save.txt");

            while ((line = fileN.ReadLine()) != null)
            {
                mainDataGridView.Rows.Add(1);
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[0].Value = false;
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[1].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[2].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[3].Value = "Browse";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[4].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[5].Value = "Browse";

            }

            if (mainDataGridView.Rows.Count.ToString().Trim() == "")
            {

                mainDataGridView.Rows.Add(1);
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[0].Value = false;
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[1].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[2].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[3].Value = "Browse";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[4].Value = "";
                mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[5].Value = "Browse";
            }

            fileN.Close();

        }

        private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (e.ColumnIndex == 3)
            {
                
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[2].Value = openFileDialog1.FileName;  
                }
            }
            if (e.ColumnIndex == 5)
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mainDataGridView.Rows[(mainDataGridView.Rows.Count - 1)].Cells[4].Value = openFileDialog1.FileName;
                }
                
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var aDataSet = new DataSet();
            


            var anotherDataTable = new DataTable { TableName = "DataGrid" };
            anotherDataTable.Columns.Add("check");
            anotherDataTable.Columns.Add("rowName");
            anotherDataTable.Columns.Add("iLocation");
            anotherDataTable.Columns.Add("iBrowse");
            anotherDataTable.Columns.Add("dLocation");
            anotherDataTable.Columns.Add("dBrowse");
            aDataSet.Tables.Add(anotherDataTable);


            foreach (DataGridViewRow c in mainDataGridView.Rows)
            {
                DataRow anotherRow = aDataSet.Tables["DataGrid"].NewRow();
                anotherRow["check"] = c.Cells[0].Value.ToString();
                anotherRow["rowName"] = c.Cells[1].Value.ToString();
                anotherRow["iLocation"] = c.Cells[2].Value.ToString();
                anotherRow["iBrowse"] = c.Cells[3].Value.ToString();
                anotherRow["dLocation"] = c.Cells[4].Value.ToString();
                anotherRow["dBrowse"] = c.Cells[5].Value.ToString();
                aDataSet.Tables["DataGrid"].Rows.Add(anotherRow);
            }

            SaveFileDialog(aDataSet);
            
        }

        private void SaveFileDialog(DataSet aDataSet)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"D:\";

            saveFileDialog1.Title = "Save State Files";

            //saveFileDialog1.CheckFileExists = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.DefaultExt = "xml";

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            saveFileDialog1.FilterIndex = 2;

            saveFileDialog1.RestoreDirectory = true;



            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                aDataSet.WriteXml(saveFileDialog1.FileName);
                MessageBox.Show("Saved in " + saveFileDialog1.FileName);
                

            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var newDataset = new DataSet();
            

            string openedFileName = OpenFile();

            try
            {
                newDataset.ReadXml(openedFileName);

                foreach (DataRow i in newDataset.Tables["DataGrid"].Rows)
                {
                    var n = mainDataGridView.Rows.Add();
                    mainDataGridView.Rows[n].Cells[0].Value = i[0].ToString();
                    mainDataGridView.Rows[n].Cells[1].Value = i[1].ToString();
                    mainDataGridView.Rows[n].Cells[2].Value = i[2].ToString();
                    mainDataGridView.Rows[n].Cells[3].Value = i[3].ToString();
                    mainDataGridView.Rows[n].Cells[4].Value = i[4].ToString();
                    mainDataGridView.Rows[n].Cells[5].Value = i[5].ToString();
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        private string OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            string fileName = "";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                   fileName = openFileDialog1.FileName;
                   mainDataGridView.Rows.Clear();
                   mainDataGridView.DataSource = null;
                }

            return fileName;
        }
    }
}
