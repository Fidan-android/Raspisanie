namespace RaspisanieWinForms.Forms
{
    partial class AddCall
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
            System.Windows.Forms.Label start_hoursLabel;
            System.Windows.Forms.Label end_hoursLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCall));
            this.btnSave = new System.Windows.Forms.Button();
            this.raspisanieDataSet = new RaspisanieWinForms.RaspisanieDataSet();
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.callTableAdapter = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.CallTableAdapter();
            this.tableAdapterManager = new RaspisanieWinForms.RaspisanieDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.start_hoursTextBox = new System.Windows.Forms.MaskedTextBox();
            this.end_hoursTextBox = new System.Windows.Forms.MaskedTextBox();
            label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            start_hoursLabel = new System.Windows.Forms.Label();
            end_hoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 16F);
            label1.Location = new System.Drawing.Point(184, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(205, 22);
            label1.TabIndex = 10;
            label1.Text = "Создание звонка";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            nameLabel.Location = new System.Drawing.Point(123, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(108, 19);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Название:";
            // 
            // start_hoursLabel
            // 
            start_hoursLabel.AutoSize = true;
            start_hoursLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            start_hoursLabel.Location = new System.Drawing.Point(145, 133);
            start_hoursLabel.Name = "start_hoursLabel";
            start_hoursLabel.Size = new System.Drawing.Size(86, 19);
            start_hoursLabel.TabIndex = 13;
            start_hoursLabel.Text = "Начало:";
            // 
            // end_hoursLabel
            // 
            end_hoursLabel.AutoSize = true;
            end_hoursLabel.Font = new System.Drawing.Font("Lucida Console", 14F);
            end_hoursLabel.Location = new System.Drawing.Point(156, 162);
            end_hoursLabel.Name = "end_hoursLabel";
            end_hoursLabel.Size = new System.Drawing.Size(75, 19);
            end_hoursLabel.TabIndex = 14;
            end_hoursLabel.Text = "Конец:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(458, 228);
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
            // callBindingSource
            // 
            this.callBindingSource.DataMember = "Call";
            this.callBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // callTableAdapter
            // 
            this.callTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoriumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.CallTableAdapter = this.callTableAdapter;
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
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.nameTextBox.Location = new System.Drawing.Point(237, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 26);
            this.nameTextBox.TabIndex = 13;
            // 
            // start_hoursTextBox
            // 
            this.start_hoursTextBox.Location = new System.Drawing.Point(237, 132);
            this.start_hoursTextBox.Mask = "00:00";
            this.start_hoursTextBox.Name = "start_hoursTextBox";
            this.start_hoursTextBox.Size = new System.Drawing.Size(175, 23);
            this.start_hoursTextBox.TabIndex = 16;
            this.start_hoursTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // end_hoursTextBox
            // 
            this.end_hoursTextBox.Location = new System.Drawing.Point(237, 161);
            this.end_hoursTextBox.Mask = "00:00";
            this.end_hoursTextBox.Name = "end_hoursTextBox";
            this.end_hoursTextBox.Size = new System.Drawing.Size(175, 23);
            this.end_hoursTextBox.TabIndex = 17;
            this.end_hoursTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // AddCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 266);
            this.Controls.Add(this.end_hoursTextBox);
            this.Controls.Add(this.start_hoursTextBox);
            this.Controls.Add(end_hoursLabel);
            this.Controls.Add(start_hoursLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звонки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCall_FormClosing);
            this.Load += new System.EventHandler(this.AddCall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private RaspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource callBindingSource;
        private RaspisanieDataSetTableAdapters.CallTableAdapter callTableAdapter;
        private RaspisanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox start_hoursTextBox;
        private System.Windows.Forms.MaskedTextBox end_hoursTextBox;
    }
}