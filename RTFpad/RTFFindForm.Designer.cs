namespace RTFpad
{
    partial class RTFFindForm
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
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFindWhat = new System.Windows.Forms.Label();
            this.groupBoxDirectionFind = new System.Windows.Forms.GroupBox();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxDirectionFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(79, 23);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(253, 20);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            this.textBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFind_KeyDown);
            // 
            // labelFindWhat
            // 
            this.labelFindWhat.AutoSize = true;
            this.labelFindWhat.Location = new System.Drawing.Point(12, 26);
            this.labelFindWhat.Name = "labelFindWhat";
            this.labelFindWhat.Size = new System.Drawing.Size(56, 13);
            this.labelFindWhat.TabIndex = 1;
            this.labelFindWhat.Text = "Find What";
            // 
            // groupBoxDirectionFind
            // 
            this.groupBoxDirectionFind.Controls.Add(this.radioButtonUp);
            this.groupBoxDirectionFind.Controls.Add(this.radioButtonDown);
            this.groupBoxDirectionFind.Location = new System.Drawing.Point(101, 49);
            this.groupBoxDirectionFind.Name = "groupBoxDirectionFind";
            this.groupBoxDirectionFind.Size = new System.Drawing.Size(231, 76);
            this.groupBoxDirectionFind.TabIndex = 2;
            this.groupBoxDirectionFind.TabStop = false;
            this.groupBoxDirectionFind.Text = "Direction";
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(112, 33);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonUp.TabIndex = 3;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Up";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(18, 33);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDown.TabIndex = 3;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "Down";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatchCase
            // 
            this.checkBoxMatchCase.AutoSize = true;
            this.checkBoxMatchCase.Location = new System.Drawing.Point(12, 73);
            this.checkBoxMatchCase.Name = "checkBoxMatchCase";
            this.checkBoxMatchCase.Size = new System.Drawing.Size(83, 17);
            this.checkBoxMatchCase.TabIndex = 3;
            this.checkBoxMatchCase.Text = "Match Case";
            this.checkBoxMatchCase.UseVisualStyleBackColor = true;
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.Location = new System.Drawing.Point(338, 26);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(93, 23);
            this.buttonFindNext.TabIndex = 4;
            this.buttonFindNext.Text = "Find Next";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(338, 55);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // RTFFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 136);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFindNext);
            this.Controls.Add(this.checkBoxMatchCase);
            this.Controls.Add(this.groupBoxDirectionFind);
            this.Controls.Add(this.labelFindWhat);
            this.Controls.Add(this.textBoxFind);
            this.Name = "RTFFindForm";
            this.Text = "RTFFindForm";
            this.Load += new System.EventHandler(this.RTFFindForm_Load);
            this.groupBoxDirectionFind.ResumeLayout(false);
            this.groupBoxDirectionFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFindWhat;
        private System.Windows.Forms.GroupBox groupBoxDirectionFind;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.CheckBox checkBoxMatchCase;
        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button buttonCancel;
    }
}