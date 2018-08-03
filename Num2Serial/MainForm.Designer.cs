namespace Num2Serial
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDataPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvIV = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabIV = new System.Windows.Forms.TabPage();
            this.tabHS = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCuscod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDocnum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDocdat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSonum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSlmcod = new System.Windows.Forms.Label();
            this.lblTelnum = new System.Windows.Forms.Label();
            this.lblCusnam = new System.Windows.Forms.Label();
            this.lblAddr01 = new System.Windows.Forms.Label();
            this.lblAddr02 = new System.Windows.Forms.Label();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.dgvSTCRD = new System.Windows.Forms.DataGridView();
            this.col_iv_docdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_docnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_cuscod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_cusnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabIV.SuspendLayout();
            this.tabHS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTCRD)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblDataPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(941, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "ที่เก็บข้อมูล :";
            // 
            // lblDataPath
            // 
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(15, 17);
            this.lblDataPath.Text = "--";
            // 
            // dgvIV
            // 
            this.dgvIV.AllowUserToAddRows = false;
            this.dgvIV.AllowUserToDeleteRows = false;
            this.dgvIV.AllowUserToResizeColumns = false;
            this.dgvIV.AllowUserToResizeRows = false;
            this.dgvIV.ColumnHeadersHeight = 28;
            this.dgvIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_iv_docdat,
            this.col_iv_docnum,
            this.col_iv_cuscod,
            this.col_iv_cusnam});
            this.dgvIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIV.EnableHeadersVisualStyles = false;
            this.dgvIV.Location = new System.Drawing.Point(3, 3);
            this.dgvIV.MultiSelect = false;
            this.dgvIV.Name = "dgvIV";
            this.dgvIV.RowHeadersVisible = false;
            this.dgvIV.RowTemplate.Height = 25;
            this.dgvIV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIV.Size = new System.Drawing.Size(310, 426);
            this.dgvIV.TabIndex = 2;
            this.dgvIV.CurrentCellChanged += new System.EventHandler(this.dgvIV_CurrentCellChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(337, 183);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 352);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSTCRD);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "รายการสินค้าในบิล (เฉพาะที่คุม Serial)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "กำหนดเงื่อนไขเพิ่มเติม";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox1.Location = new System.Drawing.Point(25, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "เฉพาะรายการที่ยังไม่ได้กรอกอายุรับประกัน";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabIV);
            this.tabControl2.Controls.Add(this.tabHS);
            this.tabControl2.Location = new System.Drawing.Point(12, 74);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(324, 461);
            this.tabControl2.TabIndex = 5;
            // 
            // tabIV
            // 
            this.tabIV.Controls.Add(this.dgvIV);
            this.tabIV.Location = new System.Drawing.Point(4, 25);
            this.tabIV.Name = "tabIV";
            this.tabIV.Padding = new System.Windows.Forms.Padding(3);
            this.tabIV.Size = new System.Drawing.Size(316, 432);
            this.tabIV.TabIndex = 0;
            this.tabIV.Text = "  ขายเชื่อ  ";
            this.tabIV.UseVisualStyleBackColor = true;
            // 
            // tabHS
            // 
            this.tabHS.Controls.Add(this.dgvHS);
            this.tabHS.Location = new System.Drawing.Point(4, 25);
            this.tabHS.Name = "tabHS";
            this.tabHS.Padding = new System.Windows.Forms.Padding(3);
            this.tabHS.Size = new System.Drawing.Size(316, 432);
            this.tabHS.TabIndex = 1;
            this.tabHS.Text = "  ขายสด  ";
            this.tabHS.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSlmcod);
            this.panel1.Controls.Add(this.lblSonum);
            this.panel1.Controls.Add(this.lblDocdat);
            this.panel1.Controls.Add(this.lblDocnum);
            this.panel1.Controls.Add(this.lblCuscod);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAddr02);
            this.panel1.Controls.Add(this.lblAddr01);
            this.panel1.Controls.Add(this.lblCusnam);
            this.panel1.Controls.Add(this.lblTelnum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(340, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 157);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสลูกค้า";
            // 
            // lblCuscod
            // 
            this.lblCuscod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCuscod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCuscod.Location = new System.Drawing.Point(85, 9);
            this.lblCuscod.Name = "lblCuscod";
            this.lblCuscod.Size = new System.Drawing.Size(139, 21);
            this.lblCuscod.TabIndex = 1;
            this.lblCuscod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "เลขที่";
            // 
            // lblDocnum
            // 
            this.lblDocnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocnum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDocnum.Location = new System.Drawing.Point(456, 9);
            this.lblDocnum.Name = "lblDocnum";
            this.lblDocnum.Size = new System.Drawing.Size(101, 21);
            this.lblDocnum.TabIndex = 1;
            this.lblDocnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "วันที่";
            // 
            // lblDocdat
            // 
            this.lblDocdat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocdat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocdat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDocdat.Location = new System.Drawing.Point(456, 37);
            this.lblDocdat.Name = "lblDocdat";
            this.lblDocdat.Size = new System.Drawing.Size(101, 21);
            this.lblDocdat.TabIndex = 1;
            this.lblDocdat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ใบสั่งขาย #";
            // 
            // lblSonum
            // 
            this.lblSonum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSonum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSonum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonum.Location = new System.Drawing.Point(456, 65);
            this.lblSonum.Name = "lblSonum";
            this.lblSonum.Size = new System.Drawing.Size(101, 21);
            this.lblSonum.TabIndex = 1;
            this.lblSonum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "พนักงานขาย";
            // 
            // lblSlmcod
            // 
            this.lblSlmcod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlmcod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlmcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSlmcod.Location = new System.Drawing.Point(456, 93);
            this.lblSlmcod.Name = "lblSlmcod";
            this.lblSlmcod.Size = new System.Drawing.Size(101, 21);
            this.lblSlmcod.TabIndex = 1;
            this.lblSlmcod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelnum
            // 
            this.lblTelnum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelnum.Location = new System.Drawing.Point(24, 123);
            this.lblTelnum.Name = "lblTelnum";
            this.lblTelnum.Size = new System.Drawing.Size(343, 21);
            this.lblTelnum.TabIndex = 0;
            this.lblTelnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCusnam
            // 
            this.lblCusnam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCusnam.Location = new System.Drawing.Point(24, 37);
            this.lblCusnam.Name = "lblCusnam";
            this.lblCusnam.Size = new System.Drawing.Size(343, 21);
            this.lblCusnam.TabIndex = 0;
            this.lblCusnam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddr01
            // 
            this.lblAddr01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddr01.Location = new System.Drawing.Point(24, 65);
            this.lblAddr01.Name = "lblAddr01";
            this.lblAddr01.Size = new System.Drawing.Size(343, 21);
            this.lblAddr01.TabIndex = 0;
            this.lblAddr01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddr02
            // 
            this.lblAddr02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddr02.Location = new System.Drawing.Point(24, 93);
            this.lblAddr02.Name = "lblAddr02";
            this.lblAddr02.Size = new System.Drawing.Size(343, 21);
            this.lblAddr02.TabIndex = 0;
            this.lblAddr02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvHS
            // 
            this.dgvHS.AllowUserToAddRows = false;
            this.dgvHS.AllowUserToDeleteRows = false;
            this.dgvHS.AllowUserToResizeColumns = false;
            this.dgvHS.AllowUserToResizeRows = false;
            this.dgvHS.ColumnHeadersHeight = 28;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHS.EnableHeadersVisualStyles = false;
            this.dgvHS.Location = new System.Drawing.Point(3, 3);
            this.dgvHS.MultiSelect = false;
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.RowHeadersVisible = false;
            this.dgvHS.RowTemplate.Height = 25;
            this.dgvHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHS.Size = new System.Drawing.Size(310, 426);
            this.dgvHS.TabIndex = 3;
            // 
            // dgvSTCRD
            // 
            this.dgvSTCRD.AllowUserToAddRows = false;
            this.dgvSTCRD.AllowUserToDeleteRows = false;
            this.dgvSTCRD.AllowUserToResizeColumns = false;
            this.dgvSTCRD.AllowUserToResizeRows = false;
            this.dgvSTCRD.ColumnHeadersHeight = 28;
            this.dgvSTCRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSTCRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSTCRD.EnableHeadersVisualStyles = false;
            this.dgvSTCRD.Location = new System.Drawing.Point(3, 3);
            this.dgvSTCRD.MultiSelect = false;
            this.dgvSTCRD.Name = "dgvSTCRD";
            this.dgvSTCRD.RowHeadersVisible = false;
            this.dgvSTCRD.RowTemplate.Height = 25;
            this.dgvSTCRD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSTCRD.Size = new System.Drawing.Size(580, 317);
            this.dgvSTCRD.TabIndex = 3;
            // 
            // col_iv_docdat
            // 
            this.col_iv_docdat.DataPropertyName = "docdat";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.col_iv_docdat.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_iv_docdat.HeaderText = "วันที่";
            this.col_iv_docdat.MinimumWidth = 85;
            this.col_iv_docdat.Name = "col_iv_docdat";
            this.col_iv_docdat.ReadOnly = true;
            this.col_iv_docdat.Width = 85;
            // 
            // col_iv_docnum
            // 
            this.col_iv_docnum.DataPropertyName = "docnum";
            this.col_iv_docnum.HeaderText = "เลขที่";
            this.col_iv_docnum.MinimumWidth = 110;
            this.col_iv_docnum.Name = "col_iv_docnum";
            this.col_iv_docnum.ReadOnly = true;
            this.col_iv_docnum.Width = 110;
            // 
            // col_iv_cuscod
            // 
            this.col_iv_cuscod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_iv_cuscod.DataPropertyName = "cuscod";
            this.col_iv_cuscod.HeaderText = "รหัสลูกค้า";
            this.col_iv_cuscod.Name = "col_iv_cuscod";
            this.col_iv_cuscod.ReadOnly = true;
            // 
            // col_iv_cusnam
            // 
            this.col_iv_cusnam.DataPropertyName = "cusnam";
            this.col_iv_cusnam.HeaderText = "ชื่อลูกค้า";
            this.col_iv_cusnam.Name = "col_iv_cusnam";
            this.col_iv_cusnam.ReadOnly = true;
            this.col_iv_cusnam.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(815, 350);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Num2Serial";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabIV.ResumeLayout(false);
            this.tabHS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTCRD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDataPath;
        private System.Windows.Forms.DataGridView dgvIV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabIV;
        private System.Windows.Forms.TabPage tabHS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSlmcod;
        private System.Windows.Forms.Label lblSonum;
        private System.Windows.Forms.Label lblDocdat;
        private System.Windows.Forms.Label lblDocnum;
        private System.Windows.Forms.Label lblCuscod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddr02;
        private System.Windows.Forms.Label lblAddr01;
        private System.Windows.Forms.Label lblCusnam;
        private System.Windows.Forms.Label lblTelnum;
        private System.Windows.Forms.DataGridView dgvSTCRD;
        private System.Windows.Forms.DataGridView dgvHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_docdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_docnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_cuscod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_cusnam;
    }
}

