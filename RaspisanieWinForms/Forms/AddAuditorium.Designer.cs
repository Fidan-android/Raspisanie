namespace RaspisanieWinForms.Forms
{
    partial class AddAuditorium
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
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label building_idLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuditorium));
            this.raspisanieDataSet = new RaspisanieWinForms.RaspisanieDataSet();
            this.auditoriumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditoriumTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.AuditoriumTableAdapter();
            this.tableAdapterManager = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager();
            this.buildingTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.BuildingTableAdapter();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.building_idComboBox = new System.Windows.Forms.ComboBox();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            numberLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            building_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            numberLabel.Location = new System.Drawing.Point(125, 98);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(119, 19);
            numberLabel.TabIndex = 1;
            numberLabel.Text = "Аудитория:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            typeLabel.Location = new System.Drawing.Point(191, 128);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(53, 19);
            typeLabel.TabIndex = 2;
            typeLabel.Text = "Тип:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            capacityLabel.Location = new System.Drawing.Point(103, 160);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(141, 19);
            capacityLabel.TabIndex = 4;
            capacityLabel.Text = "Размерность:";
            // 
            // building_idLabel
            // 
            building_idLabel.AutoSize = true;
            building_idLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            building_idLabel.Location = new System.Drawing.Point(158, 192);
            building_idLabel.Name = "building_idLabel";
            building_idLabel.Size = new System.Drawing.Size(86, 19);
            building_idLabel.TabIndex = 6;
            building_idLabel.Text = "Корпус:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 16F);
            label1.Location = new System.Drawing.Point(179, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(244, 22);
            label1.TabIndex = 8;
            label1.Text = "Создание аудитории";
            // 
            // raspisanieDataSet
            // 
            this.raspisanieDataSet.DataSetName = "RaspisanieDataSet";
            this.raspisanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditoriumBindingSource
            // 
            this.auditoriumBindingSource.DataMember = "Auditorium";
            this.auditoriumBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // auditoriumTableAdapter
            // 
            this.auditoriumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoriumTableAdapter = this.auditoriumTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = this.buildingTableAdapter;
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
            this.tableAdapterManager.WeekTableAdapter = null;
            // 
            // buildingTableAdapter
            // 
            this.buildingTableAdapter.ClearBeforeFill = true;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.numberTextBox.Location = new System.Drawing.Point(250, 95);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(216, 26);
            this.numberTextBox.TabIndex = 2;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.capacityTextBox.Location = new System.Drawing.Point(250, 157);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(216, 26);
            this.capacityTextBox.TabIndex = 5;
            // 
            // building_idComboBox
            // 
            this.building_idComboBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.building_idComboBox.FormattingEnabled = true;
            this.building_idComboBox.Location = new System.Drawing.Point(250, 189);
            this.building_idComboBox.Name = "building_idComboBox";
            this.building_idComboBox.Size = new System.Drawing.Size(216, 27);
            this.building_idComboBox.TabIndex = 7;
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataMember = "Building";
            this.buildingBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(466, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 26);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(250, 127);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(216, 24);
            this.typeComboBox.TabIndex = 10;
            // 
            // AddAuditorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 299);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(label1);
            this.Controls.Add(building_idLabel);
            this.Controls.Add(this.building_idComboBox);
            this.Controls.Add(capacityLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddAuditorium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аудитории";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAuditorium_FormClosing);
            this.Load += new System.EventHandler(this.AddAuditorium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource auditoriumBindingSource;
        private RaspisanieDataSetTableAdapters.AuditoriumTableAdapter auditoriumTableAdapter;
        private RaspisanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.ComboBox building_idComboBox;
        private RaspisanieDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}