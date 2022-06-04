using RaspisanieWinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspisanieWinForms.Forms
{
    public partial class AddAuditorium : BaseForm
    {
        public AddAuditorium()
        {
            InitializeComponent();
        }

        private void AddAuditorium_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.raspisanieDataSet.Building);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Auditorium". При необходимости она может быть перемещена или удалена.
            this.auditoriumTableAdapter.Fill(this.raspisanieDataSet.Auditorium);

            var buildings = (from b in raspisanieDataSet.Building
                            select new
                            {
                                b.id,
                                b.name
                            }).ToList();

            building_idComboBox.DataSource = buildings;
            building_idComboBox.ValueMember = "id";
            building_idComboBox.DisplayMember = "name";
            building_idComboBox.SelectedIndex = -1;

            typeComboBox.DataSource = new List<string>()
            {
                "Лекционная",
                "Практическая",
                "Лаборатория",
                "Компьюетерный класс"
            };
            typeComboBox.SelectedIndex = -1;
        }
        
        private void AddAuditorium_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "" &&
                    typeComboBox.SelectedIndex != -1 &&
                        capacityTextBox.Text != "" &&
                            building_idComboBox.SelectedIndex != -1)
            {
                var verify = (from a in raspisanieDataSet.Auditorium
                              where a.number== numberTextBox.Text && 
                                    a.building_id == int.Parse(building_idComboBox.SelectedValue.ToString())
                              select a).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такая аудитория уже существует");
                }
                else
                {
                    var result = MessageBox.Show($"Вы действительно хотите добавить " +
                        $"аудиторию в корпус { building_idComboBox.SelectedValue.ToString() }",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        auditoriumTableAdapter.Insert(numberTextBox.Text.Trim(),
                                typeComboBox.SelectedValue.ToString(),
                                int.Parse(capacityTextBox.Text.ToString()),
                                int.Parse(building_idComboBox.SelectedValue.ToString()));

                        MessageBox.Show("Аудитория успешно добавлена");
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не заполнили полностью форму!");
            }
        }
    }
}
