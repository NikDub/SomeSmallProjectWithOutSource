using SportCompetitions.Forms.Admin;
using SportCompetitions.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCompetitions.Forms
{
    public partial class AuthorizationForm : Form
    {
        SportBD BD = new SportBD();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs ee)
        {
            var user = BD.Users.FirstOrDefault<Users>(e => e.Username == textBox1.Text && e.Password == textBox2.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid data");
            }

            Hide();
            PeopleAdd peopleAdd = new PeopleAdd(user.Role);
            peopleAdd.ShowDialog();
            Show();
        }
    }
}

//Это мой
//«Информационная система спортивного клуба», которая содержит следующие сведения:
//− ведение списков спортсменов и тренеров;
//− учёт проводимых соревнований (с ведением их архива);
//− учёт травм, полученных спортсменами;
//− возможность перехода спортсмена от одного тренера к другому;
//− составление рейтингов спортсменов;
//− составление рейтингов тренеров;
//− выдачу информации по соревнованиям;
//− выдачу информации по конкретному спортсмену;
//−подбор возможных кандидатур на участие в соревнованиях
//(соответствующего уровня мастерства, возраста и без травм).
//Данная система будет иметь две подсистемы: подсистему администатора
//и менеджера спортивного клуба. Список полномочий менеджера будет гораздо шире, чем у администратора.
//Так как менеджер будет не только добавлять новых спортсменов, но и отслеживать все результаты, отмечать даты соревнований и управлять базой спортсмено, получившие травмы на соревнованиях.

