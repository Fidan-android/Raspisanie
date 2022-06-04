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
    public partial class AddDepartment : BaseForm
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.raspisanieDataSet.Faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.raspisanieDataSet.Department);

            var faculties = (from f in raspisanieDataSet.Faculty
                             select new
                             {
                                 f.id,
                                 f.name
                             }).ToList();

            faculty_idComboBox.DataSource = faculties;
            faculty_idComboBox.ValueMember = "id";
            faculty_idComboBox.DisplayMember = "name";
            faculty_idComboBox.SelectedIndex = -1;
        }

        private void AddDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" &&
                    phoneTextBox.Text != "" &&
                            faculty_idComboBox.SelectedIndex != -1)
            {
                var verify = (from d in raspisanieDataSet.Department
                              where d.name == nameTextBox.Text
                              select d).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такая кафедра уже существует");
                }
                else
                {
                    var result = MessageBox.Show($"Вы действительно хотите добавить " +
                        $"кафедру на факультет { faculty_idComboBox.SelectedValue.ToString() } ?",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        departmentTableAdapter.Insert(int.Parse(faculty_idComboBox.SelectedValue.ToString()),
                                nameTextBox.Text.Trim(),
                                    phoneTextBox.Text.Trim());

                        MessageBox.Show("Кафедра успешно добавлена");
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
