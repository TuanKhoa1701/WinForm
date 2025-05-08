namespace ExportExcel
{
    partial class FormĐăngNhập
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
            this.ĐăngNhập = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textĐăngNhập = new System.Windows.Forms.TextBox();
            this.textMậtKhẩu = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ĐăngNhập
            // 
            this.ĐăngNhập.Location = new System.Drawing.Point(446, 240);
            this.ĐăngNhập.Name = "ĐăngNhập";
            this.ĐăngNhập.Size = new System.Drawing.Size(154, 56);
            this.ĐăngNhập.TabIndex = 0;
            this.ĐăngNhập.Text = "Login";
            this.ĐăngNhập.UseVisualStyleBackColor = true;
            this.ĐăngNhập.Click += new System.EventHandler(this.ĐăngNhập_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(647, 240);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(141, 56);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textĐăngNhập
            // 
            this.textĐăngNhập.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textĐăngNhập.Location = new System.Drawing.Point(173, 71);
            this.textĐăngNhập.Name = "textĐăngNhập";
            this.textĐăngNhập.Size = new System.Drawing.Size(427, 30);
            this.textĐăngNhập.TabIndex = 4;
            // 
            // textMậtKhẩu
            // 
            this.textMậtKhẩu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMậtKhẩu.Location = new System.Drawing.Point(173, 160);
            this.textMậtKhẩu.Name = "textMậtKhẩu";
            this.textMậtKhẩu.PasswordChar = '*';
            this.textMậtKhẩu.Size = new System.Drawing.Size(427, 30);
            this.textMậtKhẩu.TabIndex = 4;
            this.textMậtKhẩu.TextChanged += new System.EventHandler(this.textMậtKhẩu_TextChanged);
            this.textMậtKhẩu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMậtKhẩu_KeyDown);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(616, 54);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(172, 154);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 52);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // FormĐăngNhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textMậtKhẩu);
            this.Controls.Add(this.textĐăngNhập);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ĐăngNhập);
            this.Name = "FormĐăngNhập";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormĐăngNhập_FormClosing);
            this.Load += new System.EventHandler(this.FormĐăngNhập_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ĐăngNhập;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textĐăngNhập;
        private System.Windows.Forms.TextBox textMậtKhẩu;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}