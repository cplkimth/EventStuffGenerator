
namespace Example
{
    partial class Form1
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
            this.uscSearch = new Example.Controls.SearchControl();
            this.SuspendLayout();
            // 
            // uscSearch
            // 
            this.uscSearch.Location = new System.Drawing.Point(12, 12);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(519, 36);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.Searched += new System.EventHandler<Example.Controls.SearchControl.SearchedEventArgs>(this.uscSearch_Searched);
            this.uscSearch.Searching += new System.EventHandler<Example.Controls.SearchControl.SearchingEventArgs>(this.uscSearch_Searching);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 61);
            this.Controls.Add(this.uscSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SearchControl uscSearch;
    }
}

