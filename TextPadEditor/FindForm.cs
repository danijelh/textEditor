using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextPadEditor
{
    public partial class FindForm : Form
    {
        public FindForm(string tekst)
        {
            InitializeComponent();
            tekstZP = tekst;
        }

        string tekstZP;

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFind.Text.Length > 0)
                buttonFindNext.Enabled = true;
            
            else
                buttonFindNext.Enabled = false;
            
        }

        private void buttonFindCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFindNext_Click(object sender, EventArgs e)
        {
            if (((FormtextPadEditor)this.Owner).pronadiText(textBoxFind.Text, radioButtonDown.Checked, checkBoxMatchCase.Checked) == false)
            {
                MessageBox.Show("Ne postoji: \'" + textBoxFind.Text + "\'", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                this.Close();
            }
        }


        private void FindForm_Load(object sender, EventArgs e)
        {
            if (tekstZP != " ")
            {
                textBoxFind.Text = tekstZP;
                buttonFindNext.PerformClick();
            }
            
        }


    }
}
