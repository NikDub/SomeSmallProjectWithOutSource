using DogShow.Models;
using GroupAndSonger.Models.DB;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GroupAndSonger
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            List<string> strings = new List<string>()
            {
                "1 Автор текста, композитор и дата создания песни с данным названием",
                "2 В репертуар какой группы она входит?",
                "3 Репертуар наиболеe популярной группы",
                "4 Цена билета на последний концерт указанной группы",
                "5 Состав исполнителей группы с заданным названием, их возраст и амилуа",
                "6 Место и продолжительность гастролей группы с заданным названием",
                "7 Какие группы в текушем году отмечают юбилей?",
                "8 Самый молодой вокалист? Какую группу он представляет? ",
                "9 В каких группах средний возраст исполнителей ве превышает 20 лет?",
            };
            comboBoxQeury.Items.AddRange(strings.ToArray());

            comboBoxGroup.Enabled = false;
            comboBoxSong.Enabled = false;

            using (var DB = new subdcursa4Entities())
            {
                comboBoxSong.Items.AddRange(DB.songs.Select(r => r.Name).ToArray());
                comboBoxGroup.Items.AddRange(DB.groups.Select(r => r.Name).ToArray());
                comboBoxRole.Items.AddRange(DB.roles.Select(r => r.Name).ToArray());
                UpdateAll();
            }
        }

        public void UpdateAll()
        {
            using (var DB = new subdcursa4Entities())
            {
                dataGridViewUsers.DataSource = DB.users.Select(r => new { r.ID, r.Login, r.Password, r.Name, r.Surname, r.Patronymic, role = r.roles.Name }).ToList();
                dataGridViewUsers.Columns[0].Visible = false;
            }
        }

        private void comboBoxQeury_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = Convert.ToInt32(comboBoxQeury.Text.Split(' ')[0]);

            switch (select)
            {
                case 1:
                case 2:
                    {
                        comboBoxSong.Enabled = true;
                        break;
                    }
                case 4:
                case 5:
                case 6:
                    {
                        comboBoxGroup.Enabled = true;
                        break;
                    }
                default:
                    {
                        comboBoxGroup.Enabled = false;
                        comboBoxSong.Enabled = false;
                        break;
                    }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var select = Convert.ToInt32(comboBoxQeury.Text.Split(' ')[0]);
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    switch (select)
                    {
                        case 1:
                            {
                                var temp1 = DB.Database.SqlQuery<Query1>("select c.Name as 'Name', c.Patronymic, c.Surname, a.Year " +
                                    " from songs as a, authors as b, executor as c " +
                                    $" where a.ID = b.ID_Song and b.ID_Executor = c.ID and a.name = '{comboBoxSong.Text}' ").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 2:
                            {
                                var temp1 = DB.Database.SqlQuery<Query2>("select c.Name " +
                                    "from songs as a, repertoires as b, groups as c " +
                                    $"where a.ID=b.ID_Song and b.ID_Group=c.ID and a.name = '{comboBoxSong.Text}'").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 3:
                            {
                                var temp1 = DB.Database.SqlQuery<Query2>("select c.Name " +
                                    "from groups as a, repertoires as b, songs as c where a.ID=(select top 1 id from groups order by groups.Place) and a.ID=b.ID_Group and b.ID_Song = c.ID").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 4:
                            {
                                var temp1 = DB.Database.SqlQuery<Query4>("select c.Price_tick " +
                                    "from groups as a, tours as b, buy_tick as c " +
                                    $"where a.ID = b.ID_Group and c.ID_Tour = b.ID and a.Name = '{comboBoxGroup.Text}'").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 5:
                            {
                                var temp1 = DB.Database.SqlQuery<Query5>("select c.Name, c.Patronymic, c.Surname, c.Birth_date " +
                                    "from groups as a, group_executor as b, executor as c " +
                                    $"where a.ID = b.ID_Group and b.ID_Executor = c.ID and a.Name = '{comboBoxGroup.Text}'").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 6:
                            {
                                var temp1 = DB.Database.SqlQuery<Query6>("select d.Name_loc, d.Name_place, c.Date_beg, c.Date_ov " +
                                    "from groups as a, tours as b, buy_tick as c, places as d " +
                                    $"where a.ID=b.ID_Group and b.ID = c.ID_Tour and c.ID_Place = d.ID and a.Name = '{comboBoxGroup.Text}'").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 7:
                            {
                                var temp1 = DB.Database.SqlQuery<Query2>("select Name from groups as a where (YEAR(getdate()) - a.Year)%10 = 0").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 8:
                            {
                                var temp1 = DB.Database.SqlQuery<Query8>("select a.Name, a.Surname, a.Patronymic, c.Name as 'Group' " +
                                    "from executor as a, group_executor as b, groups as c " +
                                    "where a.ID=b.ID_Executor and b.ID_Group = c.ID " +
                                    "order by a.Birth_date desc").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        case 9:
                            {
                                var temp1 = DB.Database.SqlQuery<Query2>("select c.Name " +
                                    "from executor as a, group_executor as b, groups as c " +
                                    "where a.ID=b.ID_Executor and b.ID_Group = c.ID " +
                                    "group by c.Name " +
                                    "having AVG(DATEDIFF(MONTH, a.Birth_date, GETDATE())/12) < 20").ToList();
                                dataGridView1.DataSource = temp1;
                                break;
                            }
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {


                var groups = DB.groups.ToList();
                foreach (var group in groups)
                {
                    Excel.Application application = new Excel.Application();
                    application.Workbooks.Add();
                    Excel.Worksheet ws = (Excel.Worksheet)application.ActiveSheet;
                    int i = 0;
                    var consist = DB.group_executor.Where(r => r.ID_Group == group.ID).Select(r => r.executor).ToList();
                    var repert = DB.repertoires.Where(r => r.ID_Group == group.ID).Select(r => r.songs).ToList();
                    var tour = DB.tours.First(r => r.ID_Group == group.ID).buy_tick.ToList();
                    var costSumm = tour.Sum(r => r.SummPR_tick);

                    ws.Cells[1, 1] = "Название группы";
                    ws.Cells[2, 1] = "Страна";
                    ws.Cells[3, 1] = "Год создания";
                    ws.Cells[4, 1] = "Расположение в чарте";

                    ws.Cells[1, 2] = group.Name;
                    ws.Cells[2, 2] = group.country.Name;
                    ws.Cells[3, 2] = group.Year;
                    ws.Cells[4, 2] = group.Place;

                    Range _excelCells1 = (Range)ws.get_Range("E1", "H1").Cells;
                    _excelCells1.Merge(Type.Missing);
                    _excelCells1.Value = "Участники группы";
                    ws.Cells[2, 5] = "Имя";
                    ws.Cells[2, 6] = "Фамилия";
                    ws.Cells[2, 7] = "Отчество";
                    ws.Cells[2, 8] = "Дата рождения";

                    for (i = 0; i < consist.Count; i++)
                    {
                        ws.Cells[i + 3, 5] = consist[i].Name;
                        ws.Cells[i + 3, 6] = consist[i].Surname;
                        ws.Cells[i + 3, 7] = consist[i].Patronymic;
                        ws.Cells[i + 3, 8] = consist[i].Birth_date;
                    }

                    Range _excelCells3 = (Range)ws.get_Range("K1", "L1").Cells;
                    _excelCells3.Merge(Type.Missing);
                    _excelCells3.Value = "Репертуар группы";
                    ws.Cells[2, 11] = "Название";
                    ws.Cells[2, 12] = "Год";
                    for (i = 0; i < repert.Count; i++)
                    {
                        ws.Cells[i + 3, 11] = repert[i].Name;
                        ws.Cells[i + 3, 12] = repert[i].Year;
                    }

                    Range _excelCells2 = (Range)ws.get_Range("O1", "V1").Cells;
                    _excelCells2.Merge(Type.Missing);
                    _excelCells2.Value = "Выступления в последнем туре";
                    ws.Cells[2, 15] = "Название места";
                    ws.Cells[2, 16] = "Название локации";
                    ws.Cells[2, 17] = "Дата начала";
                    ws.Cells[2, 18] = "Дата конца";
                    ws.Cells[2, 19] = "Количество билетов";
                    ws.Cells[2, 20] = "Цена билета";
                    ws.Cells[2, 21] = "Выручка";
                    ws.Cells[2, 22] = "Страна";

                    for (i = 0; i < tour.Count; i++)
                    {
                        ws.Cells[i + 3, 15] = tour[i].places.Name_place;
                        ws.Cells[i + 3, 16] = tour[i].places.Name_loc;
                        ws.Cells[i + 3, 17] = tour[i].Date_beg;
                        ws.Cells[i + 3, 18] = tour[i].Date_ov;
                        ws.Cells[i + 3, 19] = tour[i].Count_tick;
                        ws.Cells[i + 3, 20] = tour[i].Price_tick;
                        ws.Cells[i + 3, 21] = tour[i].SummPR_tick;
                        ws.Cells[i + 3, 22] = tour[i].places.country.Name;
                    }
                    ws.Cells[i + 3, 21] = costSumm;
                    ws.Columns.AutoFit();
                    Excel.Range rang = ws.get_Range("A1", "S40");
                    rang.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    rang.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    application.Visible = true;
                }
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value);
                    var user = DB.users.First(r => r.ID == index);
                    textBoxLogin.Text = user.Login;
                    textBoxName.Text = user.Name;
                    textBoxSurname.Text = user.Surname;
                    textBoxpatronymic.Text = user.Patronymic;
                    comboBoxRole.SelectedIndex = comboBoxRole.Items.IndexOf(user.roles.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    if(DB.users.Any(r=>r.Login == textBoxLogin.Text))
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует");
                        return;
                    }
                    var user = new users
                    {
                        ID_Role = DB.roles.First(r => r.Name == comboBoxRole.Text).ID,
                        Login = textBoxLogin.Text,
                        Password = StaticValue.HashPassword(textBoxPassword.Text),
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Patronymic = textBoxpatronymic.Text,
                    };
                    DB.users.Add(user);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    if (DB.users.Any(r => r.Login == textBoxLogin.Text))
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует");
                        return;
                    }
                    var index = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value);
                    var user = DB.users.First(r => r.ID == index);
                    user.ID_Role = DB.roles.First(r => r.Name == comboBoxRole.Text).ID;
                    user.Login = textBoxLogin.Text;
                    user.Password = StaticValue.HashPassword(textBoxPassword.Text);
                    user.Name = textBoxName.Text;
                    user.Surname = textBoxSurname.Text;
                    user.Patronymic = textBoxpatronymic.Text;
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value);
                    var user = DB.users.First(r => r.ID == index);
                    DB.users.Remove(user);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

    public class Query1
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
    }
    public class Query2
    {
        public string Name { get; set; }
    }
    public class Query4
    {
        public int Price_tick { get; set; }
    }
    public class Query5
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public DateTime Birth_date { get; set; }
    }
    public class Query6
    {
        public string Name_loc { get; set; }
        public string Name_place { get; set; }
        public DateTime Date_beg { get; set; }
        public DateTime Date_ov { get; set; }
    }
    public class Query8
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
    }
}
