namespace Bai2
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
            this.textBoxiphost = new System.Windows.Forms.TextBox();
            this.listBoxresult = new System.Windows.Forms.ListBox();
            this.buttoncheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP host:";
            // 
            // textBoxiphost
            // 
            this.textBoxiphost.Location = new System.Drawing.Point(58, 20);
            this.textBoxiphost.Name = "textBoxiphost";
            this.textBoxiphost.Size = new System.Drawing.Size(195, 20);
            this.textBoxiphost.TabIndex = 1;
            // 
            // listBoxresult
            // 
            this.listBoxresult.FormattingEnabled = true;
            this.listBoxresult.Location = new System.Drawing.Point(12, 104);
            this.listBoxresult.Name = "listBoxresult";
            this.listBoxresult.Size = new System.Drawing.Size(312, 225);
            this.listBoxresult.TabIndex = 4;
            // 
            // buttoncheck
            // 
            this.buttoncheck.Location = new System.Drawing.Point(262, 18);
            this.buttoncheck.Name = "buttoncheck";
            this.buttoncheck.Size = new System.Drawing.Size(75, 23);
            this.buttoncheck.TabIndex = 5;
            this.buttoncheck.Text = "Check";
            this.buttoncheck.UseVisualStyleBackColor = true;
            this.buttoncheck.Click += new System.EventHandler(this.buttoncheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 339);
            this.Controls.Add(this.buttoncheck);
            this.Controls.Add(this.listBoxresult);
            this.Controls.Add(this.textBoxiphost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxiphost;
        private System.Windows.Forms.ListBox listBoxresult;
        private System.Windows.Forms.Button buttoncheck;
    }
}

