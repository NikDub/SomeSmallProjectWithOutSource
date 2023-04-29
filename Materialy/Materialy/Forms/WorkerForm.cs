using Materialy.DBModel;
using Materialy.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Materialy.Forms
{
    public partial class WorkerForm : Form
    {
        MatrialyDB db = new MatrialyDB();
        int userid;
        public WorkerForm(int userId, int? Post)
        {
            userid = userId;
            InitializeComponent();
            UpdateData();
            if(Post == 1)
            {
                Height = 744;
            }
            else
            {
                Height = 306;
            }
        }

        void UpdateData()
        {
            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = db.Buy.Where(e => e.Id_Employee == userid).Select(e => new BuyM { Id = e.Id, Cost = e.Cost, Date = e.Date }).ToList();
            dataGridViewOrders.Columns[0].Visible = false;

            dataGridViewMaterial.DataSource = null;
            dataGridViewMaterial.DataSource = db.Materials.Select(e => new MaterialsM { Id = e.Id, Manufacturer = e.Manufacturer.Name, Measurements = e.Measurements.Name, Type = e.Type.Name, Name = e.Name, Cost = e.Cost }).ToList();
            dataGridViewMaterial.Columns[0].Visible = false;

            dataGridViewSupply.DataSource = null;
            dataGridViewSupply.DataSource = db.Supply.Select(e=> new SupplyM {Id = e.Id, Material = e.Materials.Name, Unit = e.Unit.Name, Count =e.Count1, Date =e.Date, Number = e.Number }).ToList();
            dataGridViewSupply.Columns[0].Visible = false;

            comboBoxOrderInfo.Items.Clear();
            comboBoxOrderInfo.Items.AddRange(db.Materials.Select(r => r.Name).ToArray());

            comboBoxMaterialManufacturer.Items.Clear();
            comboBoxMaterialManufacturer.Items.AddRange(db.Manufacturer.Select(r => r.Name).ToArray());

            comboBoxMaterialUnit.Items.Clear();
            comboBoxMaterialUnit.Items.AddRange(db.Measurements.Select(r => r.Name).ToArray());

            comboBoxMaterialType.Items.Clear();
            comboBoxMaterialType.Items.AddRange(db.Type.Select(r => r.Name).ToArray());


            comboBoxSupplyMaterial.Items.Clear();
            comboBoxSupplyMaterial.Items.AddRange(db.Materials.Select(r => r.Name).ToArray());

            comboBoxSupplyProvider.Items.Clear();
            comboBoxSupplyProvider.Items.AddRange(db.Provider.Select(r => r.Name).ToArray());

            comboBoxSupplyUnit.Items.Clear();
            comboBoxSupplyUnit.Items.AddRange(db.Unit.Select(r => r.Name).ToArray());

            dataGridViewOrders_CellClick(null, null);
        }
        
        #region orders
        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var SelectedRowID = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value);
                dataGridViewOrderInfo.DataSource = db.Buy_Details.Where(r => r.Id_Buy == SelectedRowID)
                    .Select(r => new BuyDetailM { Id = r.Id, Cost = r.Cost, Count = r.Count, Material = r.Materials.Name }).ToList();
                dataGridViewOrderInfo.Columns[0].Visible = false;

            }
            catch (Exception) { }

        }

        private void buttonOrdersAdd_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy()
            {
                Cost = 0,
                Date = DateTime.Now,
                Id_Employee = userid
            };

            db.Buy.Add(buy);
            db.SaveChanges();
            UpdateData();
        }

        private void buttonOrdersDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value);
            var buy = db.Buy.First(r => r.Id == SelectedRowID);
            foreach (var item in db.Buy_Details.Where(r => r.Id_Buy == buy.Id))
            {
                db.Buy_Details.Remove(item);
            }

            db.Buy.Remove(buy);
            db.SaveChanges();
            UpdateData();
        }
        #endregion
        #region Order Info
        private void dataGridViewOrderInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewOrderInfo.SelectedRows[0].Cells[0].Value);
            var buyd = db.Buy_Details.First(r => r.Id == SelectedRowID);
            textBoxCostOrderInfo.Text = buyd.Cost.ToString();
            numericUpDownrOderInfo.Value = Convert.ToDecimal(buyd.Count);
            comboBoxOrderInfo.SelectedIndex = comboBoxOrderInfo.Items.IndexOf(buyd.Materials.Name);
        }

        private void buttonOrderInfoAdd_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value);
            var buy = db.Buy.First(r => r.Id == SelectedRowID);
            Buy_Details buy_Details = new Buy_Details()
            {
                Cost = Convert.ToDouble(textBoxCostOrderInfo.Text),
                Count = Convert.ToInt32(numericUpDownrOderInfo.Value),
                Id_Materials = db.Materials.First(r => r.Name == comboBoxOrderInfo.Text).Id,
                Materials = db.Materials.First(r => r.Name == comboBoxOrderInfo.Text),
                Id_Buy = SelectedRowID,
                Buy = buy
            };

            db.Buy_Details.Add(buy_Details);
            db.SaveChanges();
            dataGridViewOrders_CellClick(null, null);
        }

        private void buttonOrderInfoChange_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewOrderInfo.SelectedRows[0].Cells[0].Value);
            var buyd = db.Buy_Details.First(r => r.Id == SelectedRowID);
            buyd.Cost = Convert.ToDouble(textBoxCostOrderInfo.Text);
            buyd.Count = Convert.ToInt32(numericUpDownrOderInfo.Value);
            buyd.Id_Materials = db.Materials.First(r => r.Name == comboBoxOrderInfo.Text).Id;
            buyd.Materials = db.Materials.First(r => r.Name == comboBoxOrderInfo.Text);
            db.SaveChanges();
            dataGridViewOrders_CellClick(null, null);
        }

        private void buttonOrderInfoDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewOrderInfo.SelectedRows[0].Cells[0].Value);
            var buyd = db.Buy_Details.First(r => r.Id == SelectedRowID);
            db.Buy_Details.Remove(buyd);
            db.SaveChanges();
            dataGridViewOrders_CellClick(null, null);
        }

        private void numericUpDownrOderInfo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var mat = db.Materials.First(r => r.Name == comboBoxOrderInfo.Text);
                textBoxCostOrderInfo.Text = (mat.Cost * Convert.ToInt32(numericUpDownrOderInfo.Value)).ToString();
            }
            catch (Exception) { }
        }
        #endregion
        #region Material
        private void dataGridViewMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewMaterial.SelectedRows[0].Cells[0].Value);
            var mat = db.Materials.First(r => r.Id == SelectedRowID);
            textBoxMaterialName.Text = mat.Name;
            numericUpDownMaterialCost.Value = Convert.ToDecimal(mat.Cost);
            comboBoxMaterialManufacturer.SelectedIndex = comboBoxMaterialManufacturer.Items.IndexOf(mat.Manufacturer.Name);
            comboBoxMaterialUnit.SelectedIndex = comboBoxMaterialUnit.Items.IndexOf(mat.Measurements.Name);
            comboBoxMaterialType.SelectedIndex = comboBoxMaterialType.Items.IndexOf(mat.Type.Name);
        }

        private void buttonMaterialAdd_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials()
            {
                Cost = Convert.ToInt32(numericUpDownMaterialCost.Value),
                Name = textBoxMaterialName.Text,
                Manufacturer = db.Manufacturer.First(r => r.Name == comboBoxMaterialManufacturer.Text),
                Id_Manufacturer = db.Manufacturer.First(r => r.Name == comboBoxMaterialManufacturer.Text).Id,
                Measurements = db.Measurements.First(r => r.Name == comboBoxMaterialUnit.Text),
                Id_Measurements = db.Measurements.First(r => r.Name == comboBoxMaterialUnit.Text).Id,
                Type = db.Type.First(r => r.Name == comboBoxMaterialType.Text),
                Id_Type = db.Type.First(r => r.Name == comboBoxMaterialType.Text).Id
            };
            db.Materials.Add(materials);
            db.SaveChanges();
            UpdateData();
        }

        private void buttonMaterialChange_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewMaterial.SelectedRows[0].Cells[0].Value);
            var mat = db.Materials.First(r => r.Id == SelectedRowID);
            mat.Cost = Convert.ToInt32(numericUpDownMaterialCost.Value);
            mat.Name = textBoxMaterialName.Text;
            mat.Manufacturer = db.Manufacturer.First(r => r.Name == comboBoxMaterialManufacturer.Text);
            mat.Id_Manufacturer = db.Manufacturer.First(r => r.Name == comboBoxMaterialManufacturer.Text).Id;
            mat.Measurements = db.Measurements.First(r => r.Name == comboBoxMaterialUnit.Text);
            mat.Id_Measurements = db.Measurements.First(r => r.Name == comboBoxMaterialUnit.Text).Id;
            mat.Type = db.Type.First(r => r.Name == comboBoxMaterialType.Text);
            mat.Id_Type = db.Type.First(r => r.Name == comboBoxMaterialType.Text).Id;
            db.SaveChanges();
            UpdateData();
        }

        private void buttonMaterialDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewMaterial.SelectedRows[0].Cells[0].Value);
            var mat = db.Materials.First(r => r.Id == SelectedRowID);
            db.Materials.Remove(mat);
            db.SaveChanges();
            UpdateData();
        }
        #endregion
        #region Supply
        private void dataGridViewSupply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewSupply.SelectedRows[0].Cells[0].Value);
            var supl = db.Supply.First(r => r.Id == SelectedRowID);
            comboBoxSupplyMaterial.SelectedIndex = comboBoxSupplyMaterial.Items.IndexOf(supl.Materials.Name);
            comboBoxSupplyProvider.SelectedIndex = comboBoxSupplyProvider.Items.IndexOf(supl.Provider.Name);
            comboBoxSupplyUnit.SelectedIndex = comboBoxSupplyUnit.Items.IndexOf(supl.Unit.Name);
            dateTimePickerSupplyDate.Value = (DateTime)supl.Date;
            numericUpDownSupplyCount.Value = Convert.ToDecimal(supl.Count1==null ? 1:supl.Count1);
            textBoxSupplyNumber.Text = supl.Number.ToString();

        }

        private void buttonSupplyAdd_Click(object sender, EventArgs e)
        {
            var Suppl = new Supply()
            {
                Count1 = Convert.ToInt32(numericUpDownSupplyCount.Value),
                Date = dateTimePickerSupplyDate.Value,
                Number = Int32.Parse(textBoxSupplyNumber.Text),
                Unit = db.Unit.First(r => r.Name == comboBoxSupplyUnit.Text),
                Id_Unit = db.Unit.First(r => r.Name == comboBoxSupplyUnit.Text).Id,
                Materials = db.Materials.First(r => r.Name == comboBoxSupplyMaterial.Text),
                Id_Materials = db.Materials.First(r => r.Name == comboBoxSupplyMaterial.Text).Id,
                Provider = db.Provider.First(r => r.Name == comboBoxSupplyProvider.Text),
                Id_Provider = db.Provider.First(r => r.Name == comboBoxSupplyProvider.Text).Id
            };
            db.Supply.Add(Suppl);
            db.SaveChanges();
            UpdateData();
        }

        private void buttonSupplyChange_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewSupply.SelectedRows[0].Cells[0].Value);
            var supl = db.Supply.First(r => r.Id == SelectedRowID);
            supl.Count1 = Convert.ToInt32(numericUpDownSupplyCount.Value);
            supl.Date = dateTimePickerSupplyDate.Value;
            supl.Number = Int32.Parse(textBoxSupplyNumber.Text);
            supl.Unit = db.Unit.First(r => r.Name == comboBoxSupplyUnit.Text);
            supl.Id_Unit = db.Unit.First(r => r.Name == comboBoxSupplyUnit.Text).Id;
            supl.Materials = db.Materials.First(r => r.Name == comboBoxSupplyMaterial.Text);
            supl.Id_Materials = db.Materials.First(r => r.Name == comboBoxSupplyMaterial.Text).Id;
            supl.Provider = db.Provider.First(r => r.Name == comboBoxSupplyProvider.Text);
            supl.Id_Provider = db.Provider.First(r => r.Name == comboBoxSupplyProvider.Text).Id;
            db.SaveChanges();
            UpdateData();
        }

        private void buttonSupplyDelete_Click(object sender, EventArgs e)
        {
            var SelectedRowID = Convert.ToInt32(dataGridViewSupply.SelectedRows[0].Cells[0].Value);
            var supl = db.Supply.First(r => r.Id == SelectedRowID);
            db.Supply.Remove(supl);
            db.SaveChanges();
            UpdateData();
        }
        #endregion
    }
}
