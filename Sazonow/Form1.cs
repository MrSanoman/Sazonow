using MySql.Data.MySqlClient;
using Sazonow.Clases.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sazonow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "192.168.201.12",
                Port = 3306,
                UserID = "ISP347_SazonovAI",
                Password = "2001",
                Database = "ISP347_SazonovAI_Gibdd",
                CharacterSet = "utf8"

            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (DgvUsers.SelectedRows.Count > 0)
            {
                AddUserForm addUser = new AddUserForm(DgvUsers.SelectedRows[0].Tag as User);
                addUser.ShowDialog();
                UpdateData();

              
            }
        }
        private void UpdateData()
        {
            DgvUsers.Rows.Clear();
            {
                foreach (User user in Model1.init().Users.Where(u => u.FirstName.Contains(tbSearch.Text)|| 
                u.SecondName.Contains(tbSearch.Text)|| u.LastName.Contains(tbSearch.Text)||u.Login.Contains(tbSearch.Text)|| u.Pass.Contains(tbSearch.Text)))
                {
                    int x = DgvUsers.Rows.Add(user.FirstName, user.SecondName, user.LastName, user.Login, user.Pass);
                    DgvUsers.Rows[x].Tag = user;
                }

            } 
        }

        private void bt_red_Click(object sender, EventArgs e)
        {

        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (DgvUsers.SelectedRows.Count > 0)
            {
                Model1.init().Users.Remove(DgvUsers.SelectedRows[0].Tag as User);
                Model1.init().SaveChanges();
                UpdateData();
            }
        }

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
