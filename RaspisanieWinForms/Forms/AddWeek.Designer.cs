namespace RaspisanieWinForms.Forms
{
    partial class AddWeek
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
            System.Windows.Forms.Label day_of_weekLabel;
            System.Windows.Forms.Label type_of_weekLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWeek));
            this.btnSave = new System.Windows.Forms.Button();
            this.raspisanieDataSet = new RaspisanieWinForms.RaspisanieDataSet();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.WeekTableAdapter();
            this.tableAdapterManager = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager();
            this.day_of_weekTextBox = new System.Windows.Forms.TextBox();
            this.type_of_weekComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            day_of_weekLabel = new System.Windows.Forms.Label();
            type_of_weekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 16F);
            label1.Location = new System.Drawing.Point(201, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(205, 22);
            label1.TabIndex = 10;
            label1.Text = "Создание недели";
            // 
            // day_of_weekLabel
            // 
            day_of_weekLabel.AutoSize = true;
            day_of_weekLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            day_of_weekLabel.Location = new System.Drawing.Point(127, 102);
            day_of_weekLabel.Name = "day_of_weekLabel";
            day_of_weekLabel.Size = new System.Drawing.Size(141, 19);
            day_of_weekLabel.TabIndex = 12;
            day_of_weekLabel.Text = "День недели:";
            // 
            // type_of_weekLabel
            // 
            type_of_weekLabel.AutoSize = true;
            type_of_weekLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            type_of_weekLabel.Location = new System.Drawing.Point(138, 134);
            type_of_weekLabel.Name = "type_of_weekLabel";
            type_of_weekLabel.Size = new System.Drawing.Size(130, 19);
            type_of_weekLabel.TabIndex = 13;
            type_of_weekLabel.Text = "Тип недели:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(487, 240);
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
            // weekBindingSource
            // 
            this.weekBindingSource.DataMember = "Week";
            this.weekBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // weekTableAdapter
            // 
            this.weekTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Lesson_typeTableAdapter = null;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeekTableAdapter = this.weekTableAdapter;
            // 
            // day_of_weekTextBox
            // 
            this.day_of_weekTextBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.day_of_weekTextBox.Location = new System.Drawing.Point(274, 99);
            this.day_of_weekTextBox.Name = "day_of_weekTextBox";
            this.day_of_weekTextBox.Size = new System.Drawing.Size(237, 26);
            this.day_of_weekTextBox.TabIndex = 13;
            // 
            // type_of_weekComboBox
            // 
            this.type_of_weekComboBox.FormattingEnabled = true;
            this.type_of_weekComboBox.Location = new System.Drawing.Point(274, 131);
            this.type_of_weekComboBox.Name = "type_of_weekComboBox";
            this.type_of_weekComboBox.Size = new System.Drawing.Size(237, 24);
            this.type_of_weekComboBox.TabIndex = 14;
            // 
            // AddWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 286);
            this.Controls.Add(this.type_of_weekComboBox);
            this.Controls.Add(type_of_weekLabel);
            this.Controls.Add(day_of_weekLabel);
            this.Controls.Add(this.day_of_weekTextBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddWeek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Недели";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWeek_FormClosing);
            this.Load += new System.EventHandler(this.AddWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource weekBindingSource;
        private RaspisanieDataSetTableAdapters.WeekTableAdapter weekTableAdapter;
        private RaspisanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox day_of_weekTextBox;
        private System.Windows.Forms.ComboBox type_of_weekComboBox;
    }
}