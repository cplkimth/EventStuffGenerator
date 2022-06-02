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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uscTemplateSelection = new EventStuffGenerator.Win.Controls.TemplateSelectionControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbArgumentText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbEventName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chbCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.btnEbnf = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txbGenerated = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uscTemplateSelection);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(305, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template Name";
            // 
            // uscTemplateSelection
            // 
            this.uscTemplateSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTemplateSelection.Location = new System.Drawing.Point(3, 16);
            this.uscTemplateSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscTemplateSelection.Name = "uscTemplateSelection";
            this.uscTemplateSelection.Size = new System.Drawing.Size(299, 25);
            this.uscTemplateSelection.TabIndex = 0;
            this.uscTemplateSelection.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbArgumentText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(305, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Arguments";
            // 
            // txbArgumentText
            // 
            this.txbArgumentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbArgumentText.Location = new System.Drawing.Point(3, 16);
            this.txbArgumentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbArgumentText.Multiline = true;
            this.txbArgumentText.Name = "txbArgumentText";
            this.txbArgumentText.Size = new System.Drawing.Size(299, 252);
            this.txbArgumentText.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbEventName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 43);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(305, 41);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Name";
            // 
            // txbEventName
            // 
            this.txbEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbEventName.Location = new System.Drawing.Point(3, 16);
            this.txbEventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEventName.Name = "txbEventName";
            this.txbEventName.Size = new System.Drawing.Size(299, 21);
            this.txbEventName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 400);
            this.panel1.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chbCopyToClipboard);
            this.groupBox5.Controls.Add(this.btnEbnf);
            this.groupBox5.Controls.Add(this.btnGenerate);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 354);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(305, 46);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Run";
            // 
            // chbCopyToClipboard
            // 
            this.chbCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCopyToClipboard.AutoSize = true;
            this.chbCopyToClipboard.Checked = true;
            this.chbCopyToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCopyToClipboard.Location = new System.Drawing.Point(97, 22);
            this.chbCopyToClipboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbCopyToClipboard.Name = "chbCopyToClipboard";
            this.chbCopyToClipboard.Size = new System.Drawing.Size(131, 16);
            this.chbCopyToClipboard.TabIndex = 2;
            this.chbCopyToClipboard.TabStop = false;
            this.chbCopyToClipboard.Text = "Copy To Clipboard";
            this.chbCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // btnEbnf
            // 
            this.btnEbnf.Location = new System.Drawing.Point(5, 19);
            this.btnEbnf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEbnf.Name = "btnEbnf";
            this.btnEbnf.Size = new System.Drawing.Size(66, 18);
            this.btnEbnf.TabIndex = 1;
            this.btnEbnf.TabStop = false;
            this.btnEbnf.Text = "&EBNF";
            this.btnEbnf.UseVisualStyleBackColor = true;
            this.btnEbnf.Click += new System.EventHandler(this.btnEbnf_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(234, 19);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(66, 18);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txbGenerated
            // 
            this.txbGenerated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbGenerated.Location = new System.Drawing.Point(314, 2);
            this.txbGenerated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbGenerated.Multiline = true;
            this.txbGenerated.Name = "txbGenerated";
            this.txbGenerated.ReadOnly = true;
            this.txbGenerated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbGenerated.Size = new System.Drawing.Size(306, 400);
            this.txbGenerated.TabIndex = 0;
            this.txbGenerated.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txbGenerated, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 404);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Stuff Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

