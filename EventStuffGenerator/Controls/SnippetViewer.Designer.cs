namespace EventStuffGenerator.Controls
{
    partial class SnippetViewer
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnTemplateSave = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cheAutoCopy = new System.Windows.Forms.CheckBox();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(3, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "생성(&G)";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnTemplateSave
            // 
            this.btnTemplateSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateSave.Location = new System.Drawing.Point(499, 3);
            this.btnTemplateSave.Name = "btnTemplateSave";
            this.btnTemplateSave.Size = new System.Drawing.Size(103, 23);
            this.btnTemplateSave.TabIndex = 5;
            this.btnTemplateSave.Text = "템플릿 저장(&S)";
            this.btnTemplateSave.UseVisualStyleBackColor = true;
            this.btnTemplateSave.Click += new System.EventHandler(this.btnTemplateSave_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(404, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(89, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "코드 복사(&C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cheAutoCopy
            // 
            this.cheAutoCopy.AutoSize = true;
            this.cheAutoCopy.Checked = true;
            this.cheAutoCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cheAutoCopy.Location = new System.Drawing.Point(84, 7);
            this.cheAutoCopy.Name = "cheAutoCopy";
            this.cheAutoCopy.Size = new System.Drawing.Size(92, 16);
            this.cheAutoCopy.TabIndex = 7;
            this.cheAutoCopy.Text = "생성 후 복사";
            this.cheAutoCopy.UseVisualStyleBackColor = true;
            // 
            // txtTemplate
            // 
            this.txtTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplate.Location = new System.Drawing.Point(3, 23);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(593, 226);
            this.txtTemplate.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(3, 275);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(593, 227);
            this.txtCode.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "템플릿";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "코드";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTemplate, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 505);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // SnippetViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnTemplateSave);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.cheAutoCopy);
            this.Name = "SnippetViewer";
            this.Size = new System.Drawing.Size(605, 540);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cheAutoCopy;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnTemplateSave;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
