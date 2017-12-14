namespace EventStuffGenerator.Controls
{
    partial class InputControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHistory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArgument = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnEbnf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbHistory);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "히스토리";
            // 
            // cmbHistory
            // 
            this.cmbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHistory.FormattingEnabled = true;
            this.cmbHistory.Location = new System.Drawing.Point(6, 20);
            this.cmbHistory.Name = "cmbHistory";
            this.cmbHistory.Size = new System.Drawing.Size(187, 20);
            this.cmbHistory.TabIndex = 12;
            this.cmbHistory.SelectedIndexChanged += new System.EventHandler(this.cmbHistory_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtArgument);
            this.groupBox2.Controls.Add(this.txtEventName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 430);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "새로 입력";
            // 
            // txtArgument
            // 
            this.txtArgument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArgument.Location = new System.Drawing.Point(6, 97);
            this.txtArgument.Multiline = true;
            this.txtArgument.Name = "txtArgument";
            this.txtArgument.Size = new System.Drawing.Size(187, 327);
            this.txtArgument.TabIndex = 14;
            // 
            // txtEventName
            // 
            this.txtEventName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventName.Location = new System.Drawing.Point(6, 40);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(187, 21);
            this.txtEventName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "이벤트 이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "이벤트 매개변수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnHelp);
            this.groupBox3.Controls.Add(this.btnEbnf);
            this.groupBox3.Location = new System.Drawing.Point(8, 497);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도움말";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(89, 20);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "도움말";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnEbnf
            // 
            this.btnEbnf.Location = new System.Drawing.Point(8, 20);
            this.btnEbnf.Name = "btnEbnf";
            this.btnEbnf.Size = new System.Drawing.Size(75, 23);
            this.btnEbnf.TabIndex = 0;
            this.btnEbnf.Text = "EBNF";
            this.btnEbnf.UseVisualStyleBackColor = true;
            this.btnEbnf.Click += new System.EventHandler(this.btnEbnf_Click);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputControl";
            this.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Size = new System.Drawing.Size(213, 557);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtArgument;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHistory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEbnf;
        private System.Windows.Forms.Button btnHelp;
    }
}
