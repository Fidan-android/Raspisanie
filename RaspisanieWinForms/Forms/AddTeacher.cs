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
    public partial class AddTeacher : BaseForm
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.raspisanieDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.raspisanieDataSet.Teacher);

            var departments = (from d in raspisanieDataSet.Department
                              select new
                              {
                                  d.id,
                                  d.name
                              }).ToList();

            department_idComboBox.DataSource = departments;
            department_idComboBox.ValueMember = "id";
            department_idComboBox.DisplayMember = "name";
            department_idComboBox.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (first_nameTextBox.Text != "" &&
                    middle_nameTextBox.Text != "" &&
                        last_nameTextBox.Text != "" &&
                            teacher_positionTextBox.Text != "" &&
                                department_idComboBox.SelectedIndex != -1)
            {
                var verify = (from t in raspisanieDataSet.Teacher
                              where t.first_name == first_nameTextBox.Text &&
                                        t.middle_name == middle_nameTextBox.Text &&
                                            t.last_name == last_nameTextBox.Text &&
                                                t.teacher_position == teacher_positionTextBox.Text
                              select t).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такой преподаватель уже существует");
                }
                else
                {
                    var result = MessageBox.Show($"Вы действительно хотите добавить " +
                        $"преподавателя на кафедру { department_idComboBox.SelectedValue.ToString() }",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        teacherTableAdapter.Insert(first_nameTextBox.Text.Trim(),
                            middle_nameTextBox.Text.Trim(),
                                last_nameTextBox.Text.Trim(),
                                    teacher_positionTextBox.Text,
                                int.Parse(department_idComboBox.SelectedValue.ToString()));

                        MessageBox.Show("Преподаватель успешно добавлен");
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не заполнили полностью форму!");
            }
        }

        private void AddTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }
    }
}
