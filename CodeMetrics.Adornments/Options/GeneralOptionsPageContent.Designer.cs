﻿namespace CodeMetrics.Options
{
    partial class GeneralOptionsPageContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.thresholdTextbox = new System.Windows.Forms.TextBox();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.minimumColorLabel = new System.Windows.Forms.Label();
            this.minimumColorSelection = new CodeMetrics.Options.ColorSelection();
            this.maximumColorLabel = new System.Windows.Forms.Label();
            this.maximumColorSelection = new CodeMetrics.Options.ColorSelection();
            this.SuspendLayout();
            // 
            // thresholdTextbox
            // 
            this.thresholdTextbox.Location = new System.Drawing.Point(164, 31);
            this.thresholdTextbox.Name = "thresholdTextbox";
            this.thresholdTextbox.Size = new System.Drawing.Size(48, 20);
            this.thresholdTextbox.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.thresholdTextbox, "Define minum number of fomplexity to show.\r\nHas to be a number higher or equals t" +
        "han 1.");
            this.thresholdTextbox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(44, 34);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(104, 13);
            this.thresholdLabel.TabIndex = 1;
            this.thresholdLabel.Text = "Minimum Complexity:";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minimumColorLabel
            // 
            this.minimumColorLabel.AutoSize = true;
            this.minimumColorLabel.Location = new System.Drawing.Point(18, 64);
            this.minimumColorLabel.Name = "minimumColorLabel";
            this.minimumColorLabel.Size = new System.Drawing.Size(130, 13);
            this.minimumColorLabel.TabIndex = 2;
            this.minimumColorLabel.Text = "Minimum complexity Color:";
            this.minimumColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minimumColorSelection
            // 
            this.minimumColorSelection.Location = new System.Drawing.Point(164, 58);
            this.minimumColorSelection.Name = "minimumColorSelection";
            this.minimumColorSelection.Size = new System.Drawing.Size(63, 24);
            this.minimumColorSelection.TabIndex = 3;
            this.minimumColorSelection.SelectedColorChanged += new System.EventHandler<CodeMetrics.Options.ColorChangedEventArgs>(this.MinimumColorSelection_SelectedColorChanged);
            // 
            // maximumColorLabel
            // 
            this.maximumColorLabel.AutoSize = true;
            this.maximumColorLabel.Location = new System.Drawing.Point(15, 93);
            this.maximumColorLabel.Name = "maximumColorLabel";
            this.maximumColorLabel.Size = new System.Drawing.Size(133, 13);
            this.maximumColorLabel.TabIndex = 4;
            this.maximumColorLabel.Text = "Maximum complexity Color:";
            this.maximumColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maximumColorSelection
            // 
            this.maximumColorSelection.Location = new System.Drawing.Point(164, 88);
            this.maximumColorSelection.Name = "maximumColorSelection";
            this.maximumColorSelection.Size = new System.Drawing.Size(63, 24);
            this.maximumColorSelection.TabIndex = 5;
            this.maximumColorSelection.SelectedColorChanged += new System.EventHandler<CodeMetrics.Options.ColorChangedEventArgs>(this.MaximumColorSelection_SelectedColorChanged);
            // 
            // GeneralOptionsPageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maximumColorSelection);
            this.Controls.Add(this.maximumColorLabel);
            this.Controls.Add(this.minimumColorSelection);
            this.Controls.Add(this.minimumColorLabel);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.thresholdTextbox);
            this.Name = "GeneralOptionsPageContent";
            this.Size = new System.Drawing.Size(688, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox thresholdTextbox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.Label minimumColorLabel;
        private ColorSelection minimumColorSelection;
        private System.Windows.Forms.Label maximumColorLabel;
        private ColorSelection maximumColorSelection;
    }
}