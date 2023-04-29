namespace Materialy.Forms
{
    partial class WorkerForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrderInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOrdersAdd = new System.Windows.Forms.Button();
            this.buttonOrdersDelete = new System.Windows.Forms.Button();
            this.comboBoxOrderInfo = new System.Windows.Forms.ComboBox();
            this.numericUpDownrOderInfo = new System.Windows.Forms.NumericUpDown();
            this.textBoxCostOrderInfo = new System.Windows.Forms.TextBox();
            this.buttonOrderInfoDelete = new System.Windows.Forms.Button();
            this.buttonOrderInfoAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOrderInfoChange = new System.Windows.Forms.Button();
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMaterialManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterialUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterialType = new System.Windows.Forms.ComboBox();
            this.textBoxMaterialName = new System.Windows.Forms.TextBox();
            this.numericUpDownMaterialCost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonMaterialChange = new System.Windows.Forms.Button();
            this.buttonMaterialDelete = new System.Windows.Forms.Button();
            this.buttonMaterialAdd = new System.Windows.Forms.Button();
            this.dataGridViewSupply = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSupplyMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplyProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplyUnit = new System.Windows.Forms.ComboBox();
            this.numericUpDownSupplyCount = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxSupplyNumber = new System.Windows.Forms.TextBox();
            this.buttonSupplyChange = new System.Windows.Forms.Button();
            this.buttonSupplyDelete = new System.Windows.Forms.Button();
            this.buttonSupplyAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrOderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(378, 191);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // dataGridViewOrderInfo
            // 
            this.dataGridViewOrderInfo.AllowUserToAddRows = false;
            this.dataGridViewOrderInfo.AllowUserToDeleteRows = false;
            this.dataGridViewOrderInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderInfo.Location = new System.Drawing.Point(446, 27);
            this.dataGridViewOrderInfo.Name = "dataGridViewOrderInfo";
            this.dataGridViewOrderInfo.ReadOnly = true;
            this.dataGridViewOrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderInfo.Size = new System.Drawing.Size(765, 191);
            this.dataGridViewOrderInfo.TabIndex = 2;
            this.dataGridViewOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderInfo_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Information";
            // 
            // buttonOrdersAdd
            // 
            this.buttonOrdersAdd.Location = new System.Drawing.Point(12, 224);
            this.buttonOrdersAdd.Name = "buttonOrdersAdd";
            this.buttonOrdersAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdersAdd.TabIndex = 4;
            this.buttonOrdersAdd.Text = "Add";
            this.buttonOrdersAdd.UseVisualStyleBackColor = true;
            this.buttonOrdersAdd.Click += new System.EventHandler(this.buttonOrdersAdd_Click);
            // 
            // buttonOrdersDelete
            // 
            this.buttonOrdersDelete.Location = new System.Drawing.Point(93, 224);
            this.buttonOrdersDelete.Name = "buttonOrdersDelete";
            this.buttonOrdersDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdersDelete.TabIndex = 5;
            this.buttonOrdersDelete.Text = "Delete";
            this.buttonOrdersDelete.UseVisualStyleBackColor = true;
            this.buttonOrdersDelete.Click += new System.EventHandler(this.buttonOrdersDelete_Click);
            // 
            // comboBoxOrderInfo
            // 
            this.comboBoxOrderInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderInfo.FormattingEnabled = true;
            this.comboBoxOrderInfo.Location = new System.Drawing.Point(496, 236);
            this.comboBoxOrderInfo.Name = "comboBoxOrderInfo";
            this.comboBoxOrderInfo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrderInfo.TabIndex = 6;
            this.comboBoxOrderInfo.SelectedValueChanged += new System.EventHandler(this.numericUpDownrOderInfo_ValueChanged);
            // 
            // numericUpDownrOderInfo
            // 
            this.numericUpDownrOderInfo.Location = new System.Drawing.Point(685, 236);
            this.numericUpDownrOderInfo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownrOderInfo.Name = "numericUpDownrOderInfo";
            this.numericUpDownrOderInfo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownrOderInfo.TabIndex = 7;
            this.numericUpDownrOderInfo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownrOderInfo.ValueChanged += new System.EventHandler(this.numericUpDownrOderInfo_ValueChanged);
            // 
            // textBoxCostOrderInfo
            // 
            this.textBoxCostOrderInfo.Enabled = false;
            this.textBoxCostOrderInfo.Location = new System.Drawing.Point(868, 235);
            this.textBoxCostOrderInfo.Name = "textBoxCostOrderInfo";
            this.textBoxCostOrderInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCostOrderInfo.TabIndex = 8;
            // 
            // buttonOrderInfoDelete
            // 
            this.buttonOrderInfoDelete.Location = new System.Drawing.Point(1136, 232);
            this.buttonOrderInfoDelete.Name = "buttonOrderInfoDelete";
            this.buttonOrderInfoDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderInfoDelete.TabIndex = 10;
            this.buttonOrderInfoDelete.Text = "Delete";
            this.buttonOrderInfoDelete.UseVisualStyleBackColor = true;
            this.buttonOrderInfoDelete.Click += new System.EventHandler(this.buttonOrderInfoDelete_Click);
            // 
            // buttonOrderInfoAdd
            // 
            this.buttonOrderInfoAdd.Location = new System.Drawing.Point(974, 234);
            this.buttonOrderInfoAdd.Name = "buttonOrderInfoAdd";
            this.buttonOrderInfoAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderInfoAdd.TabIndex = 9;
            this.buttonOrderInfoAdd.Text = "Add";
            this.buttonOrderInfoAdd.UseVisualStyleBackColor = true;
            this.buttonOrderInfoAdd.Click += new System.EventHandler(this.buttonOrderInfoAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cost";
            // 
            // buttonOrderInfoChange
            // 
            this.buttonOrderInfoChange.Location = new System.Drawing.Point(1055, 233);
            this.buttonOrderInfoChange.Name = "buttonOrderInfoChange";
            this.buttonOrderInfoChange.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderInfoChange.TabIndex = 14;
            this.buttonOrderInfoChange.Text = "Change";
            this.buttonOrderInfoChange.UseVisualStyleBackColor = true;
            this.buttonOrderInfoChange.Click += new System.EventHandler(this.buttonOrderInfoChange_Click);
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.AllowUserToAddRows = false;
            this.dataGridViewMaterial.AllowUserToDeleteRows = false;
            this.dataGridViewMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(12, 293);
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.ReadOnly = true;
            this.dataGridViewMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterial.Size = new System.Drawing.Size(569, 191);
            this.dataGridViewMaterial.TabIndex = 15;
            this.dataGridViewMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterial_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Material";
            // 
            // comboBoxMaterialManufacturer
            // 
            this.comboBoxMaterialManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialManufacturer.FormattingEnabled = true;
            this.comboBoxMaterialManufacturer.Location = new System.Drawing.Point(124, 501);
            this.comboBoxMaterialManufacturer.Name = "comboBoxMaterialManufacturer";
            this.comboBoxMaterialManufacturer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterialManufacturer.TabIndex = 18;
            // 
            // comboBoxMaterialUnit
            // 
            this.comboBoxMaterialUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialUnit.FormattingEnabled = true;
            this.comboBoxMaterialUnit.Location = new System.Drawing.Point(124, 531);
            this.comboBoxMaterialUnit.Name = "comboBoxMaterialUnit";
            this.comboBoxMaterialUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterialUnit.TabIndex = 19;
            // 
            // comboBoxMaterialType
            // 
            this.comboBoxMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialType.FormattingEnabled = true;
            this.comboBoxMaterialType.Location = new System.Drawing.Point(124, 561);
            this.comboBoxMaterialType.Name = "comboBoxMaterialType";
            this.comboBoxMaterialType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterialType.TabIndex = 20;
            // 
            // textBoxMaterialName
            // 
            this.textBoxMaterialName.Location = new System.Drawing.Point(124, 591);
            this.textBoxMaterialName.Name = "textBoxMaterialName";
            this.textBoxMaterialName.Size = new System.Drawing.Size(121, 20);
            this.textBoxMaterialName.TabIndex = 21;
            // 
            // numericUpDownMaterialCost
            // 
            this.numericUpDownMaterialCost.Location = new System.Drawing.Point(124, 621);
            this.numericUpDownMaterialCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaterialCost.Name = "numericUpDownMaterialCost";
            this.numericUpDownMaterialCost.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaterialCost.TabIndex = 22;
            this.numericUpDownMaterialCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Manufacturer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Measurements";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 598);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 623);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Cost";
            // 
            // buttonMaterialChange
            // 
            this.buttonMaterialChange.Location = new System.Drawing.Point(93, 659);
            this.buttonMaterialChange.Name = "buttonMaterialChange";
            this.buttonMaterialChange.Size = new System.Drawing.Size(75, 23);
            this.buttonMaterialChange.TabIndex = 30;
            this.buttonMaterialChange.Text = "Change";
            this.buttonMaterialChange.UseVisualStyleBackColor = true;
            this.buttonMaterialChange.Click += new System.EventHandler(this.buttonMaterialChange_Click);
            // 
            // buttonMaterialDelete
            // 
            this.buttonMaterialDelete.Location = new System.Drawing.Point(174, 658);
            this.buttonMaterialDelete.Name = "buttonMaterialDelete";
            this.buttonMaterialDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonMaterialDelete.TabIndex = 29;
            this.buttonMaterialDelete.Text = "Delete";
            this.buttonMaterialDelete.UseVisualStyleBackColor = true;
            this.buttonMaterialDelete.Click += new System.EventHandler(this.buttonMaterialDelete_Click);
            // 
            // buttonMaterialAdd
            // 
            this.buttonMaterialAdd.Location = new System.Drawing.Point(12, 660);
            this.buttonMaterialAdd.Name = "buttonMaterialAdd";
            this.buttonMaterialAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonMaterialAdd.TabIndex = 28;
            this.buttonMaterialAdd.Text = "Add";
            this.buttonMaterialAdd.UseVisualStyleBackColor = true;
            this.buttonMaterialAdd.Click += new System.EventHandler(this.buttonMaterialAdd_Click);
            // 
            // dataGridViewSupply
            // 
            this.dataGridViewSupply.AllowUserToAddRows = false;
            this.dataGridViewSupply.AllowUserToDeleteRows = false;
            this.dataGridViewSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupply.Location = new System.Drawing.Point(642, 293);
            this.dataGridViewSupply.Name = "dataGridViewSupply";
            this.dataGridViewSupply.ReadOnly = true;
            this.dataGridViewSupply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupply.Size = new System.Drawing.Size(569, 191);
            this.dataGridViewSupply.TabIndex = 31;
            this.dataGridViewSupply.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupply_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(639, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Supply";
            // 
            // comboBoxSupplyMaterial
            // 
            this.comboBoxSupplyMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplyMaterial.FormattingEnabled = true;
            this.comboBoxSupplyMaterial.Location = new System.Drawing.Point(755, 501);
            this.comboBoxSupplyMaterial.Name = "comboBoxSupplyMaterial";
            this.comboBoxSupplyMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplyMaterial.TabIndex = 33;
            // 
            // comboBoxSupplyProvider
            // 
            this.comboBoxSupplyProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplyProvider.FormattingEnabled = true;
            this.comboBoxSupplyProvider.Location = new System.Drawing.Point(755, 534);
            this.comboBoxSupplyProvider.Name = "comboBoxSupplyProvider";
            this.comboBoxSupplyProvider.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplyProvider.TabIndex = 34;
            // 
            // comboBoxSupplyUnit
            // 
            this.comboBoxSupplyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplyUnit.FormattingEnabled = true;
            this.comboBoxSupplyUnit.Location = new System.Drawing.Point(755, 566);
            this.comboBoxSupplyUnit.Name = "comboBoxSupplyUnit";
            this.comboBoxSupplyUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplyUnit.TabIndex = 35;
            // 
            // numericUpDownSupplyCount
            // 
            this.numericUpDownSupplyCount.Location = new System.Drawing.Point(755, 596);
            this.numericUpDownSupplyCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSupplyCount.Name = "numericUpDownSupplyCount";
            this.numericUpDownSupplyCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSupplyCount.TabIndex = 36;
            this.numericUpDownSupplyCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerSupplyDate
            // 
            this.dateTimePickerSupplyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSupplyDate.Location = new System.Drawing.Point(755, 623);
            this.dateTimePickerSupplyDate.Name = "dateTimePickerSupplyDate";
            this.dateTimePickerSupplyDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerSupplyDate.TabIndex = 37;
            // 
            // textBoxSupplyNumber
            // 
            this.textBoxSupplyNumber.Location = new System.Drawing.Point(755, 649);
            this.textBoxSupplyNumber.Name = "textBoxSupplyNumber";
            this.textBoxSupplyNumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxSupplyNumber.TabIndex = 38;
            // 
            // buttonSupplyChange
            // 
            this.buttonSupplyChange.Location = new System.Drawing.Point(723, 676);
            this.buttonSupplyChange.Name = "buttonSupplyChange";
            this.buttonSupplyChange.Size = new System.Drawing.Size(75, 23);
            this.buttonSupplyChange.TabIndex = 41;
            this.buttonSupplyChange.Text = "Change";
            this.buttonSupplyChange.UseVisualStyleBackColor = true;
            this.buttonSupplyChange.Click += new System.EventHandler(this.buttonSupplyChange_Click);
            // 
            // buttonSupplyDelete
            // 
            this.buttonSupplyDelete.Location = new System.Drawing.Point(804, 675);
            this.buttonSupplyDelete.Name = "buttonSupplyDelete";
            this.buttonSupplyDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonSupplyDelete.TabIndex = 40;
            this.buttonSupplyDelete.Text = "Delete";
            this.buttonSupplyDelete.UseVisualStyleBackColor = true;
            this.buttonSupplyDelete.Click += new System.EventHandler(this.buttonSupplyDelete_Click);
            // 
            // buttonSupplyAdd
            // 
            this.buttonSupplyAdd.Location = new System.Drawing.Point(642, 677);
            this.buttonSupplyAdd.Name = "buttonSupplyAdd";
            this.buttonSupplyAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonSupplyAdd.TabIndex = 39;
            this.buttonSupplyAdd.Text = "Add";
            this.buttonSupplyAdd.UseVisualStyleBackColor = true;
            this.buttonSupplyAdd.Click += new System.EventHandler(this.buttonSupplyAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(644, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Material";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(644, 537);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Provider";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(644, 569);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Unit";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(644, 603);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Count";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(644, 628);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(644, 652);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Number";
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 705);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonSupplyChange);
            this.Controls.Add(this.buttonSupplyDelete);
            this.Controls.Add(this.buttonSupplyAdd);
            this.Controls.Add(this.textBoxSupplyNumber);
            this.Controls.Add(this.dateTimePickerSupplyDate);
            this.Controls.Add(this.numericUpDownSupplyCount);
            this.Controls.Add(this.comboBoxSupplyUnit);
            this.Controls.Add(this.comboBoxSupplyProvider);
            this.Controls.Add(this.comboBoxSupplyMaterial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridViewSupply);
            this.Controls.Add(this.buttonMaterialChange);
            this.Controls.Add(this.buttonMaterialDelete);
            this.Controls.Add(this.buttonMaterialAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownMaterialCost);
            this.Controls.Add(this.textBoxMaterialName);
            this.Controls.Add(this.comboBoxMaterialType);
            this.Controls.Add(this.comboBoxMaterialUnit);
            this.Controls.Add(this.comboBoxMaterialManufacturer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewMaterial);
            this.Controls.Add(this.buttonOrderInfoChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOrderInfoDelete);
            this.Controls.Add(this.buttonOrderInfoAdd);
            this.Controls.Add(this.textBoxCostOrderInfo);
            this.Controls.Add(this.numericUpDownrOderInfo);
            this.Controls.Add(this.comboBoxOrderInfo);
            this.Controls.Add(this.buttonOrdersDelete);
            this.Controls.Add(this.buttonOrdersAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrderInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrOderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrderInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOrdersAdd;
        private System.Windows.Forms.Button buttonOrdersDelete;
        private System.Windows.Forms.ComboBox comboBoxOrderInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownrOderInfo;
        private System.Windows.Forms.TextBox textBoxCostOrderInfo;
        private System.Windows.Forms.Button buttonOrderInfoDelete;
        private System.Windows.Forms.Button buttonOrderInfoAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOrderInfoChange;
        private System.Windows.Forms.DataGridView dataGridViewMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMaterialManufacturer;
        private System.Windows.Forms.ComboBox comboBoxMaterialUnit;
        private System.Windows.Forms.ComboBox comboBoxMaterialType;
        private System.Windows.Forms.TextBox textBoxMaterialName;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterialCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonMaterialChange;
        private System.Windows.Forms.Button buttonMaterialDelete;
        private System.Windows.Forms.Button buttonMaterialAdd;
        private System.Windows.Forms.DataGridView dataGridViewSupply;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSupplyMaterial;
        private System.Windows.Forms.ComboBox comboBoxSupplyProvider;
        private System.Windows.Forms.ComboBox comboBoxSupplyUnit;
        private System.Windows.Forms.NumericUpDown numericUpDownSupplyCount;
        private System.Windows.Forms.DateTimePicker dateTimePickerSupplyDate;
        private System.Windows.Forms.TextBox textBoxSupplyNumber;
        private System.Windows.Forms.Button buttonSupplyChange;
        private System.Windows.Forms.Button buttonSupplyDelete;
        private System.Windows.Forms.Button buttonSupplyAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}