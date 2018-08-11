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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDataPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvIV = new System.Windows.Forms.DataGridView();
            this.col_iv_docdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_docnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_cuscod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_warranty_spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_cusnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSTCRD = new System.Windows.Forms.DataGridView();
            this.col_stkcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stkdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warranty_type = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_warranty_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tqucod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stcrdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWarranted = new System.Windows.Forms.CheckBox();
            this.cbWarranty = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabIV = new System.Windows.Forms.TabPage();
            this.tabHS = new System.Windows.Forms.TabPage();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.col_hs_docdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hs_docnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hs_cuscod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hs_warranty_spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hs_cusnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSlmcod = new System.Windows.Forms.Label();
            this.lblSonum = new System.Windows.Forms.Label();
            this.lblDocdat = new System.Windows.Forms.Label();
            this.lblDocnum = new System.Windows.Forms.Label();
            this.lblCuscod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddr02 = new System.Windows.Forms.Label();
            this.lblAddr01 = new System.Windows.Forms.Label();
            this.lblCusnam = new System.Windows.Forms.Label();
            this.lblTelnum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnWarrantyOK = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTCRD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabIV.SuspendLayout();
            this.tabHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblDataPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 643);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 22);
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
            this.col_iv_warranty_spec,
            this.col_iv_cusnam});
            this.dgvIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIV.EnableHeadersVisualStyles = false;
            this.dgvIV.Location = new System.Drawing.Point(3, 3);
            this.dgvIV.MultiSelect = false;
            this.dgvIV.Name = "dgvIV";
            this.dgvIV.RowHeadersVisible = false;
            this.dgvIV.RowTemplate.Height = 25;
            this.dgvIV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIV.Size = new System.Drawing.Size(330, 442);
            this.dgvIV.TabIndex = 2;
            this.dgvIV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvIV_CellPainting);
            this.dgvIV.CurrentCellChanged += new System.EventHandler(this.dgvIV_CurrentCellChanged);
            // 
            // col_iv_docdat
            // 
            this.col_iv_docdat.DataPropertyName = "docdat";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.col_iv_docdat.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.col_iv_docnum.MinimumWidth = 100;
            this.col_iv_docnum.Name = "col_iv_docnum";
            this.col_iv_docnum.ReadOnly = true;
            // 
            // col_iv_cuscod
            // 
            this.col_iv_cuscod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_iv_cuscod.DataPropertyName = "cuscod";
            this.col_iv_cuscod.HeaderText = "รหัสลูกค้า";
            this.col_iv_cuscod.Name = "col_iv_cuscod";
            this.col_iv_cuscod.ReadOnly = true;
            // 
            // col_iv_warranty_spec
            // 
            this.col_iv_warranty_spec.DataPropertyName = "warranty_spec";
            this.col_iv_warranty_spec.HeaderText = "War.";
            this.col_iv_warranty_spec.MinimumWidth = 30;
            this.col_iv_warranty_spec.Name = "col_iv_warranty_spec";
            this.col_iv_warranty_spec.ReadOnly = true;
            this.col_iv_warranty_spec.Width = 30;
            // 
            // col_iv_cusnam
            // 
            this.col_iv_cusnam.DataPropertyName = "cusnam";
            this.col_iv_cusnam.HeaderText = "ชื่อลูกค้า";
            this.col_iv_cusnam.Name = "col_iv_cusnam";
            this.col_iv_cusnam.ReadOnly = true;
            this.col_iv_cusnam.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(355, 220);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 410);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSTCRD);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(815, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "รายการสินค้าในบิล (เฉพาะที่คุม Serial)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSTCRD
            // 
            this.dgvSTCRD.AllowUserToAddRows = false;
            this.dgvSTCRD.AllowUserToDeleteRows = false;
            this.dgvSTCRD.AllowUserToResizeRows = false;
            this.dgvSTCRD.ColumnHeadersHeight = 28;
            this.dgvSTCRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSTCRD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stkcod,
            this.col_stkdes,
            this.col_warranty_type,
            this.col_warranty_period,
            this.col_trnqty,
            this.col_tqucod,
            this.col_stcrdmin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSTCRD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSTCRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSTCRD.EnableHeadersVisualStyles = false;
            this.dgvSTCRD.Location = new System.Drawing.Point(0, 0);
            this.dgvSTCRD.MultiSelect = false;
            this.dgvSTCRD.Name = "dgvSTCRD";
            this.dgvSTCRD.RowHeadersVisible = false;
            this.dgvSTCRD.RowTemplate.Height = 25;
            this.dgvSTCRD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSTCRD.Size = new System.Drawing.Size(815, 381);
            this.dgvSTCRD.TabIndex = 3;
            this.dgvSTCRD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTCRD_CellContentClick);
            this.dgvSTCRD.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSTCRD_Paint);
            // 
            // col_stkcod
            // 
            this.col_stkcod.DataPropertyName = "stkcod";
            this.col_stkcod.HeaderText = "รหัสสินค้า";
            this.col_stkcod.MinimumWidth = 150;
            this.col_stkcod.Name = "col_stkcod";
            this.col_stkcod.ReadOnly = true;
            this.col_stkcod.Width = 150;
            // 
            // col_stkdes
            // 
            this.col_stkdes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stkdes.DataPropertyName = "stkdes";
            this.col_stkdes.HeaderText = "รายละเอียด";
            this.col_stkdes.MinimumWidth = 140;
            this.col_stkdes.Name = "col_stkdes";
            this.col_stkdes.ReadOnly = true;
            // 
            // col_warranty_type
            // 
            this.col_warranty_type.DataPropertyName = "warranty_type";
            this.col_warranty_type.HeaderText = "Warranty Type";
            this.col_warranty_type.MinimumWidth = 140;
            this.col_warranty_type.Name = "col_warranty_type";
            this.col_warranty_type.ReadOnly = true;
            this.col_warranty_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_warranty_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_warranty_type.Width = 140;
            // 
            // col_warranty_period
            // 
            this.col_warranty_period.DataPropertyName = "warranty_period";
            this.col_warranty_period.HeaderText = "อายุรับประกัน (เดือน)";
            this.col_warranty_period.MinimumWidth = 130;
            this.col_warranty_period.Name = "col_warranty_period";
            this.col_warranty_period.ReadOnly = true;
            this.col_warranty_period.Width = 130;
            // 
            // col_trnqty
            // 
            this.col_trnqty.DataPropertyName = "trnqty";
            this.col_trnqty.HeaderText = "จำนวน";
            this.col_trnqty.MinimumWidth = 100;
            this.col_trnqty.Name = "col_trnqty";
            this.col_trnqty.ReadOnly = true;
            // 
            // col_tqucod
            // 
            this.col_tqucod.DataPropertyName = "tqucod";
            this.col_tqucod.HeaderText = "";
            this.col_tqucod.MinimumWidth = 30;
            this.col_tqucod.Name = "col_tqucod";
            this.col_tqucod.ReadOnly = true;
            this.col_tqucod.Width = 30;
            // 
            // col_stcrdmin
            // 
            this.col_stcrdmin.DataPropertyName = "stcrdmin";
            this.col_stcrdmin.HeaderText = "StcrdMin";
            this.col_stcrdmin.MinimumWidth = 100;
            this.col_stcrdmin.Name = "col_stcrdmin";
            this.col_stcrdmin.ReadOnly = true;
            this.col_stcrdmin.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbWarranted);
            this.groupBox1.Controls.Add(this.cbWarranty);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "กำหนดเงื่อนไขเพิ่มเติม";
            // 
            // cbWarranted
            // 
            this.cbWarranted.AutoSize = true;
            this.cbWarranted.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbWarranted.Location = new System.Drawing.Point(20, 51);
            this.cbWarranted.Name = "cbWarranted";
            this.cbWarranted.Size = new System.Drawing.Size(200, 20);
            this.cbWarranted.TabIndex = 1;
            this.cbWarranted.Text = "รายการที่กรอกอายุรับประกันแล้ว";
            this.cbWarranted.UseVisualStyleBackColor = true;
            // 
            // cbWarranty
            // 
            this.cbWarranty.AutoSize = true;
            this.cbWarranty.Checked = true;
            this.cbWarranty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWarranty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbWarranty.Location = new System.Drawing.Point(20, 25);
            this.cbWarranty.Name = "cbWarranty";
            this.cbWarranty.Size = new System.Drawing.Size(222, 20);
            this.cbWarranty.TabIndex = 0;
            this.cbWarranty.Text = "รายการที่ยังไม่ได้กรอกอายุรับประกัน";
            this.cbWarranty.UseVisualStyleBackColor = true;
            this.cbWarranty.CheckedChanged += new System.EventHandler(this.cbWarranty_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabIV);
            this.tabControl2.Controls.Add(this.tabHS);
            this.tabControl2.Location = new System.Drawing.Point(12, 153);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(344, 477);
            this.tabControl2.TabIndex = 5;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabIV
            // 
            this.tabIV.Controls.Add(this.dgvIV);
            this.tabIV.Location = new System.Drawing.Point(4, 25);
            this.tabIV.Name = "tabIV";
            this.tabIV.Padding = new System.Windows.Forms.Padding(3);
            this.tabIV.Size = new System.Drawing.Size(336, 448);
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
            this.tabHS.Size = new System.Drawing.Size(336, 448);
            this.tabHS.TabIndex = 1;
            this.tabHS.Text = "  ขายสด  ";
            this.tabHS.UseVisualStyleBackColor = true;
            // 
            // dgvHS
            // 
            this.dgvHS.AllowUserToAddRows = false;
            this.dgvHS.AllowUserToDeleteRows = false;
            this.dgvHS.AllowUserToResizeColumns = false;
            this.dgvHS.AllowUserToResizeRows = false;
            this.dgvHS.ColumnHeadersHeight = 28;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_hs_docdat,
            this.col_hs_docnum,
            this.col_hs_cuscod,
            this.col_hs_warranty_spec,
            this.col_hs_cusnam});
            this.dgvHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHS.EnableHeadersVisualStyles = false;
            this.dgvHS.Location = new System.Drawing.Point(3, 3);
            this.dgvHS.MultiSelect = false;
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.RowHeadersVisible = false;
            this.dgvHS.RowTemplate.Height = 25;
            this.dgvHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHS.Size = new System.Drawing.Size(330, 442);
            this.dgvHS.TabIndex = 3;
            this.dgvHS.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvIV_CellPainting);
            this.dgvHS.CurrentCellChanged += new System.EventHandler(this.dgvIV_CurrentCellChanged);
            // 
            // col_hs_docdat
            // 
            this.col_hs_docdat.DataPropertyName = "docdat";
            this.col_hs_docdat.HeaderText = "วันที่";
            this.col_hs_docdat.MinimumWidth = 85;
            this.col_hs_docdat.Name = "col_hs_docdat";
            this.col_hs_docdat.ReadOnly = true;
            this.col_hs_docdat.Width = 85;
            // 
            // col_hs_docnum
            // 
            this.col_hs_docnum.DataPropertyName = "docnum";
            this.col_hs_docnum.HeaderText = "เลขที่";
            this.col_hs_docnum.MinimumWidth = 100;
            this.col_hs_docnum.Name = "col_hs_docnum";
            this.col_hs_docnum.ReadOnly = true;
            // 
            // col_hs_cuscod
            // 
            this.col_hs_cuscod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_hs_cuscod.DataPropertyName = "cuscod";
            this.col_hs_cuscod.HeaderText = "รหัสลูกค้า";
            this.col_hs_cuscod.Name = "col_hs_cuscod";
            this.col_hs_cuscod.ReadOnly = true;
            // 
            // col_hs_warranty_spec
            // 
            this.col_hs_warranty_spec.DataPropertyName = "warranty_spec";
            this.col_hs_warranty_spec.HeaderText = "War.";
            this.col_hs_warranty_spec.MinimumWidth = 30;
            this.col_hs_warranty_spec.Name = "col_hs_warranty_spec";
            this.col_hs_warranty_spec.ReadOnly = true;
            this.col_hs_warranty_spec.Width = 30;
            // 
            // col_hs_cusnam
            // 
            this.col_hs_cusnam.DataPropertyName = "cusnam";
            this.col_hs_cusnam.HeaderText = "ชื่อลูกค้า";
            this.col_hs_cusnam.Name = "col_hs_cusnam";
            this.col_hs_cusnam.ReadOnly = true;
            this.col_hs_cusnam.Visible = false;
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
            this.panel1.Location = new System.Drawing.Point(360, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 157);
            this.panel1.TabIndex = 6;
            // 
            // lblSlmcod
            // 
            this.lblSlmcod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlmcod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlmcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSlmcod.Location = new System.Drawing.Point(683, 93);
            this.lblSlmcod.Name = "lblSlmcod";
            this.lblSlmcod.Size = new System.Drawing.Size(101, 21);
            this.lblSlmcod.TabIndex = 1;
            this.lblSlmcod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSonum
            // 
            this.lblSonum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSonum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSonum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonum.Location = new System.Drawing.Point(683, 65);
            this.lblSonum.Name = "lblSonum";
            this.lblSonum.Size = new System.Drawing.Size(101, 21);
            this.lblSonum.TabIndex = 1;
            this.lblSonum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocdat
            // 
            this.lblDocdat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocdat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocdat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDocdat.Location = new System.Drawing.Point(683, 37);
            this.lblDocdat.Name = "lblDocdat";
            this.lblDocdat.Size = new System.Drawing.Size(101, 21);
            this.lblDocdat.TabIndex = 1;
            this.lblDocdat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocnum
            // 
            this.lblDocnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocnum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDocnum.Location = new System.Drawing.Point(683, 9);
            this.lblDocnum.Name = "lblDocnum";
            this.lblDocnum.Size = new System.Drawing.Size(101, 21);
            this.lblDocnum.TabIndex = 1;
            this.lblDocnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "พนักงานขาย";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ใบสั่งขาย #";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "วันที่";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "เลขที่";
            // 
            // lblAddr02
            // 
            this.lblAddr02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddr02.Location = new System.Drawing.Point(24, 93);
            this.lblAddr02.Name = "lblAddr02";
            this.lblAddr02.Size = new System.Drawing.Size(570, 21);
            this.lblAddr02.TabIndex = 0;
            this.lblAddr02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddr01
            // 
            this.lblAddr01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddr01.Location = new System.Drawing.Point(24, 65);
            this.lblAddr01.Name = "lblAddr01";
            this.lblAddr01.Size = new System.Drawing.Size(570, 21);
            this.lblAddr01.TabIndex = 0;
            this.lblAddr01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCusnam
            // 
            this.lblCusnam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCusnam.Location = new System.Drawing.Point(24, 37);
            this.lblCusnam.Name = "lblCusnam";
            this.lblCusnam.Size = new System.Drawing.Size(570, 21);
            this.lblCusnam.TabIndex = 0;
            this.lblCusnam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelnum
            // 
            this.lblTelnum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelnum.Location = new System.Drawing.Point(24, 123);
            this.lblTelnum.Name = "lblTelnum";
            this.lblTelnum.Size = new System.Drawing.Size(570, 21);
            this.lblTelnum.TabIndex = 0;
            this.lblTelnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnItem,
            this.toolStripSeparator1,
            this.btnSave,
            this.btnStop,
            this.toolStripSeparator2,
            this.btnWarrantyOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1188, 43);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnItem
            // 
            this.btnItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItem.Image = global::Num2Serial.Properties.Resources.item;
            this.btnItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(36, 40);
            this.btnItem.Text = "เริ่มกรอกอายุรับประกันในรายการสินค้า <F8>";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Num2Serial.Properties.Resources.save;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 40);
            this.btnSave.Text = "บันทึก <F9>";
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::Num2Serial.Properties.Resources.stop;
            this.btnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(36, 40);
            this.btnStop.Text = "ยกเลิกการแก้ไขข้อมูล <Esc>";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnWarrantyOK
            // 
            this.btnWarrantyOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWarrantyOK.Image = global::Num2Serial.Properties.Resources.ok;
            this.btnWarrantyOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnWarrantyOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWarrantyOK.Name = "btnWarrantyOK";
            this.btnWarrantyOK.Size = new System.Drawing.Size(36, 40);
            this.btnWarrantyOK.Text = "ทำเครื่องหมายว่าอินวอยซ์นี้ กรอกอายุรับประกันแล้ว";
            this.btnWarrantyOK.Click += new System.EventHandler(this.btnWarrantyOK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 665);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(815, 400);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTCRD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabIV.ResumeLayout(false);
            this.tabHS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbWarranty;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_warranty_spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_cusnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_docdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_docnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_cuscod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_warranty_spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_cusnam;
        private System.Windows.Forms.CheckBox cbWarranted;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnItem;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnWarrantyOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stkcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stkdes;
        private System.Windows.Forms.DataGridViewButtonColumn col_warranty_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warranty_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_trnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tqucod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stcrdmin;
    }
}

