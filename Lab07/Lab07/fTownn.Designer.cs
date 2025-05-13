namespace Lab07
{
    partial class fTownn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbSquare = new TextBox();
            tbYearIncome = new TextBox();
            tbName = new TextBox();
            tbCountry = new TextBox();
            tbRegion = new TextBox();
            tbPopulation = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbAirport = new CheckBox();
            cbPort = new CheckBox();
            btOk = new Button();
            btCancl = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSquare);
            groupBox1.Controls.Add(tbYearIncome);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbCountry);
            groupBox1.Controls.Add(tbRegion);
            groupBox1.Controls.Add(tbPopulation);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Загальні дані";
            // 
            // tbSquare
            // 
            tbSquare.Location = new Point(173, 202);
            tbSquare.Name = "tbSquare";
            tbSquare.Size = new Size(100, 23);
            tbSquare.TabIndex = 12;
            // 
            // tbYearIncome
            // 
            tbYearIncome.Location = new Point(173, 167);
            tbYearIncome.Name = "tbYearIncome";
            tbYearIncome.Size = new Size(100, 23);
            tbYearIncome.TabIndex = 11;
            // 
            // tbName
            // 
            tbName.Location = new Point(173, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 10;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(173, 62);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(100, 23);
            tbCountry.TabIndex = 9;
            // 
            // tbRegion
            // 
            tbRegion.Location = new Point(173, 97);
            tbRegion.Name = "tbRegion";
            tbRegion.Size = new Size(100, 23);
            tbRegion.TabIndex = 8;
            // 
            // tbPopulation
            // 
            tbPopulation.Location = new Point(173, 132);
            tbPopulation.Name = "tbPopulation";
            tbPopulation.Size = new Size(100, 23);
            tbPopulation.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 205);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 6;
            label6.Text = "Площа, кв. км:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 170);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 5;
            label5.Text = "Річний дохід, грн:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 135);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 4;
            label4.Text = "Кількість мешканців: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 100);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Регіон:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Країна:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Назва міста:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbAirport);
            groupBox2.Controls.Add(cbPort);
            groupBox2.Location = new Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Транспорт";
            // 
            // cbAirport
            // 
            cbAirport.AutoSize = true;
            cbAirport.Location = new Point(21, 67);
            cbAirport.Name = "cbAirport";
            cbAirport.Size = new Size(137, 19);
            cbAirport.TabIndex = 1;
            cbAirport.Text = "Місто має аеропорт";
            cbAirport.UseVisualStyleBackColor = true;
            // 
            // cbPort
            // 
            cbPort.AutoSize = true;
            cbPort.Location = new Point(21, 32);
            cbPort.Name = "cbPort";
            cbPort.Size = new Size(111, 19);
            cbPort.TabIndex = 0;
            cbPort.Text = "Місто має порт";
            cbPort.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            btOk.Location = new Point(327, 34);
            btOk.Name = "btOk";
            btOk.Size = new Size(89, 23);
            btOk.TabIndex = 2;
            btOk.Text = "Ok";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancl
            // 
            btCancl.Location = new Point(327, 63);
            btCancl.Name = "btCancl";
            btCancl.Size = new Size(89, 23);
            btCancl.TabIndex = 3;
            btCancl.Text = "Скасувати";
            btCancl.UseVisualStyleBackColor = true;
            btCancl.Click += btCancl_Click;
            // 
            // fTownn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 383);
            Controls.Add(btCancl);
            Controls.Add(btOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fTownn";
            Text = "Дані про нове місто";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbCountry;
        private TextBox tbRegion;
        private TextBox tbPopulation;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbSquare;
        private TextBox tbYearIncome;
        private TextBox tbName;
        private GroupBox groupBox2;
        private CheckBox cbAirport;
        private CheckBox cbPort;
        private Button btOk;
        private Button btCancl;
    }
}
