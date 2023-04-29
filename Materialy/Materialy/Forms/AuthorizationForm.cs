using Materialy.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materialy.Forms
{
    public partial class AuthorizationForm : Form
    {
        MatrialyDB db = new MatrialyDB();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs ex)
        {
            var user = db.Employee.FirstOrDefault(e => e.UserName == textBox1.Text && e.PassWord == textBox2.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid data");
            }

            Hide();
            if(user.Post.Id == 1)
            {
            }
            else if(user.Post.Id == 2)
            {
                new WorkerForm(user.Id, user.Id_Post).ShowDialog();
            }
            else MessageBox.Show("Invalid data");
            Show();
        }
    }
}
