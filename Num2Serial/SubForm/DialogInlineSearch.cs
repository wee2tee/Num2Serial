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
    public partial class DialogInlineSearch : Form
    {
        public string keyword = string.Empty;

        public DialogInlineSearch(string keyword)
        {
            InitializeComponent();
            this.txtKeyword.Text = keyword;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            this.keyword = ((TextBox)sender).Text;

            this.btnOK.Enabled = this.keyword.Trim().Length == 0 ? false : true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Enter)
            {
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
    }
}
