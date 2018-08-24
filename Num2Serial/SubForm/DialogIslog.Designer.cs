namespace Warranty.SubForm
{
    partial class DialogIslog
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rec_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_docnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_seqnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersHeight = 28;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_rec_time,
            this.col_data_path,
            this.col_docnum,
            this.col_seqnum,
            this.col_desc});
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(3, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(843, 404);
            this.dgv.TabIndex = 0;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Visible = false;
            // 
            // col_rec_time
            // 
            this.col_rec_time.DataPropertyName = "rec_time";
            dataGridViewCellStyle1.Format = "dd/MM/yy  HH:mm";
            this.col_rec_time.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_rec_time.HeaderText = "วันที่/เวลา";
            this.col_rec_time.MinimumWidth = 100;
            this.col_rec_time.Name = "col_rec_time";
            this.col_rec_time.ReadOnly = true;
            // 
            // col_data_path
            // 
            this.col_data_path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_data_path.DataPropertyName = "data_path";
            this.col_data_path.FillWeight = 70F;
            this.col_data_path.HeaderText = "ที่เก็บข้อมูล";
            this.col_data_path.MinimumWidth = 180;
            this.col_data_path.Name = "col_data_path";
            this.col_data_path.ReadOnly = true;
            // 
            // col_docnum
            // 
            this.col_docnum.DataPropertyName = "docnum";
            this.col_docnum.HeaderText = "เลขที่เอกสาร";
            this.col_docnum.MinimumWidth = 100;
            this.col_docnum.Name = "col_docnum";
            this.col_docnum.ReadOnly = true;
            // 
            // col_seqnum
            // 
            this.col_seqnum.DataPropertyName = "seqnum";
            this.col_seqnum.HeaderText = "ลำดับ";
            this.col_seqnum.MinimumWidth = 50;
            this.col_seqnum.Name = "col_seqnum";
            this.col_seqnum.ReadOnly = true;
            this.col_seqnum.Width = 50;
            // 
            // col_desc
            // 
            this.col_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_desc.DataPropertyName = "desc";
            this.col_desc.HeaderText = "รายละเอียด";
            this.col_desc.Name = "col_desc";
            this.col_desc.ReadOnly = true;
            // 
            // DialogIslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 412);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogIslog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ประวัติการทำงาน";
            this.Load += new System.EventHandler(this.DialogIslog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rec_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_docnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_seqnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_desc;
    }
}