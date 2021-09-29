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
   
    public partial class AddUserForm : Form
    {
        User EditUser;
        public AddUserForm(User user)
        {
            EditUser = user;
            InitializeComponent();
            First_Name.Text = user.FirstName;
            Second_Name.Text = user.SecondName;
            Last_Name.Text = user.LastName;
            Login.Text = user.Login;
            Pass.Text = user.Pass;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUser.FirstName = First_Name.Text;
            EditUser.SecondName = Second_Name.Text;
            EditUser.LastName = Last_Name.Text;
            EditUser.Login = Login.Text;
            EditUser.Pass = Pass.Text;
            if(EditUser.id==0)
            {
                Model1.init().Users.Add(EditUser);
            }
            Model1.init().SaveChanges();
        }
    }
}
