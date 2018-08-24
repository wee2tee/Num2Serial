namespace Warranty.SubForm
{
    partial class DialogWarranty
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
            this.cbWarType = new System.Windows.Forms.ComboBox();
            this.numWarMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numWarMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWarType
            // 
            this.cbWarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarType.FormattingEnabled = true;
            this.cbWarType.Location = new System.Drawing.Point(179, 30);
            this.cbWarType.Name = "cbWarType";
            this.cbWarType.Size = new System.Drawing.Size(137, 24);
            this.cbWarType.TabIndex = 0;
            this.cbWarType.SelectedIndexChanged += new System.EventHandler(this.cbWarType_SelectedIndexChanged);
            // 
            // numWarMonth
            // 
            this.numWarMonth.Location = new System.Drawing.Point(179, 62);
            this.numWarMonth.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numWarMonth.Name = "numWarMonth";
            this.numWarMonth.Size = new System.Drawing.Size(136, 23);
            this.numWarMonth.TabIndex = 1;
            this.numWarMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWarMonth.ValueChanged += new System.EventHandler(this.numWarMonth_ValueChanged);
            this.numWarMonth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numWarMonth_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "วิธีกำหนดอายุรับประกัน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "อายุรับประกัน (เดือน)";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(80, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 33);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ตกลง <F9>";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(188, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "ยกเลิก <Esc>";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DialogWarranty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 169);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numWarMonth);
            this.Controls.Add(this.cbWarType);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogWarranty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "กำหนดอายุรับประกัน";
            this.Load += new System.EventHandler(this.DialogWarranty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWarMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWarType;
        private System.Windows.Forms.NumericUpDown numWarMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}