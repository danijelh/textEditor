using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace TextPadEditor
{
    public partial class FormtextPadEditor : Form
    {
        public FormtextPadEditor()
        {
            InitializeComponent();
        }

        string tekst=" ";
        bool otvoreno = false;
        bool daynight = false;
        private int pointer = 0;

        private void izbornikNew_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            otvoreno = false;
        }

        OpenFileDialog dialogOtvori = new OpenFileDialog();
        private void izbornikOpen_Click(object sender, EventArgs e)
        {
            dialogOtvori.Title = "Otvori";
            dialogOtvori.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialogOtvori.FilterIndex = 1;
            dialogOtvori.DefaultExt = "txt";

            if (dialogOtvori.ShowDialog() == DialogResult.OK)
            {
                StreamReader sReader = new StreamReader(dialogOtvori.FileName);
                textBox.Text = sReader.ReadToEnd();

                sReader.Close();
                otvoreno = true;
            }
        }

        private void izbornikSave_Click(object sender, EventArgs e)
        {
            if (otvoreno == false)
                izbornikSaveAs.PerformClick();
            else
            {
                StreamWriter sWriter = new StreamWriter(dialogOtvori.FileName);
                sWriter.WriteLine(textBox.Text);

                sWriter.Close();
            }

        }

        SaveFileDialog dialogSpremi = new SaveFileDialog();
        private void izbornikSaveAs_Click(object sender, EventArgs e)
        {
            dialogSpremi.Title = "Spremi";
            dialogSpremi.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialogSpremi.FilterIndex = 1;
            dialogSpremi.DefaultExt = "txt";

            if (dialogSpremi.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sWriter = new StreamWriter(dialogSpremi.FileName);
                sWriter.WriteLine(textBox.Text);

                sWriter.Close();
            }
        }

        private void izbornikPageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetup = new PageSetupDialog();
            pageSetup.ShowDialog();
            
            
        }

        private void izbornikPrint_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();

            if (print.ShowDialog() == DialogResult.OK)
            {
                print.ShowDialog();
            }
        }

        private void izbornikExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izbornikUndo_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void izbornikRedo_Click(object sender, EventArgs e)
        {
            // ?
            textBox.Undo();
        }

        private void izbornikCut_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void izbornikCopy_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void izbornikPaste_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void izbornikDelete_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = "";
        }

        private void izbornikFind_Click(object sender, EventArgs e)
        {
            tekst = " ";
            FindForm dialogFind = new FindForm(tekst);
            dialogFind.Owner = this;
            dialogFind.ShowDialog();
        }

        protected internal bool pronadiText(string textZaPronaci, bool pretrazivanjePremaDolje, bool pazitiNaCase)
        {

            try
            {


                if (pazitiNaCase)
                {

                    int nStart = textBox.Text.IndexOf(textZaPronaci, pointer);
                    int nLength = textZaPronaci.Length;

                    textBox.Select(nStart, nLength);
                    textBox.Focus();
                    pointer = nStart + nLength;
                    return true;

                }

                else
                {
                    int nStart = textBox.Text.IndexOf(textZaPronaci, pointer, StringComparison.OrdinalIgnoreCase);
                    int nLength = textZaPronaci.Length;

                    textBox.Select(nStart, nLength);
                    textBox.Focus();
                    pointer = nStart + nLength;
                    return true;
                }


            }
            catch (Exception e)
            {

                e.ToString();
                MessageBox.Show("Kraj dokumenta");
                pointer = 0;
                return false;

            }



            //if (textBox.Text.Contains(textZaPronaci))
            //{
            //    textBox.SelectionStart = textBox.Text.IndexOf(textZaPronaci);
            //    textBox.SelectionLength = textZaPronaci.Length;
            //    return true;
            //}
            //else if (tekst != " " && textBox.Text.Contains(textZaPronaci))
            //{

            //    // TODO: Višak koda..kako ispraviti?
            //    textBox.SelectionStart = textBox.Text.IndexOf(textZaPronaci) + textZaPronaci.Length + 1;
            //    textBox.SelectionLength = textZaPronaci.Length;
            //    return true;
            //}
            //else
            //    return false;
        }

        private void izbornikFindNext_Click(object sender, EventArgs e)
        {
            tekst = textBox.SelectedText;
            FindForm dialogFind = new FindForm(tekst);
            dialogFind.Owner = this;
            dialogFind.ShowDialog();
        }

        private void izbornikSelectAll_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void izbornikDateTime_Click(object sender, EventArgs e)
        {
            textBox.AppendText(DateTime.Now.ToString());
        }

        private void izbornikWordWrap_Click(object sender, EventArgs e)
        {
            if (textBox.WordWrap == true)
            {
                textBox.WordWrap = false;
                izbornikWordWrap.Checked = false;
            }
            else
            {
                textBox.WordWrap = true;
                izbornikWordWrap.Checked = true;
            }

        }

        private void izbornikFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                textBox.Font = fontDialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBox.ForeColor = colorDialog.Color;
        }

        private void FormtextPadEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (otvoreno == false && textBox.Text != "")
            {
                if (MessageBox.Show("Želite li spremiti dokument?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    izbornikSaveAs.PerformClick();
                }
                else
                {
 
                }
            }
        }

        private void FormtextPadEditor_Load(object sender, EventArgs e)
        {
            //izbornikWordWrap.Checked = true;
            textBox.Font = new Font(textBox.Font.FontFamily, 12);
        }

        private void dayNightToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (daynight == false)
            {
                textBox.BackColor = Color.Black;
                textBox.ForeColor = Color.White;
                daynight = true;
                izbornikDayNight.Checked = true;
            }
            else 
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                daynight = false;
                izbornikDayNight.Checked = false;
            }
        }

        private void aboutTextPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }


    }
}
