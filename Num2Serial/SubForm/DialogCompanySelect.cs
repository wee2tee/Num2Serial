using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warranty.Helper;

namespace Warranty.SubForm
{
    public partial class DialogCompanySelect : Form
    {
        private MainForm main_form;
        private BindingList<SccompVM> sccomp;
        public Sccomp selected_comp = null;

        public DialogCompanySelect(MainForm main_form)
        {
            this.main_form = main_form;
            InitializeComponent();
        }

        private void DialogCompanySelect_Load(object sender, EventArgs e)
        {
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Misc.MAIN_BG;
            this.dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Misc.MAIN_BG;

            this.sccomp = new BindingList<SccompVM>(DbfTable.Sccomp(this.main_form.secure_path).ToViewModel().OrderBy(sc => sc.compnam).ToList());
            this.dgv.DataSource = this.sccomp;
            
            if(this.sccomp.Count > 0)
            {
                this.dgv.Rows[0].Cells[this.col_compnam.Name].Selected = true;
                this.btnOK.Enabled = true;
                this.btnSearch.Enabled = true;
            }
        }

        private void dgv_CurrentCellChanged(object sender, EventArgs e)
        {
            if(((DataGridView)sender).CurrentCell == null)
                return;

            this.selected_comp = (Sccomp)((DataGridView)sender).Rows[((DataGridView)sender).CurrentCell.RowIndex].Cells[this.col_sccomp.Name].Value;
            this.btnOK.Enabled = true;
            this.btnSearch.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Enter)
            {
                if (this.ActiveControl == this.btnCancel || this.ActiveControl == this.btnSearch)
                    return false;

                this.btnOK.PerformClick();
                return true;
            }

            if(keyData == Keys.Escape)
            {
                this.btnCancel.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;

            if(this.sccomp.Count > 0)
            {
                DialogInlineSearch s = new DialogInlineSearch(e.KeyChar.ToString());
                Point p = this.btnOK.PointToScreen(Point.Empty);

                s.SetBounds(p.X - 13, p.Y - 18, s.Width, s.Height);
                if (s.ShowDialog() == DialogResult.OK)
                {
                    var selected_row = this.dgv.Rows.Cast<DataGridViewRow>().Where(r => ((string)r.Cells[this.col_compnam.Name].Value).StartsWith(s.keyword)).FirstOrDefault();

                    if (selected_row != null)
                        selected_row.Cells[this.col_compnam.Name].Selected = true;
                }
            }
            
            //base.OnKeyPress(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.sccomp.Count > 0)
            {
                DialogInlineSearch s = new DialogInlineSearch(string.Empty);
                Point p = this.btnOK.PointToScreen(Point.Empty);

                s.SetBounds(p.X - 13, p.Y - 18, s.Width, s.Height);
                if (s.ShowDialog() == DialogResult.OK)
                {
                    var selected_row = this.dgv.Rows.Cast<DataGridViewRow>().Where(r => ((string)r.Cells[this.col_compnam.Name].Value).StartsWith(s.keyword)).FirstOrDefault();

                    if (selected_row != null)
                        selected_row.Cells[this.col_compnam.Name].Selected = true;
                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnOK.PerformClick();
        }
    }
}
