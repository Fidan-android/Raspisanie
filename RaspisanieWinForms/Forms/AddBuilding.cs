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
    public partial class AddBuilding : BaseForm, IRefreshContent
    {
        public AddBuilding()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void Building_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void Building_Load(object sender, EventArgs e)
        {
            onRefreshContent();
        }

        public void onRefreshContent()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.raspisanieDataSet.Building);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                var verify = (from b in raspisanieDataSet.Building
                              where b.name == nameTextBox.Text
                              select b).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такой корпус уже существует");
                } else
                {
                    var result = MessageBox.Show($"Вы действительно хотите добавить корпус { nameTextBox.Text }?",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        buildingTableAdapter.Insert(nameTextBox.Text.Trim());
                        MessageBox.Show("Корпус успешно добавлен");
                        Close();
                    }
                }
            } else
            {
                MessageBox.Show("Вы не ввели название корпуса");
            }
        }
    }
}
