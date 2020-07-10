using System.ComponentModel;

namespace EventStuffGenerator.Win.Controls
{
    partial class TemplateSelectionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.cbbTemplate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbTemplate
            // 
            this.cbbTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTemplate.FormattingEnabled = true;
            this.cbbTemplate.Location = new System.Drawing.Point(0, 0);
            this.cbbTemplate.Name = "cbbTemplate";
            this.cbbTemplate.Size = new System.Drawing.Size(150, 23);
            this.cbbTemplate.TabIndex = 0;
            // 
            // TemplateSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbTemplate);
            this.Name = "TemplateSelectionControl";
            this.Size = new System.Drawing.Size(150, 26);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbbTemplate;
        #endregion
    }
}