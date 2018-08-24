namespace Warranty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDataPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvIV = new System.Windows.Forms.DataGridView();
            this.col_iv_docdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_docnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_cuscod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iv_warranty_spec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_iv_cusnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSTCRD = new System.Windows.Forms.DataGridView();
            this.col_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stkcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stkdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warranty_type = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_warranty_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tqucod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stcrdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabIV = new System.Windows.Forms.TabPage();
            this.tabHS = new System.Windows.Forms.TabPage();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.col_hs_docdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hs_docnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hs_cuscod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hs_warranty_spec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_hs_cusnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchDocnum = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.ToolStripSplitButton();
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
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblDataPath,
            this.btnLog});
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
            this.lblDataPath.Size = new System.Drawing.Size(1020, 17);
            this.lblDataPath.Spring = true;
            this.lblDataPath.Text = "--";
            this.lblDataPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIV.EnableHeadersVisualStyles = false;
            this.dgvIV.Location = new System.Drawing.Point(3, 3);
            this.dgvIV.MultiSelect = false;
            this.dgvIV.Name = "dgvIV";
            this.dgvIV.RowHeadersVisible = false;
            this.dgvIV.RowTemplate.Height = 25;
            this.dgvIV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIV.Size = new System.Drawing.Size(330, 457);
            this.dgvIV.StandardTab = true;
            this.dgvIV.TabIndex = 2;
            this.dgvIV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIV_CellContentClick);
            this.dgvIV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIV_CellFormatting);
            this.dgvIV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvIV_CellPainting);
            this.dgvIV.CurrentCellChanged += new System.EventHandler(this.dgvIV_CurrentCellChanged);
            this.dgvIV.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_PaintFocusedRow);
            this.dgvIV.Enter += new System.EventHandler(this.dgvIV_Enter);
            this.dgvIV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvIV_MouseClick);
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
            this.col_iv_warranty_spec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_iv_warranty_spec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.tabControl1.Location = new System.Drawing.Point(360, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 459);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSTCRD);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(810, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "รายการสินค้าในบิล (เฉพาะที่คุม Serial Number) <F8>";
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
            this.col_seq,
            this.col_stkcod,
            this.col_stkdes,
            this.col_warranty_type,
            this.col_warranty_period,
            this.col_trnqty,
            this.col_tqucod,
            this.col_stcrdmin});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSTCRD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSTCRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSTCRD.EnableHeadersVisualStyles = false;
            this.dgvSTCRD.Location = new System.Drawing.Point(0, 0);
            this.dgvSTCRD.MultiSelect = false;
            this.dgvSTCRD.Name = "dgvSTCRD";
            this.dgvSTCRD.RowHeadersVisible = false;
            this.dgvSTCRD.RowTemplate.Height = 25;
            this.dgvSTCRD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSTCRD.Size = new System.Drawing.Size(810, 430);
            this.dgvSTCRD.StandardTab = true;
            this.dgvSTCRD.TabIndex = 3;
            this.dgvSTCRD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTCRD_CellContentClick);
            this.dgvSTCRD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTCRD_CellDoubleClick);
            this.dgvSTCRD.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSTCRD_CellFormatting);
            this.dgvSTCRD.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSTCRD_CellPainting);
            this.dgvSTCRD.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_PaintFocusedRow);
            this.dgvSTCRD.Enter += new System.EventHandler(this.dgvSTCRD_Enter);
            this.dgvSTCRD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSTCRD_MouseClick);
            // 
            // col_seq
            // 
            this.col_seq.DataPropertyName = "seqnum";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_seq.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_seq.HeaderText = "ลำดับ";
            this.col_seq.MinimumWidth = 40;
            this.col_seq.Name = "col_seq";
            this.col_seq.ReadOnly = true;
            this.col_seq.Width = 40;
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
            this.col_warranty_type.HeaderText = "วิธีบันทึกอายุรับประกัน";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.col_warranty_period.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_warranty_period.HeaderText = "อายุรับประกัน (เดือน)";
            this.col_warranty_period.MinimumWidth = 130;
            this.col_warranty_period.Name = "col_warranty_period";
            this.col_warranty_period.ReadOnly = true;
            this.col_warranty_period.Width = 130;
            // 
            // col_trnqty
            // 
            this.col_trnqty.DataPropertyName = "trnqty";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.col_trnqty.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_trnqty.HeaderText = "";
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "กำหนดเงื่อนไขการแสดงข้อมูล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "สถานะรายการ";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(13, 44);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(312, 24);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabIV);
            this.tabControl2.Controls.Add(this.tabHS);
            this.tabControl2.Location = new System.Drawing.Point(12, 107);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(344, 492);
            this.tabControl2.TabIndex = 5;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabIV
            // 
            this.tabIV.Controls.Add(this.dgvIV);
            this.tabIV.Location = new System.Drawing.Point(4, 25);
            this.tabIV.Name = "tabIV";
            this.tabIV.Padding = new System.Windows.Forms.Padding(3);
            this.tabIV.Size = new System.Drawing.Size(336, 463);
            this.tabIV.TabIndex = 0;
            this.tabIV.Text = "  ขายเชื่อ <F6>  ";
            this.tabIV.UseVisualStyleBackColor = true;
            // 
            // tabHS
            // 
            this.tabHS.Controls.Add(this.dgvHS);
            this.tabHS.Location = new System.Drawing.Point(4, 25);
            this.tabHS.Name = "tabHS";
            this.tabHS.Padding = new System.Windows.Forms.Padding(3);
            this.tabHS.Size = new System.Drawing.Size(336, 463);
            this.tabHS.TabIndex = 1;
            this.tabHS.Text = "  ขายสด <F7>  ";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHS.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHS.EnableHeadersVisualStyles = false;
            this.dgvHS.Location = new System.Drawing.Point(3, 3);
            this.dgvHS.MultiSelect = false;
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.RowHeadersVisible = false;
            this.dgvHS.RowTemplate.Height = 25;
            this.dgvHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHS.Size = new System.Drawing.Size(330, 457);
            this.dgvHS.StandardTab = true;
            this.dgvHS.TabIndex = 3;
            this.dgvHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIV_CellContentClick);
            this.dgvHS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIV_CellFormatting);
            this.dgvHS.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvIV_CellPainting);
            this.dgvHS.CurrentCellChanged += new System.EventHandler(this.dgvIV_CurrentCellChanged);
            this.dgvHS.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_PaintFocusedRow);
            this.dgvHS.Enter += new System.EventHandler(this.dgvIV_Enter);
            this.dgvHS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvIV_MouseClick);
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
            this.col_hs_warranty_spec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_hs_warranty_spec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.panel1.Controls.Add(this.lblStatus);
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
            this.panel1.Location = new System.Drawing.Point(360, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 157);
            this.panel1.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(621, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(167, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "บันทึกอายุรับประกันแล้ว";
            this.lblStatus.Visible = false;
            // 
            // lblSlmcod
            // 
            this.lblSlmcod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlmcod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlmcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSlmcod.Location = new System.Drawing.Point(683, 123);
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
            this.lblSonum.Location = new System.Drawing.Point(683, 93);
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
            this.lblDocdat.Location = new System.Drawing.Point(683, 65);
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
            this.lblDocnum.Location = new System.Drawing.Point(683, 37);
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
            this.label9.Location = new System.Drawing.Point(603, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "พนักงานขาย";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ใบสั่งขาย #";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "วันที่";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 39);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ค้นหาบิลขาย เลขที่";
            // 
            // txtSearchDocnum
            // 
            this.txtSearchDocnum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchDocnum.Location = new System.Drawing.Point(127, 605);
            this.txtSearchDocnum.MaxLength = 12;
            this.txtSearchDocnum.Name = "txtSearchDocnum";
            this.txtSearchDocnum.Size = new System.Drawing.Size(194, 23);
            this.txtSearchDocnum.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Warranty.Properties.Resources.zoom_16;
            this.btnSearch.Location = new System.Drawing.Point(322, 604);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLog
            // 
            this.btnLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLog.DropDownButtonWidth = 0;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(54, 20);
            this.btnLog.Text = "View Log";
            this.btnLog.ButtonClick += new System.EventHandler(this.btnLog_ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 665);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchDocnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(825, 400);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "บันทึกอายุรับประกันสินค้า";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_docdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_docnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_cuscod;
        private System.Windows.Forms.DataGridViewButtonColumn col_iv_warranty_spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iv_cusnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_docdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_docnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_cuscod;
        private System.Windows.Forms.DataGridViewButtonColumn col_hs_warranty_spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hs_cusnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stkcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stkdes;
        private System.Windows.Forms.DataGridViewButtonColumn col_warranty_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warranty_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_trnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tqucod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stcrdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchDocnum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripSplitButton btnLog;
    }
}

