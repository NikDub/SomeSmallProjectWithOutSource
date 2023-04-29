using SportCompetitions.Model;
using SportCompetitions.ModelsForShow;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SportCompetitions.Forms.Admin
{
    public partial class PeopleAdd : Form
    {
        readonly SportBD SportBD = new SportBD();
        List<Person> peopleList;
        public PeopleAdd(string role)
        {
            InitializeComponent();
            UpdateDataGrid();
            if (role == "admin")
            {
                Height = 260;
            }
            else if (role == "manager")
            {
                Height = 554;
            }
            else System.Environment.Exit(1);
        }

        private void UpdateDataGrid()
        {
            peopleList = SportBD.People.Select(e => new Person
            {
                Id = e.ID,
                Name = e.Name,
                Surname = e.Surname,
                Patronymic = e.Patronymic,
                Country = e.Country,
                City = e.City,
                Birth_date = e.Birth_date,
                Nationality = e.Nationality
            }).ToList();
            dataGridViewPeople.DataSource = peopleList;
            if (peopleList.Count != 0)
                dataGridViewPeople.Columns[0].Visible = false;

            comboBoxAccidents.Items.AddRange(SportBD.Accident.Select(r => r.Name).ToArray());
            dataGridViewAccidentEdit.DataSource = SportBD.Accident.Select(r => new { r.ID, r.Name }).ToList();
            dataGridViewAccidentEdit.Columns[0].Visible = false;

            comboBoxDischarge.Items.AddRange(SportBD.Discharge.Select(r => r.Name).ToArray());
            var sporttype = SportBD.Sport_type.Select(r => r.Name).ToArray();
            comboBoxDischargeSportType.Items.AddRange(sporttype);
            comboBoxSportTypePost.Items.AddRange(sporttype);
            comboBoxTitleSportType.Items.AddRange(sporttype);

            comboBoxTitle.Items.AddRange(SportBD.Title.Select(r => r.Name).ToArray());
            comboBoxCoach.Items.AddRange(SportBD.People.ToList().Select(r => $"{r.Name} {r.Surname} {r.Patronymic}").ToArray());
            comboBoxPost.Items.AddRange(SportBD.Post.Select(r => r.Name).ToArray());

            comboBoxPeopleTeam.Items.AddRange(SportBD.Team.Select(r => r.Name).ToArray());
            var teams = SportBD.Team.Select(r => new { r.ID, r.Name, r.Country, r.City }).ToList();
            dataGridViewTeam.DataSource = teams;
            if (teams.Count != 0)
                dataGridViewTeam.Columns[0].Visible = false;

            comboBoxPeopleCompetitionCompetition.Items.AddRange(SportBD.Competition.Select(r => r.Name).ToArray());
            comboBoxPeopleCompetitionTeam.Items.AddRange(SportBD.Team.Select(r => r.Name).ToArray());

            var compet = SportBD.Competition.Select(r => new CompetitionShow { Id = r.ID, City = r.City, Country = r.Country, Name = r.Name, date_end = r.End_date, date_start = r.Start_date }).ToList();
            dataGridViewCompetition.DataSource = compet;
            if (compet.Count != 0)
                dataGridViewCompetition.Columns[0].Visible = false;

            comboBoxAchivmentCompetition.Items.AddRange(SportBD.Competition.Select(r => r.Name).ToArray());
            comboBoxCompetitionMedal.Items.AddRange(SportBD.Medal.Select(r => r.Name).ToArray());
            DataGridView1_CellClick(null, null);
        }
        private void ClearTextBox()
        {
            textBoxNatianality.Clear();
            textBoxCity.Clear();
            textBoxCountry.Clear();
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxPatronymic.Clear();
            textBoxSurname.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var SelectedRowID = Convert.ToInt32(dataGridViewPeople.SelectedRows[0].Cells[0].Value);
                var person = SportBD.People.First(y => y.ID == SelectedRowID);
                textBoxID.Text = person.ID.ToString();
                textBoxName.Text = person.Name;
                textBoxSurname.Text = person.Surname;
                textBoxPatronymic.Text = person.Patronymic;
                textBoxCountry.Text = person.Country;
                textBoxCity.Text = person.City;
                textBoxNatianality.Text = person.Nationality;
                dateTimePicker1.Value = (DateTime)person.Birth_date;

                var accidentPeople = SportBD.Accident_People.Where(r => r.ID_people == SelectedRowID).Select(r => new AccidentShow { Id = r.ID, Name = r.Accident.Name, Date = r.date }).ToList();
                dataGridViewAccident.DataSource = accidentPeople;
                if (accidentPeople.Count != 0)
                    dataGridViewAccident.Columns[0].Visible = false;

                var dischargePeople = SportBD.People_Discharge.Where(r => r.ID_People == SelectedRowID).Select(r => new DischargeShow { ID = r.ID, Discharge = r.Discharge.Name, SportType = r.Sport_type.Name }).ToList();
                dataGridViewDischarge.DataSource = dischargePeople;
                if (dischargePeople.Count != 0)
                    dataGridViewDischarge.Columns[0].Visible = false;

                var titlePeople = SportBD.People_Title.Where(r => r.ID_People == SelectedRowID).Select(r => new TitleShow { ID = r.ID, Title = r.Title.Name, SportType = r.Sport_type.Name }).ToList();
                dataGridViewTitle.DataSource = titlePeople;
                if (titlePeople.Count != 0)
                    dataGridViewTitle.Columns[0].Visible = false;

                var coachPeople = SportBD.Coach
                    .Where(r => r.ID_People == SelectedRowID)
                    .Select(q =>
                        new CoachPeopleShow
                        {
                            Id = q.ID,
                            DateTime = q.Date,
                            Name = SportBD.People.FirstOrDefault(a => a.ID == q.ID_Coach).Name,
                            SurName = SportBD.People.FirstOrDefault(a => a.ID == q.ID_Coach).Surname,
                            Patronymic = SportBD.People.FirstOrDefault(a => a.ID == q.ID_Coach).Patronymic
                        })
                    .ToList();
                dataGridViewCoach.DataSource = coachPeople;
                if (coachPeople.Count != 0)
                    dataGridViewCoach.Columns[0].Visible = false;

                var postPeople = SportBD.People_Post.Where(r => r.ID_people == SelectedRowID).Select(r => new PostPeopleShow { Id = r.ID, Post = r.Post.Name, SportType = r.Sport_type.Name, EndDate = r.End_date, StartDate = r.Start_date }).ToList();
                dataGridViewPost.DataSource = postPeople;
                if (postPeople.Count != 0)
                    dataGridViewPost.Columns[0].Visible = false;

                var teams = SportBD.People_Team.Where(r => r.ID_people == SelectedRowID).Select(r => new TeamShow { Id = r.ID, Name = r.Team.Name, Reason = r.Reason, EndDate = r.End_date, StartDate = r.Start_date }).ToList();
                dataGridViewTeamPeople.DataSource = teams;
                if (teams.Count != 0)
                    dataGridViewTeamPeople.Columns[0].Visible = false;

                var competition = SportBD.Competition_Participant.Where(r => r.ID_People == SelectedRowID).Select(r => new Competition_ParticipantShow { Id = r.ID, Competition = r.Competition.Name, Team = r.Team.Name }).ToList();
                dataGridViewPeopleCompetition.DataSource = competition;
                if (competition.Count != 0)
                    dataGridViewPeopleCompetition.Columns[0].Visible = false;

                var achivments = SportBD.Achivments.Where(r => r.ID_People == SelectedRowID).Select(r => new AchivmentsShow { Id = r.ID, CompetitionName = r.Competition_Participant.Competition.Name, MedalName = r.Medal.Name }).ToList();
                dataGridViewAchivment.DataSource = achivments;
                if (achivments.Count != 0)
                    dataGridViewAchivment.Columns[0].Visible = false;
            }
            catch (Exception) { }
        }

        #region Person
        private void button3_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewPeople.SelectedRows[0].Cells[0].Value);
            var deletePerson = SportBD.People.FirstOrDefault(r => r.ID == SelectedRowID);
            SportBD.People.Remove(deletePerson);
            SportBD.SaveChanges();
            UpdateDataGrid();
            ClearTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt16(textBoxID.Text);
            var person = SportBD.People.First(y => y.ID == id);
            person.Name = textBoxName.Text;
            person.Surname = textBoxSurname.Text;
            person.Patronymic = textBoxPatronymic.Text;
            person.City = textBoxCity.Text;
            person.Country = textBoxCountry.Text;
            person.Birth_date = dateTimePicker1.Value;
            person.Nationality = textBoxNatianality.Text;
            SportBD.SaveChanges();
            UpdateDataGrid();
            ClearTextBox();
        }

        private void button4_Click(object sender, EventArgs e) => ClearTextBox();

        private void button1_Click(object sender, EventArgs e)
        {
            People people = new People()
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Patronymic = textBoxPatronymic.Text,
                City = textBoxCity.Text,
                Country = textBoxCountry.Text,
                Birth_date = dateTimePicker1.Value,
                Nationality = textBoxNatianality.Text
            };
            SportBD.People.Add(people);
            SportBD.SaveChanges();
            UpdateDataGrid();
            ClearTextBox();
        }
        #endregion

        #region Accident
        private void dataGridViewAccident_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAccident.SelectedRows[0].Cells[0].Value);
            var accident = SportBD.Accident_People.First(y => y.ID == SelectedRowID);
            textBox_accident_id.Text = accident.ID.ToString();
            comboBoxAccidents.SelectedIndex = comboBoxAccidents.Items.IndexOf(accident.Accident.Name);
            dateTimePicker_accident_date.Value = (DateTime)accident.date;
        }

        private void button_Add_Accident_Click(object sender, EventArgs e)
        {
            Accident_People accident = new Accident_People()
            {
                ID_people = Convert.ToInt32(dataGridViewPeople.SelectedRows[0].Cells[0].Value),
                ID_accident = SportBD.Accident.First(r => r.Name == comboBoxAccidents.Text).ID,
                date = dateTimePicker_accident_date.Value,
                Accident = SportBD.Accident.First(r => r.Name == comboBoxAccidents.Text),
                People = SportBD.People.First(r => r.ID == Convert.ToInt32(dataGridViewPeople.SelectedRows[0].Cells[0].Value))
            };
            SportBD.Accident_People.Add(accident);
            SportBD.SaveChanges();
        }

        private void button_Edit_Accident_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAccident.SelectedRows[0].Cells[0].Value);
            var accident = SportBD.Accident_People.First(y => y.ID == SelectedRowID);
            accident.date = dateTimePicker_accident_date.Value;
            accident.ID_accident = SportBD.Accident.First(r => r.Name == comboBoxAccidents.Text).ID;
            SportBD.SaveChanges();
        }

        private void button_Delete_Accident_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAccident.SelectedRows[0].Cells[0].Value);
            var accident = SportBD.Accident_People.First(y => y.ID == SelectedRowID);
            SportBD.Accident_People.Remove(accident);
            SportBD.SaveChanges();
        }

        private void button_Clear_Accident_Click(object sender, EventArgs e)
        {
            textBox_accident_id.Clear();
            comboBoxAccidents.SelectedIndex = 0;
            dateTimePicker_accident_date.Value = DateTime.Now;
        }

        #endregion

        #region AccidentEdit
        private void dataGridViewAccidentEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAccidentEdit.SelectedRows[0].Cells[0].Value);
            textBoxAccidentEdit.Text = SportBD.Accident.First(r => r.ID == SelectedRowID).Name;
        }

        private void buttonAccidentAddEdit_Click(object sender, EventArgs e)
        {
            Accident accident = new Accident()
            {
                Name = textBoxAccidentEdit.Text
            };
            SportBD.Accident.Add(accident);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonAccidentEditEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAccidentEdit.SelectedRows[0].Cells[0].Value);
            var accident = SportBD.Accident.First(r => r.ID == SelectedRowID);
            accident.Name = textBoxAccidentEdit.Text;
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonAccidentDeleteEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAccidentEdit.SelectedRows[0].Cells[0].Value);
            var accident = SportBD.Accident.First(r => r.ID == SelectedRowID);
            SportBD.Accident.Remove(accident);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        #endregion

        #region Discharge
        private void dataGridViewDischarge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewDischarge.SelectedRows[0].Cells[0].Value);
            var discharge = SportBD.People_Discharge.First(r => r.ID_People == SelectedRowID);
            textBoxDischargeID.Text = discharge.ID.ToString();
            comboBoxDischarge.SelectedIndex = comboBoxDischarge.Items.IndexOf(discharge.Discharge.Name);
            comboBoxDischargeSportType.SelectedIndex = comboBoxDischargeSportType.Items.IndexOf(discharge.Sport_type.Name);
        }

        private void buttonAddDischarge_Click(object sender, EventArgs e)
        {
            People_Discharge people_Discharge = new People_Discharge
            {
                ID_Discharge = SportBD.Discharge.First(r => r.Name == comboBoxDischarge.Text).ID,
                Discharge = SportBD.Discharge.First(r => r.Name == comboBoxDischarge.Text),
                ID_People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID,
                People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)),
                ID_Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxDischargeSportType.Text).ID,
                Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxDischargeSportType.Text)
            };
            SportBD.People_Discharge.Add(people_Discharge);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonEditDischarge_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewDischarge.SelectedRows[0].Cells[0].Value);
            var discharge = SportBD.People_Discharge.First(r => r.ID == SelectedRowID);
            discharge.ID_Discharge = SportBD.Discharge.First(r => r.Name == comboBoxDischarge.Text).ID;
            discharge.Discharge = SportBD.Discharge.First(r => r.Name == comboBoxDischarge.Text);
            discharge.ID_Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxDischargeSportType.Text).ID;
            discharge.Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxDischargeSportType.Text);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonDeleteDischarge_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewDischarge.SelectedRows[0].Cells[0].Value);
            var discharge = SportBD.People_Discharge.First(r => r.ID == SelectedRowID);
            SportBD.People_Discharge.Remove(discharge);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        #endregion

        #region Title
        private void dataGridViewTitle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTitle.SelectedRows[0].Cells[0].Value);
            var title = SportBD.People_Title.First(r => r.ID_People == SelectedRowID);
            textBoxTitleID.Text = title.ID.ToString();
            comboBoxTitle.SelectedIndex = comboBoxTitle.Items.IndexOf(title.Title.Name);
            comboBoxTitleSportType.SelectedIndex = comboBoxTitleSportType.Items.IndexOf(title.Sport_type.Name);
        }

        private void buttonTitleAdd_Click(object sender, EventArgs e)
        {
            People_Title people_Title = new People_Title
            {
                ID_Title = SportBD.Title.First(r => r.Name == comboBoxTitle.Text).ID,
                Title = SportBD.Title.First(r => r.Name == comboBoxTitle.Text),
                ID_People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID,
                People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)),
                ID_Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxTitleSportType.Text).ID,
                Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxTitleSportType.Text)
            };
            SportBD.People_Title.Add(people_Title);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonTitleEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTitle.SelectedRows[0].Cells[0].Value);
            var title = SportBD.People_Title.First(r => r.ID_People == SelectedRowID);
            title.ID_Title = SportBD.Title.First(r => r.Name == comboBoxTitle.Text).ID;
            title.Title = SportBD.Title.First(r => r.Name == comboBoxTitle.Text);
            title.ID_Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxTitleSportType.Text).ID;
            title.Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxTitleSportType.Text);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonTitleDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTitle.SelectedRows[0].Cells[0].Value);
            var title = SportBD.People_Title.First(r => r.ID_People == SelectedRowID);
            SportBD.People_Title.Remove(title);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        #endregion

        #region Coach
        private void dataGridViewCoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewCoach.SelectedRows[0].Cells[0].Value);
            var coach = SportBD.Coach.First(r => r.ID_People == SelectedRowID);
            var person = SportBD.People.First(r => r.ID == coach.ID_Coach);
            textBoxTitleID.Text = coach.ID.ToString();
            comboBoxCoach.SelectedIndex = comboBoxCoach.Items.IndexOf($"{person.Name} {person.Surname} {person.Patronymic}");
            dateTimePickerCoach.Value = (DateTime)coach.Date;
        }

        private void buttonCoachAdd_Click(object sender, EventArgs e)
        {
            var comCoach = comboBoxCoach.Text.Split(' ');
            Coach coach = new Coach
            {
                ID_Coach = SportBD.People.First(r => r.Name == comCoach[0] && r.Surname == comCoach[1] && r.Patronymic == comCoach[2]).ID,
                ID_People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID,
                People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)),
                Date = dateTimePickerCoach.Value,
            };
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonCoachEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewCoach.SelectedRows[0].Cells[0].Value);
            var coach = SportBD.Coach.First(r => r.ID_People == SelectedRowID);
            var comCoach = comboBoxCoach.Text.Split(' ');
            coach.ID_Coach = SportBD.People.First(r => r.Name == comCoach[0] && r.Surname == comCoach[1] && r.Patronymic == comCoach[2]).ID;
            coach.Date = dateTimePickerCoach.Value;
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonCoachDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewCoach.SelectedRows[0].Cells[0].Value);
            var coach = SportBD.Coach.First(r => r.ID_People == SelectedRowID);
            SportBD.Coach.Remove(coach);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }
        #endregion

        #region Post  
        private void dataGridViewPost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewPost.SelectedRows[0].Cells[0].Value);
            var post = SportBD.People_Post.First(r => r.ID_people == SelectedRowID);
            textBoxPostID.Text = post.ID.ToString();
            comboBoxPost.SelectedIndex = comboBoxPost.Items.IndexOf(post.Post.Name);
            comboBoxSportTypePost.SelectedIndex = comboBoxSportTypePost.Items.IndexOf(post.Sport_type.Name);
            dateTimePickerPostEnd.Value = (DateTime)(post.End_date != null ? post.End_date : DateTime.Now);
            dateTimePickerPostStart.Value = (DateTime)post.Start_date;
        }

        private void buttonPostAdd_Click(object sender, EventArgs e)
        {
            People_Post people_Post = new People_Post
            {
                ID_people = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID,
                People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)),
                ID_post = SportBD.Post.First(r => r.Name == comboBoxPost.Text).ID,
                Post = SportBD.Post.First(r => r.Name == comboBoxPost.Text),
                Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxSportTypePost.Text),
                ID_sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxSportTypePost.Text).ID,
                Start_date = dateTimePickerPostStart.Value,
                End_date = dateTimePickerPostEnd.Value
            };
            SportBD.People_Post.Add(people_Post);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonPostEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewPost.SelectedRows[0].Cells[0].Value);
            var post = SportBD.People_Post.First(r => r.ID_people == SelectedRowID);
            post.ID_post = SportBD.Post.First(r => r.Name == comboBoxPost.Text).ID;
            post.Post = SportBD.Post.First(r => r.Name == comboBoxPost.Text);
            post.Sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxSportTypePost.Text);
            post.ID_sport_type = SportBD.Sport_type.First(r => r.Name == comboBoxSportTypePost.Text).ID;
            post.Start_date = dateTimePickerPostStart.Value;
            post.End_date = dateTimePickerPostEnd.Value;
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonPostDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewPost.SelectedRows[0].Cells[0].Value);
            var post = SportBD.People_Post.First(r => r.ID_people == SelectedRowID);
            SportBD.People_Post.Remove(post);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        #endregion

        #region People Team 
        private void dataGridViewTeamPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTeamPeople.SelectedRows[0].Cells[0].Value);
            var team = SportBD.People_Team.First(r => r.ID == SelectedRowID);
            textBoxTeamID.Text = team.ID.ToString();
            comboBoxPeopleTeam.SelectedIndex = comboBoxPeopleTeam.Items.IndexOf(team.Team.Name);
            textBoxTeamReason.Text = team.Reason;
            dateTimePickerTeamEnd.Value = (DateTime)(team.End_date != null ? team.End_date : DateTime.Now);
            dateTimePickerTeamStart.Value = (DateTime)(team.Start_date != null ? team.Start_date : DateTime.Now);
        }

        private void buttonTeamPeopleAdd_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTeamPeople.SelectedRows[0].Cells[0].Value);

            People_Team team = new People_Team
            {
                ID_people = SportBD.People.First(r => r.ID == SelectedRowID).ID,
                People = SportBD.People.First(r => r.ID == SelectedRowID),
                ID_Team = SportBD.Team.First(r => r.Name == comboBoxPeopleTeam.Text).ID,
                Team = SportBD.Team.First(r => r.Name == comboBoxPeopleTeam.Text),
                Reason = textBoxTeamReason.Text,
                End_date = dateTimePickerTeamEnd.Value,
                Start_date = dateTimePickerTeamStart.Value
            };
            SportBD.People_Team.Add(team);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonTeamPeopleEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTeamPeople.SelectedRows[0].Cells[0].Value);
            var team = SportBD.People_Team.First(r => r.ID == SelectedRowID);
            team.ID_Team = SportBD.Team.First(r => r.Name == comboBoxPeopleTeam.Text).ID;
            team.Team = SportBD.Team.First(r => r.Name == comboBoxPeopleTeam.Text);
            team.Reason = textBoxTeamReason.Text;
            team.End_date = dateTimePickerTeamEnd.Value;
            team.Start_date = dateTimePickerTeamStart.Value;
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonTeamPeopleDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTeamPeople.SelectedRows[0].Cells[0].Value);
            var team = SportBD.People_Team.First(r => r.ID == SelectedRowID);
            SportBD.People_Team.Remove(team);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }
        #endregion

        #region Team 
        private void dataGridViewTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTeam.SelectedRows[0].Cells[0].Value);
            var team = SportBD.Team.First(r => r.ID == SelectedRowID);
            textBoxTeamID.Text = team.ID.ToString();
            textBoxTeamName.Text = team.Name;
            textBoxCountryTeam.Text = team.Country;
            textBoxCityTeam.Text = team.City;
        }

        private void buttonTeamAdd_Click(object sender, EventArgs e)
        {
            Team team = new Team
            {
                Name = textBoxTeamName.Text,
                Country = textBoxCountryTeam.Text,
                City = textBoxCityTeam.Text
            };
            SportBD.Team.Add(team);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonTeamEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTeam.SelectedRows[0].Cells[0].Value);
            var team = SportBD.Team.First(r => r.ID == SelectedRowID);
            team.Name = textBoxTeamName.Text;
            team.Country = textBoxCountryTeam.Text;
            team.City = textBoxCityTeam.Text;
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonTeamDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewTeam.SelectedRows[0].Cells[0].Value);
            var team = SportBD.Team.First(r => r.ID == SelectedRowID);
            SportBD.Team.Remove(team);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }
        #endregion

        #region Competition part
        private void dataGridViewPeopleCompetition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewPeopleCompetition.SelectedRows[0].Cells[0].Value);
            var compet = SportBD.Competition_Participant.First(r => r.ID_People == SelectedRowID);
            textBoxPeopleCompetitionID.Text = compet.ID.ToString();
            comboBoxPeopleCompetitionTeam.SelectedIndex = comboBoxPeopleCompetitionTeam.Items.IndexOf(compet.Team.Name);
            comboBoxPeopleCompetitionCompetition.SelectedIndex = comboBoxPeopleCompetitionCompetition.Items.IndexOf(compet.Competition.Name);
        }

        private void buttonPeopleCompetitionAdd_Click(object sender, EventArgs e)
        {
            Competition_Participant competition_Participant = new Competition_Participant
            {
                ID_People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID,
                People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)),
                ID_Competition = SportBD.Competition.First(r => r.Name == comboBoxPeopleCompetitionCompetition.Text).ID,
                Competition = SportBD.Competition.First(r => r.Name == comboBoxPeopleCompetitionCompetition.Text),
                ID_Team = SportBD.Team.First(r => r.Name == comboBoxPeopleCompetitionTeam.Text).ID,
                Team = SportBD.Team.First(r => r.Name == comboBoxPeopleCompetitionTeam.Text)
            };
            SportBD.Competition_Participant.Add(competition_Participant);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonPeopleCompetitionEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewPeopleCompetition.SelectedRows[0].Cells[0].Value);
            var compet = SportBD.Competition_Participant.First(r => r.ID_People == SelectedRowID);
            compet.ID_Competition = SportBD.Competition.First(r => r.Name == comboBoxPeopleCompetitionCompetition.Text).ID;
            compet.Competition = SportBD.Competition.First(r => r.Name == comboBoxPeopleCompetitionCompetition.Text);
            compet.ID_Team = SportBD.Team.First(r => r.Name == comboBoxPeopleCompetitionTeam.Text).ID;
            compet.Team = SportBD.Team.First(r => r.Name == comboBoxPeopleCompetitionTeam.Text);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonPeopleCompetitionDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewPeopleCompetition.SelectedRows[0].Cells[0].Value);
            var compet = SportBD.Competition_Participant.First(r => r.ID_People == SelectedRowID);
            SportBD.Competition_Participant.Remove(compet);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        #endregion

        #region Competition
        private void dataGridViewCompetition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewCompetition.SelectedRows[0].Cells[0].Value);
            var compet = SportBD.Competition.First(r => r.ID == SelectedRowID);
            textBoxCompetitionName.Text = compet.Name;
            textBoxCompetitionCity.Text = compet.City;
            textBoxCompetitionCountry.Text = compet.Country;
            dateTimePickerCompetitionStart.Value = (DateTime)compet.Start_date;
            dateTimePickerCompetitionEnd.Value = (DateTime)compet.End_date;
        }

        private void buttonCompetitionAdd_Click(object sender, EventArgs e)
        {
            Competition competition = new Competition
            {
                Name = textBoxCompetitionName.Text,
                City = textBoxCompetitionCity.Text,
                Country = textBoxCompetitionCountry.Text,
                Start_date = dateTimePickerCompetitionStart.Value,
                End_date = dateTimePickerCompetitionEnd.Value
            };
            SportBD.Competition.Add(competition);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonCompetitionEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewCompetition.SelectedRows[0].Cells[0].Value);
            var compet = SportBD.Competition.First(r => r.ID == SelectedRowID);
            compet.Name = textBoxCompetitionName.Text;
            compet.City = textBoxCompetitionCity.Text;
            compet.Country = textBoxCompetitionCountry.Text;
            compet.Start_date = dateTimePickerCompetitionStart.Value;
            compet.End_date = dateTimePickerCompetitionEnd.Value;
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonCompetitionDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewCompetition.SelectedRows[0].Cells[0].Value);
            var compet = SportBD.Competition.First(r => r.ID == SelectedRowID);
            SportBD.Competition.Remove(compet);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        #endregion

        #region Achivments
        private void dataGridViewAchivment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAchivment.SelectedRows[0].Cells[0].Value);
            var achivment = SportBD.Achivments.First(r => r.ID_People == SelectedRowID);
            comboBoxAchivmentCompetition.SelectedIndex = comboBoxAchivmentCompetition.Items.IndexOf(achivment.Competition_Participant.Team.Name);
            comboBoxCompetitionMedal.SelectedIndex = comboBoxCompetitionMedal.Items.IndexOf(achivment.Medal.Name);
        }

        private void buttonAchivmentAdd_Click(object sender, EventArgs e)
        {
            Achivments achivments = new Achivments
            {
                ID_People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID,
                People = SportBD.People.First(r => r.ID == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)),
                ID_Medal = SportBD.Medal.First(r => r.Name == comboBoxCompetitionMedal.Text).ID,
                Medal = SportBD.Medal.First(r => r.Name == comboBoxCompetitionMedal.Text),
                ID_Competition_Participant = SportBD.Competition_Participant.First(r=>r.Competition.Name == comboBoxAchivmentCompetition.Text && r.ID_People == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID,
                Competition_Participant = SportBD.Competition_Participant.First(r => r.Competition.Name == comboBoxAchivmentCompetition.Text && r.ID_People == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value))
            };
            SportBD.Achivments.Add(achivments);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonAchivmentEdit_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAchivment.SelectedRows[0].Cells[0].Value);
            var achivment = SportBD.Achivments.First(r => r.ID_People == SelectedRowID);
            achivment.ID_Medal = SportBD.Medal.First(r => r.Name == comboBoxCompetitionMedal.Text).ID;
            achivment.Medal = SportBD.Medal.First(r => r.Name == comboBoxCompetitionMedal.Text);
            achivment.ID_Competition_Participant = SportBD.Competition_Participant.First(r => r.Competition.Name == comboBoxAchivmentCompetition.Text && r.ID_People == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value)).ID;
            achivment.Competition_Participant = SportBD.Competition_Participant.First(r => r.Competition.Name == comboBoxAchivmentCompetition.Text && r.ID_People == Convert.ToInt16(dataGridViewPeople.SelectedRows[0].Cells[0].Value));
            SportBD.SaveChanges();
            UpdateDataGrid();
        }

        private void buttonAchivmentDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewAchivment.SelectedRows[0].Cells[0].Value);
            var achivment = SportBD.Achivments.First(r => r.ID_People == SelectedRowID);
            SportBD.Achivments.Remove(achivment);
            SportBD.SaveChanges();
            UpdateDataGrid();
        }
        #endregion

    }
}
