namespace RaspisanieWinForms.Forms
{
    partial class AddCurriculum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label dicpline_idLabel;
            System.Windows.Forms.Label lesson_typeLabel;
            System.Windows.Forms.Label group_idLabel;
            System.Windows.Forms.Label teacher_idLabel;
            System.Windows.Forms.Label scheduled_hoursLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCurriculum));
            this.btnSave = new System.Windows.Forms.Button();
            this.raspisanieDataSet = new RaspisanieWinForms.RaspisanieDataSet();
            this.curriculumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curriculumTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.CurriculumTableAdapter();
            this.tableAdapterManager = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager();
            this.disciplineTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.DisciplineTableAdapter();
            this.groupTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.GroupTableAdapter();
            this.lesson_typeTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.Lesson_typeTableAdapter();
            this.teacherTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TeacherTableAdapter();
            this.dicpline_idComboBox = new System.Windows.Forms.ComboBox();
            this.lesson_typeComboBox = new System.Windows.Forms.ComboBox();
            this.group_idComboBox = new System.Windows.Forms.ComboBox();
            this.teacher_idComboBox = new System.Windows.Forms.ComboBox();
            this.scheduled_hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lesson_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            dicpline_idLabel = new System.Windows.Forms.Label();
            lesson_typeLabel = new System.Windows.Forms.Label();
            group_idLabel = new System.Windows.Forms.Label();
            teacher_idLabel = new System.Windows.Forms.Label();
            scheduled_hoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesson_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 16F);
            label1.Location = new System.Drawing.Point(158, 9);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(335, 22);
            label1.TabIndex = 10;
            label1.Text = "Заполнение учебного плана";
            // 
            // dicpline_idLabel
            // 
            dicpline_idLabel.AutoSize = true;
            dicpline_idLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            dicpline_idLabel.Location = new System.Drawing.Point(141, 103);
            dicpline_idLabel.Name = "dicpline_idLabel";
            dicpline_idLabel.Size = new System.Drawing.Size(130, 19);
            dicpline_idLabel.TabIndex = 12;
            dicpline_idLabel.Text = "Дисциплина:";
            // 
            // lesson_typeLabel
            // 
            lesson_typeLabel.AutoSize = true;
            lesson_typeLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            lesson_typeLabel.Location = new System.Drawing.Point(141, 136);
            lesson_typeLabel.Name = "lesson_typeLabel";
            lesson_typeLabel.Size = new System.Drawing.Size(130, 19);
            lesson_typeLabel.TabIndex = 13;
            lesson_typeLabel.Text = "Тип лекции:";
            // 
            // group_idLabel
            // 
            group_idLabel.AutoSize = true;
            group_idLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            group_idLabel.Location = new System.Drawing.Point(185, 169);
            group_idLabel.Name = "group_idLabel";
            group_idLabel.Size = new System.Drawing.Size(86, 19);
            group_idLabel.TabIndex = 14;
            group_idLabel.Text = "Группа:";
            // 
            // teacher_idLabel
            // 
            teacher_idLabel.AutoSize = true;
            teacher_idLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            teacher_idLabel.Location = new System.Drawing.Point(119, 202);
            teacher_idLabel.Name = "teacher_idLabel";
            teacher_idLabel.Size = new System.Drawing.Size(152, 19);
            teacher_idLabel.TabIndex = 15;
            teacher_idLabel.Text = "Преподаватель";
            // 
            // scheduled_hoursLabel
            // 
            scheduled_hoursLabel.AutoSize = true;
            scheduled_hoursLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            scheduled_hoursLabel.Location = new System.Drawing.Point(108, 234);
            scheduled_hoursLabel.Name = "scheduled_hoursLabel";
            scheduled_hoursLabel.Size = new System.Drawing.Size(163, 19);
            scheduled_hoursLabel.TabIndex = 16;
            scheduled_hoursLabel.Text = "Плановые часы:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(520, 321);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // raspisanieDataSet
            // 
            this.raspisanieDataSet.DataSetName = "RaspisanieDataSet";
            this.raspisanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // curriculumBindingSource
            // 
            this.curriculumBindingSource.DataMember = "Curriculum";
            this.curriculumBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // curriculumTableAdapter
            // 
            this.curriculumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoriumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.CallTableAdapter = null;
            this.tableAdapterManager.CurriculumTableAdapter = this.curriculumTableAdapter;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = this.disciplineTableAdapter;
            this.tableAdapterManager.DistanceTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = this.groupTableAdapter;
            this.tableAdapterManager.Lesson_typeTableAdapter = this.lesson_typeTableAdapter;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeekTableAdapter = null;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // lesson_typeTableAdapter
            // 
            this.lesson_typeTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // dicpline_idComboBox
            // 
            this.dicpline_idComboBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.dicpline_idComboBox.FormattingEnabled = true;
            this.dicpline_idComboBox.Location = new System.Drawing.Point(277, 100);
            this.dicpline_idComboBox.Name = "dicpline_idComboBox";
            this.dicpline_idComboBox.Size = new System.Drawing.Size(256, 27);
            this.dicpline_idComboBox.TabIndex = 13;
            // 
            // lesson_typeComboBox
            // 
            this.lesson_typeComboBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lesson_typeComboBox.FormattingEnabled = true;
            this.lesson_typeComboBox.Location = new System.Drawing.Point(277, 133);
            this.lesson_typeComboBox.Name = "lesson_typeComboBox";
            this.lesson_typeComboBox.Size = new System.Drawing.Size(256, 27);
            this.lesson_typeComboBox.TabIndex = 14;
            // 
            // group_idComboBox
            // 
            this.group_idComboBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.group_idComboBox.FormattingEnabled = true;
            this.group_idComboBox.Location = new System.Drawing.Point(277, 166);
            this.group_idComboBox.Name = "group_idComboBox";
            this.group_idComboBox.Size = new System.Drawing.Size(256, 27);
            this.group_idComboBox.TabIndex = 15;
            // 
            // teacher_idComboBox
            // 
            this.teacher_idComboBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.teacher_idComboBox.FormattingEnabled = true;
            this.teacher_idComboBox.Location = new System.Drawing.Point(277, 199);
            this.teacher_idComboBox.Name = "teacher_idComboBox";
            this.teacher_idComboBox.Size = new System.Drawing.Size(256, 27);
            this.teacher_idComboBox.TabIndex = 16;
            // 
            // scheduled_hoursNumericUpDown
            // 
            this.scheduled_hoursNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.scheduled_hoursNumericUpDown.Location = new System.Drawing.Point(278, 232);
            this.scheduled_hoursNumericUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.scheduled_hoursNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.scheduled_hoursNumericUpDown.Name = "scheduled_hoursNumericUpDown";
            this.scheduled_hoursNumericUpDown.Size = new System.Drawing.Size(255, 26);
            this.scheduled_hoursNumericUpDown.TabIndex = 17;
            this.scheduled_hoursNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // lesson_typeBindingSource
            // 
            this.lesson_typeBindingSource.DataMember = "Lesson_type";
            this.lesson_typeBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // AddCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 366);
            this.Controls.Add(scheduled_hoursLabel);
            this.Controls.Add(this.scheduled_hoursNumericUpDown);
            this.Controls.Add(teacher_idLabel);
            this.Controls.Add(this.teacher_idComboBox);
            this.Controls.Add(group_idLabel);
            this.Controls.Add(this.group_idComboBox);
            this.Controls.Add(lesson_typeLabel);
            this.Controls.Add(this.lesson_typeComboBox);
            this.Controls.Add(dicpline_idLabel);
            this.Controls.Add(this.dicpline_idComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddCurriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебный план";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCurriculum_FormClosing);
            this.Load += new System.EventHandler(this.AddCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesson_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource curriculumBindingSource;
        private RaspisanieDataSetTableAdapters.CurriculumTableAdapter curriculumTableAdapter;
        private RaspisanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RaspisanieDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.ComboBox dicpline_idComboBox;
        private System.Windows.Forms.ComboBox lesson_typeComboBox;
        private System.Windows.Forms.ComboBox group_idComboBox;
        private System.Windows.Forms.ComboBox teacher_idComboBox;
        private System.Windows.Forms.NumericUpDown scheduled_hoursNumericUpDown;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private RaspisanieDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private RaspisanieDataSetTableAdapters.Lesson_typeTableAdapter lesson_typeTableAdapter;
        private System.Windows.Forms.BindingSource lesson_typeBindingSource;
        private RaspisanieDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
    }
}