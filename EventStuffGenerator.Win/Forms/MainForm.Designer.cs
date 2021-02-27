using EventStuffGenerator.Win.Controls;

namespace EventStuffGenerator.Win.Forms
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uscTemplateSelection = new EventStuffGenerator.Win.Controls.TemplateSelectionControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbArgumentText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbEventName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbGenerated = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEbnf = new System.Windows.Forms.Button();
            this.chbCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.tbcContainer = new System.Windows.Forms.TabControl();
            this.tbpGenerate = new System.Windows.Forms.TabPage();
            this.tbpCode = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tbcContainer.SuspendLayout();
            this.tbpGenerate.SuspendLayout();
            this.tbpCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uscTemplateSelection);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "템플릿";
            // 
            // uscTemplateSelection
            // 
            this.uscTemplateSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTemplateSelection.Location = new System.Drawing.Point(3, 21);
            this.uscTemplateSelection.Name = "uscTemplateSelection";
            this.uscTemplateSelection.Size = new System.Drawing.Size(420, 30);
            this.uscTemplateSelection.TabIndex = 0;
            this.uscTemplateSelection.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbArgumentText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이벤트 매개변수";
            // 
            // txbArgumentText
            // 
            this.txbArgumentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbArgumentText.Location = new System.Drawing.Point(3, 21);
            this.txbArgumentText.Multiline = true;
            this.txbArgumentText.Name = "txbArgumentText";
            this.txbArgumentText.Size = new System.Drawing.Size(420, 138);
            this.txbArgumentText.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbEventName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 51);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "이벤트 이름";
            // 
            // txbEventName
            // 
            this.txbEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbEventName.Location = new System.Drawing.Point(3, 21);
            this.txbEventName.Name = "txbEventName";
            this.txbEventName.Size = new System.Drawing.Size(420, 25);
            this.txbEventName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 324);
            this.panel1.TabIndex = 6;
            // 
            // txbGenerated
            // 
            this.txbGenerated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbGenerated.Location = new System.Drawing.Point(3, 3);
            this.txbGenerated.Multiline = true;
            this.txbGenerated.Name = "txbGenerated";
            this.txbGenerated.ReadOnly = true;
            this.txbGenerated.Size = new System.Drawing.Size(426, 324);
            this.txbGenerated.TabIndex = 0;
            this.txbGenerated.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chbCopyToClipboard);
            this.groupBox5.Controls.Add(this.btnEbnf);
            this.groupBox5.Controls.Add(this.btnGenerate);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(426, 57);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "실행";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(345, 24);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEbnf
            // 
            this.btnEbnf.Location = new System.Drawing.Point(6, 24);
            this.btnEbnf.Name = "btnEbnf";
            this.btnEbnf.Size = new System.Drawing.Size(75, 23);
            this.btnEbnf.TabIndex = 1;
            this.btnEbnf.TabStop = false;
            this.btnEbnf.Text = "&EBNF";
            this.btnEbnf.UseVisualStyleBackColor = true;
            this.btnEbnf.Click += new System.EventHandler(this.btnEbnf_Click);
            // 
            // chbCopyToClipboard
            // 
            this.chbCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCopyToClipboard.AutoSize = true;
            this.chbCopyToClipboard.Checked = true;
            this.chbCopyToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCopyToClipboard.Location = new System.Drawing.Point(186, 27);
            this.chbCopyToClipboard.Name = "chbCopyToClipboard";
            this.chbCopyToClipboard.Size = new System.Drawing.Size(152, 19);
            this.chbCopyToClipboard.TabIndex = 2;
            this.chbCopyToClipboard.TabStop = false;
            this.chbCopyToClipboard.Text = "Copy To Clipboard";
            this.chbCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // tbcContainer
            // 
            this.tbcContainer.Controls.Add(this.tbpGenerate);
            this.tbcContainer.Controls.Add(this.tbpCode);
            this.tbcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcContainer.Location = new System.Drawing.Point(5, 5);
            this.tbcContainer.Name = "tbcContainer";
            this.tbcContainer.SelectedIndex = 0;
            this.tbcContainer.Size = new System.Drawing.Size(440, 359);
            this.tbcContainer.TabIndex = 1;
            // 
            // tbpGenerate
            // 
            this.tbpGenerate.Controls.Add(this.panel1);
            this.tbpGenerate.Location = new System.Drawing.Point(4, 25);
            this.tbpGenerate.Name = "tbpGenerate";
            this.tbpGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGenerate.Size = new System.Drawing.Size(432, 330);
            this.tbpGenerate.TabIndex = 0;
            this.tbpGenerate.Text = "생성";
            this.tbpGenerate.UseVisualStyleBackColor = true;
            // 
            // tbpCode
            // 
            this.tbpCode.Controls.Add(this.txbGenerated);
            this.tbpCode.Location = new System.Drawing.Point(4, 25);
            this.tbpCode.Name = "tbpCode";
            this.tbpCode.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCode.Size = new System.Drawing.Size(432, 330);
            this.tbpCode.TabIndex = 1;
            this.tbpCode.Text = "코드";
            this.tbpCode.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 369);
            this.Controls.Add(this.tbcContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "이벤트 코드 생성기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tbcContainer.ResumeLayout(false);
            this.tbpGenerate.ResumeLayout(false);
            this.tbpCode.ResumeLayout(false);
            this.tbpCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TemplateSelectionControl uscTemplateSelection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbArgumentText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbEventName;
        private System.Windows.Forms.TextBox txbGenerated;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chbCopyToClipboard;
        private System.Windows.Forms.Button btnEbnf;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabControl tbcContainer;
        private System.Windows.Forms.TabPage tbpGenerate;
        private System.Windows.Forms.TabPage tbpCode;
    }
}

