namespace TextPadEditor
{
    partial class FindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.labelFindWhat = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.buttonFindCancel = new System.Windows.Forms.Button();
            this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBoxDirectionFind = new System.Windows.Forms.GroupBox();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.groupBoxDirectionFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFindWhat
            // 
            this.labelFindWhat.AutoSize = true;
            this.labelFindWhat.Location = new System.Drawing.Point(42, 23);
            this.labelFindWhat.Name = "labelFindWhat";
            this.labelFindWhat.Size = new System.Drawing.Size(59, 13);
            this.labelFindWhat.TabIndex = 0;
            this.labelFindWhat.Text = "Find What:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(107, 20);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(234, 20);
            this.textBoxFind.TabIndex = 1;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.Location = new System.Drawing.Point(347, 18);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(111, 23);
            this.buttonFindNext.TabIndex = 2;
            this.buttonFindNext.Text = "Find Next";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            // 
            // buttonFindCancel
            // 
            this.buttonFindCancel.Location = new System.Drawing.Point(347, 47);
            this.buttonFindCancel.Name = "buttonFindCancel";
            this.buttonFindCancel.Size = new System.Drawing.Size(111, 23);
            this.buttonFindCancel.TabIndex = 3;
            this.buttonFindCancel.Text = "Cancel";
            this.buttonFindCancel.UseVisualStyleBackColor = true;
            this.buttonFindCancel.Click += new System.EventHandler(this.buttonFindCancel_Click);
            // 
            // checkBoxMatchCase
            // 
            this.checkBoxMatchCase.AutoSize = true;
            this.checkBoxMatchCase.Location = new System.Drawing.Point(12, 78);
            this.checkBoxMatchCase.Name = "checkBoxMatchCase";
            this.checkBoxMatchCase.Size = new System.Drawing.Size(83, 17);
            this.checkBoxMatchCase.TabIndex = 4;
            this.checkBoxMatchCase.Text = "Match Case";
            this.checkBoxMatchCase.UseVisualStyleBackColor = true;
            // 
            // groupBoxDirectionFind
            // 
            this.groupBoxDirectionFind.Controls.Add(this.radioButtonUp);
            this.groupBoxDirectionFind.Controls.Add(this.radioButtonDown);
            this.groupBoxDirectionFind.Location = new System.Drawing.Point(107, 47);
            this.groupBoxDirectionFind.Name = "groupBoxDirectionFind";
            this.groupBoxDirectionFind.Size = new System.Drawing.Size(234, 58);
            this.groupBoxDirectionFind.TabIndex = 5;
            this.groupBoxDirectionFind.TabStop = false;
            this.groupBoxDirectionFind.Text = "Direction";
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(147, 19);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonUp.TabIndex = 7;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Up";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(57, 19);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDown.TabIndex = 6;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "Down";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 117);
            this.Controls.Add(this.groupBoxDirectionFind);
            this.Controls.Add(this.checkBoxMatchCase);
            this.Controls.Add(this.buttonFindCancel);
            this.Controls.Add(this.buttonFindNext);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.labelFindWhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.Opacity = 0.9D;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.groupBoxDirectionFind.ResumeLayout(false);
            this.groupBoxDirectionFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindWhat;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button buttonFindCancel;
        private System.Windows.Forms.CheckBox checkBoxMatchCase;
        private System.Windows.Forms.GroupBox groupBoxDirectionFind;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.RadioButton radioButtonDown;
    }
}