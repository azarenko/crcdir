
namespace crcdir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._source1 = new System.Windows.Forms.TextBox();
            this._source2 = new System.Windows.Forms.TextBox();
            this._select1 = new System.Windows.Forms.Button();
            this._select2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._difflog = new System.Windows.Forms.TextBox();
            this._compare = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source directory 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source directory 2: ";
            // 
            // _source1
            // 
            this._source1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._source1.Location = new System.Drawing.Point(150, 12);
            this._source1.Name = "_source1";
            this._source1.Size = new System.Drawing.Size(450, 22);
            this._source1.TabIndex = 2;
            // 
            // _source2
            // 
            this._source2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._source2.Location = new System.Drawing.Point(150, 40);
            this._source2.Name = "_source2";
            this._source2.Size = new System.Drawing.Size(450, 22);
            this._source2.TabIndex = 3;
            // 
            // _select1
            // 
            this._select1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._select1.Location = new System.Drawing.Point(606, 12);
            this._select1.Name = "_select1";
            this._select1.Size = new System.Drawing.Size(75, 23);
            this._select1.TabIndex = 4;
            this._select1.Text = "...";
            this._select1.UseVisualStyleBackColor = true;
            this._select1.Click += new System.EventHandler(this._select1_Click);
            // 
            // _select2
            // 
            this._select2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._select2.Location = new System.Drawing.Point(606, 40);
            this._select2.Name = "_select2";
            this._select2.Size = new System.Drawing.Size(75, 23);
            this._select2.TabIndex = 5;
            this._select2.Text = "...";
            this._select2.UseVisualStyleBackColor = true;
            this._select2.Click += new System.EventHandler(this._select2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._difflog);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 394);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difference";
            // 
            // _difflog
            // 
            this._difflog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._difflog.Location = new System.Drawing.Point(3, 18);
            this._difflog.MaxLength = 3276700;
            this._difflog.Multiline = true;
            this._difflog.Name = "_difflog";
            this._difflog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._difflog.Size = new System.Drawing.Size(659, 373);
            this._difflog.TabIndex = 0;
            // 
            // _compare
            // 
            this._compare.Location = new System.Drawing.Point(15, 72);
            this._compare.Name = "_compare";
            this._compare.Size = new System.Drawing.Size(96, 23);
            this._compare.TabIndex = 7;
            this._compare.Text = "Compare";
            this._compare.UseVisualStyleBackColor = true;
            this._compare.Click += new System.EventHandler(this._compare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 516);
            this.Controls.Add(this._compare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._select2);
            this.Controls.Add(this._select1);
            this.Controls.Add(this._source2);
            this.Controls.Add(this._source1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CRC32 Directory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _source1;
        private System.Windows.Forms.TextBox _source2;
        private System.Windows.Forms.Button _select1;
        private System.Windows.Forms.Button _select2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _difflog;
        private System.Windows.Forms.Button _compare;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

