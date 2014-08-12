using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTFpad
{
    public partial class rtfForm : Form
    {
        
        private FontFamily[] popisFontova;
        public rtfForm()
        {
            //Za fontove
            InitializeComponent();
            this.popisFontova = FontFamily.Families;

            for (int i = 0; i < this.popisFontova.Length; i++)
                this.CBoxFont.Items.Add(this.popisFontova[i].Name);

            //Za velicinu fonta
            this.CBoxFont_SelectedIndexChanged(this, new EventArgs());

            //Za boje
            string[] popisBoja = System.Enum.GetNames(typeof(KnownColor));
            for (int i = 0; i < popisBoja.Length; i++)
            {
                Color boja = Color.FromKnownColor((KnownColor)System.Enum.Parse(typeof(KnownColor), popisBoja[i]));

                if (boja.IsSystemColor == false && boja.Name != Color.Transparent.Name)
                    this.buttonFontColor.DropDownItems.Add(popisBoja[i]);
            }


        }
        //varijable
        bool otvoreno = false;
        int oznacenaBoja;

        private void izbornikNew_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            otvoreno = false;
        }

        OpenFileDialog dialogOtvori = new OpenFileDialog();
        private void izbornikOtvori_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOtvori = new OpenFileDialog();
            dialogOtvori.Title = "Otvori";
            dialogOtvori.Filter = "Tekst Dokument(*.txt)|*.txt| Svi dokumenti(*.*)|*.*";
            dialogOtvori.DefaultExt = "rtf";
            if (dialogOtvori.ShowDialog() == DialogResult.OK)
                textBox.LoadFile(dialogOtvori.FileName, RichTextBoxStreamType.PlainText);

            otvoreno = true;

        }

        SaveFileDialog dialogSpremi = new SaveFileDialog();
        private void izbornikSaveAs_Click(object sender, EventArgs e)
        {
            
            dialogSpremi.Title = "Spremi kao";
            dialogSpremi.Filter = "Tekst Dokument(*.txt)|*.txt| Svi dokumenti(*.*)|*.*";
            dialogSpremi.DefaultExt = "rtf";

            if (dialogSpremi.ShowDialog() == DialogResult.OK)
                textBox.SaveFile(dialogSpremi.FileName, RichTextBoxStreamType.PlainText);

            otvoreno = true;
        }

        private void izbornikSave_Click(object sender, EventArgs e)
        {
            if (otvoreno == false)
                izbornikSaveAs.PerformClick();
            else
                textBox.SaveFile(dialogOtvori.FileName, RichTextBoxStreamType.PlainText);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            izbornikNew.PerformClick();
        }

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            izbornikOtvori.PerformClick();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            izbornikSaveAs.PerformClick();
        }

        private void izbornikExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.textBox.SelectionFont = new Font(this.popisFontova[this.CBoxFont.SelectedIndex], int.Parse(this.CBoxSize.SelectedItem.ToString()), this.textBox.Font.Style, this.textBox.Font.Unit);
            }
            catch
            {

            }
            finally 
            {
                this.textBox.Focus();
            }

        }

        private void textBox_SelectionChanged(object sender, EventArgs e)
        {
            this.CBoxSize.SelectedItem = Math.Round(this.textBox.SelectionFont.Size).ToString();
            try 
            {
                this.CBoxFont.SelectedItem = this.textBox.SelectionFont.FontFamily.Name;
            }
            catch 
            { 
            }
        }

        private void CBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.textBox.SelectionFont = new Font(this.textBox.SelectionFont.FontFamily, int.Parse(this.CBoxSize.SelectedItem.ToString()), this.textBox.Font.Style, this.textBox.Font.Unit);
            }
            catch 
            {
            }
            finally 
            {
                this.textBox.Focus();
            }
        }

        private void buttonFontColor_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.textBox.SelectionColor = Color.FromKnownColor((KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text));
            ((ToolStripMenuItem)this.buttonFontColor.DropDownItems[this.oznacenaBoja]).Checked = false;

            this.oznacenaBoja = this.buttonFontColor.DropDownItems.IndexOf((ToolStripMenuItem)e.ClickedItem);
            ((ToolStripMenuItem)e.ClickedItem).Checked = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int duljina=textBox.TextLength;
            statusLength.Text = "Lenght: " + duljina;
        }



        
    }
}