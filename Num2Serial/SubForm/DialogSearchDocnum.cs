using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warranty.SubForm
{
    public partial class DialogSearchDocnum : Form
    {
        public string docnum = string.Empty;

        public DialogSearchDocnum()
        {
            InitializeComponent();
        }

        private void DialogSearchDocnum_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtDocnum;
        }

        private void txtDocnum_TextChanged(object sender, EventArgs e)
        {
            this.docnum = ((TextBox)sender).Text;

            this.btnOK.Enabled = this.docnum.Trim().Length == 0 ? false : true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Enter)
            {
                if (this.txtDocnum.Focused)
                {
                    this.btnOK.PerformClick();
                    return true;
                }
            }

            if(keyData == Keys.Escape)
            {
                this.btnCancel.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
