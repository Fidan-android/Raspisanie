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
using RaspisanieWinForms.Forms;

namespace RaspisanieWinForms
{
    public partial class Menu : BaseForm, IRefreshContent
    {
        private EventHandler defaultEventHandler = null;

        public Menu()
        {
            base.InitializeComponent();
            InitializeComponent();
        }
        
        // Метод, который вызывается когда форма загружается
        private void Menu_Load(object sender, EventArgs e)
        {
            onRefreshContent();
            btnAdd.Enabled = false;
        }

        // Метод, который вызывается когда форма закрывается
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you leave?", "Leaving..", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        // Приватный метод для обновления панели с таблицей данных
        private void onRefreshPanel(IEnumerable<dynamic> data) {
            contentPanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = data.ToList();
            contentPanel.Controls.Add(dataGridView);
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Margin = new Padding(10);

            dataGridView.AutoResizeColumns();
        }

        // Приватный метод для очистки обрабочтика нажатия кнопки
        private void ClearEventHandlerOnButton(EventHandler eh)
        {
            btnAdd.Click -= defaultEventHandler;
            defaultEventHandler = eh;

            if (defaultEventHandler != null)
            {
                btnAdd.Click += defaultEventHandler;
            }
        }

        /*
         * Метод унаследованный от интерфейса IRefreshContent, 
         * необходим для обновления адаптеров данными из базы данных
         */
        public void onRefreshContent()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Auditorium". При необходимости она может быть перемещена или удалена.
            this.auditoriumTableAdapter.Fill(this.raspisanieDataSet.Auditorium);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.raspisanieDataSet.Faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.raspisanieDataSet.Building);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Week". При необходимости она может быть перемещена или удалена.
            this.weekTableAdapter.Fill(this.raspisanieDataSet.Week);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.raspisanieDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Session". При необходимости она может быть перемещена или удалена.
            this.sessionTableAdapter.Fill(this.raspisanieDataSet.Session);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Lesson_type". При необходимости она может быть перемещена или удалена.
            this.lesson_typeTableAdapter.Fill(this.raspisanieDataSet.Lesson_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.raspisanieDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Distance". При необходимости она может быть перемещена или удалена.
            this.distanceTableAdapter.Fill(this.raspisanieDataSet.Distance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.raspisanieDataSet.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Curriculum". При необходимости она может быть перемещена или удалена.
            this.curriculumTableAdapter.Fill(this.raspisanieDataSet.Curriculum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Call". При необходимости она может быть перемещена или удалена.
            this.callTableAdapter.Fill(this.raspisanieDataSet.Call);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.raspisanieDataSet.Department);

            ClearEventHandlerOnButton(null);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            onRefreshContent();
        }

        // Обработчик кнопки Очистки панели с данными
        private void btnClear_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            btnAdd.Text = "";
            btnAdd.Enabled = false;

            ClearEventHandlerOnButton(null);
        }

        #region [Обработчики нажатий на элементы меню]
        private void корпусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from b in raspisanieDataSet.Building
                       select new
                       {
                           Идентификатор = b.id,
                           Здание = b.name
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить корпус";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddBuilding));
        }

        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from f in raspisanieDataSet.Faculty
                       join b in raspisanieDataSet.Building on f.building_id equals b.id
                       select new
                       {
                           Идентификатор = f.id,
                           Факультет = f.name,
                           Телефон = f.phone,
                           Корпус = b.name
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить факультет";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddFaculty));
        }

