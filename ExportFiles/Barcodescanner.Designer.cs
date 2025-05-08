namespace ExportExcel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Import = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerateBarcode = new System.Windows.Forms.Button();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tickcnc = new System.Windows.Forms.RadioButton();
            this.tickcutting = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CNC = new System.Windows.Forms.Button();
            this.MáyDánCạnh = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MáyCưa = new System.Windows.Forms.Button();
            this.ĐăngXuất = new System.Windows.Forms.Button();
            this.RESETSERVER = new System.Windows.Forms.Button();
            this.btnketnoicsdl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CLENG = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MATNAME = new System.Windows.Forms.Button();
            this.Workflow = new System.Windows.Forms.Button();
            this.PartName = new System.Windows.Forms.Button();
            this.QTY = new System.Windows.Forms.Button();
            this.CWIDTH = new System.Windows.Forms.Button();
            this.Barcode = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Import
            // 
            this.Import.BackColor = System.Drawing.Color.LimeGreen;
            this.Import.Location = new System.Drawing.Point(0, 28);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(156, 76);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import Excel FIle";
            this.Import.UseVisualStyleBackColor = false;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1950, 500);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btnGenerateBarcode
            // 
            this.btnGenerateBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBarcode.Location = new System.Drawing.Point(739, 124);
            this.btnGenerateBarcode.Name = "btnGenerateBarcode";
            this.btnGenerateBarcode.Size = new System.Drawing.Size(272, 72);
            this.btnGenerateBarcode.TabIndex = 10;
            this.btnGenerateBarcode.Text = "btnGenerateBarcode";
            this.btnGenerateBarcode.UseVisualStyleBackColor = true;
            this.btnGenerateBarcode.Click += new System.EventHandler(this.btnGenerateBarcode_Click);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(66, 46);
            this.txtbarcode.Multiline = true;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(295, 75);
            this.txtbarcode.TabIndex = 11;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // NAME
            // 
            this.NAME.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NAME.Enabled = false;
            this.NAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NAME.Location = new System.Drawing.Point(1376, 46);
            this.NAME.Multiline = true;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Size = new System.Drawing.Size(272, 75);
            this.NAME.TabIndex = 19;
            this.NAME.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1779, 940);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.tickcnc);
            this.tabPage1.Controls.Add(this.tickcutting);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1771, 907);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IMPORT";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1371, 862);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(495, 32);
            this.label7.TabIndex = 36;
            this.label7.Text = "Programmed by Nguyễn Tuấn Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(811, 862);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(889, 862);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "label3";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(1556, 111);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(122, 24);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Edgebander";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // tickcnc
            // 
            this.tickcnc.AutoSize = true;
            this.tickcnc.Enabled = false;
            this.tickcnc.Location = new System.Drawing.Point(1415, 111);
            this.tickcnc.Name = "tickcnc";
            this.tickcnc.Size = new System.Drawing.Size(59, 24);
            this.tickcnc.TabIndex = 32;
            this.tickcnc.TabStop = true;
            this.tickcnc.Text = "cnc";
            this.tickcnc.UseVisualStyleBackColor = true;
            // 
            // tickcutting
            // 
            this.tickcutting.AutoSize = true;
            this.tickcutting.Enabled = false;
            this.tickcutting.ForeColor = System.Drawing.Color.Black;
            this.tickcutting.Location = new System.Drawing.Point(1272, 111);
            this.tickcutting.Name = "tickcutting";
            this.tickcutting.Size = new System.Drawing.Size(105, 24);
            this.tickcutting.TabIndex = 31;
            this.tickcutting.TabStop = true;
            this.tickcutting.Text = "PanelSaw";
            this.tickcutting.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CNC);
            this.panel2.Controls.Add(this.MáyDánCạnh);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.MáyCưa);
            this.panel2.Controls.Add(this.ĐăngXuất);
            this.panel2.Controls.Add(this.txtbarcode);
            this.panel2.Controls.Add(this.RESETSERVER);
            this.panel2.Controls.Add(this.btnketnoicsdl);
            this.panel2.Controls.Add(this.NAME);
            this.panel2.Location = new System.Drawing.Point(85, 702);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1729, 147);
            this.panel2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Control board";
            // 
            // CNC
            // 
            this.CNC.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CNC.Location = new System.Drawing.Point(1019, 10);
            this.CNC.Name = "CNC";
            this.CNC.Size = new System.Drawing.Size(122, 57);
            this.CNC.TabIndex = 25;
            this.CNC.Text = "CNC";
            this.CNC.UseVisualStyleBackColor = false;
            this.CNC.Click += new System.EventHandler(this.CNC_Click);
            // 
            // MáyDánCạnh
            // 
            this.MáyDánCạnh.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MáyDánCạnh.Location = new System.Drawing.Point(839, 10);
            this.MáyDánCạnh.Name = "MáyDánCạnh";
            this.MáyDánCạnh.Size = new System.Drawing.Size(130, 57);
            this.MáyDánCạnh.TabIndex = 25;
            this.MáyDánCạnh.Text = "Edgebander";
            this.MáyDánCạnh.UseVisualStyleBackColor = false;
            this.MáyDánCạnh.Click += new System.EventHandler(this.MáyDánCạnh_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Exit.Location = new System.Drawing.Point(1053, 82);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(163, 60);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MáyCưa
            // 
            this.MáyCưa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MáyCưa.Location = new System.Drawing.Point(674, 10);
            this.MáyCưa.Name = "MáyCưa";
            this.MáyCưa.Size = new System.Drawing.Size(122, 57);
            this.MáyCưa.TabIndex = 25;
            this.MáyCưa.Text = "PanelSaw";
            this.MáyCưa.UseVisualStyleBackColor = false;
            this.MáyCưa.Click += new System.EventHandler(this.MáyCưa_Click);
            // 
            // ĐăngXuất
            // 
            this.ĐăngXuất.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ĐăngXuất.Location = new System.Drawing.Point(586, 77);
            this.ĐăngXuất.Name = "ĐăngXuất";
            this.ĐăngXuất.Size = new System.Drawing.Size(158, 65);
            this.ĐăngXuất.TabIndex = 28;
            this.ĐăngXuất.Text = "LogOut";
            this.ĐăngXuất.UseVisualStyleBackColor = false;
            this.ĐăngXuất.Click += new System.EventHandler(this.ĐăngXuất_Click);
            // 
            // RESETSERVER
            // 
            this.RESETSERVER.BackColor = System.Drawing.Color.Aquamarine;
            this.RESETSERVER.Location = new System.Drawing.Point(1169, 10);
            this.RESETSERVER.Name = "RESETSERVER";
            this.RESETSERVER.Size = new System.Drawing.Size(174, 66);
            this.RESETSERVER.TabIndex = 23;
            this.RESETSERVER.Text = "RESET SERVER";
            this.RESETSERVER.UseVisualStyleBackColor = false;
            this.RESETSERVER.Click += new System.EventHandler(this.RESETSERVER_Click);
            // 
            // btnketnoicsdl
            // 
            this.btnketnoicsdl.BackColor = System.Drawing.Color.Aquamarine;
            this.btnketnoicsdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnketnoicsdl.Location = new System.Drawing.Point(454, 5);
            this.btnketnoicsdl.Name = "btnketnoicsdl";
            this.btnketnoicsdl.Size = new System.Drawing.Size(184, 66);
            this.btnketnoicsdl.TabIndex = 22;
            this.btnketnoicsdl.Text = "CONNECT SERVER";
            this.btnketnoicsdl.UseVisualStyleBackColor = false;
            this.btnketnoicsdl.Click += new System.EventHandler(this.btnketnoicsdl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CLENG);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.MATNAME);
            this.panel1.Controls.Add(this.Workflow);
            this.panel1.Controls.Add(this.PartName);
            this.panel1.Controls.Add(this.QTY);
            this.panel1.Controls.Add(this.Import);
            this.panel1.Controls.Add(this.CWIDTH);
            this.panel1.Controls.Add(this.Barcode);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 109);
            this.panel1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Utilities";
            // 
            // CLENG
            // 
            this.CLENG.BackColor = System.Drawing.Color.LawnGreen;
            this.CLENG.Location = new System.Drawing.Point(261, 73);
            this.CLENG.Name = "CLENG";
            this.CLENG.Size = new System.Drawing.Size(87, 31);
            this.CLENG.TabIndex = 21;
            this.CLENG.Text = "CLENG";
            this.CLENG.UseVisualStyleBackColor = false;
            this.CLENG.Click += new System.EventHandler(this.CLENG_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LawnGreen;
            this.button4.Location = new System.Drawing.Point(1098, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "EDGE4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.EDGE4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.Location = new System.Drawing.Point(1010, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 31);
            this.button3.TabIndex = 18;
            this.button3.Text = "EDGE3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.EDGE3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Location = new System.Drawing.Point(918, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "EDGE2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.EDGE2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(830, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "EDGE1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EDGE1_Click);
            // 
            // MATNAME
            // 
            this.MATNAME.BackColor = System.Drawing.Color.LawnGreen;
            this.MATNAME.Location = new System.Drawing.Point(723, 73);
            this.MATNAME.Name = "MATNAME";
            this.MATNAME.Size = new System.Drawing.Size(100, 31);
            this.MATNAME.TabIndex = 18;
            this.MATNAME.Text = "MATNAME";
            this.MATNAME.UseVisualStyleBackColor = false;
            this.MATNAME.Click += new System.EventHandler(this.MATNAME_Click);
            // 
            // Workflow
            // 
            this.Workflow.BackColor = System.Drawing.Color.LawnGreen;
            this.Workflow.Location = new System.Drawing.Point(624, 73);
            this.Workflow.Name = "Workflow";
            this.Workflow.Size = new System.Drawing.Size(93, 31);
            this.Workflow.TabIndex = 18;
            this.Workflow.Text = "Workflow";
            this.Workflow.UseVisualStyleBackColor = false;
            this.Workflow.Click += new System.EventHandler(this.Workflow_Click);
            // 
            // PartName
            // 
            this.PartName.BackColor = System.Drawing.Color.LawnGreen;
            this.PartName.Location = new System.Drawing.Point(528, 73);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(90, 31);
            this.PartName.TabIndex = 18;
            this.PartName.Text = "PartName";
            this.PartName.UseVisualStyleBackColor = false;
            this.PartName.Click += new System.EventHandler(this.PartName_Click);
            // 
            // QTY
            // 
            this.QTY.BackColor = System.Drawing.Color.LawnGreen;
            this.QTY.Location = new System.Drawing.Point(446, 73);
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(76, 31);
            this.QTY.TabIndex = 18;
            this.QTY.Text = "QTY";
            this.QTY.UseVisualStyleBackColor = false;
            this.QTY.Click += new System.EventHandler(this.QTY_Click);
            // 
            // CWIDTH
            // 
            this.CWIDTH.BackColor = System.Drawing.Color.LawnGreen;
            this.CWIDTH.Location = new System.Drawing.Point(354, 73);
            this.CWIDTH.Name = "CWIDTH";
            this.CWIDTH.Size = new System.Drawing.Size(86, 31);
            this.CWIDTH.TabIndex = 18;
            this.CWIDTH.Text = "CWIDTH";
            this.CWIDTH.UseVisualStyleBackColor = false;
            this.CWIDTH.Click += new System.EventHandler(this.CWIDTH_Click);
            // 
            // Barcode
            // 
            this.Barcode.BackColor = System.Drawing.Color.LawnGreen;
            this.Barcode.Location = new System.Drawing.Point(171, 73);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(84, 31);
            this.Barcode.TabIndex = 18;
            this.Barcode.Text = "Barcode";
            this.Barcode.UseVisualStyleBackColor = false;
            this.Barcode.Click += new System.EventHandler(this.Barcode_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1356, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(352, 26);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(757, 55);
            this.label2.TabIndex = 26;
            this.label2.Text = "Production Feedback Application";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnGenerateBarcode);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1771, 907);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 55);
            this.label1.TabIndex = 22;
            this.label1.Text = "Barcode Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1950, 462);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 940);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerateBarcode;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Barcode;
        private System.Windows.Forms.Button CLENG;
        private System.Windows.Forms.Button CWIDTH;
        private System.Windows.Forms.Button QTY;
        private System.Windows.Forms.Button MATNAME;
        private System.Windows.Forms.Button Workflow;
        private System.Windows.Forms.Button PartName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnketnoicsdl;
        private System.Windows.Forms.Button RESETSERVER;
        private System.Windows.Forms.Button CNC;
        private System.Windows.Forms.Button MáyDánCạnh;
        private System.Windows.Forms.Button MáyCưa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ĐăngXuất;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton tickcnc;
        private System.Windows.Forms.RadioButton tickcutting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

