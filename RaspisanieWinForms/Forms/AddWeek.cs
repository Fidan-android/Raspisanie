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
    public partial class AddWeek : BaseForm
    {
        public AddWeek()
        {
            InitializeComponent();
        }

        private void AddWeek_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Week". При необходимости она может быть перемещена или удалена.
            this.weekTableAdapter.Fill(this.raspisanieDataSet.Week);
            type_of_weekComboBox.DataSource = new List<string>()
            {
                "четная",
                "нечетная"
            };
            type_of_weekComboBox.SelectedIndex = -1;
        }

        private void AddWeek_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (day_of_weekTextBox.Text != "" &&
                    type_of_weekComboBox.SelectedIndex != -1)
            {
                var verify = (from w in raspisanieDataSet.Week
                              where w.day_of_week == day_of_weekTextBox.Text &&
                                        w.type_of_week == type_of_weekComboBox.SelectedValue.ToString()
                              select w).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такой тип недели уже существует");
                }
                else
                {
                    var result = MessageBox.Show("Вы действительно хотите добавить тип недели?",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        weekTableAdapter.Insert(day_of_weekTextBox.Text.Trim(),
                                type_of_weekComboBox.SelectedValue.ToString());

                        MessageBox.Show("Тип недели успешно добавлен");
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
