namespace RaspisanieWinForms.Forms
{
    partial class AddGroup
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label department_idLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroup));
            this.raspisanieDataSet = new RaspisanieWinForms.RaspisanieDataSet();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.department_idComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.DepartmentTableAdapter();
            this.groupTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.GroupTableAdapter();
            numberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            department_idLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            numberLabel.Location = new System.Drawing.Point(104, 109);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(152, 19);
            numberLabel.TabIndex = 1;
            numberLabel.Text = "Номер группы:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            nameLabel.Location = new System.Drawing.Point(93, 141);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(163, 19);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Специальность:";
            // 
            // department_idLabel
            // 
            department_idLabel.AutoSize = true;
            department_idLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            department_idLabel.Location = new System.Drawing.Point(159, 205);
            department_idLabel.Name = "department_idLabel";
            department_idLabel.Size = new System.Drawing.Size(97, 19);
            department_idLabel.TabIndex = 4;
            department_idLabel.Text = "Кафедра:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            quantityLabel.Location = new System.Drawing.Point(115, 173);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(141, 19);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Размерность:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 16.25F);
            label1.Location = new System.Drawing.Point(192, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(231, 22);
            label1.TabIndex = 8;
            label1.Text = "Добавление группы";
            // 
            // raspisanieDataSet
            // 
            this.raspisanieDataSet.DataSetName = "RaspisanieDataSet";
            this.raspisanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoriumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.CallTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.numberTextBox.Location = new System.Drawing.Point(262, 106);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(221, 26);
            this.numberTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.nameTextBox.Location = new System.Drawing.Point(262, 138);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // department_idComboBox
            // 
            this.department_idComboBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.department_idComboBox.FormattingEnabled = true;
            this.department_idComboBox.Location = new System.Drawing.Point(262, 202);
            this.department_idComboBox.Name = "department_idComboBox";
            this.department_idComboBox.Size = new System.Drawing.Size(221, 27);
            this.department_idComboBox.TabIndex = 5;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.quantityTextBox.Location = new System.Drawing.Point(262, 170);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(221, 26);
            this.quantityTextBox.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 290);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 341);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(label1);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(department_idLabel);
            this.Controls.Add(this.department_idComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddGroup_FormClosing);
            this.Load += new System.EventHandler(this.AddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private RaspisanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox department_idComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private RaspisanieDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private RaspisanieDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
    }
}