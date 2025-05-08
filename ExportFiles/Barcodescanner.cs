using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Zen.Barcode;
using OfficeOpenXml.Drawing;
using System.Data.SqlClient;
using FirebaseAdmin.Messaging;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel;


namespace ExportExcel
{
    public partial class Form1 : Form
    {
        System.Data.DataTable dta = new System.Data.DataTable();
        string strcon = @"Data Source=KHOAKUN\SQLEXPRESS;Persist Security Info=True;User ID=sa;Password=1234567890;TrustServerCertificate=True;";
        SqlConnection sqlcon = null;
        SqlDataAdapter adapter = null;
        private string filepath;
        int previousIndex = -1;
        int c = 0, m = 0, i = 0;
        string Enable;
        bool isThoat = true;
        public Form1(string user)
        {
            InitializeComponent();
            label3.Text = user;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtbarcode.Focus();
        }
        private void ImportExcel1(string path)
        {
            FileInfo file = new FileInfo(filepath);

            using (ExcelPackage package = new ExcelPackage(file))
            {

                System.Data.DataTable dt = new System.Data.DataTable();
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for (int column = 1; column <= worksheet.Dimension.End.Column; column++)
                {
                    dt.Columns.Add(worksheet.Cells[1, column].Text);
                }
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow datarow = dt.NewRow();
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        datarow[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    dt.Rows.Add(datarow);
                }
                if (!dt.Columns.Contains("Barcode"))
                {
                    dt.Columns.Add("Barcode", typeof(Image));
                }
                dataGridView1.DataSource = dt;
                AddColumnText("PanelSaw", "PanelSaw");
                AddColumnText("Checked PanelSaw", "Checked PanelSaw");
                AddColumnText("EdgeBander", "EdgeBander");
                AddColumnText("Checked EdgeBander", "Checked EdgeBander");
                AddColumnText("CNC", "CNC");
                AddColumnText("Checked CNC", "Checked CNC");
            }
        }
        private void ImportExcel2(string filepath)
        {
            FileInfo file = new FileInfo(filepath);
            try
            {
            
                using (ExcelPackage package = new ExcelPackage(file))
            {

                System.Data.DataTable dt2 = new System.Data.DataTable();
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for (int column = 1; column <= worksheet.Dimension.End.Column; column++)
                {
                    dt2.Columns.Add(worksheet.Cells[1, column].Text);
                }
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow datarow = dt2.NewRow();
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        datarow[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    dt2.Rows.Add(datarow);
                }
                dataGridView2.DataSource = dt2;

            }
            }
            catch
            {
                MessageBox.Show("already have ID!");
            }
        }
        private void Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "Book1|*.xlsx";
                openfiledialog.Title = "select the file";
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openfiledialog.FileName;
                    ImportExcel1(filepath);
                }
                else
                {
                    MessageBox.Show("Unsuccess");
                }
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddColumnText(String columnname, string headerText)
        {
            if (!dataGridView1.Columns.Contains(columnname))
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn
                {
                    HeaderText = headerText,
                    Width = 130,
                    Name = columnname
                };
                dataGridView1.Columns.Add(Column);
            }
        }
        private void AddCheckBoxColumnText(String columnname, string headerText)
        {
            if (!dataGridView1.Columns.Contains(columnname))
            {
                DataGridViewCheckBoxColumn Column = new DataGridViewCheckBoxColumn
                {
                    HeaderText = headerText,
                    Width = 130,
                    Name = columnname
                };
                dataGridView1.Columns.Add(Column);
            }
        }
        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "Book1|*.xlsx";
                openfiledialog.Title = "select the file";
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Added file");
                    filepath = openfiledialog.FileName;
                    GenerateBarcode(filepath);
                    ImportExcel2(@"D:\BKEU\TTNT\Book1.xlsx");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void GenerateBarcode(String path)
        {
                FileInfo file = new FileInfo(filepath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                try
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                worksheet.Cells[1, worksheet.Dimension.End.Column + 1].Value = "ID";
                worksheet.Cells[1, worksheet.Dimension.End.Column + 1].Value = "Barcode";

                for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
                {
                    string barcodeValue = "PK_TG410" + (i - 1).ToString();
                    worksheet.Cells[i, worksheet.Dimension.End.Column - 1].Value = barcodeValue;
                    Image barcodeImage = GenerateBarcodeImage(barcodeValue);
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        barcodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = ms.ToArray();
                    }
                    ExcelPicture picture = worksheet.Drawings.AddPicture(barcodeValue, new MemoryStream(imageBytes));
                    var cell = worksheet.Cells[i, worksheet.Dimension.End.Column + 2];
                    float cellWidth = (float)(worksheet.Column(cell.Start.Column).Width * 7.5);
                    float cellHeight = (float)(worksheet.Row(cell.Start.Row).Height * 0.75);
                    picture.SetPosition(i - 1, 0, worksheet.Dimension.End.Column - 1, 0);
                    picture.SetSize((int)cellWidth, (int)cellHeight);           
                }
                    MessageBox.Show("Create barcode success");
                    package.SaveAs(@"D:\BKEU\TTNT\Book1.xlsx");
                }
                catch
                {
                    MessageBox.Show("already have barcode");
                }
            }
        }
        private Image GenerateBarcodeImage(string data)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            return barcode.Draw(data, 50);
        }

        private async void txtbarcode_TextChanged(object sender, EventArgs e)
        {
                
            string scannedBarcode = txtbarcode.Text;
            switch (Enable)
            {
                case "CNC":
                    check(scannedBarcode, "CNC", "Checked CNC", ref i);                
                    break;
                case "PanelSaw":
                    check(scannedBarcode, "PanelSaw", "Checked PanelSaw", ref c);
                    break;
                case "EdgeBander":
                    check(scannedBarcode, "EdgeBander", "Checked EdgeBander", ref m);
                    break;
                default:
                    MessageBox.Show("Choose one of the process!");
                    break;
            }
            ShowPartName(txtbarcode.Text);
            if (!string.IsNullOrEmpty(txtbarcode.Text))
            {
                string previous = txtbarcode.Text;
            }
            await Task.Delay(500);
            txtbarcode.Clear();
            txtbarcode.Focus();
        }

        private void ToggleColumnVisibility(string columnName)
        {
            if (dataGridView1.Columns.Contains(columnName))
            {
                dataGridView1.Columns[columnName].Visible = !dataGridView1.Columns[columnName].Visible;
            }
            else
            {
                MessageBox.Show("no found");
            }
        }

        private async void NAME_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(500);
            NAME.Clear();  
        }

        private void Barcode_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("Barcode");
        }

        private void CLENG_Click_1(object sender, EventArgs e)
        {
            ToggleColumnVisibility("CLENG");
        }
        private void MATNAME_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("MATNAME");
        }
        private void EDGE1_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("EDGE1");
        }
        private void EDGE2_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("EDGE2");
        }
        private void EDGE3_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("EDGE3");
        }
        private void EDGE4_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("EDGE4");
        }
        private void CWIDTH_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("CWIDTH");
        }
        private void QTY_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("QTY");
        }
        private void PartName_Click(object sender, EventArgs e)
        {
            ToggleColumnVisibility("PartName");
        }
        private void Workflow_Click(object sender, EventArgs e)
        {

            ToggleColumnVisibility("Workflow");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnketnoicsdl_Click(object sender, EventArgs e)
        {
            try
            {
                int kq = 0;
                SqlConnection sqlcon = new SqlConnection(strcon);
                string createTableQuerry = @"
                    CREATE TABLE Quetmavach (
                     [Index] INT PRIMARY KEY IDENTITY,
                     MATNAME NVARCHAR(100),
                     CLENG FLOAT,
                     CWIDTH FLOAT,
                     QTY INT,
                     PartName NVARCHAR(100),
                     Workflow NVARCHAR(100),
                     Edge1 NVARCHAR(100),
                     Edge2 NVARCHAR(100),
                     Edge3 NVARCHAR(100),
                     Edge4 NVARCHAR(100),
                     ID NVARCHAR(100),
                     Barcode NVARCHAR(100),
                     [PanelSaw] INT,
                     [Checked PanelSaw] CHAR(100),
                     EdgeBander INT,
                     [Checked EdgeBander] CHAR(100),
                     CNC INT,
                     [Checked CNC] NVARCHAR(100),
                        );       
                ";
                SqlCommand command = new SqlCommand(createTableQuerry, sqlcon);
                sqlcon.Open();
                command.ExecuteNonQuery();
                sqlcon.Close();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (!dta.Columns.Contains(col.Name))
                    {
                        dta.Columns.Add(col.Name, col.ValueType ?? typeof(object));
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow datarow = dta.NewRow();
                        foreach (DataGridViewCell Cell in row.Cells)
                        {
                            datarow[Cell.ColumnIndex] = Cell.Value;
                        }
                        dta.Rows.Add(datarow);
                        String query = "select * from Quetmavach";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        kq = adapter.Update(dta);
                    }
                }
                if (kq > 0)
                {
                    MessageBox.Show("Connect successful");
                }
                else
                {
                    MessageBox.Show("Connect unsuccessful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please reset server first");
            }



        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cncValue = dataGridView1.Rows[e.RowIndex].Cells["CNC"].Value;
                var checkedcncValue = dataGridView1.Rows[e.RowIndex].Cells["Checked CNC"].Value;
                var mayDanCanhValue = dataGridView1.Rows[e.RowIndex].Cells["EdgeBander"].Value;
                var checkedmayDanCanhValue = dataGridView1.Rows[e.RowIndex].Cells["Checked EdgeBander"].Value;
                var mayCuaValue = dataGridView1.Rows[e.RowIndex].Cells["PanelSaw"].Value;
                var checkedmayCuaValue = dataGridView1.Rows[e.RowIndex].Cells["Checked PanelSaw"].Value;
                var primaryKeyValue = dataGridView1.Rows[e.RowIndex].Cells["Index"].Value;
                SqlConnection sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                string query = @"UPDATE Quetmavach SET CNC = @CNC, [EdgeBander]=@Máydáncạnh, [PanelSaw]=@Máycưa, [Checked CNC] =@checkedCNC, [Checked EdgeBander]= @checkeMayDanCanh, [Checked PanelSaw] = @checkedMayCua WHERE [Index] = @primaryKeyValue";
                SqlCommand UpdateCommand = new SqlCommand(query, sqlcon);
                UpdateCommand.Parameters.AddWithValue("@Máycưa", mayCuaValue ?? DBNull.Value);
                UpdateCommand.Parameters.AddWithValue("@checkedMayCua", checkedmayCuaValue ?? DBNull.Value);
                UpdateCommand.Parameters.AddWithValue("@Máydáncạnh", mayDanCanhValue ?? DBNull.Value);
                UpdateCommand.Parameters.AddWithValue("@checkeMayDanCanh", checkedmayDanCanhValue ?? DBNull.Value);
                UpdateCommand.Parameters.AddWithValue("@CNC", cncValue ?? DBNull.Value);
                UpdateCommand.Parameters.AddWithValue("@checkedCNC", checkedcncValue ?? DBNull.Value);
                UpdateCommand.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                UpdateCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Please reset server before!");
            }
        }
        private void RESETSERVER_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strcon);
            connection.Open();
            string deleteCommandText = "DROP TABLE Quetmavach";
            SqlCommand deleteCommand = new SqlCommand(deleteCommandText, connection);
            try
            {
                int kq = deleteCommand.ExecuteNonQuery();
                if (kq == -1)
                {
                    MessageBox.Show("Reset successful");
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("no data");
            }
        }

        private void CNC_Click(object sender, EventArgs e)
        {
            Enable = "CNC";
            tickcnc.Checked = true;
            MessageBox.Show("choose CNC");
        }

        private void MáyCưa_Click(object sender, EventArgs e)
        {
            Enable = "PanelSaw";
            tickcutting.Checked = true;
            MessageBox.Show("Choose PanelSaw");
        }

        private void MáyDánCạnh_Click(object sender, EventArgs e)
        {
            Enable = "EdgeBander";
            radioButton3.Checked = true;
            MessageBox.Show("Choose EdgeBander");
        }

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ĐăngXuất_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            FormĐăngNhập f = new FormĐăngNhập();
            f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Do you want to exit", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

       

        private void ShowPartName(String scannedBarcode)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == scannedBarcode)
                {
                    NAME.Text = row.Cells["PartName"].Value.ToString();
                    break;
                }
            }
        }
        private void check(String scannedBarcode, String PROGRESS, String machine, ref int count)
        {
            int cellvalue;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == scannedBarcode)
                {
                    if (previousIndex != -1 && previousIndex != row.Index)
                    {
                        MessageBox.Show("Scan the previous barcode!");
                        break;
                    }
                    previousIndex = row.Index;
                    int.TryParse(row.Cells["Qty"].Value.ToString(), out cellvalue);
                    count++;
                    row.Cells[PROGRESS].Value = count;
                    row.Cells[PROGRESS].Style.BackColor = Color.White;
                    row.Cells[machine].Value = "";
                    if (count == cellvalue)
                    {
                        row.Cells[PROGRESS].Style.BackColor = Color.LightGreen;
                        row.Cells[machine].Value = "Checked";
                        count = 0;
                        previousIndex = -1;
                        txtbarcode.Clear();
                        break;
                    }
                }
            }
        }
    }

}