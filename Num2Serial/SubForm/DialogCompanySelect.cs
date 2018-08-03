using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Num2Serial.Helper;

namespace Num2Serial.SubForm
{
    public partial class DialogCompanySelect : Form
    {
        private MainForm main_form;
        private BindingList<SccompVM> sccomp;
        public Sccomp selected_comp;

        public DialogCompanySelect(MainForm main_form)
        {
            this.main_form = main_form;
            InitializeComponent();
        }

        private void DialogCompanySelect_Load(object sender, EventArgs e)
        {
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Misc.MAIN_BG;
            this.dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Misc.MAIN_BG;

            this.sccomp = new BindingList<SccompVM>(DbfTable.Sccomp(this.main_form.secure_path).ToViewModel());
            this.dgv.DataSource = this.sccomp;
        }

        private void dgv_CurrentCellChanged(object sender, EventArgs e)
        {
            if(((DataGridView)sender).CurrentCell == null)
            {
                this.selected_comp = null;
                this.btnOK.Enabled = false;
                return;
            }

            this.selected_comp = (Sccomp)((DataGridView)sender).Rows[((DataGridView)sender).CurrentCell.RowIndex].Cells[this.col_sccomp.Name].Value;
            this.btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
