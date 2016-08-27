namespace ControlMenuBar
{
    partial class ColumnTable
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxMdbFileFullPath = new System.Windows.Forms.TextBox();
            this.cmbxTableNames = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbxEndRowNum = new System.Windows.Forms.TextBox();
            this.txbxStartRowNum = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbxValueDescribe1 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe = new System.Windows.Forms.TextBox();
            this.cmbxZField = new System.Windows.Forms.ComboBox();
            this.cmbxYField = new System.Windows.Forms.ComboBox();
            this.cmbxXField = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMdbBrowse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "mdb文件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "表名";
            // 
            // txbxMdbFileFullPath
            // 
            this.txbxMdbFileFullPath.Location = new System.Drawing.Point(87, 29);
            this.txbxMdbFileFullPath.Name = "txbxMdbFileFullPath";
            this.txbxMdbFileFullPath.Size = new System.Drawing.Size(467, 21);
            this.txbxMdbFileFullPath.TabIndex = 2;
            // 
            // cmbxTableNames
            // 
            this.cmbxTableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableNames.FormattingEnabled = true;
            this.cmbxTableNames.Location = new System.Drawing.Point(87, 82);
            this.cmbxTableNames.Name = "cmbxTableNames";
            this.cmbxTableNames.Size = new System.Drawing.Size(312, 20);
            this.cmbxTableNames.TabIndex = 3;
            this.cmbxTableNames.SelectedIndexChanged += new System.EventHandler(this.cmbxTableNames_SelectedIndexChanged);
            this.cmbxTableNames.TextChanged += new System.EventHandler(this.cmbxTableNames_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(434, 280);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbxEndRowNum);
            this.groupBox1.Controls.Add(this.txbxStartRowNum);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe1);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe);
            this.groupBox1.Controls.Add(this.cmbxZField);
            this.groupBox1.Controls.Add(this.cmbxYField);
            this.groupBox1.Controls.Add(this.cmbxXField);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(477, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计图表";
            // 
            // txbxEndRowNum
            // 
            this.txbxEndRowNum.Location = new System.Drawing.Point(136, 240);
            this.txbxEndRowNum.Name = "txbxEndRowNum";
            this.txbxEndRowNum.Size = new System.Drawing.Size(52, 21);
            this.txbxEndRowNum.TabIndex = 13;
            // 
            // txbxStartRowNum
            // 
            this.txbxStartRowNum.Location = new System.Drawing.Point(54, 240);
            this.txbxStartRowNum.Name = "txbxStartRowNum";
            this.txbxStartRowNum.Size = new System.Drawing.Size(51, 21);
            this.txbxStartRowNum.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "生成表";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "生成图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbxValueDescribe1
            // 
            this.cmbxValueDescribe1.Location = new System.Drawing.Point(66, 196);
            this.cmbxValueDescribe1.Name = "cmbxValueDescribe1";
            this.cmbxValueDescribe1.Size = new System.Drawing.Size(122, 21);
            this.cmbxValueDescribe1.TabIndex = 9;
            // 
            // cmbxValueDescribe
            // 
            this.cmbxValueDescribe.Location = new System.Drawing.Point(66, 154);
            this.cmbxValueDescribe.Name = "cmbxValueDescribe";
            this.cmbxValueDescribe.Size = new System.Drawing.Size(121, 21);
            this.cmbxValueDescribe.TabIndex = 8;
            // 
            // cmbxZField
            // 
            this.cmbxZField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxZField.FormattingEnabled = true;
            this.cmbxZField.Location = new System.Drawing.Point(66, 115);
            this.cmbxZField.Name = "cmbxZField";
            this.cmbxZField.Size = new System.Drawing.Size(121, 20);
            this.cmbxZField.TabIndex = 7;
            this.cmbxZField.TextChanged += new System.EventHandler(this.cmbxZField_TextChanged);
            // 
            // cmbxYField
            // 
            this.cmbxYField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYField.FormattingEnabled = true;
            this.cmbxYField.Location = new System.Drawing.Point(66, 72);
            this.cmbxYField.Name = "cmbxYField";
            this.cmbxYField.Size = new System.Drawing.Size(121, 20);
            this.cmbxYField.TabIndex = 6;
            this.cmbxYField.TextChanged += new System.EventHandler(this.cmbxYField_TextChanged);
            // 
            // cmbxXField
            // 
            this.cmbxXField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxXField.FormattingEnabled = true;
            this.cmbxXField.Location = new System.Drawing.Point(66, 25);
            this.cmbxXField.Name = "cmbxXField";
            this.cmbxXField.Size = new System.Drawing.Size(121, 20);
            this.cmbxXField.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "值描述Y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "值描述Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "因变量Y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "因变量Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "自变量X:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMdbBrowse
            // 
            this.btnMdbBrowse.Location = new System.Drawing.Point(581, 26);
            this.btnMdbBrowse.Name = "btnMdbBrowse";
            this.btnMdbBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMdbBrowse.TabIndex = 7;
            this.btnMdbBrowse.Text = "浏览";
            this.btnMdbBrowse.UseVisualStyleBackColor = true;
            this.btnMdbBrowse.Click += new System.EventHandler(this.btnMdbBrowse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "从";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "至";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "绘图范围";
            // 
            // ColumnTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 477);
            this.Controls.Add(this.btnMdbBrowse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbxTableNames);
            this.Controls.Add(this.txbxMdbFileFullPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColumnTable";
            this.Text = "用水户协会成立的必要性";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxMdbFileFullPath;
        private System.Windows.Forms.ComboBox cmbxTableNames;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cmbxValueDescribe1;
        private System.Windows.Forms.TextBox cmbxValueDescribe;
        private System.Windows.Forms.ComboBox cmbxZField;
        private System.Windows.Forms.ComboBox cmbxYField;
        private System.Windows.Forms.ComboBox cmbxXField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMdbBrowse;
        private System.Windows.Forms.TextBox txbxEndRowNum;
        private System.Windows.Forms.TextBox txbxStartRowNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