        private void аудиторииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from a in raspisanieDataSet.Auditorium
                       join b in raspisanieDataSet.Building on a.building_id equals b.id
                       select new
                       {
                           Идентификатор = a.id,
                           Аудитория = a.number,
                           Тип = a.type,
                           Размерность = a.capacity,
                           Корпус = b.name

                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить аудиторию";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddAuditorium));
        }
        
        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from d in raspisanieDataSet.Department
                       join f in raspisanieDataSet.Faculty on d.faculty_id equals f.id
                       select new
                       {
                           Идентификатор = d.id,
                           Факультет = f.name,
                           Кафедра = d.name,
                           Телефон = d.phone
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить кафедру";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddDepartment));
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from t in raspisanieDataSet.Teacher
                       join d in raspisanieDataSet.Department on t.department_id equals d.id
                       select new
                       {
                           Идентификатор = t.id,
                           ФИО = t.first_name + " " + t.middle_name + " " + t.last_name,
                           Должность = t.teacher_position,
                           Кафедра = d.name
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить преподавателя";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddTeacher));
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from g in raspisanieDataSet.Group
                       join d in raspisanieDataSet.Department on g.department_id equals d.id
                       select new
                       {
                           Идентификатор = g.id,
                           Группа = g.number,
                           Специальность = g.name,
                           Размерность = g.quantity,
                           Кафедра = d.name
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить группу";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddGroup));
        }
        private void звонкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from c in raspisanieDataSet.Call
                       select new
                       {
                           Идентификатор = c.id,
                           Наименование = c.name,
                           Начало = c.start_hours,
                           Конец = c.end_hours
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить звонок";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddCall));
        }
        private void неделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from w in raspisanieDataSet.Week
                       select new
                       {
                           Идентификатор = w.id,
                           День = w.day_of_week,
                           Неделя = w.type_of_week
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить неделю";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddWeek));
        }
        private void типЛекцийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from l in raspisanieDataSet.Lesson_type
                       select new
                       {
                           Идентификатор = l.id,
                           Наименование = l.name,
                           Продолжительность = l.duration
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить тип лекций";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddLessonType));
        }
        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from d in raspisanieDataSet.Discipline
                       select new
                       {
                           Идентификатор = d.id,
                           Наименование = d.name
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить дисциплины";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddDiscipline));
        }

        private void учебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = from c in raspisanieDataSet.Curriculum
                       join d in raspisanieDataSet.Discipline on c.dicpline_id equals d.id
                       join lt in raspisanieDataSet.Lesson_type on c.lesson_type equals lt.id
                       join g in raspisanieDataSet.Group on c.group_id equals g.id
                       join t in raspisanieDataSet.Teacher on c.teacher_id equals t.id
                       select new
                       {
                           Идентификатор = c.id,
                           Дисциплина = d.name,
                           Лекция = lt.name,
                           Группа = g.number,
                           Преподаватель = t.first_name + " " 
                                        + t.middle_name.Substring(0, 1) + ". " 
                                        + t.last_name.Substring(0, 1) + ".",
                           Часы = c.scheduled_hours
                       };
            onRefreshPanel(data);
            btnAdd.Text = "Добавить учебный план";
            btnAdd.Enabled = true;

            ClearEventHandlerOnButton(new EventHandler(this.AddCurriculum));
        }

        private void лекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вся логика
        }
        #endregion


        #region [Процедуры для перехода на формы создания данных]
        private void AddBuilding(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddBuilding().ShowDialog();
            корпусаToolStripMenuItem_Click(sender, e);
        }

        private void AddFaculty(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddFaculty().ShowDialog();
            факультетыToolStripMenuItem_Click(sender, e);
        }

        private void AddAuditorium(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddAuditorium().ShowDialog();
            аудиторииToolStripMenuItem_Click(sender, e);
        }

        private void AddDepartment(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddDepartment().ShowDialog();
            кафедрыToolStripMenuItem_Click(sender, e);
        }

        private void AddTeacher(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddTeacher().ShowDialog();
            преподавателиToolStripMenuItem_Click(sender, e);
        }

        private void AddGroup(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddGroup().ShowDialog();
            группыToolStripMenuItem_Click(sender, e);
        }

        private void AddCall(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddCall().ShowDialog();
            звонкиToolStripMenuItem_Click(sender, e);
        }

        private void AddWeek(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddWeek().ShowDialog();
            неделиToolStripMenuItem_Click(sender, e);
        }

        private void AddLessonType(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddLessonType().ShowDialog();
            типЛекцийToolStripMenuItem_Click(sender, e);
        }

        private void AddDiscipline(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddDiscipline().ShowDialog();
            дисциплиныToolStripMenuItem_Click(sender, e);
        }

        private void AddCurriculum(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddCurriculum().ShowDialog();
            учебныйПланToolStripMenuItem_Click(sender, e);
        }

        private void AddLesson(object sender, EventArgs e)
        {
            Helper.BackStack = this;
            new AddDiscipline().ShowDialog();
            лекцииToolStripMenuItem_Click(sender, e);
        }
        #endregion

    }
}
