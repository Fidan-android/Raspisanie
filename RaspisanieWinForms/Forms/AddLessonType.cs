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
    public partial class AddLessonType : BaseForm
    {
        public AddLessonType()
        {
            InitializeComponent();
        }

        private void AddLessonType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Lesson_type". При необходимости она может быть перемещена или удалена.
            this.lesson_typeTableAdapter.Fill(this.raspisanieDataSet.Lesson_type);

        }

        private void AddLessonType_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                var verify = (from l in raspisanieDataSet.Lesson_type
                              where l.name == nameTextBox.Text
                              select l).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такой тип уже существует");
                }
                else
                {
                    var result = MessageBox.Show("Вы действительно хотите добавить тип лекции?",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        lesson_typeTableAdapter.Insert(nameTextBox.Text.Trim(),
                                int.Parse(durationNumericUpDown.Value.ToString()));

                        MessageBox.Show("Тип лекции успешно добавлен");
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
