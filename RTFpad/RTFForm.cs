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

        #region varijable

        bool otvoreno = false;
        int oznacenaBoja;
        private int pointer = 0;
        string tekst = " ";
        bool statusBar = true;
        bool toolStrip = true;
        bool daynight = false;
        bool searchbar = true;

        #endregion


        private void rtfForm_Load(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font.FontFamily, 12);
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

        }


        #region File..New-Exit

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

        #endregion



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

        //Duljina znakova-Linija

        


        #region Print

        private void izbornikPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pDialog = new PrintDialog();
            pDialog.ShowDialog();
        }

        private void izbornikPageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog1 = new PageSetupDialog();
            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog1.EnableMetric = false;
            pageSetupDialog1.ShowDialog();
        }

        private void izbornikPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppDialog = new PrintPreviewDialog();
            ppDialog.ShowDialog();
        }

        #endregion

        //Cut, copy, select..
        #region Cut, copy, undo, select itd

        //izbornik
        private void izbornikUndo_Click(object sender, EventArgs e)
        {
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

        private void izbornikPasteSpecial_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void izbornikClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void izbornikSelectAll_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        //Gumbiæi
        private void buttonCut_Click(object sender, EventArgs e)
        {
            izbornikCut.PerformClick();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            izbornikCopy.PerformClick();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            izbornikPaste.PerformClick();
        }

        #endregion



        private void izbornikFind_Click(object sender, EventArgs e)
        {
            tekst = " ";
            RTFFindForm dialogFind = new RTFFindForm(tekst);
            dialogFind.Owner = this;
            dialogFind.ShowDialog();
        }

        private void izbornikFindNext_Click(object sender, EventArgs e)
        {
            tekst = textBox.SelectedText;
            RTFFindForm dialogFind = new RTFFindForm(tekst);
            dialogFind.Owner = this;
            dialogFind.ShowDialog();
        }

        private void textBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string tekst = textBoxFind.Text;
                    int nStart = textBox.Text.IndexOf(tekst, pointer, StringComparison.OrdinalIgnoreCase);
                    int nLength = tekst.Length;

                    textBox.Select(nStart, nLength);
                    textBox.Focus();
                    pointer = nStart + nLength;
                }
                catch (Exception b)
                {
                    b.ToString();
                    MessageBox.Show("Kraj dokumenta");
                    pointer = 0;
                }
            }
        }


        #region View

        private void izbornikStatusBar_Click(object sender, EventArgs e)
        {
            if (statusBar == true)
            {
                statusStripRTF.Hide();
                statusBar = false;
            }
            else 
            {
                statusStripRTF.Show();
                statusBar = true;
            }
        }

        private void izbornikToolbar_Click(object sender, EventArgs e)
        {
            if (toolStrip == true)
            {
                toolStripMenu.Hide();
                toolStrip = false;
            }
            else 
            {
                toolStripMenu.Show();
                toolStrip = true;
            }
        }

        private void izbornikDayNight_Click(object sender, EventArgs e)
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

        private void izbornikSearchBar_Click(object sender, EventArgs e)
        {

            if (searchbar)
            {
                searchbar = false;
                toolStripMenu2.Hide();
            }
            else
            {
                searchbar = true;
                toolStripMenu2.Show();
            }

        }

        #endregion

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.AppendText(DateTime.Now.ToString());
        }

        private void izbornikFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = font.Font;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
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

        #region Poravnanje


        private void izbornikLeft_Click(object sender, EventArgs e)
        {
            izbornikLeft.PerformClick();
        }

        private void izbornikCenter_Click(object sender, EventArgs e)
        {
            izbornikCenter.PerformClick();
        }

        private void izbornikRight_Click(object sender, EventArgs e)
        {
            izbornikRight.PerformClick();
        }

        private void izbornikLeft_Click_1(object sender, EventArgs e)
        {
            textBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void izbornikCenter_Click_1(object sender, EventArgs e)
        {
            textBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void izbornikRight_Click_1(object sender, EventArgs e)
        {
            textBox.SelectionAlignment = HorizontalAlignment.Right;
        }


        #endregion

        #region Uvlacenje

        private void izbornikPovecajI_Click(object sender, EventArgs e)
        {
            textBox.SelectionIndent = 8 + textBox.SelectionIndent;
            textBox.SelectionHangingIndent = 3;
            textBox.SelectionRightIndent = 12;
        }

        private void izbornikSmanjiI_Click(object sender, EventArgs e)
        {
            textBox.SelectionIndent = textBox.SelectionIndent - 8;
            textBox.SelectionHangingIndent = 3;
            textBox.SelectionRightIndent = 12;
        }

        private void buttonPovecajI_Click(object sender, EventArgs e)
        {
            izbornikPovecajI.PerformClick();
        }

        private void buttonSmanjiI_Click(object sender, EventArgs e)
        {
            izbornikSmanjiI.PerformClick();
        }

        #endregion

        #region Bold, italic, underlined

        private void buttonBold_Click(object sender, EventArgs e)
        {

            try
            {
                Font fontOfSelectedText = textBox.SelectionFont;
                FontStyle styleApplied = FontStyle.Bold;
                Font FontToApply = textBox.SelectionFont;

                if (textBox.SelectionFont.Bold == true)
                {
                    FontToApply = new Font(new FontFamily(CBoxFont.Text), float.Parse(CBoxSize.Text), textBox.SelectionFont.Style & ~styleApplied);
                }
                else
                {
                    FontToApply = new Font(new FontFamily(CBoxFont.Text), float.Parse(CBoxSize.Text), textBox.SelectionFont.Style | styleApplied);
                }

                textBox.SelectionFont = FontToApply;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {

            try
            {
                Font fontOfSelectedText = textBox.SelectionFont;
                FontStyle styleApplied = FontStyle.Italic;
                Font FontToApply = textBox.SelectionFont;

                if (textBox.SelectionFont.Bold == true)
                {
                    FontToApply = new Font(new FontFamily(CBoxFont.Text), float.Parse(CBoxSize.Text), textBox.SelectionFont.Style & ~styleApplied);
                }
                else
                {
                    FontToApply = new Font(new FontFamily(CBoxFont.Text), float.Parse(CBoxSize.Text), textBox.SelectionFont.Style | styleApplied);
                }

                textBox.SelectionFont = FontToApply;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonPodcrtaj_Click(object sender, EventArgs e)
        {
            try
            {
                Font fontOfSelectedText = textBox.SelectionFont;
                FontStyle styleApplied = FontStyle.Underline;
                Font FontToApply = textBox.SelectionFont;

                if (textBox.SelectionFont.Bold == true)
                {
                    FontToApply = new Font(new FontFamily(CBoxFont.Text), float.Parse(CBoxSize.Text), textBox.SelectionFont.Style & ~styleApplied);
                }
                else
                {
                    FontToApply = new Font(new FontFamily(CBoxFont.Text), float.Parse(CBoxSize.Text), textBox.SelectionFont.Style | styleApplied);
                }

                textBox.SelectionFont = FontToApply;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        

        

        private void textBoxFind_Enter(object sender, EventArgs e)
        {
            if (textBoxFind.Text == "Search")
            {
                textBoxFind.Clear();
            }
        }

        private void textBoxFind_Leave(object sender, EventArgs e)
        {

            if (textBoxFind.Text == "")
            {
                textBoxFind.Text = "Search";
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
            int duljina=textBox.TextLength;
            statusLength.Text = "Duljina: " + duljina;


            int brojLinije = textBox.GetLineFromCharIndex(textBox.TextLength) + 1;
            statusLinija.Text = "Linija: " + brojLinije;
            
        }

        


    }
}