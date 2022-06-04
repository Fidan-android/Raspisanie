namespace RaspisanieWinForms.Forms
{
    partial class AddTeacher
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
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label teacher_positionLabel;
            System.Windows.Forms.Label department_idLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher));
            this.btnSave = new System.Windows.Forms.Button();
            this.raspisanieDataSet = new RaspisanieWinForms.RaspisanieDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TeacherTableAdapter();
            this.tableAdapterManager = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.DepartmentTableAdapter();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.teacher_positionTextBox = new System.Windows.Forms.TextBox();
            this.department_idComboBox = new System.Windows.Forms.ComboBox();
            first_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            teacher_positionLabel = new System.Windows.Forms.Label();
            department_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(513, 302);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // raspisanieDataSet
            // 
            this.raspisanieDataSet.DataSetName = "RaspisanieDataSet";
            this.raspisanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoriumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.CallTableAdapter = null;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.DistanceTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.Lesson_typeTableAdapter = null;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeekTableAdapter = null;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            first_nameLabel.Location = new System.Drawing.Point(150, 93);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(97, 19);
            first_nameLabel.TabIndex = 7;
            first_nameLabel.Text = "Фамилия:";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.first_nameTextBox.Location = new System.Drawing.Point(253, 90);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(275, 26);
            this.first_nameTextBox.TabIndex = 8;
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            middle_nameLabel.Location = new System.Drawing.Point(194, 125);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(53, 19);
            middle_nameLabel.TabIndex = 8;
            middle_nameLabel.Text = "Имя:";
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.middle_nameTextBox.Location = new System.Drawing.Point(253, 122);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(275, 26);
            this.middle_nameTextBox.TabIndex = 9;
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            last_nameLabel.Location = new System.Drawing.Point(139, 157);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(108, 19);
            last_nameLabel.TabIndex = 9;
            last_nameLabel.Text = "Отчество:";
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.last_nameTextBox.Location = new System.Drawing.Point(253, 154);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(275, 26);
            this.last_nameTextBox.TabIndex = 10;
            // 
            // teacher_positionLabel
            // 
            teacher_positionLabel.AutoSize = true;
            teacher_positionLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            teacher_positionLabel.Location = new System.Drawing.Point(128, 189);
            teacher_positionLabel.Name = "teacher_positionLabel";
            teacher_positionLabel.Size = new System.Drawing.Size(119, 19);
            teacher_positionLabel.TabIndex = 10;
            teacher_positionLabel.Text = "Должность:";
            // 
            // teacher_positionTextBox
            // 
            this.teacher_positionTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.teacher_positionTextBox.Location = new System.Drawing.Point(253, 186);
            this.teacher_positionTextBox.Name = "teacher_positionTextBox";
            this.teacher_positionTextBox.Size = new System.Drawing.Size(275, 26);
            this.teacher_positionTextBox.TabIndex = 11;
            // 
            // department_idLabel
            // 
            department_idLabel.AutoSize = true;
            department_idLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            department_idLabel.Location = new System.Drawing.Point(150, 221);
            department_idLabel.Name = "department_idLabel";
            department_idLabel.Size = new System.Drawing.Size(97, 19);
            department_idLabel.TabIndex = 11;
            department_idLabel.Text = "Кафедра:";
            // 
            // department_idComboBox
            // 
            this.department_idComboBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.department_idComboBox.FormattingEnabled = true;
            this.department_idComboBox.Location = new System.Drawing.Point(253, 218);
            this.department_idComboBox.Name = "department_idComboBox";
            this.department_idComboBox.Size = new System.Drawing.Size(275, 27);
            this.department_idComboBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 16.25F);
            label1.Location = new System.Drawing.Point(188, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(322, 22);
            label1.TabIndex = 13;
            label1.Text = "Добавление преподавателя";
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 345);
            this.Controls.Add(label1);
            this.Controls.Add(department_idLabel);
            this.Controls.Add(this.department_idComboBox);
            this.Controls.Add(teacher_positionLabel);
            this.Controls.Add(this.teacher_positionTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(middle_nameLabel);
            this.Controls.Add(this.middle_nameTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преподаватели";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTeacher_FormClosing);
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private RaspisanieDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private RaspisanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RaspisanieDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox teacher_positionTextBox;
        private System.Windows.Forms.ComboBox department_idComboBox;
    }
}