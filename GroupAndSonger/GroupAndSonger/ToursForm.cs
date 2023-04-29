using GroupAndSonger.Models.DB;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GroupAndSonger
{
    public partial class ToursForm : Form
    {
        public int Id_Group { get; }
        public ToursForm(int id_group)
        {
            Id_Group = id_group;
            InitializeComponent();
            UpdateAll();
        }

        private void UpdateAll()
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    dataGridViewTour.DataSource = DB.tours.Where(r => r.ID_Group == Id_Group).Select(r => new
                    {
                        r.ID,
                        r.Date_beg
                    }).ToList();

                    comboBoxTourSong.Items.Clear();
                    comboBoxTourSong.Items.AddRange(DB.songs.Select(r => r.Name).ToArray());

                    comboBoxTicketPlace.Items.Clear();
                    comboBoxTicketPlace.Items.AddRange(DB.places.Select(r => r.Name_place).ToArray());

                    comboBoxPlaceCountry.Items.Clear();
                    comboBoxPlaceCountry.Items.AddRange(DB.country.Select(r => r.Name).ToArray());

                    dataGridViewCountry.DataSource = DB.country.Select(r => new { r.ID, r.Name }).ToList();
                    dataGridViewCountry.Columns[0].Visible = false;

                    dataGridViewPlace.DataSource = DB.places.Select(r => new
                    {
                        r.ID,
                        r.country.Name,
                        r.Name_place,
                        r.Name_loc,
                        r.Capacity,
                        r.Price_tick
                    }).ToList();
                    dataGridViewPlace.Columns[0].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #region Туры
        private void dataGridViewTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewTour.SelectedRows[0].Cells[0].Value);
                    var item = DB.tours.First(r => r.ID == index);

                    dateTimePickerTourStart.Value = (DateTime)item.Date_beg;

                    dataGridViewTourSong.DataSource = DB.tour_songs.Where(r => r.ID_Tour == index).Select(r => new { r.ID, r.songs.Name }).ToList();
                    dataGridViewTourSong.Columns[0].Visible = false;

                    dataGridViewTicket.DataSource = DB.buy_tick.Where(r => r.ID_Tour == index).Select(r => new
                    {
                        r.ID,
                        r.Date_beg,
                        r.Date_ov,
                        r.places.Name_place,
                        r.places.Name_loc,
                        r.Count_tick,
                        r.Price_tick,
                        r.SummPR_tick
                    }).ToList();
                    dataGridViewTicket.Columns[0].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTourAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var item = new tours
                    {
                        ID_Group = Id_Group,
                        Date_beg = dateTimePickerTourStart.Value,
                    };
                    DB.tours.Add(item);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void buttonTourEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewTour.SelectedRows[0].Cells[0].Value);
                    var item = DB.tours.First(r => r.ID == index);
                    item.Date_beg = dateTimePickerTourStart.Value;
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void buttonTourDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewTour.SelectedRows[0].Cells[0].Value);
                    var item = DB.tours.First(r => r.ID == index);
                    DB.tours.Remove(item);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        #endregion

        #region Песни тура
        private void dataGridViewTourSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewTourSong.SelectedRows[0].Cells[0].Value);
                    var item = DB.tour_songs.First(r => r.ID == index);
                    comboBoxTourSong.SelectedIndex = comboBoxTourSong.Items.IndexOf(item.songs.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTourSongAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var item = new tour_songs
                    {
                        ID_Tour = Convert.ToInt32(dataGridViewTour.SelectedRows[0].Cells[0].Value),
                        ID_Song = DB.songs.First(r => r.Name == comboBoxTourSong.Text).ID
                    };
                    DB.tour_songs.Add(item);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void buttonTourSongEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewTourSong.SelectedRows[0].Cells[0].Value);
                    var item = DB.tour_songs.First(r => r.ID == index);
                    item.ID_Tour = Convert.ToInt32(dataGridViewTour.SelectedRows[0].Cells[0].Value);
                    item.ID_Song = DB.songs.First(r => r.Name == comboBoxTourSong.Text).ID;
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void buttonTourSongDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewTourSong.SelectedRows[0].Cells[0].Value);
                    var item = DB.tour_songs.First(r => r.ID == index);
                    DB.tour_songs.Remove(item);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        #endregion

        #region Страны
        private void dataGridViewCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewCountry.SelectedRows[0].Cells[0].Value);
                    var item = DB.country.First(r => r.ID == index);
                    textBoxCountryName.Text = item.Name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonCountryAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var item = new country
                    {
                        Name = textBoxCountryName.Text
                    };
                    DB.country.Add(item);
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

        private void buttonCountryEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewCountry.SelectedRows[0].Cells[0].Value);
                    var item = DB.country.First(r => r.ID == index);
                    item.Name = textBoxCountryName.Text;
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

        private void buttonCountryDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewCountry.SelectedRows[0].Cells[0].Value);
                    var item = DB.country.First(r => r.ID == index);
                    DB.country.Remove(item);
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

        #region Выступления
        private void dataGridViewTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewTicket.SelectedRows[0].Cells[0].Value);
                    var item = DB.buy_tick.First(r => r.ID == index);
                    comboBoxTicketPlace.SelectedIndex = comboBoxTicketPlace.Items.IndexOf(item.places.Name_place);
                    dateTimePickerTicketStart.Value = (DateTime)item.Date_beg;
                    dateTimePickerTicketEnd.Value = (DateTime)item.Date_ov;
                    numericUpDownTicketCount.Value = (decimal)item.Count_tick;
                    numericUpDownTicketCost.Value = (decimal)item.Price_tick;
                    numericUpDownTicketSumm.Value = (decimal)item.SummPR_tick;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTicketAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var item = new buy_tick
                    {
                        ID_Place = DB.places.First(r => r.Name_place == comboBoxTicketPlace.Text).ID,
                        ID_Tour = Convert.ToInt32(dataGridViewTour.SelectedRows[0].Cells[0].Value),
                        Date_beg = dateTimePickerTicketStart.Value,
                        Date_ov = dateTimePickerTicketEnd.Value,
                        Count_tick = (int?)numericUpDownTicketCount.Value,
                        Price_tick = (int?)numericUpDownTicketCost.Value,
                        SummPR_tick = (int?)numericUpDownTicketSumm.Value
                    };
                    DB.buy_tick.Add(item);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTicketEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewTicket.SelectedRows[0].Cells[0].Value);
                    var item = DB.buy_tick.First(r => r.ID == index);
                    item.ID_Place = DB.places.First(r => r.Name_place == comboBoxTicketPlace.Text).ID;
                    item.ID_Tour = Convert.ToInt32(dataGridViewTour.SelectedRows[0].Cells[0].Value);
                    item.Date_beg = dateTimePickerTicketStart.Value;
                    item.Date_ov = dateTimePickerTicketEnd.Value;
                    item.Count_tick = (int?)numericUpDownTicketCount.Value;
                    item.Price_tick = (int?)numericUpDownTicketCost.Value;
                    item.SummPR_tick = (int?)numericUpDownTicketSumm.Value;
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTicketDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewTicket.SelectedRows[0].Cells[0].Value);
                    var item = DB.buy_tick.First(r => r.ID == index);
                    DB.buy_tick.Remove(item);
                    DB.SaveChanges();
                    tran.Commit();
                    UpdateAll();
                    dataGridViewTour_CellClick(null, null);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region Места
        private void dataGridViewPlace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                try
                {
                    var index = Convert.ToInt32(dataGridViewPlace.SelectedRows[0].Cells[0].Value);
                    var item = DB.places.First(r => r.ID == index);
                    textBoxPlaceName.Text = item.Name_place;
                    textBoxPlaceLocation.Text = item.Name_loc;
                    numericUpDownPlaceCapasity.Value = (decimal)item.Capacity;
                    comboBoxPlaceCountry.SelectedIndex = comboBoxPlaceCountry.Items.IndexOf(item.country.Name);
                    numericUpDownPlaceCostTicket.Value = (decimal)item.Price_tick;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonPlaceAdd_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var item = new places
                    {
                        ID_Country = DB.country.First(r => r.Name == comboBoxPlaceCountry.Text).ID,
                        Capacity = (int?)numericUpDownPlaceCapasity.Value,
                        Name_loc = textBoxPlaceLocation.Text,
                        Name_place = textBoxPlaceName.Text,
                        Price_tick = (int?)numericUpDownPlaceCostTicket.Value
                    };
                    DB.places.Add(item);
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

        private void buttonPlaceEdit_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewPlace.SelectedRows[0].Cells[0].Value);
                    var item = DB.places.First(r => r.ID == index);
                    item.ID_Country = DB.country.First(r => r.Name == comboBoxPlaceCountry.Text).ID;
                    item.Capacity = (int?)numericUpDownPlaceCapasity.Value;
                    item.Name_loc = textBoxPlaceLocation.Text;
                    item.Name_place = textBoxPlaceName.Text;
                    item.Price_tick = (int?)numericUpDownPlaceCostTicket.Value;
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

        private void buttonPlaceDelete_Click(object sender, EventArgs e)
        {
            using (var DB = new subdcursa4Entities())
            {
                var tran = DB.Database.BeginTransaction();
                try
                {
                    var index = Convert.ToInt32(dataGridViewPlace.SelectedRows[0].Cells[0].Value);
                    var item = DB.places.First(r => r.ID == index);
                    DB.places.Remove(item);
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

        private void numericUpDownCost_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDownTicketSumm.Value = numericUpDownTicketCount.Value * numericUpDownTicketCost.Value;
            }
            catch (Exception ex)
            {
                numericUpDownTicketSumm.Value = 0;
            }
        }
    }
}
