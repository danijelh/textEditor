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
        public rtfForm()
        {
            InitializeComponent();
        }

        bool otvoreno = false;

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



        
    }
}