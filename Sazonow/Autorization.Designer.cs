
namespace Sazonow
{
    partial class Autorization
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
            this.btlogin = new System.Windows.Forms.Button();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(86, 125);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "button1";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(72, 36);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(100, 20);
            this.tblogin.TabIndex = 1;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(72, 62);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 2;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 216);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.btlogin);
            this.Name = "Autorization";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Autorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbpass;
    }
}