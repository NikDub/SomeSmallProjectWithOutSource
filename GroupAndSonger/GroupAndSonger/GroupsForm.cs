using GroupAndSonger.Models.DB;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GroupAndSonger
{
    public partial class GroupsForm : Form
    {
        public int User_Id { get; }

        private users userSingle;

        public GroupsForm(int user_id)
        {
            InitializeComponent();
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    User_Id = user_id;
                    userSingle = DB.users.First(r => r.ID == User_Id);
                }
                catch (Exception)
                {
                    MessageBox.Show("");
                }
            }
            UpdateAll();
        }

        private void UpdateAll()
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    dataGridView1.DataSource = DB.groups.Where(r => r.ID_User == User_Id).Select(r => new
                    {
                        r.ID,
                        r.Name,
                        Country = r.country.Name,
                        r.Year,
                        r.Place
                    }).ToList();
                    dataGridView1.Columns[0].Visible = false;

                    comboBoxCountry.Items.Clear();
                    comboBoxCountry.Items.AddRange(DB.country.Select(r => r.Name).ToArray());

                    comboBoxExec.Items.Clear();
                    comboBoxExec.Items.AddRange(DB.executor.Select(r => r.Name + " " + r.Surname + " " + r.Patronymic).ToArray());

                    dataGridViewSong.DataSource = DB.songs.Select(r => new
                    {
                        r.ID,
                        r.Name,
                        r.Year
                    }).ToList();
                    dataGridViewSong.Columns[0].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #region Группа
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    var group = DB.groups.First(r => r.ID == index);
                    textBoxName.Text = group.Name;
                    textBoxUser.Text = userSingle.Surname + " " + userSingle.Name + " " + userSingle.Patronymic;
                    numericUpDown1.Value = (decimal)group.Place;
                    numericUpDownYear.Value = (decimal)group.Year;
                    comboBoxCountry.SelectedIndex = comboBoxCountry.Items.IndexOf(group.country.Name);

                    var consist = DB.group_executor.Where(r => r.ID_Group == index).Select(r => new
                    {
                        r.ID,
                        r.Date_arr,
                        r.Date_depart,
                        r.Role_stat,
                        r.executor.Name,
                        r.executor.Surname,
                        r.executor.Patronymic
                    }).ToList();
                    dataGridViewConsists.DataSource = consist;
                    dataGridViewConsists.Columns[0].Visible = false;

                    dataGridViewExecuter.DataSource = DB.group_executor.Where(r => r.ID_Group == index).Select(r => new
                    {
                        r.executor.ID,
                        r.executor.Name,
                        r.executor.Surname,
                        r.executor.Patronymic,
                        r.executor.Birth_date
                    }).ToList();
                    dataGridViewExecuter.Columns[0].Visible = false;

                    dataGridViewRepertuar.DataSource = DB.repertoires.Where(r => r.ID_Group == index).Select(r => new
                    {
                        r.ID,
                        r.songs.Name,
                        r.songs.Year,
                        r.date_beg
                    }).ToList();
                    dataGridViewRepertuar.Columns[0].Visible = false;

                    dataGridViewAuthor.DataSource = DB.authors.Where(r => r.songs.repertoires.Where(re => re.ID_Group == index).Count() != 0).Select(r => new
                    {
                        r.ID,
                        Song = r.songs.Name,
                        r.songs.Year,
                        r.executor.Name,
                        r.executor.Surname,
                        r.executor.Patronymic,
                        r.role_stat
                    }).ToList();

                    comboBoxRepertuarName.Items.Clear();
                    comboBoxRepertuarName.Items.AddRange(DB.songs.Select(r => r.Name).ToArray());

                    comboBoxAuthorSong.Items.Clear();
                    comboBoxAuthorSong.Items.AddRange(DB.songs.Select(r => r.Name).ToArray());

                    comboBoxAuthorExec.Items.Clear();
                    comboBoxAuthorExec.Items.AddRange(DB.group_executor.Where(r => r.ID_Group == index).Select(r => r.executor.Name + " " + r.executor.Surname + " " + r.executor.Patronymic).ToArray());
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
                    var county = DB.country.First(r => r.Name == comboBoxCountry.Text);
                    var group = new groups
                    {
                        ID_User = User_Id,
                        country = county,
                        ID_Country = county.ID,
                        Name = textBoxName.Text,
                        Place = (int?)numericUpDown1.Value,
                        Year = (int?)numericUpDownYear.Value
                    };
                    DB.groups.Add(group);
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
                    var index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    var county = DB.country.First(r => r.Name == comboBoxCountry.Text);
                    var group = DB.groups.First(r => r.ID == index);
                    group.country = county;
                    group.ID_Country = county.ID;
                    group.Name = textBoxName.Text;
                    group.Place = (int?)numericUpDown1.Value;
                    group.Year = (int?)numericUpDownYear.Value;
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
                    var index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    var group = DB.groups.First(r => r.ID == index);
                    DB.groups.Remove(group);
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
        #endregion

        #region Состав группы
        private void dataGridViewConsists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewConsists.SelectedRows[0].Cells[0].Value);
                    var constd = DB.group_executor.First(r => r.ID == index);
                    comboBoxExec.SelectedIndex = comboBoxExec.Items.IndexOf(constd.executor.Name + " " + constd.executor.Surname + " " + constd.executor.Patronymic);
                    dateTimePickerStart.Value = (DateTime)constd.Date_arr;
                    dateTimePickerEnd.Value = (DateTime)constd.Date_depart;
                    textBoxRole.Text = constd.Role_stat;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonConsistAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var strSplit = comboBoxExec.Text.Split(' ');
                    var name = strSplit[0];
                    var surname = strSplit[1];
                    var patronymic = strSplit[2];
                    var exec = DB.executor.First(r => r.Name == name && r.Surname == surname && r.Patronymic == patronymic);
                    var groupId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    var newObj = new group_executor
                    {
                        ID_Executor = exec.ID,
                        ID_Group = groupId,
                        Role_stat = textBoxRole.Text,
                        Date_arr = dateTimePickerStart.Value,
                        Date_depart = dateTimePickerEnd.Value,
                    };
                    DB.group_executor.Add(newObj);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonConsistEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var strSplit = comboBoxExec.Text.Split(' ');
                    var name = strSplit[0];
                    var surname = strSplit[1];
                    var patronymic = strSplit[2];
                    var exec = DB.executor.First(r => r.Name == name && r.Surname == surname && r.Patronymic == patronymic);
                    var groupId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    var index = Convert.ToInt32(dataGridViewConsists.SelectedRows[0].Cells[0].Value);
                    var newObj = DB.group_executor.First(r => r.ID == index);
                    newObj.ID_Executor = exec.ID;
                    newObj.Role_stat = textBoxRole.Text;
                    newObj.Date_arr = dateTimePickerStart.Value;
                    newObj.Date_depart = dateTimePickerEnd.Value;
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonConsistDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewConsists.SelectedRows[0].Cells[0].Value);
                    var newObj = DB.group_executor.First(r => r.ID == index);
                    DB.group_executor.Remove(newObj);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region Участник
        private void dataGridViewExecuter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewExecuter.SelectedRows[0].Cells[0].Value);
                    var zexe = DB.executor.First(r => r.ID == index);
                    textBoxExeName.Text = zexe.Name;
                    textBoxExeSurname.Text = zexe.Surname;
                    textBoxExePatro.Text = zexe.Patronymic;
                    dateTimePickerBirth.Value = (DateTime)zexe.Birth_date;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonExeAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var exec = new executor
                    {
                        Birth_date = dateTimePickerBirth.Value,
                        Name = textBoxExeName.Text,
                        Surname = textBoxExeSurname.Text,
                        Patronymic = textBoxExePatro.Text,
                    };
                    DB.executor.Add(exec);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonExeEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewExecuter.SelectedRows[0].Cells[0].Value);
                    var zexe = DB.executor.First(r => r.ID == index);
                    zexe.Birth_date = dateTimePickerBirth.Value;
                    zexe.Name = textBoxExeName.Text;
                    zexe.Surname = textBoxExeSurname.Text;
                    zexe.Patronymic = textBoxExePatro.Text;
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonExeDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewExecuter.SelectedRows[0].Cells[0].Value);
                    var zexe = DB.executor.First(r => r.ID == index);
                    DB.executor.Remove(zexe);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                    UpdateAll();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Репертуар
        private void dataGridViewRepertuar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewRepertuar.SelectedRows[0].Cells[0].Value);
                    var item = DB.repertoires.First(r => r.ID == index);
                    comboBoxRepertuarName.SelectedIndex = comboBoxRepertuarName.Items.IndexOf(item.songs.Name);
                    dateTimePickerRepertuarDate.Value = (DateTime)item.date_beg;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonRepertuarAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var newObj = new repertoires
                    {
                        ID_Group = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                        date_beg = dateTimePickerRepertuarDate.Value,
                        ID_Song = DB.songs.First(r => r.Name == comboBoxRepertuarName.Text).ID
                    };
                    DB.repertoires.Add(newObj);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRepertuarEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewRepertuar.SelectedRows[0].Cells[0].Value);
                    var item = DB.repertoires.First(r => r.ID == index);
                    item.date_beg = dateTimePickerRepertuarDate.Value;
                    item.ID_Song = DB.songs.First(r => r.Name == comboBoxRepertuarName.Text).ID;
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRepertuarDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewRepertuar.SelectedRows[0].Cells[0].Value);
                    var item = DB.repertoires.First(r => r.ID == index);
                    DB.repertoires.Remove(item);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Песни
        private void dataGridViewSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewSong.SelectedRows[0].Cells[0].Value);
                    var item = DB.songs.First(r => r.ID == index);
                    textBoxSongName.Text = item.Name;
                    numericUpDownSongYear.Value = (decimal)item.Year;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonSongAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var item = new songs
                    {
                        Name = textBoxSongName.Text,
                        Year = (int?)numericUpDownSongYear.Value,
                    };
                    DB.songs.Add(item);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonSongEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewSong.SelectedRows[0].Cells[0].Value);
                    var item = DB.songs.First(r => r.ID == index);
                    item.Name = textBoxSongName.Text;
                    item.Year = (int?)numericUpDownSongYear.Value;
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonSongDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewSong.SelectedRows[0].Cells[0].Value);
                    var item = DB.songs.First(r => r.ID == index);
                    DB.songs.Remove(item);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Авторы
        private void dataGridViewAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewAuthor.SelectedRows[0].Cells[0].Value);
                    var item = DB.authors.First(r => r.ID == index);
                    comboBoxAuthorExec.SelectedIndex = comboBoxAuthorExec.Items.IndexOf(item.executor.Name + " " + item.executor.Surname + " " + item.executor.Patronymic);
                    comboBoxAuthorSong.SelectedIndex = comboBoxAuthorSong.Items.IndexOf(item.songs.Name);
                    textBoxAuthorRole.Text = item.role_stat;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAuthorAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var splitstr = comboBoxAuthorExec.Text.Split(' ');
                    var name = splitstr[0];
                    var surname = splitstr[1];
                    var patronymic = splitstr[2];
                    var exec = DB.executor.First(r => r.Name == name && r.Surname == surname && r.Patronymic == patronymic);
                    var song = DB.songs.First(r => r.Name == comboBoxAuthorSong.Text);

                    var newObj = new authors
                    {
                        ID_Executor = exec.ID,
                        ID_Song = song.ID,
                        role_stat = textBoxAuthorRole.Text
                    };
                    DB.authors.Add(newObj);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAuthorEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewAuthor.SelectedRows[0].Cells[0].Value);
                    var item = DB.authors.First(r => r.ID == index);
                    var splitstr = comboBoxAuthorExec.Text.Split(' ');
                    var name = splitstr[0];
                    var surname = splitstr[1];
                    var patronymic = splitstr[2];
                    var exec = DB.executor.First(r => r.Name == name && r.Surname == surname && r.Patronymic == patronymic);
                    var song = DB.songs.First(r => r.Name == comboBoxAuthorSong.Text);
                    item.ID_Executor = exec.ID;
                    item.ID_Song = song.ID;
                    item.role_stat = textBoxAuthorRole.Text;
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAuthorDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewAuthor.SelectedRows[0].Cells[0].Value);
                    var item = DB.authors.First(r => r.ID == index);
                    DB.authors.Remove(item);
                    DB.SaveChanges();
                    tran.Commit();
                    dataGridView1_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hide();
            var index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var from = new ToursForm(index);
            from.ShowDialog();
            Show();
        }
    }
}
