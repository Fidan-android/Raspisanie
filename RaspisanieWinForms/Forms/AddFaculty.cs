using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaspisanieWinForms.Helpers;

namespace RaspisanieWinForms.Forms
{
    public partial class AddFaculty : BaseForm, IRefreshContent
    {
        public AddFaculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            onRefreshContent();
        }

        public void onRefreshContent()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.raspisanieDataSet.Building);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.raspisanieDataSet.Faculty);

            var buildings_all = (from b in raspisanieDataSet.Building
                             select new
                             {
                                 b.id,
                                 b.name
                             }).ToList();

            var buildings_with_faculty = (from f in raspisanieDataSet.Faculty
                                          select f.building_id).ToList();

            var buildings = (from b in buildings_all
                           where !buildings_with_faculty.Any(a => a == b.id)
                           select b).ToList();

            building_idComboBox.DataSource = buildings;
            building_idComboBox.ValueMember = "id";
            building_idComboBox.DisplayMember = "name";
            building_idComboBox.SelectedIndex = -1;
        }

        private void Faculty_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (building_idComboBox.SelectedIndex != -1 &&
                    nameTextBox.Text != "" &&
                        phoneTextBox.Text.Length == 12)
            {
                var verify = (from f in raspisanieDataSet.Faculty
                              where f.name == nameTextBox.Text
                              select f).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такой факультет уже существует");
                }
                else
                {
                    var result = MessageBox.Show($"Вы действительно хотите добавить " +
                        $"факультет в корпус { building_idComboBox.SelectedValue.ToString() }",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        facultyTableAdapter.Insert(int.Parse(building_idComboBox.SelectedValue.ToString()),
                                nameTextBox.Text.Trim(),
                                    phoneTextBox.Text.Trim());

                        MessageBox.Show("Факультет успешно добавлен");
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не заполнили форму полностью!");
            }
        }
    }
}
