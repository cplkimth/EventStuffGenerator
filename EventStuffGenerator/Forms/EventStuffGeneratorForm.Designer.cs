using EventStuffGenerator.Controls;
using SnippetViewer=EventStuffGenerator.Controls.SnippetViewer;

namespace EventStuffGenerator.Forms
{
    partial class EventStuffGeneratorForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbcTab = new System.Windows.Forms.TabControl();
            this.uscInput = new EventStuffGenerator.Controls.InputControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uscInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbcTab);
            this.splitContainer1.Size = new System.Drawing.Size(987, 711);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbcTab
            // 
            this.tbcTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTab.Location = new System.Drawing.Point(0, 0);
            this.tbcTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcTab.Name = "tbcTab";
            this.tbcTab.SelectedIndex = 0;
            this.tbcTab.Size = new System.Drawing.Size(782, 711);
            this.tbcTab.TabIndex = 0;
            // 
            // uscInput
            // 
            this.uscInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscInput.Location = new System.Drawing.Point(0, 0);
            this.uscInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uscInput.Name = "uscInput";
            this.uscInput.Padding = new System.Windows.Forms.Padding(6);
            this.uscInput.Size = new System.Drawing.Size(200, 711);
            this.uscInput.TabIndex = 0;
            // 
            // EventStuffGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 711);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EventStuffGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "이벤트 코드 생성기";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private InputControl uscInput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tbcTab;
    }
}