using System.Windows.Forms;

namespace SportCompetitions.Forms.Admin
{
    partial class PeopleAdd
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
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.button_Add_Person = new System.Windows.Forms.Button();
            this.button_Edit_Person = new System.Windows.Forms.Button();
            this.button_Delete_Person = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxNatianality = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Clear_Person = new System.Windows.Forms.Button();
            this.dataGridViewAccident = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonAccidentDeleteEdit = new System.Windows.Forms.Button();
            this.buttonAccidentEditEdit = new System.Windows.Forms.Button();
            this.buttonAccidentAddEdit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAccidentEdit = new System.Windows.Forms.TextBox();
            this.dataGridViewAccidentEdit = new System.Windows.Forms.DataGridView();
            this.comboBoxAccidents = new System.Windows.Forms.ComboBox();
            this.button_Clear_Accident = new System.Windows.Forms.Button();
            this.dateTimePicker_accident_date = new System.Windows.Forms.DateTimePicker();
            this.button_Delete_Accident = new System.Windows.Forms.Button();
            this.button_Edit_Accident = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Add_Accident = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_accident_id = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxDischarge = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewDischarge = new System.Windows.Forms.DataGridView();
            this.textBoxDischargeID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonAddDischarge = new System.Windows.Forms.Button();
            this.buttonEditDischarge = new System.Windows.Forms.Button();
            this.buttonDeleteDischarge = new System.Windows.Forms.Button();
            this.comboBoxDischargeSportType = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridViewTitle = new System.Windows.Forms.DataGridView();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxTitleSportType = new System.Windows.Forms.ComboBox();
            this.buttonTitleDelete = new System.Windows.Forms.Button();
            this.textBoxTitleID = new System.Windows.Forms.TextBox();
            this.buttonTitleEdit = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonTitleAdd = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridViewCoach = new System.Windows.Forms.DataGridView();
            this.comboBoxCoach = new System.Windows.Forms.ComboBox();
            this.textBoxCoachID = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.dateTimePickerCoach = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonCoachDelete = new System.Windows.Forms.Button();
            this.buttonCoachAdd = new System.Windows.Forms.Button();
            this.buttonCoachEdit = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBoxSportTypePost = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dateTimePickerPostEnd = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridViewPost = new System.Windows.Forms.DataGridView();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.textBoxPostID = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dateTimePickerPostStart = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.buttonPostDelete = new System.Windows.Forms.Button();
            this.buttonPostAdd = new System.Windows.Forms.Button();
            this.buttonPostEdit = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewTeamPeople = new System.Windows.Forms.DataGridView();
            this.label38 = new System.Windows.Forms.Label();
            this.dateTimePickerTeamEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonTeamPeopleEdit = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.buttonTeamPeopleAdd = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.buttonTeamPeopleDelete = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.comboBoxPeopleTeam = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTeamStart = new System.Windows.Forms.DateTimePicker();
            this.textBoxIDTeamPeople = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBoxTeamReason = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dataGridViewTeam = new System.Windows.Forms.DataGridView();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBoxTeamID = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxCountryTeam = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBoxCityTeam = new System.Windows.Forms.TextBox();
            this.buttonTeamEdit = new System.Windows.Forms.Button();
            this.buttonTeamAdd = new System.Windows.Forms.Button();
            this.buttonTeamDelete = new System.Windows.Forms.Button();
            this.dataGridViewPeopleCompetition = new System.Windows.Forms.DataGridView();
            this.buttonPeopleCompetitionEdit = new System.Windows.Forms.Button();
            this.buttonPeopleCompetitionAdd = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.buttonPeopleCompetitionDelete = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.comboBoxPeopleCompetitionTeam = new System.Windows.Forms.ComboBox();
            this.textBoxPeopleCompetitionID = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.dataGridViewCompetition = new System.Windows.Forms.DataGridView();
            this.label47 = new System.Windows.Forms.Label();
            this.textBoxCompetitionID = new System.Windows.Forms.TextBox();
            this.comboBoxPeopleCompetitionCompetition = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.buttonCompetitionEdit = new System.Windows.Forms.Button();
            this.buttonCompetitionAdd = new System.Windows.Forms.Button();
            this.buttonCompetitionDelete = new System.Windows.Forms.Button();
            this.textBoxCompetitionName = new System.Windows.Forms.TextBox();
            this.textBoxCompetitionCity = new System.Windows.Forms.TextBox();
            this.textBoxCompetitionCountry = new System.Windows.Forms.TextBox();
            this.dateTimePickerCompetitionStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCompetitionEnd = new System.Windows.Forms.DateTimePicker();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.comboBoxCompetitionMedal = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.dataGridViewAchivment = new System.Windows.Forms.DataGridView();
            this.buttonAchivmentEdit = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.buttonAchivmentAdd = new System.Windows.Forms.Button();
            this.textBoxAchivmentID = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.comboBoxAchivmentCompetition = new System.Windows.Forms.ComboBox();
            this.buttonAchivmentDelete = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccident)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccidentEdit)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDischarge)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitle)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoach)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPost)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamPeople)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleCompetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchivment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.AllowUserToAddRows = false;
            this.dataGridViewPeople.AllowUserToDeleteRows = false;
            this.dataGridViewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPeople.MultiSelect = false;
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            this.dataGridViewPeople.RowHeadersVisible = false;
            this.dataGridViewPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeople.Size = new System.Drawing.Size(776, 202);
            this.dataGridViewPeople.TabIndex = 0;
            this.dataGridViewPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // button_Add_Person
            // 
            this.button_Add_Person.Location = new System.Drawing.Point(801, 191);
            this.button_Add_Person.Name = "button_Add_Person";
            this.button_Add_Person.Size = new System.Drawing.Size(75, 23);
            this.button_Add_Person.TabIndex = 1;
            this.button_Add_Person.Text = "Добавить";
            this.button_Add_Person.UseVisualStyleBackColor = true;
            this.button_Add_Person.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Edit_Person
            // 
            this.button_Edit_Person.Location = new System.Drawing.Point(882, 191);
            this.button_Edit_Person.Name = "button_Edit_Person";
            this.button_Edit_Person.Size = new System.Drawing.Size(75, 23);
            this.button_Edit_Person.TabIndex = 2;
            this.button_Edit_Person.Text = "Изменить";
            this.button_Edit_Person.UseVisualStyleBackColor = true;
            this.button_Edit_Person.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Delete_Person
            // 
            this.button_Delete_Person.Location = new System.Drawing.Point(963, 191);
            this.button_Delete_Person.Name = "button_Delete_Person";
            this.button_Delete_Person.Size = new System.Drawing.Size(75, 23);
            this.button_Delete_Person.TabIndex = 3;
            this.button_Delete_Person.Text = "Удалить";
            this.button_Delete_Person.UseVisualStyleBackColor = true;
            this.button_Delete_Person.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(858, 27);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(141, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(858, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(141, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(858, 79);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(141, 20);
            this.textBoxSurname.TabIndex = 6;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(858, 105);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(141, 20);
            this.textBoxPatronymic.TabIndex = 7;
            // 
            // textBoxNatianality
            // 
            this.textBoxNatianality.Location = new System.Drawing.Point(1129, 101);
            this.textBoxNatianality.Name = "textBoxNatianality";
            this.textBoxNatianality.Size = new System.Drawing.Size(161, 20);
            this.textBoxNatianality.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(1129, 49);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(161, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(1129, 23);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(161, 20);
            this.textBoxCountry.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ИД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1025, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Национальность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1025, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1025, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1025, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Страна";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1129, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // button_Clear_Person
            // 
            this.button_Clear_Person.Location = new System.Drawing.Point(1044, 191);
            this.button_Clear_Person.Name = "button_Clear_Person";
            this.button_Clear_Person.Size = new System.Drawing.Size(94, 23);
            this.button_Clear_Person.TabIndex = 21;
            this.button_Clear_Person.Text = "Очистить поля";
            this.button_Clear_Person.UseVisualStyleBackColor = true;
            this.button_Clear_Person.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewAccident
            // 
            this.dataGridViewAccident.AllowUserToAddRows = false;
            this.dataGridViewAccident.AllowUserToDeleteRows = false;
            this.dataGridViewAccident.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccident.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewAccident.MultiSelect = false;
            this.dataGridViewAccident.Name = "dataGridViewAccident";
            this.dataGridViewAccident.ReadOnly = true;
            this.dataGridViewAccident.RowHeadersVisible = false;
            this.dataGridViewAccident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccident.Size = new System.Drawing.Size(413, 138);
            this.dataGridViewAccident.TabIndex = 22;
            this.dataGridViewAccident.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccident_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 220);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1278, 283);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.buttonAccidentDeleteEdit);
            this.tabPage1.Controls.Add(this.buttonAccidentEditEdit);
            this.tabPage1.Controls.Add(this.buttonAccidentAddEdit);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBoxAccidentEdit);
            this.tabPage1.Controls.Add(this.dataGridViewAccidentEdit);
            this.tabPage1.Controls.Add(this.comboBoxAccidents);
            this.tabPage1.Controls.Add(this.button_Clear_Accident);
            this.tabPage1.Controls.Add(this.dateTimePicker_accident_date);
            this.tabPage1.Controls.Add(this.button_Delete_Accident);
            this.tabPage1.Controls.Add(this.button_Edit_Accident);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button_Add_Accident);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dataGridViewAccident);
            this.tabPage1.Controls.Add(this.textBox_accident_id);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1270, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Травма";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Травмы спортсмена";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(794, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Изменение травм";
            // 
            // buttonAccidentDeleteEdit
            // 
            this.buttonAccidentDeleteEdit.Location = new System.Drawing.Point(1192, 93);
            this.buttonAccidentDeleteEdit.Name = "buttonAccidentDeleteEdit";
            this.buttonAccidentDeleteEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAccidentDeleteEdit.TabIndex = 34;
            this.buttonAccidentDeleteEdit.Text = "Удалить";
            this.buttonAccidentDeleteEdit.UseVisualStyleBackColor = true;
            this.buttonAccidentDeleteEdit.Click += new System.EventHandler(this.buttonAccidentDeleteEdit_Click);
            // 
            // buttonAccidentEditEdit
            // 
            this.buttonAccidentEditEdit.Location = new System.Drawing.Point(1111, 93);
            this.buttonAccidentEditEdit.Name = "buttonAccidentEditEdit";
            this.buttonAccidentEditEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAccidentEditEdit.TabIndex = 33;
            this.buttonAccidentEditEdit.Text = "Изменить";
            this.buttonAccidentEditEdit.UseVisualStyleBackColor = true;
            this.buttonAccidentEditEdit.Click += new System.EventHandler(this.buttonAccidentEditEdit_Click);
            // 
            // buttonAccidentAddEdit
            // 
            this.buttonAccidentAddEdit.Location = new System.Drawing.Point(1030, 93);
            this.buttonAccidentAddEdit.Name = "buttonAccidentAddEdit";
            this.buttonAccidentAddEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAccidentAddEdit.TabIndex = 32;
            this.buttonAccidentAddEdit.Text = "Добавить";
            this.buttonAccidentAddEdit.UseVisualStyleBackColor = true;
            this.buttonAccidentAddEdit.Click += new System.EventHandler(this.buttonAccidentAddEdit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1030, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Травма";
            // 
            // textBoxAccidentEdit
            // 
            this.textBoxAccidentEdit.Location = new System.Drawing.Point(1082, 48);
            this.textBoxAccidentEdit.Name = "textBoxAccidentEdit";
            this.textBoxAccidentEdit.Size = new System.Drawing.Size(182, 20);
            this.textBoxAccidentEdit.TabIndex = 30;
            // 
            // dataGridViewAccidentEdit
            // 
            this.dataGridViewAccidentEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccidentEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccidentEdit.Location = new System.Drawing.Point(784, 27);
            this.dataGridViewAccidentEdit.Name = "dataGridViewAccidentEdit";
            this.dataGridViewAccidentEdit.RowHeadersVisible = false;
            this.dataGridViewAccidentEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccidentEdit.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewAccidentEdit.TabIndex = 29;
            this.dataGridViewAccidentEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccidentEdit_CellClick);
            // 
            // comboBoxAccidents
            // 
            this.comboBoxAccidents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccidents.FormattingEnabled = true;
            this.comboBoxAccidents.Location = new System.Drawing.Point(495, 49);
            this.comboBoxAccidents.Name = "comboBoxAccidents";
            this.comboBoxAccidents.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAccidents.TabIndex = 28;
            // 
            // button_Clear_Accident
            // 
            this.button_Clear_Accident.Location = new System.Drawing.Point(674, 116);
            this.button_Clear_Accident.Name = "button_Clear_Accident";
            this.button_Clear_Accident.Size = new System.Drawing.Size(94, 23);
            this.button_Clear_Accident.TabIndex = 27;
            this.button_Clear_Accident.Text = "Очистить поля";
            this.button_Clear_Accident.UseVisualStyleBackColor = true;
            this.button_Clear_Accident.Click += new System.EventHandler(this.button_Clear_Accident_Click);
            // 
            // dateTimePicker_accident_date
            // 
            this.dateTimePicker_accident_date.Location = new System.Drawing.Point(495, 76);
            this.dateTimePicker_accident_date.Name = "dateTimePicker_accident_date";
            this.dateTimePicker_accident_date.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker_accident_date.TabIndex = 25;
            // 
            // button_Delete_Accident
            // 
            this.button_Delete_Accident.Location = new System.Drawing.Point(593, 116);
            this.button_Delete_Accident.Name = "button_Delete_Accident";
            this.button_Delete_Accident.Size = new System.Drawing.Size(75, 23);
            this.button_Delete_Accident.TabIndex = 26;
            this.button_Delete_Accident.Text = "Удалить";
            this.button_Delete_Accident.UseVisualStyleBackColor = true;
            this.button_Delete_Accident.Click += new System.EventHandler(this.button_Delete_Accident_Click);
            // 
            // button_Edit_Accident
            // 
            this.button_Edit_Accident.Location = new System.Drawing.Point(512, 116);
            this.button_Edit_Accident.Name = "button_Edit_Accident";
            this.button_Edit_Accident.Size = new System.Drawing.Size(75, 23);
            this.button_Edit_Accident.TabIndex = 25;
            this.button_Edit_Accident.Text = "Изменить";
            this.button_Edit_Accident.UseVisualStyleBackColor = true;
            this.button_Edit_Accident.Click += new System.EventHandler(this.button_Edit_Accident_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Дата";
            // 
            // button_Add_Accident
            // 
            this.button_Add_Accident.Location = new System.Drawing.Point(431, 116);
            this.button_Add_Accident.Name = "button_Add_Accident";
            this.button_Add_Accident.Size = new System.Drawing.Size(75, 23);
            this.button_Add_Accident.TabIndex = 24;
            this.button_Add_Accident.Text = "Добавить";
            this.button_Add_Accident.UseVisualStyleBackColor = true;
            this.button_Add_Accident.Click += new System.EventHandler(this.button_Add_Accident_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Травма";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "ИД";
            // 
            // textBox_accident_id
            // 
            this.textBox_accident_id.Enabled = false;
            this.textBox_accident_id.Location = new System.Drawing.Point(495, 24);
            this.textBox_accident_id.Name = "textBox_accident_id";
            this.textBox_accident_id.Size = new System.Drawing.Size(161, 20);
            this.textBox_accident_id.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.comboBoxDischarge);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dataGridViewDischarge);
            this.tabPage2.Controls.Add(this.textBoxDischargeID);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.buttonAddDischarge);
            this.tabPage2.Controls.Add(this.buttonEditDischarge);
            this.tabPage2.Controls.Add(this.buttonDeleteDischarge);
            this.tabPage2.Controls.Add(this.comboBoxDischargeSportType);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1270, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Разряд";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(434, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 75;
            this.label16.Text = "Разряд";
            // 
            // comboBoxDischarge
            // 
            this.comboBoxDischarge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDischarge.FormattingEnabled = true;
            this.comboBoxDischarge.Location = new System.Drawing.Point(501, 51);
            this.comboBoxDischarge.Name = "comboBoxDischarge";
            this.comboBoxDischarge.Size = new System.Drawing.Size(161, 21);
            this.comboBoxDischarge.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "Разряды спортсмена";
            // 
            // dataGridViewDischarge
            // 
            this.dataGridViewDischarge.AllowUserToAddRows = false;
            this.dataGridViewDischarge.AllowUserToDeleteRows = false;
            this.dataGridViewDischarge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDischarge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDischarge.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewDischarge.MultiSelect = false;
            this.dataGridViewDischarge.Name = "dataGridViewDischarge";
            this.dataGridViewDischarge.ReadOnly = true;
            this.dataGridViewDischarge.RowHeadersVisible = false;
            this.dataGridViewDischarge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDischarge.Size = new System.Drawing.Size(413, 138);
            this.dataGridViewDischarge.TabIndex = 56;
            this.dataGridViewDischarge.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDischarge_CellClick);
            // 
            // textBoxDischargeID
            // 
            this.textBoxDischargeID.Enabled = false;
            this.textBoxDischargeID.Location = new System.Drawing.Point(501, 25);
            this.textBoxDischargeID.Name = "textBoxDischargeID";
            this.textBoxDischargeID.Size = new System.Drawing.Size(161, 20);
            this.textBoxDischargeID.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(434, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 60;
            this.label20.Text = "ИД";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(434, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "Вид спорта";
            // 
            // buttonAddDischarge
            // 
            this.buttonAddDischarge.Location = new System.Drawing.Point(435, 140);
            this.buttonAddDischarge.Name = "buttonAddDischarge";
            this.buttonAddDischarge.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDischarge.TabIndex = 58;
            this.buttonAddDischarge.Text = "Добавить";
            this.buttonAddDischarge.UseVisualStyleBackColor = true;
            this.buttonAddDischarge.Click += new System.EventHandler(this.buttonAddDischarge_Click);
            // 
            // buttonEditDischarge
            // 
            this.buttonEditDischarge.Location = new System.Drawing.Point(516, 140);
            this.buttonEditDischarge.Name = "buttonEditDischarge";
            this.buttonEditDischarge.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDischarge.TabIndex = 62;
            this.buttonEditDischarge.Text = "Изменить";
            this.buttonEditDischarge.UseVisualStyleBackColor = true;
            this.buttonEditDischarge.Click += new System.EventHandler(this.buttonEditDischarge_Click);
            // 
            // buttonDeleteDischarge
            // 
            this.buttonDeleteDischarge.Location = new System.Drawing.Point(597, 140);
            this.buttonDeleteDischarge.Name = "buttonDeleteDischarge";
            this.buttonDeleteDischarge.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDischarge.TabIndex = 64;
            this.buttonDeleteDischarge.Text = "Удалить";
            this.buttonDeleteDischarge.UseVisualStyleBackColor = true;
            this.buttonDeleteDischarge.Click += new System.EventHandler(this.buttonDeleteDischarge_Click);
            // 
            // comboBoxDischargeSportType
            // 
            this.comboBoxDischargeSportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDischargeSportType.FormattingEnabled = true;
            this.comboBoxDischargeSportType.Location = new System.Drawing.Point(501, 78);
            this.comboBoxDischargeSportType.Name = "comboBoxDischargeSportType";
            this.comboBoxDischargeSportType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxDischargeSportType.TabIndex = 66;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.dataGridViewTitle);
            this.tabPage3.Controls.Add(this.comboBoxTitle);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.comboBoxTitleSportType);
            this.tabPage3.Controls.Add(this.buttonTitleDelete);
            this.tabPage3.Controls.Add(this.textBoxTitleID);
            this.tabPage3.Controls.Add(this.buttonTitleEdit);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.buttonTitleAdd);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1270, 257);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Титул";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(434, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 87;
            this.label17.Text = "Титул";
            // 
            // dataGridViewTitle
            // 
            this.dataGridViewTitle.AllowUserToAddRows = false;
            this.dataGridViewTitle.AllowUserToDeleteRows = false;
            this.dataGridViewTitle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTitle.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewTitle.MultiSelect = false;
            this.dataGridViewTitle.Name = "dataGridViewTitle";
            this.dataGridViewTitle.ReadOnly = true;
            this.dataGridViewTitle.RowHeadersVisible = false;
            this.dataGridViewTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTitle.Size = new System.Drawing.Size(413, 138);
            this.dataGridViewTitle.TabIndex = 77;
            this.dataGridViewTitle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTitle_CellClick);
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(501, 54);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTitle.TabIndex = 88;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 86;
            this.label18.Text = "Титулы спортсмена";
            // 
            // comboBoxTitleSportType
            // 
            this.comboBoxTitleSportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitleSportType.FormattingEnabled = true;
            this.comboBoxTitleSportType.Location = new System.Drawing.Point(501, 81);
            this.comboBoxTitleSportType.Name = "comboBoxTitleSportType";
            this.comboBoxTitleSportType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTitleSportType.TabIndex = 85;
            // 
            // buttonTitleDelete
            // 
            this.buttonTitleDelete.Location = new System.Drawing.Point(597, 143);
            this.buttonTitleDelete.Name = "buttonTitleDelete";
            this.buttonTitleDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTitleDelete.TabIndex = 83;
            this.buttonTitleDelete.Text = "Удалить";
            this.buttonTitleDelete.UseVisualStyleBackColor = true;
            this.buttonTitleDelete.Click += new System.EventHandler(this.buttonTitleDelete_Click);
            // 
            // textBoxTitleID
            // 
            this.textBoxTitleID.Enabled = false;
            this.textBoxTitleID.Location = new System.Drawing.Point(501, 28);
            this.textBoxTitleID.Name = "textBoxTitleID";
            this.textBoxTitleID.Size = new System.Drawing.Size(161, 20);
            this.textBoxTitleID.TabIndex = 78;
            // 
            // buttonTitleEdit
            // 
            this.buttonTitleEdit.Location = new System.Drawing.Point(516, 143);
            this.buttonTitleEdit.Name = "buttonTitleEdit";
            this.buttonTitleEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTitleEdit.TabIndex = 82;
            this.buttonTitleEdit.Text = "Изменить";
            this.buttonTitleEdit.UseVisualStyleBackColor = true;
            this.buttonTitleEdit.Click += new System.EventHandler(this.buttonTitleEdit_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(434, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 13);
            this.label21.TabIndex = 80;
            this.label21.Text = "ИД";
            // 
            // buttonTitleAdd
            // 
            this.buttonTitleAdd.Location = new System.Drawing.Point(435, 143);
            this.buttonTitleAdd.Name = "buttonTitleAdd";
            this.buttonTitleAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTitleAdd.TabIndex = 79;
            this.buttonTitleAdd.Text = "Добавить";
            this.buttonTitleAdd.UseVisualStyleBackColor = true;
            this.buttonTitleAdd.Click += new System.EventHandler(this.buttonTitleAdd_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(434, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 81;
            this.label22.Text = "Вид спорта";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.dataGridViewCoach);
            this.tabPage4.Controls.Add(this.comboBoxCoach);
            this.tabPage4.Controls.Add(this.textBoxCoachID);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.dateTimePickerCoach);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.buttonCoachDelete);
            this.tabPage4.Controls.Add(this.buttonCoachAdd);
            this.tabPage4.Controls.Add(this.buttonCoachEdit);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1270, 257);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Тренер";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "Тренеры спортсмена";
            // 
            // dataGridViewCoach
            // 
            this.dataGridViewCoach.AllowUserToAddRows = false;
            this.dataGridViewCoach.AllowUserToDeleteRows = false;
            this.dataGridViewCoach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoach.Location = new System.Drawing.Point(3, 24);
            this.dataGridViewCoach.MultiSelect = false;
            this.dataGridViewCoach.Name = "dataGridViewCoach";
            this.dataGridViewCoach.ReadOnly = true;
            this.dataGridViewCoach.RowHeadersVisible = false;
            this.dataGridViewCoach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCoach.Size = new System.Drawing.Size(413, 138);
            this.dataGridViewCoach.TabIndex = 37;
            this.dataGridViewCoach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoach_CellClick);
            // 
            // comboBoxCoach
            // 
            this.comboBoxCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoach.FormattingEnabled = true;
            this.comboBoxCoach.Location = new System.Drawing.Point(492, 49);
            this.comboBoxCoach.Name = "comboBoxCoach";
            this.comboBoxCoach.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCoach.TabIndex = 47;
            // 
            // textBoxCoachID
            // 
            this.textBoxCoachID.Enabled = false;
            this.textBoxCoachID.Location = new System.Drawing.Point(492, 24);
            this.textBoxCoachID.Name = "textBoxCoachID";
            this.textBoxCoachID.Size = new System.Drawing.Size(161, 20);
            this.textBoxCoachID.TabIndex = 40;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(431, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 13);
            this.label26.TabIndex = 44;
            this.label26.Text = "ИД";
            // 
            // dateTimePickerCoach
            // 
            this.dateTimePickerCoach.Location = new System.Drawing.Point(492, 76);
            this.dateTimePickerCoach.Name = "dateTimePickerCoach";
            this.dateTimePickerCoach.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerCoach.TabIndex = 41;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(431, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 43;
            this.label25.Text = "Тренер";
            // 
            // buttonCoachDelete
            // 
            this.buttonCoachDelete.Location = new System.Drawing.Point(588, 139);
            this.buttonCoachDelete.Name = "buttonCoachDelete";
            this.buttonCoachDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCoachDelete.TabIndex = 45;
            this.buttonCoachDelete.Text = "Удалить";
            this.buttonCoachDelete.UseVisualStyleBackColor = true;
            this.buttonCoachDelete.Click += new System.EventHandler(this.buttonCoachDelete_Click);
            // 
            // buttonCoachAdd
            // 
            this.buttonCoachAdd.Location = new System.Drawing.Point(426, 139);
            this.buttonCoachAdd.Name = "buttonCoachAdd";
            this.buttonCoachAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCoachAdd.TabIndex = 39;
            this.buttonCoachAdd.Text = "Добавить";
            this.buttonCoachAdd.UseVisualStyleBackColor = true;
            this.buttonCoachAdd.Click += new System.EventHandler(this.buttonCoachAdd_Click);
            // 
            // buttonCoachEdit
            // 
            this.buttonCoachEdit.Location = new System.Drawing.Point(507, 139);
            this.buttonCoachEdit.Name = "buttonCoachEdit";
            this.buttonCoachEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCoachEdit.TabIndex = 42;
            this.buttonCoachEdit.Text = "Изменить";
            this.buttonCoachEdit.UseVisualStyleBackColor = true;
            this.buttonCoachEdit.Click += new System.EventHandler(this.buttonCoachEdit_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(431, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Дата";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.comboBoxSportTypePost);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.dateTimePickerPostEnd);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.dataGridViewPost);
            this.tabPage5.Controls.Add(this.comboBoxPost);
            this.tabPage5.Controls.Add(this.textBoxPostID);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.dateTimePickerPostStart);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.buttonPostDelete);
            this.tabPage5.Controls.Add(this.buttonPostAdd);
            this.tabPage5.Controls.Add(this.buttonPostEdit);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1270, 257);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Должность";
            // 
            // comboBoxSportTypePost
            // 
            this.comboBoxSportTypePost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSportTypePost.FormattingEnabled = true;
            this.comboBoxSportTypePost.Location = new System.Drawing.Point(704, 74);
            this.comboBoxSportTypePost.Name = "comboBoxSportTypePost";
            this.comboBoxSportTypePost.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSportTypePost.TabIndex = 52;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(626, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 13);
            this.label32.TabIndex = 51;
            this.label32.Text = "Вид спорта";
            // 
            // dateTimePickerPostEnd
            // 
            this.dateTimePickerPostEnd.Location = new System.Drawing.Point(704, 127);
            this.dateTimePickerPostEnd.Name = "dateTimePickerPostEnd";
            this.dateTimePickerPostEnd.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerPostEnd.TabIndex = 50;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(626, 129);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 13);
            this.label31.TabIndex = 49;
            this.label31.Text = "Дата конца";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(129, 13);
            this.label27.TabIndex = 48;
            this.label27.Text = "Должности спортсмена";
            // 
            // dataGridViewPost
            // 
            this.dataGridViewPost.AllowUserToAddRows = false;
            this.dataGridViewPost.AllowUserToDeleteRows = false;
            this.dataGridViewPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPost.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewPost.MultiSelect = false;
            this.dataGridViewPost.Name = "dataGridViewPost";
            this.dataGridViewPost.ReadOnly = true;
            this.dataGridViewPost.RowHeadersVisible = false;
            this.dataGridViewPost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPost.Size = new System.Drawing.Size(608, 183);
            this.dataGridViewPost.TabIndex = 37;
            this.dataGridViewPost.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPost_CellClick);
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(704, 47);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(161, 21);
            this.comboBoxPost.TabIndex = 47;
            // 
            // textBoxPostID
            // 
            this.textBoxPostID.Enabled = false;
            this.textBoxPostID.Location = new System.Drawing.Point(704, 21);
            this.textBoxPostID.Name = "textBoxPostID";
            this.textBoxPostID.Size = new System.Drawing.Size(161, 20);
            this.textBoxPostID.TabIndex = 40;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(626, 29);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 13);
            this.label30.TabIndex = 44;
            this.label30.Text = "ИД";
            // 
            // dateTimePickerPostStart
            // 
            this.dateTimePickerPostStart.Location = new System.Drawing.Point(704, 101);
            this.dateTimePickerPostStart.Name = "dateTimePickerPostStart";
            this.dateTimePickerPostStart.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerPostStart.TabIndex = 41;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(626, 55);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 13);
            this.label29.TabIndex = 43;
            this.label29.Text = "Должность";
            // 
            // buttonPostDelete
            // 
            this.buttonPostDelete.Location = new System.Drawing.Point(793, 181);
            this.buttonPostDelete.Name = "buttonPostDelete";
            this.buttonPostDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonPostDelete.TabIndex = 45;
            this.buttonPostDelete.Text = "Удалить";
            this.buttonPostDelete.UseVisualStyleBackColor = true;
            this.buttonPostDelete.Click += new System.EventHandler(this.buttonPostDelete_Click);
            // 
            // buttonPostAdd
            // 
            this.buttonPostAdd.Location = new System.Drawing.Point(631, 181);
            this.buttonPostAdd.Name = "buttonPostAdd";
            this.buttonPostAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonPostAdd.TabIndex = 39;
            this.buttonPostAdd.Text = "Добавить";
            this.buttonPostAdd.UseVisualStyleBackColor = true;
            this.buttonPostAdd.Click += new System.EventHandler(this.buttonPostAdd_Click);
            // 
            // buttonPostEdit
            // 
            this.buttonPostEdit.Location = new System.Drawing.Point(712, 181);
            this.buttonPostEdit.Name = "buttonPostEdit";
            this.buttonPostEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPostEdit.TabIndex = 42;
            this.buttonPostEdit.Text = "Изменить";
            this.buttonPostEdit.UseVisualStyleBackColor = true;
            this.buttonPostEdit.Click += new System.EventHandler(this.buttonPostEdit_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(626, 107);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 13);
            this.label28.TabIndex = 38;
            this.label28.Text = "Дата начала";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.buttonTeamEdit);
            this.tabPage6.Controls.Add(this.buttonTeamAdd);
            this.tabPage6.Controls.Add(this.buttonTeamDelete);
            this.tabPage6.Controls.Add(this.label43);
            this.tabPage6.Controls.Add(this.textBoxCityTeam);
            this.tabPage6.Controls.Add(this.label42);
            this.tabPage6.Controls.Add(this.textBoxCountryTeam);
            this.tabPage6.Controls.Add(this.textBoxTeamID);
            this.tabPage6.Controls.Add(this.label41);
            this.tabPage6.Controls.Add(this.label40);
            this.tabPage6.Controls.Add(this.textBoxTeamName);
            this.tabPage6.Controls.Add(this.label39);
            this.tabPage6.Controls.Add(this.dataGridViewTeam);
            this.tabPage6.Controls.Add(this.label33);
            this.tabPage6.Controls.Add(this.textBoxTeamReason);
            this.tabPage6.Controls.Add(this.dataGridViewTeamPeople);
            this.tabPage6.Controls.Add(this.label38);
            this.tabPage6.Controls.Add(this.dateTimePickerTeamEnd);
            this.tabPage6.Controls.Add(this.buttonTeamPeopleEdit);
            this.tabPage6.Controls.Add(this.label34);
            this.tabPage6.Controls.Add(this.buttonTeamPeopleAdd);
            this.tabPage6.Controls.Add(this.label35);
            this.tabPage6.Controls.Add(this.buttonTeamPeopleDelete);
            this.tabPage6.Controls.Add(this.label37);
            this.tabPage6.Controls.Add(this.comboBoxPeopleTeam);
            this.tabPage6.Controls.Add(this.dateTimePickerTeamStart);
            this.tabPage6.Controls.Add(this.textBoxIDTeamPeople);
            this.tabPage6.Controls.Add(this.label36);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1270, 257);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Команды";
            // 
            // dataGridViewTeamPeople
            // 
            this.dataGridViewTeamPeople.AllowUserToAddRows = false;
            this.dataGridViewTeamPeople.AllowUserToDeleteRows = false;
            this.dataGridViewTeamPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeamPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamPeople.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewTeamPeople.MultiSelect = false;
            this.dataGridViewTeamPeople.Name = "dataGridViewTeamPeople";
            this.dataGridViewTeamPeople.ReadOnly = true;
            this.dataGridViewTeamPeople.RowHeadersVisible = false;
            this.dataGridViewTeamPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeamPeople.Size = new System.Drawing.Size(456, 183);
            this.dataGridViewTeamPeople.TabIndex = 53;
            this.dataGridViewTeamPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeamPeople_CellClick);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(470, 81);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(71, 13);
            this.label38.TabIndex = 54;
            this.label38.Text = "Дата начала";
            // 
            // dateTimePickerTeamEnd
            // 
            this.dateTimePickerTeamEnd.Location = new System.Drawing.Point(548, 101);
            this.dateTimePickerTeamEnd.Name = "dateTimePickerTeamEnd";
            this.dateTimePickerTeamEnd.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerTeamEnd.TabIndex = 65;
            // 
            // buttonTeamPeopleEdit
            // 
            this.buttonTeamPeopleEdit.Location = new System.Drawing.Point(556, 182);
            this.buttonTeamPeopleEdit.Name = "buttonTeamPeopleEdit";
            this.buttonTeamPeopleEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamPeopleEdit.TabIndex = 58;
            this.buttonTeamPeopleEdit.Text = "Изменить";
            this.buttonTeamPeopleEdit.UseVisualStyleBackColor = true;
            this.buttonTeamPeopleEdit.Click += new System.EventHandler(this.buttonTeamPeopleEdit_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(470, 103);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(66, 13);
            this.label34.TabIndex = 64;
            this.label34.Text = "Дата конца";
            // 
            // buttonTeamPeopleAdd
            // 
            this.buttonTeamPeopleAdd.Location = new System.Drawing.Point(475, 182);
            this.buttonTeamPeopleAdd.Name = "buttonTeamPeopleAdd";
            this.buttonTeamPeopleAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamPeopleAdd.TabIndex = 55;
            this.buttonTeamPeopleAdd.Text = "Добавить";
            this.buttonTeamPeopleAdd.UseVisualStyleBackColor = true;
            this.buttonTeamPeopleAdd.Click += new System.EventHandler(this.buttonTeamPeopleAdd_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 5);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(118, 13);
            this.label35.TabIndex = 63;
            this.label35.Text = "Команды спортсмена";
            // 
            // buttonTeamPeopleDelete
            // 
            this.buttonTeamPeopleDelete.Location = new System.Drawing.Point(637, 182);
            this.buttonTeamPeopleDelete.Name = "buttonTeamPeopleDelete";
            this.buttonTeamPeopleDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamPeopleDelete.TabIndex = 61;
            this.buttonTeamPeopleDelete.Text = "Удалить";
            this.buttonTeamPeopleDelete.UseVisualStyleBackColor = true;
            this.buttonTeamPeopleDelete.Click += new System.EventHandler(this.buttonTeamPeopleDelete_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(470, 56);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(52, 13);
            this.label37.TabIndex = 59;
            this.label37.Text = "Команда";
            // 
            // comboBoxPeopleTeam
            // 
            this.comboBoxPeopleTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeopleTeam.FormattingEnabled = true;
            this.comboBoxPeopleTeam.Location = new System.Drawing.Point(548, 48);
            this.comboBoxPeopleTeam.Name = "comboBoxPeopleTeam";
            this.comboBoxPeopleTeam.Size = new System.Drawing.Size(161, 21);
            this.comboBoxPeopleTeam.TabIndex = 62;
            // 
            // dateTimePickerTeamStart
            // 
            this.dateTimePickerTeamStart.Location = new System.Drawing.Point(548, 75);
            this.dateTimePickerTeamStart.Name = "dateTimePickerTeamStart";
            this.dateTimePickerTeamStart.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerTeamStart.TabIndex = 57;
            // 
            // textBoxIDTeamPeople
            // 
            this.textBoxIDTeamPeople.Enabled = false;
            this.textBoxIDTeamPeople.Location = new System.Drawing.Point(548, 22);
            this.textBoxIDTeamPeople.Name = "textBoxIDTeamPeople";
            this.textBoxIDTeamPeople.Size = new System.Drawing.Size(161, 20);
            this.textBoxIDTeamPeople.TabIndex = 56;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(470, 30);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(24, 13);
            this.label36.TabIndex = 60;
            this.label36.Text = "ИД";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.label54);
            this.tabPage7.Controls.Add(this.label53);
            this.tabPage7.Controls.Add(this.label52);
            this.tabPage7.Controls.Add(this.label51);
            this.tabPage7.Controls.Add(this.label50);
            this.tabPage7.Controls.Add(this.label49);
            this.tabPage7.Controls.Add(this.dateTimePickerCompetitionEnd);
            this.tabPage7.Controls.Add(this.dateTimePickerCompetitionStart);
            this.tabPage7.Controls.Add(this.textBoxCompetitionCountry);
            this.tabPage7.Controls.Add(this.textBoxCompetitionCity);
            this.tabPage7.Controls.Add(this.textBoxCompetitionName);
            this.tabPage7.Controls.Add(this.buttonCompetitionEdit);
            this.tabPage7.Controls.Add(this.buttonCompetitionAdd);
            this.tabPage7.Controls.Add(this.buttonCompetitionDelete);
            this.tabPage7.Controls.Add(this.comboBoxPeopleCompetitionCompetition);
            this.tabPage7.Controls.Add(this.label48);
            this.tabPage7.Controls.Add(this.label47);
            this.tabPage7.Controls.Add(this.textBoxCompetitionID);
            this.tabPage7.Controls.Add(this.dataGridViewCompetition);
            this.tabPage7.Controls.Add(this.dataGridViewPeopleCompetition);
            this.tabPage7.Controls.Add(this.buttonPeopleCompetitionEdit);
            this.tabPage7.Controls.Add(this.label46);
            this.tabPage7.Controls.Add(this.buttonPeopleCompetitionAdd);
            this.tabPage7.Controls.Add(this.textBoxPeopleCompetitionID);
            this.tabPage7.Controls.Add(this.label44);
            this.tabPage7.Controls.Add(this.comboBoxPeopleCompetitionTeam);
            this.tabPage7.Controls.Add(this.buttonPeopleCompetitionDelete);
            this.tabPage7.Controls.Add(this.label45);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1270, 257);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Соревнования";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage8.Controls.Add(this.comboBoxCompetitionMedal);
            this.tabPage8.Controls.Add(this.dataGridViewAchivment);
            this.tabPage8.Controls.Add(this.label55);
            this.tabPage8.Controls.Add(this.label58);
            this.tabPage8.Controls.Add(this.buttonAchivmentDelete);
            this.tabPage8.Controls.Add(this.buttonAchivmentEdit);
            this.tabPage8.Controls.Add(this.comboBoxAchivmentCompetition);
            this.tabPage8.Controls.Add(this.label56);
            this.tabPage8.Controls.Add(this.label57);
            this.tabPage8.Controls.Add(this.buttonAchivmentAdd);
            this.tabPage8.Controls.Add(this.textBoxAchivmentID);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1270, 257);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Медали";
            // 
            // textBoxTeamReason
            // 
            this.textBoxTeamReason.Location = new System.Drawing.Point(548, 128);
            this.textBoxTeamReason.Name = "textBoxTeamReason";
            this.textBoxTeamReason.Size = new System.Drawing.Size(161, 20);
            this.textBoxTeamReason.TabIndex = 66;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(472, 128);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 13);
            this.label33.TabIndex = 67;
            this.label33.Text = "Причина";
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.AllowUserToAddRows = false;
            this.dataGridViewTeam.AllowUserToDeleteRows = false;
            this.dataGridViewTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Location = new System.Drawing.Point(732, 23);
            this.dataGridViewTeam.MultiSelect = false;
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.ReadOnly = true;
            this.dataGridViewTeam.RowHeadersVisible = false;
            this.dataGridViewTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeam.Size = new System.Drawing.Size(277, 183);
            this.dataGridViewTeam.TabIndex = 68;
            this.dataGridViewTeam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeam_CellClick);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(729, 5);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 13);
            this.label39.TabIndex = 69;
            this.label39.Text = "Команды";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1021, 55);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 13);
            this.label40.TabIndex = 71;
            this.label40.Text = "Название";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(1097, 55);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(161, 20);
            this.textBoxTeamName.TabIndex = 70;
            // 
            // textBoxTeamID
            // 
            this.textBoxTeamID.Enabled = false;
            this.textBoxTeamID.Location = new System.Drawing.Point(1097, 29);
            this.textBoxTeamID.Name = "textBoxTeamID";
            this.textBoxTeamID.Size = new System.Drawing.Size(161, 20);
            this.textBoxTeamID.TabIndex = 72;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1021, 36);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(24, 13);
            this.label41.TabIndex = 73;
            this.label41.Text = "ИД";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(1021, 81);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 13);
            this.label42.TabIndex = 75;
            this.label42.Text = "Страна";
            // 
            // textBoxCountryTeam
            // 
            this.textBoxCountryTeam.Location = new System.Drawing.Point(1097, 81);
            this.textBoxCountryTeam.Name = "textBoxCountryTeam";
            this.textBoxCountryTeam.Size = new System.Drawing.Size(161, 20);
            this.textBoxCountryTeam.TabIndex = 74;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(1021, 107);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 13);
            this.label43.TabIndex = 77;
            this.label43.Text = "Город";
            // 
            // textBoxCityTeam
            // 
            this.textBoxCityTeam.Location = new System.Drawing.Point(1097, 107);
            this.textBoxCityTeam.Name = "textBoxCityTeam";
            this.textBoxCityTeam.Size = new System.Drawing.Size(161, 20);
            this.textBoxCityTeam.TabIndex = 76;
            // 
            // buttonTeamEdit
            // 
            this.buttonTeamEdit.Location = new System.Drawing.Point(1102, 182);
            this.buttonTeamEdit.Name = "buttonTeamEdit";
            this.buttonTeamEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamEdit.TabIndex = 79;
            this.buttonTeamEdit.Text = "Изменить";
            this.buttonTeamEdit.UseVisualStyleBackColor = true;
            this.buttonTeamEdit.Click += new System.EventHandler(this.buttonTeamEdit_Click);
            // 
            // buttonTeamAdd
            // 
            this.buttonTeamAdd.Location = new System.Drawing.Point(1021, 182);
            this.buttonTeamAdd.Name = "buttonTeamAdd";
            this.buttonTeamAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamAdd.TabIndex = 78;
            this.buttonTeamAdd.Text = "Добавить";
            this.buttonTeamAdd.UseVisualStyleBackColor = true;
            this.buttonTeamAdd.Click += new System.EventHandler(this.buttonTeamAdd_Click);
            // 
            // buttonTeamDelete
            // 
            this.buttonTeamDelete.Location = new System.Drawing.Point(1183, 182);
            this.buttonTeamDelete.Name = "buttonTeamDelete";
            this.buttonTeamDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamDelete.TabIndex = 80;
            this.buttonTeamDelete.Text = "Удалить";
            this.buttonTeamDelete.UseVisualStyleBackColor = true;
            this.buttonTeamDelete.Click += new System.EventHandler(this.buttonTeamDelete_Click);
            // 
            // dataGridViewPeopleCompetition
            // 
            this.dataGridViewPeopleCompetition.AllowUserToAddRows = false;
            this.dataGridViewPeopleCompetition.AllowUserToDeleteRows = false;
            this.dataGridViewPeopleCompetition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPeopleCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeopleCompetition.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewPeopleCompetition.MultiSelect = false;
            this.dataGridViewPeopleCompetition.Name = "dataGridViewPeopleCompetition";
            this.dataGridViewPeopleCompetition.ReadOnly = true;
            this.dataGridViewPeopleCompetition.RowHeadersVisible = false;
            this.dataGridViewPeopleCompetition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeopleCompetition.Size = new System.Drawing.Size(279, 183);
            this.dataGridViewPeopleCompetition.TabIndex = 64;
            this.dataGridViewPeopleCompetition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeopleCompetition_CellClick);
            // 
            // buttonPeopleCompetitionEdit
            // 
            this.buttonPeopleCompetitionEdit.Location = new System.Drawing.Point(373, 184);
            this.buttonPeopleCompetitionEdit.Name = "buttonPeopleCompetitionEdit";
            this.buttonPeopleCompetitionEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPeopleCompetitionEdit.TabIndex = 67;
            this.buttonPeopleCompetitionEdit.Text = "Изменить";
            this.buttonPeopleCompetitionEdit.UseVisualStyleBackColor = true;
            this.buttonPeopleCompetitionEdit.Click += new System.EventHandler(this.buttonPeopleCompetitionEdit_Click);
            // 
            // buttonPeopleCompetitionAdd
            // 
            this.buttonPeopleCompetitionAdd.Location = new System.Drawing.Point(292, 184);
            this.buttonPeopleCompetitionAdd.Name = "buttonPeopleCompetitionAdd";
            this.buttonPeopleCompetitionAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonPeopleCompetitionAdd.TabIndex = 65;
            this.buttonPeopleCompetitionAdd.Text = "Добавить";
            this.buttonPeopleCompetitionAdd.UseVisualStyleBackColor = true;
            this.buttonPeopleCompetitionAdd.Click += new System.EventHandler(this.buttonPeopleCompetitionAdd_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 5);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(144, 13);
            this.label44.TabIndex = 72;
            this.label44.Text = "Соревнования спортсмена";
            // 
            // buttonPeopleCompetitionDelete
            // 
            this.buttonPeopleCompetitionDelete.Location = new System.Drawing.Point(454, 184);
            this.buttonPeopleCompetitionDelete.Name = "buttonPeopleCompetitionDelete";
            this.buttonPeopleCompetitionDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonPeopleCompetitionDelete.TabIndex = 70;
            this.buttonPeopleCompetitionDelete.Text = "Удалить";
            this.buttonPeopleCompetitionDelete.UseVisualStyleBackColor = true;
            this.buttonPeopleCompetitionDelete.Click += new System.EventHandler(this.buttonPeopleCompetitionDelete_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(287, 58);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(52, 13);
            this.label45.TabIndex = 68;
            this.label45.Text = "Команда";
            // 
            // comboBoxPeopleCompetitionTeam
            // 
            this.comboBoxPeopleCompetitionTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeopleCompetitionTeam.FormattingEnabled = true;
            this.comboBoxPeopleCompetitionTeam.Location = new System.Drawing.Point(365, 50);
            this.comboBoxPeopleCompetitionTeam.Name = "comboBoxPeopleCompetitionTeam";
            this.comboBoxPeopleCompetitionTeam.Size = new System.Drawing.Size(161, 21);
            this.comboBoxPeopleCompetitionTeam.TabIndex = 71;
            // 
            // textBoxPeopleCompetitionID
            // 
            this.textBoxPeopleCompetitionID.Enabled = false;
            this.textBoxPeopleCompetitionID.Location = new System.Drawing.Point(365, 24);
            this.textBoxPeopleCompetitionID.Name = "textBoxPeopleCompetitionID";
            this.textBoxPeopleCompetitionID.Size = new System.Drawing.Size(161, 20);
            this.textBoxPeopleCompetitionID.TabIndex = 66;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(287, 32);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(24, 13);
            this.label46.TabIndex = 69;
            this.label46.Text = "ИД";
            // 
            // dataGridViewCompetition
            // 
            this.dataGridViewCompetition.AllowUserToAddRows = false;
            this.dataGridViewCompetition.AllowUserToDeleteRows = false;
            this.dataGridViewCompetition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetition.Location = new System.Drawing.Point(535, 23);
            this.dataGridViewCompetition.MultiSelect = false;
            this.dataGridViewCompetition.Name = "dataGridViewCompetition";
            this.dataGridViewCompetition.ReadOnly = true;
            this.dataGridViewCompetition.RowHeadersVisible = false;
            this.dataGridViewCompetition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompetition.Size = new System.Drawing.Size(448, 184);
            this.dataGridViewCompetition.TabIndex = 73;
            this.dataGridViewCompetition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompetition_CellClick);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(1006, 31);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(24, 13);
            this.label47.TabIndex = 75;
            this.label47.Text = "ИД";
            // 
            // textBoxCompetitionID
            // 
            this.textBoxCompetitionID.Enabled = false;
            this.textBoxCompetitionID.Location = new System.Drawing.Point(1084, 23);
            this.textBoxCompetitionID.Name = "textBoxCompetitionID";
            this.textBoxCompetitionID.Size = new System.Drawing.Size(161, 20);
            this.textBoxCompetitionID.TabIndex = 74;
            // 
            // comboBoxPeopleCompetitionCompetition
            // 
            this.comboBoxPeopleCompetitionCompetition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeopleCompetitionCompetition.FormattingEnabled = true;
            this.comboBoxPeopleCompetitionCompetition.Location = new System.Drawing.Point(365, 77);
            this.comboBoxPeopleCompetitionCompetition.Name = "comboBoxPeopleCompetitionCompetition";
            this.comboBoxPeopleCompetitionCompetition.Size = new System.Drawing.Size(161, 21);
            this.comboBoxPeopleCompetitionCompetition.TabIndex = 77;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(287, 80);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(80, 13);
            this.label48.TabIndex = 76;
            this.label48.Text = "Соревнования";
            // 
            // buttonCompetitionEdit
            // 
            this.buttonCompetitionEdit.Location = new System.Drawing.Point(1089, 183);
            this.buttonCompetitionEdit.Name = "buttonCompetitionEdit";
            this.buttonCompetitionEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCompetitionEdit.TabIndex = 79;
            this.buttonCompetitionEdit.Text = "Изменить";
            this.buttonCompetitionEdit.UseVisualStyleBackColor = true;
            this.buttonCompetitionEdit.Click += new System.EventHandler(this.buttonCompetitionEdit_Click);
            // 
            // buttonCompetitionAdd
            // 
            this.buttonCompetitionAdd.Location = new System.Drawing.Point(1008, 183);
            this.buttonCompetitionAdd.Name = "buttonCompetitionAdd";
            this.buttonCompetitionAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCompetitionAdd.TabIndex = 78;
            this.buttonCompetitionAdd.Text = "Добавить";
            this.buttonCompetitionAdd.UseVisualStyleBackColor = true;
            this.buttonCompetitionAdd.Click += new System.EventHandler(this.buttonCompetitionAdd_Click);
            // 
            // buttonCompetitionDelete
            // 
            this.buttonCompetitionDelete.Location = new System.Drawing.Point(1170, 183);
            this.buttonCompetitionDelete.Name = "buttonCompetitionDelete";
            this.buttonCompetitionDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCompetitionDelete.TabIndex = 80;
            this.buttonCompetitionDelete.Text = "Удалить";
            this.buttonCompetitionDelete.UseVisualStyleBackColor = true;
            this.buttonCompetitionDelete.Click += new System.EventHandler(this.buttonCompetitionDelete_Click);
            // 
            // textBoxCompetitionName
            // 
            this.textBoxCompetitionName.Location = new System.Drawing.Point(1084, 49);
            this.textBoxCompetitionName.Name = "textBoxCompetitionName";
            this.textBoxCompetitionName.Size = new System.Drawing.Size(161, 20);
            this.textBoxCompetitionName.TabIndex = 81;
            // 
            // textBoxCompetitionCity
            // 
            this.textBoxCompetitionCity.Location = new System.Drawing.Point(1084, 75);
            this.textBoxCompetitionCity.Name = "textBoxCompetitionCity";
            this.textBoxCompetitionCity.Size = new System.Drawing.Size(161, 20);
            this.textBoxCompetitionCity.TabIndex = 82;
            // 
            // textBoxCompetitionCountry
            // 
            this.textBoxCompetitionCountry.Location = new System.Drawing.Point(1084, 101);
            this.textBoxCompetitionCountry.Name = "textBoxCompetitionCountry";
            this.textBoxCompetitionCountry.Size = new System.Drawing.Size(161, 20);
            this.textBoxCompetitionCountry.TabIndex = 83;
            // 
            // dateTimePickerCompetitionStart
            // 
            this.dateTimePickerCompetitionStart.Location = new System.Drawing.Point(1084, 127);
            this.dateTimePickerCompetitionStart.Name = "dateTimePickerCompetitionStart";
            this.dateTimePickerCompetitionStart.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerCompetitionStart.TabIndex = 84;
            // 
            // dateTimePickerCompetitionEnd
            // 
            this.dateTimePickerCompetitionEnd.Location = new System.Drawing.Point(1084, 153);
            this.dateTimePickerCompetitionEnd.Name = "dateTimePickerCompetitionEnd";
            this.dateTimePickerCompetitionEnd.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerCompetitionEnd.TabIndex = 85;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(1006, 53);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(57, 13);
            this.label49.TabIndex = 86;
            this.label49.Text = "Название";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(1006, 78);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(37, 13);
            this.label50.TabIndex = 87;
            this.label50.Text = "Город";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(1006, 101);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(43, 13);
            this.label51.TabIndex = 88;
            this.label51.Text = "Страна";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(1006, 127);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(71, 13);
            this.label52.TabIndex = 89;
            this.label52.Text = "Дата начала";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(1006, 153);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(66, 13);
            this.label53.TabIndex = 90;
            this.label53.Text = "Дата конца";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(532, 7);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(80, 13);
            this.label54.TabIndex = 91;
            this.label54.Text = "Соревнования";
            // 
            // comboBoxCompetitionMedal
            // 
            this.comboBoxCompetitionMedal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetitionMedal.FormattingEnabled = true;
            this.comboBoxCompetitionMedal.Location = new System.Drawing.Point(365, 76);
            this.comboBoxCompetitionMedal.Name = "comboBoxCompetitionMedal";
            this.comboBoxCompetitionMedal.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCompetitionMedal.TabIndex = 88;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(287, 79);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(46, 13);
            this.label55.TabIndex = 87;
            this.label55.Text = "Медаль";
            // 
            // dataGridViewAchivment
            // 
            this.dataGridViewAchivment.AllowUserToAddRows = false;
            this.dataGridViewAchivment.AllowUserToDeleteRows = false;
            this.dataGridViewAchivment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAchivment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAchivment.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewAchivment.MultiSelect = false;
            this.dataGridViewAchivment.Name = "dataGridViewAchivment";
            this.dataGridViewAchivment.ReadOnly = true;
            this.dataGridViewAchivment.RowHeadersVisible = false;
            this.dataGridViewAchivment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAchivment.Size = new System.Drawing.Size(279, 183);
            this.dataGridViewAchivment.TabIndex = 78;
            this.dataGridViewAchivment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAchivment_CellClick);
            // 
            // buttonAchivmentEdit
            // 
            this.buttonAchivmentEdit.Location = new System.Drawing.Point(373, 183);
            this.buttonAchivmentEdit.Name = "buttonAchivmentEdit";
            this.buttonAchivmentEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAchivmentEdit.TabIndex = 81;
            this.buttonAchivmentEdit.Text = "Изменить";
            this.buttonAchivmentEdit.UseVisualStyleBackColor = true;
            this.buttonAchivmentEdit.Click += new System.EventHandler(this.buttonAchivmentEdit_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(287, 31);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(24, 13);
            this.label56.TabIndex = 83;
            this.label56.Text = "ИД";
            // 
            // buttonAchivmentAdd
            // 
            this.buttonAchivmentAdd.Location = new System.Drawing.Point(292, 183);
            this.buttonAchivmentAdd.Name = "buttonAchivmentAdd";
            this.buttonAchivmentAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAchivmentAdd.TabIndex = 79;
            this.buttonAchivmentAdd.Text = "Добавить";
            this.buttonAchivmentAdd.UseVisualStyleBackColor = true;
            this.buttonAchivmentAdd.Click += new System.EventHandler(this.buttonAchivmentAdd_Click);
            // 
            // textBoxAchivmentID
            // 
            this.textBoxAchivmentID.Enabled = false;
            this.textBoxAchivmentID.Location = new System.Drawing.Point(365, 23);
            this.textBoxAchivmentID.Name = "textBoxAchivmentID";
            this.textBoxAchivmentID.Size = new System.Drawing.Size(161, 20);
            this.textBoxAchivmentID.TabIndex = 80;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(3, 4);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(112, 13);
            this.label57.TabIndex = 86;
            this.label57.Text = "Заслуги спортсмена";
            // 
            // comboBoxAchivmentCompetition
            // 
            this.comboBoxAchivmentCompetition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAchivmentCompetition.FormattingEnabled = true;
            this.comboBoxAchivmentCompetition.Location = new System.Drawing.Point(365, 49);
            this.comboBoxAchivmentCompetition.Name = "comboBoxAchivmentCompetition";
            this.comboBoxAchivmentCompetition.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAchivmentCompetition.TabIndex = 85;
            // 
            // buttonAchivmentDelete
            // 
            this.buttonAchivmentDelete.Location = new System.Drawing.Point(454, 183);
            this.buttonAchivmentDelete.Name = "buttonAchivmentDelete";
            this.buttonAchivmentDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonAchivmentDelete.TabIndex = 84;
            this.buttonAchivmentDelete.Text = "Удалить";
            this.buttonAchivmentDelete.UseVisualStyleBackColor = true;
            this.buttonAchivmentDelete.Click += new System.EventHandler(this.buttonAchivmentDelete_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(287, 57);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(80, 13);
            this.label58.TabIndex = 82;
            this.label58.Text = "Соревнование";
            // 
            // PeopleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_Clear_Person);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNatianality);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.button_Delete_Person);
            this.Controls.Add(this.button_Edit_Person);
            this.Controls.Add(this.button_Add_Person);
            this.Controls.Add(this.dataGridViewPeople);
            this.Name = "PeopleAdd";
            this.Text = "Спорт";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccident)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccidentEdit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDischarge)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitle)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoach)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPost)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamPeople)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleCompetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchivment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private Button button_Add_Person;
        private Button button_Edit_Person;
        private Button button_Delete_Person;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPatronymic;
        private TextBox textBoxNatianality;
        private TextBox textBoxCity;
        private TextBox textBoxCountry;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button button_Clear_Person;
        private DataGridView dataGridViewAccident;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DateTimePicker dateTimePicker_accident_date;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox_accident_id;
        private Button button_Clear_Accident;
        private Button button_Delete_Accident;
        private Button button_Edit_Accident;
        private Button button_Add_Accident;
        private ComboBox comboBoxAccidents;
        private Button buttonAccidentDeleteEdit;
        private Button buttonAccidentEditEdit;
        private Button buttonAccidentAddEdit;
        private Label label12;
        private TextBox textBoxAccidentEdit;
        private DataGridView dataGridViewAccidentEdit;
        private Label label13;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label14;
        private Label label16;
        private ComboBox comboBoxDischarge;
        private Label label15;
        private DataGridView dataGridViewDischarge;
        private TextBox textBoxDischargeID;
        private Label label20;
        private Label label19;
        private Button buttonAddDischarge;
        private Button buttonEditDischarge;
        private Button buttonDeleteDischarge;
        private ComboBox comboBoxDischargeSportType;
        private Label label17;
        private DataGridView dataGridViewTitle;
        private ComboBox comboBoxTitle;
        private Label label18;
        private ComboBox comboBoxTitleSportType;
        private Button buttonTitleDelete;
        private TextBox textBoxTitleID;
        private Button buttonTitleEdit;
        private Label label21;
        private Button buttonTitleAdd;
        private Label label22;
        private Label label23;
        private DataGridView dataGridViewCoach;
        private ComboBox comboBoxCoach;
        private TextBox textBoxCoachID;
        private Label label26;
        private DateTimePicker dateTimePickerCoach;
        private Label label25;
        private Button buttonCoachDelete;
        private Button buttonCoachAdd;
        private Button buttonCoachEdit;
        private Label label24;
        private ComboBox comboBoxSportTypePost;
        private Label label32;
        private DateTimePicker dateTimePickerPostEnd;
        private Label label31;
        private Label label27;
        private DataGridView dataGridViewPost;
        private ComboBox comboBoxPost;
        private TextBox textBoxPostID;
        private Label label30;
        private DateTimePicker dateTimePickerPostStart;
        private Label label29;
        private Button buttonPostDelete;
        private Button buttonPostAdd;
        private Button buttonPostEdit;
        private Label label28;
        private TabPage tabPage6;
        private DataGridView dataGridViewTeamPeople;
        private Label label38;
        private DateTimePicker dateTimePickerTeamEnd;
        private Button buttonTeamPeopleEdit;
        private Label label34;
        private Button buttonTeamPeopleAdd;
        private Label label35;
        private Button buttonTeamPeopleDelete;
        private Label label37;
        private ComboBox comboBoxPeopleTeam;
        private DateTimePicker dateTimePickerTeamStart;
        private TextBox textBoxIDTeamPeople;
        private Label label36;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Label label43;
        private TextBox textBoxCityTeam;
        private Label label42;
        private TextBox textBoxCountryTeam;
        private TextBox textBoxTeamID;
        private Label label41;
        private Label label40;
        private TextBox textBoxTeamName;
        private Label label39;
        private DataGridView dataGridViewTeam;
        private Label label33;
        private TextBox textBoxTeamReason;
        private Button buttonTeamEdit;
        private Button buttonTeamAdd;
        private Button buttonTeamDelete;
        private Label label52;
        private Label label51;
        private Label label50;
        private Label label49;
        private DateTimePicker dateTimePickerCompetitionEnd;
        private DateTimePicker dateTimePickerCompetitionStart;
        private TextBox textBoxCompetitionCountry;
        private TextBox textBoxCompetitionCity;
        private TextBox textBoxCompetitionName;
        private Button buttonCompetitionEdit;
        private Button buttonCompetitionAdd;
        private Button buttonCompetitionDelete;
        private ComboBox comboBoxPeopleCompetitionCompetition;
        private Label label48;
        private Label label47;
        private TextBox textBoxCompetitionID;
        private DataGridView dataGridViewCompetition;
        private DataGridView dataGridViewPeopleCompetition;
        private Button buttonPeopleCompetitionEdit;
        private Label label46;
        private Button buttonPeopleCompetitionAdd;
        private TextBox textBoxPeopleCompetitionID;
        private Label label44;
        private ComboBox comboBoxPeopleCompetitionTeam;
        private Button buttonPeopleCompetitionDelete;
        private Label label45;
        private Label label54;
        private Label label53;
        private ComboBox comboBoxCompetitionMedal;
        private DataGridView dataGridViewAchivment;
        private Label label55;
        private Label label58;
        private Button buttonAchivmentDelete;
        private Button buttonAchivmentEdit;
        private ComboBox comboBoxAchivmentCompetition;
        private Label label56;
        private Label label57;
        private Button buttonAchivmentAdd;
        private TextBox textBoxAchivmentID;
    }
}