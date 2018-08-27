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
    public partial class DialogSearchDate : Form
    {
        public DateTime? selected_date = null;

        public DialogSearchDate(DateTime? selected_date = null)
        {
            this.selected_date = selected_date.HasValue ? selected_date : DateTime.Now;
            InitializeComponent();
        }

        private void DialogSearchDate_Load(object sender, EventArgs e)
        {
            this.dateTime1.Value = this.selected_date.Value;
        }

        private void dateTime1_ValueChanged(object sender, EventArgs e)
        {
            this.selected_date = ((DateTimePicker)sender).Value.Date;

            this.btnOK.Enabled = this.selected_date.HasValue ? true : false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Enter)
            {
                //if (this.dateTime1.Focused)
                //{
                //    this.btnOK.PerformClick();
                //    return true;
                //}
            }

            if(keyData == Keys.Escape)
            {
                this.btnCancel.PerformClick();
                return true;
            }

            if(keyData == Keys.F6)
            {
                if (this.dateTime1.Focused)
                {
                    SendKeys.Send("{F4}");
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
