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
    public partial class AddGroup : BaseForm
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.raspisanieDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.raspisanieDataSet.Group);
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

        private void AddGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "" &&
                    nameTextBox.Text != "" &&
                        quantityTextBox.Text != "" &&
                            department_idComboBox.SelectedIndex != -1)
            {
                var verify = (from g in raspisanieDataSet.Group
                              where g.number == numberTextBox.Text
                              select g).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("Такая группа уже существует");
                }
                else
                {
                    var result = MessageBox.Show($"Вы действительно хотите добавить " +
                        $"группу на кафедру { department_idComboBox.SelectedValue.ToString() }",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        groupTableAdapter.Insert(numberTextBox.Text.Trim(),
                            nameTextBox.Text.Trim(),
                                int.Parse(department_idComboBox.SelectedValue.ToString()),
                                    int.Parse(quantityTextBox.Text.ToString()));

                        MessageBox.Show("Группа успешно добавлена");
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
