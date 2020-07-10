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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGenerate = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbEbnf = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uscTemplateSelection = new EventStuffGenerator.Win.Controls.TemplateSelectionControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txbArgumentText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbEventName = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGenerate,
            this.tsbHelp,
            this.tsbEbnf});
            this.toolStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(504, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGenerate
            // 
            this.tsbGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGenerate.Image = global::EventStuffGenerator.Win.Properties.Resources.Generate;
            this.tsbGenerate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerate.Name = "tsbGenerate";
            this.tsbGenerate.Size = new System.Drawing.Size(36, 36);
            this.tsbGenerate.Text = "&Generate";
            this.tsbGenerate.Click += new System.EventHandler(this.tsbGenerate_Click);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = global::EventStuffGenerator.Win.Properties.Resources.Help;
            this.tsbHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(36, 36);
            this.tsbHelp.Text = "Help";
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // tsbEbnf
            // 
            this.tsbEbnf.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEbnf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEbnf.Image = global::EventStuffGenerator.Win.Properties.Resources.Ebnf;
            this.tsbEbnf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEbnf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEbnf.Name = "tsbEbnf";
            this.tsbEbnf.Size = new System.Drawing.Size(36, 36);
            this.tsbEbnf.Text = "EBNF";
            this.tsbEbnf.Click += new System.EventHandler(this.tsbEbnf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uscTemplateSelection);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "템플릿";
            // 
            // uscTemplateSelection
            // 
            this.uscTemplateSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTemplateSelection.Location = new System.Drawing.Point(3, 21);
            this.uscTemplateSelection.Name = "uscTemplateSelection";
            this.uscTemplateSelection.Size = new System.Drawing.Size(498, 30);
            this.uscTemplateSelection.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.txbArgumentText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이벤트 매개변수";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(342, 96);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(0, 0);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txbArgumentText
            // 
            this.txbArgumentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbArgumentText.Location = new System.Drawing.Point(3, 21);
            this.txbArgumentText.Multiline = true;
            this.txbArgumentText.Name = "txbArgumentText";
            this.txbArgumentText.Size = new System.Drawing.Size(498, 219);
            this.txbArgumentText.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbEventName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(5, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 51);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "이벤트 이름";
            // 
            // txbEventName
            // 
            this.txbEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbEventName.Location = new System.Drawing.Point(3, 21);
            this.txbEventName.Name = "txbEventName";
            this.txbEventName.Size = new System.Drawing.Size(498, 25);
            this.txbEventName.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "이벤트 코드 생성기";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGenerate;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripButton tsbEbnf;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TemplateSelectionControl uscTemplateSelection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbArgumentText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbEventName;
        private System.Windows.Forms.Button btnGenerate;
    }
}

