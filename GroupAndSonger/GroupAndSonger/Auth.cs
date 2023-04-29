using DogShow.Models;
using GroupAndSonger.Models.DB;
using System;
using System.Linq;
using System.Windows.Forms;
namespace GroupAndSonger
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            //using (var DB = new subdcursa4Entities())
            //{
            //    var list = DB.users.Where(r => r.ID == 1002).ToList();
            //    foreach (var user in list)
            //    {
            //        user.Password = StaticValue.HashPassword(user.Password);
            //    }
            //    DB.SaveChanges();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var user = DB.users.ToList().FirstOrDefault(q => q.Login.Equals(textBoxLogin.Text));
                    if (user != null)
                    {
                        var ver = StaticValue.VerifyHashedPassword(user.Password, textBoxPassword.Text);

                        if (ver)
                        {
                            if (user.roles.Name == "admin")
                            {
                                Hide();
                                var group = new AdminForm();
                                group.ShowDialog();
                                Show();
                            }
                            else
                            {
                                Hide();
                                var group = new GroupsForm(user.ID);
                                group.ShowDialog();
                                Show();
                            }
                            return;
                        }
                        MessageBox.Show("Пароль не верный");
                        return;
                    }
                    MessageBox.Show("Такого пользователя нет");
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
