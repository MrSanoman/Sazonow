using Sazonow.Clases.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sazonow
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            User user = Model1.init().Users.Where(u => u.Login == tblogin.Text && u.Pass == tbpass.Text).FirstOrDefault();
            if (user==null)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                MessageBox.Show("Успех" + user.FirstName);
                Hide();
                new Form1().ShowDialog();
                Show();
            }
        }
    }
}
