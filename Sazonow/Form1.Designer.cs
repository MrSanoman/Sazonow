
namespace Sazonow
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
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.LoginColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_red = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsers
            // 
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginColoumn,
            this.PassColoumn,
            this.FullNameColumn});
            this.DgvUsers.Location = new System.Drawing.Point(186, 12);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.Size = new System.Drawing.Size(587, 327);
            this.DgvUsers.TabIndex = 0;
            this.DgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellContentClick);
            // 
            // LoginColoumn
            // 
            this.LoginColoumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoginColoumn.HeaderText = "Login";
            this.LoginColoumn.Name = "LoginColoumn";
            // 
            // PassColoumn
            // 
            this.PassColoumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PassColoumn.HeaderText = "Pass";
            this.PassColoumn.Name = "PassColoumn";
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameColumn.HeaderText = "FullName";
            this.FullNameColumn.Name = "FullNameColumn";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(36, 55);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(95, 23);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Добавить";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(36, 151);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(95, 23);
            this.bt_del.TabIndex = 2;
            this.bt_del.Text = "Удалить";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // bt_red
            // 
            this.bt_red.Location = new System.Drawing.Point(36, 103);
            this.bt_red.Name = "bt_red";
            this.bt_red.Size = new System.Drawing.Size(95, 23);
            this.bt_red.TabIndex = 3;
            this.bt_red.Text = "Редактировать";
            this.bt_red.UseVisualStyleBackColor = true;
            this.bt_red.Click += new System.EventHandler(this.bt_red_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(31, 223);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bt_red);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.DgvUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_red;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

