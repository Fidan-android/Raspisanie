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
    public partial class AddCall : BaseForm
    {
        public AddCall()
        {
            InitializeComponent();
        }

        private void AddCall_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Call". При необходимости она может быть перемещена или удалена.
            this.callTableAdapter.Fill(this.raspisanieDataSet.Call);
        }

        private void AddCall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" &&
                    start_hoursTextBox.Text != "" &&
                        end_hoursTextBox.Text != "")
            {
                var verify = (from c in raspisanieDataSet.Call
                              where c.name == nameTextBox.Text
                              select c).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такой звонок уже существует");
                }
                else
                {
                    var result = MessageBox.Show("Вы действительно хотите добавить звонок?",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        callTableAdapter.Insert(nameTextBox.Text.Trim(), 
                                TimeSpan.Parse(start_hoursTextBox.Text.ToString()),
                                TimeSpan.Parse(end_hoursTextBox.Text.ToString()));

                        MessageBox.Show("Звонок успешно добавлен");
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
