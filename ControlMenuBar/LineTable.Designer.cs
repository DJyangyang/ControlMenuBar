namespace ControlMenuBar
{
    partial class LineTable
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnBrowser2 = new System.Windows.Forms.Button();
            this.cmbxTableNames1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbxEndRowNum1 = new System.Windows.Forms.TextBox();
            this.txbxStartRowNum1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxValueDescribe04 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe03 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe02 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe01 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbxYField4 = new System.Windows.Forms.ComboBox();
            this.cmbxYField3 = new System.Windows.Forms.ComboBox();
            this.cmbxYField2 = new System.Windows.Forms.ComboBox();
            this.cmbxYField1 = new System.Windows.Forms.ComboBox();
            this.cmbxXField1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(929, 549);
            this.splitContainer1.SplitterDistance = 598;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnBrowser2);
            this.splitContainer2.Panel1.Controls.Add(this.cmbxTableNames1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(598, 549);
            this.splitContainer2.SplitterDistance = 46;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnBrowser2
            // 
            this.btnBrowser2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowser2.Location = new System.Drawing.Point(507, 7);
            this.btnBrowser2.Name = "btnBrowser2";
            this.btnBrowser2.Size = new System.Drawing.Size(75, 32);
            this.btnBrowser2.TabIndex = 2;
            this.btnBrowser2.Text = "浏览";
            this.btnBrowser2.UseVisualStyleBackColor = true;
            this.btnBrowser2.Click += new System.EventHandler(this.btnBrowser2_Click);
            // 
            // cmbxTableNames1
            // 
            this.cmbxTableNames1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableNames1.FormattingEnabled = true;
            this.cmbxTableNames1.Location = new System.Drawing.Point(70, 13);
            this.cmbxTableNames1.Name = "cmbxTableNames1";
            this.cmbxTableNames1.Size = new System.Drawing.Size(416, 20);
            this.cmbxTableNames1.TabIndex = 1;
            this.cmbxTableNames1.SelectedIndexChanged += new System.EventHandler(this.cmbxTableNames1_SelectedIndexChanged);
            this.cmbxTableNames1.TextChanged += new System.EventHandler(this.cmbxTableNames1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名：";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(598, 499);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView2_RowStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnChart);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txbxEndRowNum1);
            this.groupBox1.Controls.Add(this.txbxStartRowNum1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe04);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe03);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe02);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe01);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbxYField4);
            this.groupBox1.Controls.Add(this.cmbxYField3);
            this.groupBox1.Controls.Add(this.cmbxYField2);
            this.groupBox1.Controls.Add(this.cmbxYField1);
            this.groupBox1.Controls.Add(this.cmbxXField1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计图表";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(73, 386);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 32);
            this.btnChart.TabIndex = 23;
            this.btnChart.Text = "生成图";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "绘图范围";
            // 
            // txbxEndRowNum1
            // 
            this.txbxEndRowNum1.Location = new System.Drawing.Point(185, 285);
            this.txbxEndRowNum1.Name = "txbxEndRowNum1";
            this.txbxEndRowNum1.Size = new System.Drawing.Size(67, 26);
            this.txbxEndRowNum1.TabIndex = 21;
            // 
            // txbxStartRowNum1
            // 
            this.txbxStartRowNum1.Location = new System.Drawing.Point(73, 285);
            this.txbxStartRowNum1.Name = "txbxStartRowNum1";
            this.txbxStartRowNum1.Size = new System.Drawing.Size(65, 26);
            this.txbxStartRowNum1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "至";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "从";
            // 
            // cmbxValueDescribe04
            // 
            this.cmbxValueDescribe04.Location = new System.Drawing.Point(219, 215);
            this.cmbxValueDescribe04.Name = "cmbxValueDescribe04";
            this.cmbxValueDescribe04.Size = new System.Drawing.Size(80, 26);
            this.cmbxValueDescribe04.TabIndex = 17;
            // 
            // cmbxValueDescribe03
            // 
            this.cmbxValueDescribe03.Location = new System.Drawing.Point(219, 171);
            this.cmbxValueDescribe03.Name = "cmbxValueDescribe03";
            this.cmbxValueDescribe03.Size = new System.Drawing.Size(80, 26);
            this.cmbxValueDescribe03.TabIndex = 16;
            // 
            // cmbxValueDescribe02
            // 
            this.cmbxValueDescribe02.Location = new System.Drawing.Point(219, 124);
            this.cmbxValueDescribe02.Name = "cmbxValueDescribe02";
            this.cmbxValueDescribe02.Size = new System.Drawing.Size(80, 26);
            this.cmbxValueDescribe02.TabIndex = 15;
            // 
            // cmbxValueDescribe01
            // 
            this.cmbxValueDescribe01.Location = new System.Drawing.Point(219, 78);
            this.cmbxValueDescribe01.Name = "cmbxValueDescribe01";
            this.cmbxValueDescribe01.Size = new System.Drawing.Size(80, 26);
            this.cmbxValueDescribe01.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "值";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "值";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "值";
            // 
            // cmbxYField4
            // 
            this.cmbxYField4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYField4.FormattingEnabled = true;
            this.cmbxYField4.Location = new System.Drawing.Point(73, 215);
            this.cmbxYField4.Name = "cmbxYField4";
            this.cmbxYField4.Size = new System.Drawing.Size(90, 28);
            this.cmbxYField4.TabIndex = 9;
            this.cmbxYField4.TextChanged += new System.EventHandler(this.cmbxYField4_TextChanged);
            // 
            // cmbxYField3
            // 
            this.cmbxYField3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYField3.FormattingEnabled = true;
            this.cmbxYField3.Location = new System.Drawing.Point(73, 171);
            this.cmbxYField3.Name = "cmbxYField3";
            this.cmbxYField3.Size = new System.Drawing.Size(90, 28);
            this.cmbxYField3.TabIndex = 8;
            this.cmbxYField3.TextChanged += new System.EventHandler(this.cmbxYField3_TextChanged);
            // 
            // cmbxYField2
            // 
            this.cmbxYField2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYField2.FormattingEnabled = true;
            this.cmbxYField2.Location = new System.Drawing.Point(73, 125);
            this.cmbxYField2.Name = "cmbxYField2";
            this.cmbxYField2.Size = new System.Drawing.Size(90, 28);
            this.cmbxYField2.TabIndex = 7;
            this.cmbxYField2.TextChanged += new System.EventHandler(this.cmbxYField2_TextChanged);
            // 
            // cmbxYField1
            // 
            this.cmbxYField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYField1.FormattingEnabled = true;
            this.cmbxYField1.Location = new System.Drawing.Point(73, 78);
            this.cmbxYField1.Name = "cmbxYField1";
            this.cmbxYField1.Size = new System.Drawing.Size(90, 28);
            this.cmbxYField1.TabIndex = 6;
            this.cmbxYField1.TextChanged += new System.EventHandler(this.cmbxYField1_TextChanged);
            // 
            // cmbxXField1
            // 
            this.cmbxXField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxXField1.FormattingEnabled = true;
            this.cmbxXField1.Location = new System.Drawing.Point(69, 23);
            this.cmbxXField1.Name = "cmbxXField1";
            this.cmbxXField1.Size = new System.Drawing.Size(230, 28);
            this.cmbxXField1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "因变量Y4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "因变量Y3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "因变量Y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "因变量Y1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "自变量X";
            // 
            // LineTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LineTable";
            this.Text = "LineTable";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cmbxTableNames1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnBrowser2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cmbxValueDescribe04;
        private System.Windows.Forms.TextBox cmbxValueDescribe03;
        private System.Windows.Forms.TextBox cmbxValueDescribe02;
        private System.Windows.Forms.TextBox cmbxValueDescribe01;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxYField4;
        private System.Windows.Forms.ComboBox cmbxYField3;
        private System.Windows.Forms.ComboBox cmbxYField2;
        private System.Windows.Forms.ComboBox cmbxYField1;
        private System.Windows.Forms.ComboBox cmbxXField1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbxEndRowNum1;
        private System.Windows.Forms.TextBox txbxStartRowNum1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChart;
    }
}