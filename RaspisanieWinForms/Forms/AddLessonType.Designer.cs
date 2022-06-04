namespace RaspisanieWinForms.Forms
{
    partial class AddLessonType
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label durationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLessonType));
            this.btnSave = new System.Windows.Forms.Button();
            this.raspisanieDataSet = new RaspisanieWinForms.RaspisanieDataSet();
            this.lesson_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lesson_typeTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.Lesson_typeTableAdapter();
            this.tableAdapterManager = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesson_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 16F);
            label1.Location = new System.Drawing.Point(148, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(270, 22);
            label1.TabIndex = 10;
            label1.Text = "Создание типа лекций";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            nameLabel.Location = new System.Drawing.Point(138, 122);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(119, 19);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Назавание:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            durationLabel.Location = new System.Drawing.Point(50, 154);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(207, 19);
            durationLabel.TabIndex = 13;
            durationLabel.Text = "Продолжительность:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(434, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 26);
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
            // lesson_typeBindingSource
            // 
            this.lesson_typeBindingSource.DataMember = "Lesson_type";
            this.lesson_typeBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // lesson_typeTableAdapter
            // 
            this.lesson_typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoriumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.CallTableAdapter = null;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.DistanceTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.Lesson_typeTableAdapter = this.lesson_typeTableAdapter;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeekTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.nameTextBox.Location = new System.Drawing.Point(263, 119);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 26);
            this.nameTextBox.TabIndex = 13;
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.Location = new System.Drawing.Point(263, 154);
            this.durationNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.durationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(203, 23);
            this.durationNumericUpDown.TabIndex = 15;
            this.durationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddLessonType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 323);
            this.Controls.Add(this.durationNumericUpDown);
            this.Controls.Add(durationLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddLessonType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы лекций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddLessonType_FormClosing);
            this.Load += new System.EventHandler(this.AddLessonType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesson_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource lesson_typeBindingSource;
        private RaspisanieDataSetTableAdapters.Lesson_typeTableAdapter lesson_typeTableAdapter;
        private RaspisanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown durationNumericUpDown;
    }
}