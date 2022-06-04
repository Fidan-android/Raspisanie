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
    public partial class AddCurriculum : BaseForm
    {
        public AddCurriculum()
        {
            InitializeComponent();
        }

        private void AddCurriculum_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.raspisanieDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Lesson_type". При необходимости она может быть перемещена или удалена.
            this.lesson_typeTableAdapter.Fill(this.raspisanieDataSet.Lesson_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.raspisanieDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.raspisanieDataSet.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Curriculum". При необходимости она может быть перемещена или удалена.
            this.curriculumTableAdapter.Fill(this.raspisanieDataSet.Curriculum);

            var diciplines = (from d in raspisanieDataSet.Discipline
                             select new
                             {
                                 d.id,
                                 d.name
                             }).ToList();

            dicpline_idComboBox.DataSource = diciplines;
            dicpline_idComboBox.ValueMember = "id";
            dicpline_idComboBox.DisplayMember = "name";
            dicpline_idComboBox.SelectedIndex = -1;

            var lesson_types = (from lt in raspisanieDataSet.Lesson_type
                             select new
                             {
                                 lt.id,
                                 lt.name
                             }).ToList();

            lesson_typeComboBox.DataSource = lesson_types;
            lesson_typeComboBox.ValueMember = "id";
            lesson_typeComboBox.DisplayMember = "name";
            lesson_typeComboBox.SelectedIndex = -1;

            var groups = (from g in raspisanieDataSet.Group
                             select new
                             {
                                 g.id,
                                 g.number
                             }).ToList();

            group_idComboBox.DataSource = groups;
            group_idComboBox.ValueMember = "id";
            group_idComboBox.DisplayMember = "number";
            group_idComboBox.SelectedIndex = -1;

            var teachers = (from t in raspisanieDataSet.Teacher
                             select new
                             {
                                 t.id,
                                 teacher = t.first_name + " "
                                        + t.middle_name.Substring(0, 1) + ". "
                                        + t.last_name.Substring(0, 1) + ".",
                             }).ToList();

            teacher_idComboBox.DataSource = teachers;
            teacher_idComboBox.ValueMember = "id";
            teacher_idComboBox.DisplayMember = "teacher";
            teacher_idComboBox.SelectedIndex = -1;
        }

        private void AddCurriculum_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = (Menu)Helper.BackStack;
            menu.onRefreshContent();
            menu.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dicpline_idComboBox.SelectedIndex != -1 &&
                    lesson_typeComboBox.SelectedIndex != -1 &&
                        group_idComboBox.SelectedIndex != -1 &&
                            teacher_idComboBox.SelectedIndex != -1)
            {
                var verify = (from c in raspisanieDataSet.Curriculum
                              where c.dicpline_id == int.Parse(dicpline_idComboBox.SelectedValue.ToString()) &&
                                        c.lesson_type == int.Parse(lesson_typeComboBox.SelectedValue.ToString()) &&
                                            c.group_id == int.Parse(group_idComboBox.SelectedValue.ToString())
                              select c).ToList();

                if (verify.Count > 0)
                {
                    MessageBox.Show("На данную дисциплину и группу уже заполнен учебный план");
                }
                else
                {
                    var result = MessageBox.Show($"Вы действительно хотите дополнить учебный план?",
                        "Добавление...",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        curriculumTableAdapter.Insert(int.Parse(dicpline_idComboBox.SelectedValue.ToString()),
                                int.Parse(lesson_typeComboBox.SelectedValue.ToString()),
                                    int.Parse(group_idComboBox.SelectedValue.ToString()),
                                        int.Parse(teacher_idComboBox.SelectedValue.ToString()),
                                            int.Parse(scheduled_hoursNumericUpDown.Value.ToString()));

                        MessageBox.Show("Учебный план успешно дополнен!");
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
