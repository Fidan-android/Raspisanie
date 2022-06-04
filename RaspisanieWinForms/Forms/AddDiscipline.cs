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
    public partial class AddDiscipline : BaseForm
    {
        public AddDiscipline()
        {
            InitializeComponent();
        }

        private void AddDiscipline_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.raspisanieDataSet.Discipline);

        }

        private void AddDiscipline_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                var verify = (from d in raspisanieDataSet.Discipline
                              where d.name == nameTextBox.Text
                              select d).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такая дисциплина уже существует");
                }
                else
                {
                    var result = MessageBox.Show("Вы действительно хотите добавить дисциплину?",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        disciplineTableAdapter.Insert(nameTextBox.Text.Trim());

                        MessageBox.Show("Дисциплина успешно добавлена");
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
