namespace TextPadEditor
{
    partial class FormtextPadEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormtextPadEditor));
            this.glavniIzbornik = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikNew = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikSave = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izbornikPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.izbornikExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.izbornikCut = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.izbornikFind = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.izbornikSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.izbornikDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikFont = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikColor = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dayNightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glavniIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniIzbornik
            // 
            this.glavniIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.glavniIzbornik.Location = new System.Drawing.Point(0, 0);
            this.glavniIzbornik.Name = "glavniIzbornik";
            this.glavniIzbornik.Size = new System.Drawing.Size(784, 24);
            this.glavniIzbornik.TabIndex = 0;
            this.glavniIzbornik.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikNew,
            this.izbornikOpen,
            this.izbornikSave,
            this.izbornikSaveAs,
            this.toolStripSeparator1,
            this.izbornikPageSetup,
            this.izbornikPrint,
            this.toolStripSeparator2,
            this.izbornikExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // izbornikNew
            // 
            this.izbornikNew.Name = "izbornikNew";
            this.izbornikNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.izbornikNew.Size = new System.Drawing.Size(199, 22);
            this.izbornikNew.Text = "New";
            this.izbornikNew.Click += new System.EventHandler(this.izbornikNew_Click);
            // 
            // izbornikOpen
            // 
            this.izbornikOpen.Name = "izbornikOpen";
            this.izbornikOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.izbornikOpen.Size = new System.Drawing.Size(199, 22);
            this.izbornikOpen.Text = "Open";
            this.izbornikOpen.Click += new System.EventHandler(this.izbornikOpen_Click);
            // 
            // izbornikSave
            // 
            this.izbornikSave.Name = "izbornikSave";
            this.izbornikSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.izbornikSave.Size = new System.Drawing.Size(199, 22);
            this.izbornikSave.Text = "Save";
            this.izbornikSave.Click += new System.EventHandler(this.izbornikSave_Click);
            // 
            // izbornikSaveAs
            // 
            this.izbornikSaveAs.Name = "izbornikSaveAs";
            this.izbornikSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.izbornikSaveAs.Size = new System.Drawing.Size(199, 22);
            this.izbornikSaveAs.Text = "Save As";
            this.izbornikSaveAs.Click += new System.EventHandler(this.izbornikSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // izbornikPageSetup
            // 
            this.izbornikPageSetup.Name = "izbornikPageSetup";
            this.izbornikPageSetup.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.P)));
            this.izbornikPageSetup.Size = new System.Drawing.Size(199, 22);
            this.izbornikPageSetup.Text = "Page Setup";
            this.izbornikPageSetup.Click += new System.EventHandler(this.izbornikPageSetup_Click);
            // 
            // izbornikPrint
            // 
            this.izbornikPrint.Name = "izbornikPrint";
            this.izbornikPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.izbornikPrint.Size = new System.Drawing.Size(199, 22);
            this.izbornikPrint.Text = "Print";
            this.izbornikPrint.Click += new System.EventHandler(this.izbornikPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // izbornikExit
            // 
            this.izbornikExit.Name = "izbornikExit";
            this.izbornikExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.izbornikExit.Size = new System.Drawing.Size(199, 22);
            this.izbornikExit.Text = "Exit";
            this.izbornikExit.Click += new System.EventHandler(this.izbornikExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikUndo,
            this.izbornikRedo,
            this.toolStripSeparator3,
            this.izbornikCut,
            this.izbornikCopy,
            this.izbornikPaste,
            this.izbornikDelete,
            this.toolStripSeparator4,
            this.izbornikFind,
            this.izbornikFindNext,
            this.izbornikReplace,
            this.izbornikGoTo,
            this.toolStripSeparator6,
            this.izbornikSelectAll,
            this.toolStripSeparator5,
            this.izbornikDateTime});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // izbornikUndo
            // 
            this.izbornikUndo.Name = "izbornikUndo";
            this.izbornikUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.izbornikUndo.Size = new System.Drawing.Size(175, 22);
            this.izbornikUndo.Text = "Undo";
            this.izbornikUndo.Click += new System.EventHandler(this.izbornikUndo_Click);
            // 
            // izbornikRedo
            // 
            this.izbornikRedo.Name = "izbornikRedo";
            this.izbornikRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.izbornikRedo.Size = new System.Drawing.Size(175, 22);
            this.izbornikRedo.Text = "Redo";
            this.izbornikRedo.Click += new System.EventHandler(this.izbornikRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // izbornikCut
            // 
            this.izbornikCut.Name = "izbornikCut";
            this.izbornikCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.izbornikCut.Size = new System.Drawing.Size(175, 22);
            this.izbornikCut.Text = "Cut";
            this.izbornikCut.Click += new System.EventHandler(this.izbornikCut_Click);
            // 
            // izbornikCopy
            // 
            this.izbornikCopy.Name = "izbornikCopy";
            this.izbornikCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.izbornikCopy.Size = new System.Drawing.Size(175, 22);
            this.izbornikCopy.Text = "Copy";
            this.izbornikCopy.Click += new System.EventHandler(this.izbornikCopy_Click);
            // 
            // izbornikPaste
            // 
            this.izbornikPaste.Name = "izbornikPaste";
            this.izbornikPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.izbornikPaste.Size = new System.Drawing.Size(175, 22);
            this.izbornikPaste.Text = "Paste";
            this.izbornikPaste.Click += new System.EventHandler(this.izbornikPaste_Click);
            // 
            // izbornikDelete
            // 
            this.izbornikDelete.Name = "izbornikDelete";
            this.izbornikDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.izbornikDelete.Size = new System.Drawing.Size(175, 22);
            this.izbornikDelete.Text = "Delete";
            this.izbornikDelete.Click += new System.EventHandler(this.izbornikDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // izbornikFind
            // 
            this.izbornikFind.Name = "izbornikFind";
            this.izbornikFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.izbornikFind.Size = new System.Drawing.Size(175, 22);
            this.izbornikFind.Text = "Find";
            this.izbornikFind.Click += new System.EventHandler(this.izbornikFind_Click);
            // 
            // izbornikFindNext
            // 
            this.izbornikFindNext.Name = "izbornikFindNext";
            this.izbornikFindNext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.izbornikFindNext.Size = new System.Drawing.Size(175, 22);
            this.izbornikFindNext.Text = "Find Next";
            this.izbornikFindNext.Click += new System.EventHandler(this.izbornikFindNext_Click);
            // 
            // izbornikReplace
            // 
            this.izbornikReplace.Name = "izbornikReplace";
            this.izbornikReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.izbornikReplace.Size = new System.Drawing.Size(175, 22);
            this.izbornikReplace.Text = "Replace";
            // 
            // izbornikGoTo
            // 
            this.izbornikGoTo.Name = "izbornikGoTo";
            this.izbornikGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.izbornikGoTo.Size = new System.Drawing.Size(175, 22);
            this.izbornikGoTo.Text = "Go to";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(172, 6);
            // 
            // izbornikSelectAll
            // 
            this.izbornikSelectAll.Name = "izbornikSelectAll";
            this.izbornikSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.izbornikSelectAll.Size = new System.Drawing.Size(175, 22);
            this.izbornikSelectAll.Text = "Select All";
            this.izbornikSelectAll.Click += new System.EventHandler(this.izbornikSelectAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
            // 
            // izbornikDateTime
            // 
            this.izbornikDateTime.Name = "izbornikDateTime";
            this.izbornikDateTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.izbornikDateTime.Size = new System.Drawing.Size(175, 22);
            this.izbornikDateTime.Text = "Date/Time";
            this.izbornikDateTime.Click += new System.EventHandler(this.izbornikDateTime_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikWordWrap,
            this.izbornikFont,
            this.izbornikColor});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // izbornikWordWrap
            // 
            this.izbornikWordWrap.Checked = true;
            this.izbornikWordWrap.CheckOnClick = true;
            this.izbornikWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.izbornikWordWrap.Name = "izbornikWordWrap";
            this.izbornikWordWrap.Size = new System.Drawing.Size(152, 22);
            this.izbornikWordWrap.Text = "Word Wrap";
            this.izbornikWordWrap.Click += new System.EventHandler(this.izbornikWordWrap_Click);
            // 
            // izbornikFont
            // 
            this.izbornikFont.Name = "izbornikFont";
            this.izbornikFont.Size = new System.Drawing.Size(152, 22);
            this.izbornikFont.Text = "Font";
            this.izbornikFont.Click += new System.EventHandler(this.izbornikFont_Click);
            // 
            // izbornikColor
            // 
            this.izbornikColor.Name = "izbornikColor";
            this.izbornikColor.Size = new System.Drawing.Size(152, 22);
            this.izbornikColor.Text = "Color";
            this.izbornikColor.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayNightToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(784, 538);
            this.textBox.TabIndex = 1;
            // 
            // dayNightToolStripMenuItem
            // 
            this.dayNightToolStripMenuItem.Name = "dayNightToolStripMenuItem";
            this.dayNightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dayNightToolStripMenuItem.Text = "Day/Night";
            // 
            // FormtextPadEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.glavniIzbornik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.glavniIzbornik;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormtextPadEditor";
            this.Text = "TextPad";
            this.Load += new System.EventHandler(this.FormtextPadEditor_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormtextPadEditor_FormClosing);
            this.glavniIzbornik.ResumeLayout(false);
            this.glavniIzbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip glavniIzbornik;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbornikNew;
        private System.Windows.Forms.ToolStripMenuItem izbornikOpen;
        private System.Windows.Forms.ToolStripMenuItem izbornikSave;
        private System.Windows.Forms.ToolStripMenuItem izbornikSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izbornikPageSetup;
        private System.Windows.Forms.ToolStripMenuItem izbornikPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem izbornikExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbornikUndo;
        private System.Windows.Forms.ToolStripMenuItem izbornikRedo;
        private System.Windows.Forms.ToolStripMenuItem izbornikCut;
        private System.Windows.Forms.ToolStripMenuItem izbornikCopy;
        private System.Windows.Forms.ToolStripMenuItem izbornikPaste;
        private System.Windows.Forms.ToolStripMenuItem izbornikDelete;
        private System.Windows.Forms.ToolStripMenuItem izbornikFind;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem izbornikFindNext;
        private System.Windows.Forms.ToolStripMenuItem izbornikReplace;
        private System.Windows.Forms.ToolStripMenuItem izbornikGoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem izbornikSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem izbornikDateTime;
        private System.Windows.Forms.ToolStripMenuItem izbornikWordWrap;
        private System.Windows.Forms.ToolStripMenuItem izbornikFont;
        private System.Windows.Forms.ToolStripMenuItem izbornikColor;
        private System.Windows.Forms.ToolStripMenuItem dayNightToolStripMenuItem;
    }
}

