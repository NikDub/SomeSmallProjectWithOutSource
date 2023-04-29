namespace GroupAndSonger
{
    partial class ToursForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTour = new System.Windows.Forms.DataGridView();
            this.dataGridViewTourSong = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTourStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTourDelete = new System.Windows.Forms.Button();
            this.buttonTourEdit = new System.Windows.Forms.Button();
            this.buttonTourAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTourSong = new System.Windows.Forms.ComboBox();
            this.buttonTourSongDelete = new System.Windows.Forms.Button();
            this.buttonTourSongEdit = new System.Windows.Forms.Button();
            this.buttonTourSongAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCountry = new System.Windows.Forms.DataGridView();
            this.buttonCountryDelete = new System.Windows.Forms.Button();
            this.buttonCountryEdit = new System.Windows.Forms.Button();
            this.buttonCountryAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewPlace = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTicketDelete = new System.Windows.Forms.Button();
            this.buttonTicketEdit = new System.Windows.Forms.Button();
            this.buttonTicketAdd = new System.Windows.Forms.Button();
            this.buttonPlaceDelete = new System.Windows.Forms.Button();
            this.buttonPlaceEdit = new System.Windows.Forms.Button();
            this.buttonPlaceAdd = new System.Windows.Forms.Button();
            this.comboBoxTicketPlace = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerTicketStart = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerTicketEnd = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownTicketCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTicketCost = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPlaceLocation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownPlaceCapasity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPlaceCountry = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDownPlaceCostTicket = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDownTicketSumm = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaceCapasity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaceCostTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketSumm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Туры группы";
            // 
            // dataGridViewTour
            // 
            this.dataGridViewTour.AllowUserToAddRows = false;
            this.dataGridViewTour.AllowUserToDeleteRows = false;
            this.dataGridViewTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTour.Location = new System.Drawing.Point(12, 24);
            this.dataGridViewTour.MultiSelect = false;
            this.dataGridViewTour.Name = "dataGridViewTour";
            this.dataGridViewTour.ReadOnly = true;
            this.dataGridViewTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTour.Size = new System.Drawing.Size(259, 176);
            this.dataGridViewTour.TabIndex = 2;
            this.dataGridViewTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTour_CellClick);
            // 
            // dataGridViewTourSong
            // 
            this.dataGridViewTourSong.AllowUserToAddRows = false;
            this.dataGridViewTourSong.AllowUserToDeleteRows = false;
            this.dataGridViewTourSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTourSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourSong.Location = new System.Drawing.Point(497, 24);
            this.dataGridViewTourSong.MultiSelect = false;
            this.dataGridViewTourSong.Name = "dataGridViewTourSong";
            this.dataGridViewTourSong.ReadOnly = true;
            this.dataGridViewTourSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTourSong.Size = new System.Drawing.Size(261, 176);
            this.dataGridViewTourSong.TabIndex = 4;
            this.dataGridViewTourSong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTourSong_CellClick);
            // 
            // dateTimePickerTourStart
            // 
            this.dateTimePickerTourStart.Location = new System.Drawing.Point(277, 44);
            this.dateTimePickerTourStart.Name = "dateTimePickerTourStart";
            this.dateTimePickerTourStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTourStart.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата начала";
            // 
            // buttonTourDelete
            // 
            this.buttonTourDelete.Location = new System.Drawing.Point(327, 177);
            this.buttonTourDelete.Name = "buttonTourDelete";
            this.buttonTourDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTourDelete.TabIndex = 18;
            this.buttonTourDelete.Text = "Удалить";
            this.buttonTourDelete.UseVisualStyleBackColor = true;
            this.buttonTourDelete.Click += new System.EventHandler(this.buttonTourDelete_Click);
            // 
            // buttonTourEdit
            // 
            this.buttonTourEdit.Location = new System.Drawing.Point(327, 148);
            this.buttonTourEdit.Name = "buttonTourEdit";
            this.buttonTourEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTourEdit.TabIndex = 17;
            this.buttonTourEdit.Text = "Изменить";
            this.buttonTourEdit.UseVisualStyleBackColor = true;
            this.buttonTourEdit.Click += new System.EventHandler(this.buttonTourEdit_Click);
            // 
            // buttonTourAdd
            // 
            this.buttonTourAdd.Location = new System.Drawing.Point(327, 119);
            this.buttonTourAdd.Name = "buttonTourAdd";
            this.buttonTourAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTourAdd.TabIndex = 16;
            this.buttonTourAdd.Text = "Добавить";
            this.buttonTourAdd.UseVisualStyleBackColor = true;
            this.buttonTourAdd.Click += new System.EventHandler(this.buttonTourAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Исполняемые песни в туре";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Песня";
            // 
            // comboBoxTourSong
            // 
            this.comboBoxTourSong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTourSong.FormattingEnabled = true;
            this.comboBoxTourSong.Location = new System.Drawing.Point(778, 43);
            this.comboBoxTourSong.Name = "comboBoxTourSong";
            this.comboBoxTourSong.Size = new System.Drawing.Size(199, 21);
            this.comboBoxTourSong.TabIndex = 48;
            // 
            // buttonTourSongDelete
            // 
            this.buttonTourSongDelete.Location = new System.Drawing.Point(843, 177);
            this.buttonTourSongDelete.Name = "buttonTourSongDelete";
            this.buttonTourSongDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTourSongDelete.TabIndex = 51;
            this.buttonTourSongDelete.Text = "Удалить";
            this.buttonTourSongDelete.UseVisualStyleBackColor = true;
            this.buttonTourSongDelete.Click += new System.EventHandler(this.buttonTourSongDelete_Click);
            // 
            // buttonTourSongEdit
            // 
            this.buttonTourSongEdit.Location = new System.Drawing.Point(843, 148);
            this.buttonTourSongEdit.Name = "buttonTourSongEdit";
            this.buttonTourSongEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTourSongEdit.TabIndex = 50;
            this.buttonTourSongEdit.Text = "Изменить";
            this.buttonTourSongEdit.UseVisualStyleBackColor = true;
            this.buttonTourSongEdit.Click += new System.EventHandler(this.buttonTourSongEdit_Click);
            // 
            // buttonTourSongAdd
            // 
            this.buttonTourSongAdd.Location = new System.Drawing.Point(843, 119);
            this.buttonTourSongAdd.Name = "buttonTourSongAdd";
            this.buttonTourSongAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTourSongAdd.TabIndex = 49;
            this.buttonTourSongAdd.Text = "Добавить";
            this.buttonTourSongAdd.UseVisualStyleBackColor = true;
            this.buttonTourSongAdd.Click += new System.EventHandler(this.buttonTourSongAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1006, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Страны";
            // 
            // dataGridViewCountry
            // 
            this.dataGridViewCountry.AllowUserToAddRows = false;
            this.dataGridViewCountry.AllowUserToDeleteRows = false;
            this.dataGridViewCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountry.Location = new System.Drawing.Point(1009, 24);
            this.dataGridViewCountry.MultiSelect = false;
            this.dataGridViewCountry.Name = "dataGridViewCountry";
            this.dataGridViewCountry.ReadOnly = true;
            this.dataGridViewCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountry.Size = new System.Drawing.Size(261, 176);
            this.dataGridViewCountry.TabIndex = 52;
            this.dataGridViewCountry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountry_CellClick);
            // 
            // buttonCountryDelete
            // 
            this.buttonCountryDelete.Location = new System.Drawing.Point(1370, 177);
            this.buttonCountryDelete.Name = "buttonCountryDelete";
            this.buttonCountryDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCountryDelete.TabIndex = 56;
            this.buttonCountryDelete.Text = "Удалить";
            this.buttonCountryDelete.UseVisualStyleBackColor = true;
            this.buttonCountryDelete.Click += new System.EventHandler(this.buttonCountryDelete_Click);
            // 
            // buttonCountryEdit
            // 
            this.buttonCountryEdit.Location = new System.Drawing.Point(1370, 148);
            this.buttonCountryEdit.Name = "buttonCountryEdit";
            this.buttonCountryEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCountryEdit.TabIndex = 55;
            this.buttonCountryEdit.Text = "Изменить";
            this.buttonCountryEdit.UseVisualStyleBackColor = true;
            this.buttonCountryEdit.Click += new System.EventHandler(this.buttonCountryEdit_Click);
            // 
            // buttonCountryAdd
            // 
            this.buttonCountryAdd.Location = new System.Drawing.Point(1370, 119);
            this.buttonCountryAdd.Name = "buttonCountryAdd";
            this.buttonCountryAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCountryAdd.TabIndex = 54;
            this.buttonCountryAdd.Text = "Добавить";
            this.buttonCountryAdd.UseVisualStyleBackColor = true;
            this.buttonCountryAdd.Click += new System.EventHandler(this.buttonCountryAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1286, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Название страны";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(1289, 44);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(224, 20);
            this.textBoxCountryName.TabIndex = 58;
            // 
            // dataGridViewTicket
            // 
            this.dataGridViewTicket.AllowUserToAddRows = false;
            this.dataGridViewTicket.AllowUserToDeleteRows = false;
            this.dataGridViewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicket.Location = new System.Drawing.Point(12, 259);
            this.dataGridViewTicket.MultiSelect = false;
            this.dataGridViewTicket.Name = "dataGridViewTicket";
            this.dataGridViewTicket.ReadOnly = true;
            this.dataGridViewTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTicket.Size = new System.Drawing.Size(746, 176);
            this.dataGridViewTicket.TabIndex = 59;
            this.dataGridViewTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTicket_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Выступления";
            // 
            // dataGridViewPlace
            // 
            this.dataGridViewPlace.AllowUserToAddRows = false;
            this.dataGridViewPlace.AllowUserToDeleteRows = false;
            this.dataGridViewPlace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlace.Location = new System.Drawing.Point(778, 259);
            this.dataGridViewPlace.MultiSelect = false;
            this.dataGridViewPlace.Name = "dataGridViewPlace";
            this.dataGridViewPlace.ReadOnly = true;
            this.dataGridViewPlace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlace.Size = new System.Drawing.Size(735, 176);
            this.dataGridViewPlace.TabIndex = 61;
            this.dataGridViewPlace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlace_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(775, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Место";
            // 
            // buttonTicketDelete
            // 
            this.buttonTicketDelete.Location = new System.Drawing.Point(683, 507);
            this.buttonTicketDelete.Name = "buttonTicketDelete";
            this.buttonTicketDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTicketDelete.TabIndex = 65;
            this.buttonTicketDelete.Text = "Удалить";
            this.buttonTicketDelete.UseVisualStyleBackColor = true;
            this.buttonTicketDelete.Click += new System.EventHandler(this.buttonTicketDelete_Click);
            // 
            // buttonTicketEdit
            // 
            this.buttonTicketEdit.Location = new System.Drawing.Point(683, 478);
            this.buttonTicketEdit.Name = "buttonTicketEdit";
            this.buttonTicketEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTicketEdit.TabIndex = 64;
            this.buttonTicketEdit.Text = "Изменить";
            this.buttonTicketEdit.UseVisualStyleBackColor = true;
            this.buttonTicketEdit.Click += new System.EventHandler(this.buttonTicketEdit_Click);
            // 
            // buttonTicketAdd
            // 
            this.buttonTicketAdd.Location = new System.Drawing.Point(683, 449);
            this.buttonTicketAdd.Name = "buttonTicketAdd";
            this.buttonTicketAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTicketAdd.TabIndex = 63;
            this.buttonTicketAdd.Text = "Добавить";
            this.buttonTicketAdd.UseVisualStyleBackColor = true;
            this.buttonTicketAdd.Click += new System.EventHandler(this.buttonTicketAdd_Click);
            // 
            // buttonPlaceDelete
            // 
            this.buttonPlaceDelete.Location = new System.Drawing.Point(1438, 507);
            this.buttonPlaceDelete.Name = "buttonPlaceDelete";
            this.buttonPlaceDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaceDelete.TabIndex = 68;
            this.buttonPlaceDelete.Text = "Удалить";
            this.buttonPlaceDelete.UseVisualStyleBackColor = true;
            this.buttonPlaceDelete.Click += new System.EventHandler(this.buttonPlaceDelete_Click);
            // 
            // buttonPlaceEdit
            // 
            this.buttonPlaceEdit.Location = new System.Drawing.Point(1438, 478);
            this.buttonPlaceEdit.Name = "buttonPlaceEdit";
            this.buttonPlaceEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaceEdit.TabIndex = 67;
            this.buttonPlaceEdit.Text = "Изменить";
            this.buttonPlaceEdit.UseVisualStyleBackColor = true;
            this.buttonPlaceEdit.Click += new System.EventHandler(this.buttonPlaceEdit_Click);
            // 
            // buttonPlaceAdd
            // 
            this.buttonPlaceAdd.Location = new System.Drawing.Point(1438, 449);
            this.buttonPlaceAdd.Name = "buttonPlaceAdd";
            this.buttonPlaceAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaceAdd.TabIndex = 66;
            this.buttonPlaceAdd.Text = "Добавить";
            this.buttonPlaceAdd.UseVisualStyleBackColor = true;
            this.buttonPlaceAdd.Click += new System.EventHandler(this.buttonPlaceAdd_Click);
            // 
            // comboBoxTicketPlace
            // 
            this.comboBoxTicketPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTicketPlace.FormattingEnabled = true;
            this.comboBoxTicketPlace.Location = new System.Drawing.Point(12, 462);
            this.comboBoxTicketPlace.Name = "comboBoxTicketPlace";
            this.comboBoxTicketPlace.Size = new System.Drawing.Size(199, 21);
            this.comboBoxTicketPlace.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Место";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Дата начала";
            // 
            // dateTimePickerTicketStart
            // 
            this.dateTimePickerTicketStart.Location = new System.Drawing.Point(11, 506);
            this.dateTimePickerTicketStart.Name = "dateTimePickerTicketStart";
            this.dateTimePickerTicketStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTicketStart.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Дата окончания";
            // 
            // dateTimePickerTicketEnd
            // 
            this.dateTimePickerTicketEnd.Location = new System.Drawing.Point(11, 549);
            this.dateTimePickerTicketEnd.Name = "dateTimePickerTicketEnd";
            this.dateTimePickerTicketEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTicketEnd.TabIndex = 73;
            // 
            // numericUpDownTicketCount
            // 
            this.numericUpDownTicketCount.Location = new System.Drawing.Point(327, 462);
            this.numericUpDownTicketCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownTicketCount.Name = "numericUpDownTicketCount";
            this.numericUpDownTicketCount.Size = new System.Drawing.Size(224, 20);
            this.numericUpDownTicketCount.TabIndex = 75;
            this.numericUpDownTicketCount.ValueChanged += new System.EventHandler(this.numericUpDownCost_ValueChanged);
            // 
            // numericUpDownTicketCost
            // 
            this.numericUpDownTicketCost.Location = new System.Drawing.Point(327, 506);
            this.numericUpDownTicketCost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownTicketCost.Name = "numericUpDownTicketCost";
            this.numericUpDownTicketCost.Size = new System.Drawing.Size(224, 20);
            this.numericUpDownTicketCost.TabIndex = 76;
            this.numericUpDownTicketCost.ValueChanged += new System.EventHandler(this.numericUpDownCost_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(324, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Количество билетов";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Стоимость билета";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 536);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Суммарная стоимость билетов";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(775, 445);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Название места";
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Location = new System.Drawing.Point(778, 461);
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(224, 20);
            this.textBoxPlaceName.TabIndex = 81;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(775, 489);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 84;
            this.label16.Text = "Название локации";
            // 
            // textBoxPlaceLocation
            // 
            this.textBoxPlaceLocation.Location = new System.Drawing.Point(778, 505);
            this.textBoxPlaceLocation.Name = "textBoxPlaceLocation";
            this.textBoxPlaceLocation.Size = new System.Drawing.Size(224, 20);
            this.textBoxPlaceLocation.TabIndex = 83;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(775, 533);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 86;
            this.label17.Text = "Вместимость";
            // 
            // numericUpDownPlaceCapasity
            // 
            this.numericUpDownPlaceCapasity.Location = new System.Drawing.Point(778, 549);
            this.numericUpDownPlaceCapasity.Maximum = new decimal(new int[] {
            int.MaxValue,
            0,
            0,
            0});
            this.numericUpDownPlaceCapasity.Name = "numericUpDownPlaceCapasity";
            this.numericUpDownPlaceCapasity.Size = new System.Drawing.Size(224, 20);
            this.numericUpDownPlaceCapasity.TabIndex = 87;
            // 
            // comboBoxPlaceCountry
            // 
            this.comboBoxPlaceCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlaceCountry.FormattingEnabled = true;
            this.comboBoxPlaceCountry.Location = new System.Drawing.Point(1041, 460);
            this.comboBoxPlaceCountry.Name = "comboBoxPlaceCountry";
            this.comboBoxPlaceCountry.Size = new System.Drawing.Size(199, 21);
            this.comboBoxPlaceCountry.TabIndex = 89;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1038, 440);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Страна";
            // 
            // numericUpDownPlaceCostTicket
            // 
            this.numericUpDownPlaceCostTicket.Location = new System.Drawing.Point(1041, 549);
            this.numericUpDownPlaceCostTicket.Maximum = new decimal(new int[] {
            int.MaxValue,
            0,
            0,
            0});
            this.numericUpDownPlaceCostTicket.Name = "numericUpDownPlaceCostTicket";
            this.numericUpDownPlaceCostTicket.Size = new System.Drawing.Size(199, 20);
            this.numericUpDownPlaceCostTicket.TabIndex = 91;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1038, 533);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 90;
            this.label19.Text = "Стоимость билета";
            // 
            // numericUpDownTicketSumm
            // 
            this.numericUpDownTicketSumm.Enabled = false;
            this.numericUpDownTicketSumm.Location = new System.Drawing.Point(327, 553);
            this.numericUpDownTicketSumm.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownTicketSumm.Name = "numericUpDownTicketSumm";
            this.numericUpDownTicketSumm.Size = new System.Drawing.Size(224, 20);
            this.numericUpDownTicketSumm.TabIndex = 92;
            // 
            // ToursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 581);
            this.Controls.Add(this.numericUpDownTicketSumm);
            this.Controls.Add(this.numericUpDownPlaceCostTicket);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBoxPlaceCountry);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericUpDownPlaceCapasity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxPlaceLocation);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxPlaceName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownTicketCost);
            this.Controls.Add(this.numericUpDownTicketCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerTicketEnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerTicketStart);
            this.Controls.Add(this.comboBoxTicketPlace);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonPlaceDelete);
            this.Controls.Add(this.buttonPlaceEdit);
            this.Controls.Add(this.buttonPlaceAdd);
            this.Controls.Add(this.buttonTicketDelete);
            this.Controls.Add(this.buttonTicketEdit);
            this.Controls.Add(this.buttonTicketAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewPlace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewTicket);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCountryDelete);
            this.Controls.Add(this.buttonCountryEdit);
            this.Controls.Add(this.buttonCountryAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewCountry);
            this.Controls.Add(this.buttonTourSongDelete);
            this.Controls.Add(this.buttonTourSongEdit);
            this.Controls.Add(this.buttonTourSongAdd);
            this.Controls.Add(this.comboBoxTourSong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTourDelete);
            this.Controls.Add(this.buttonTourEdit);
            this.Controls.Add(this.buttonTourAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerTourStart);
            this.Controls.Add(this.dataGridViewTourSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTour);
            this.Name = "ToursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выступления";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaceCapasity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaceCostTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicketSumm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTour;
        private System.Windows.Forms.DataGridView dataGridViewTourSong;
        private System.Windows.Forms.DateTimePicker dateTimePickerTourStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTourDelete;
        private System.Windows.Forms.Button buttonTourEdit;
        private System.Windows.Forms.Button buttonTourAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTourSong;
        private System.Windows.Forms.Button buttonTourSongDelete;
        private System.Windows.Forms.Button buttonTourSongEdit;
        private System.Windows.Forms.Button buttonTourSongAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCountry;
        private System.Windows.Forms.Button buttonCountryDelete;
        private System.Windows.Forms.Button buttonCountryEdit;
        private System.Windows.Forms.Button buttonCountryAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.DataGridView dataGridViewTicket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewPlace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTicketDelete;
        private System.Windows.Forms.Button buttonTicketEdit;
        private System.Windows.Forms.Button buttonTicketAdd;
        private System.Windows.Forms.Button buttonPlaceDelete;
        private System.Windows.Forms.Button buttonPlaceEdit;
        private System.Windows.Forms.Button buttonPlaceAdd;
        private System.Windows.Forms.ComboBox comboBoxTicketPlace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerTicketStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerTicketEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownTicketCount;
        private System.Windows.Forms.NumericUpDown numericUpDownTicketCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxPlaceName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPlaceLocation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownPlaceCapasity;
        private System.Windows.Forms.ComboBox comboBoxPlaceCountry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDownPlaceCostTicket;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDownTicketSumm;
    }
}