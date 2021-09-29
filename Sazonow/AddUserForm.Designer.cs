
namespace Sazonow
{
    partial class AddUserForm
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
            this.First_Name = new System.Windows.Forms.TextBox();
            this.Second_Name = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Add_UserBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(40, 54);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(100, 20);
            this.First_Name.TabIndex = 0;
            // 
            // Second_Name
            // 
            this.Second_Name.Location = new System.Drawing.Point(40, 94);
            this.Second_Name.Name = "Second_Name";
            this.Second_Name.Size = new System.Drawing.Size(100, 20);
            this.Second_Name.TabIndex = 1;
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(40, 149);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(100, 20);
            this.Last_Name.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(40, 187);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(40, 227);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 4;
            // 
            // Add_UserBt
            // 
            this.Add_UserBt.Location = new System.Drawing.Point(65, 277);
            this.Add_UserBt.Name = "Add_UserBt";
            this.Add_UserBt.Size = new System.Drawing.Size(75, 23);
            this.Add_UserBt.TabIndex = 5;
            this.Add_UserBt.Text = "Registrate";
            this.Add_UserBt.UseVisualStyleBackColor = true;
            this.Add_UserBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Регистрация";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_UserBt);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.Second_Name);
            this.Controls.Add(this.First_Name);
            this.Name = "AddUserForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.TextBox Second_Name;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button Add_UserBt;
        private System.Windows.Forms.Label label1;
    }
}