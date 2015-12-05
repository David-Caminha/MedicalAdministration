namespace MedicalAdministrationApp
{
    partial class Form1
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addPatientLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.moradaLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.healthCareNumberLabel = new System.Windows.Forms.Label();
            this.healthCareNumberTextBox = new System.Windows.Forms.TextBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.healthCareSystemLabel = new System.Windows.Forms.Label();
            this.healthCareSystemComboBox = new System.Windows.Forms.ComboBox();
            this.jobLabel = new System.Windows.Forms.Label();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.fiscalNumberLabel = new System.Windows.Forms.Label();
            this.fiscalNumberTextBox = new System.Windows.Forms.TextBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.searchPatientsButton = new System.Windows.Forms.Button();
            this.patientsListView = new System.Windows.Forms.ListView();
            this.healthCareNumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.healthCareSystemCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiscalNumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.setAppointmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(79, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(639, 24);
            this.nameTextBox.TabIndex = 1;
            // 
            // addPatientLabel
            // 
            this.addPatientLabel.AutoSize = true;
            this.addPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientLabel.Location = new System.Drawing.Point(14, 10);
            this.addPatientLabel.Name = "addPatientLabel";
            this.addPatientLabel.Size = new System.Drawing.Size(228, 25);
            this.addPatientLabel.TabIndex = 19;
            this.addPatientLabel.Text = "Adicionar novo doente";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(16, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome :";
            // 
            // moradaLabel
            // 
            this.moradaLabel.AutoSize = true;
            this.moradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moradaLabel.Location = new System.Drawing.Point(736, 52);
            this.moradaLabel.Name = "moradaLabel";
            this.moradaLabel.Size = new System.Drawing.Size(67, 18);
            this.moradaLabel.TabIndex = 2;
            this.moradaLabel.Text = "Morada :";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(809, 49);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(787, 24);
            this.addressTextBox.TabIndex = 3;
            // 
            // contactLabel
            // 
            this.contactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(16, 97);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(77, 18);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Contacto :";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.Location = new System.Drawing.Point(99, 94);
            this.contactTextBox.MaxLength = 9;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(159, 24);
            this.contactTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(278, 97);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 18);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(336, 94);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(381, 24);
            this.emailTextBox.TabIndex = 7;
            // 
            // healthCareNumberLabel
            // 
            this.healthCareNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthCareNumberLabel.AutoSize = true;
            this.healthCareNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCareNumberLabel.Location = new System.Drawing.Point(16, 140);
            this.healthCareNumberLabel.Name = "healthCareNumberLabel";
            this.healthCareNumberLabel.Size = new System.Drawing.Size(117, 18);
            this.healthCareNumberLabel.TabIndex = 10;
            this.healthCareNumberLabel.Text = "Numero Utente :";
            // 
            // healthCareNumberTextBox
            // 
            this.healthCareNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthCareNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCareNumberTextBox.Location = new System.Drawing.Point(139, 136);
            this.healthCareNumberTextBox.MaxLength = 9;
            this.healthCareNumberTextBox.Name = "healthCareNumberTextBox";
            this.healthCareNumberTextBox.Size = new System.Drawing.Size(192, 24);
            this.healthCareNumberTextBox.TabIndex = 11;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(861, 140);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(151, 18);
            this.birthDateLabel.TabIndex = 16;
            this.birthDateLabel.Text = "Data de Nascimento :";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthDatePicker.Location = new System.Drawing.Point(1018, 136);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(180, 24);
            this.birthDatePicker.TabIndex = 17;
            // 
            // healthCareSystemLabel
            // 
            this.healthCareSystemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthCareSystemLabel.AutoSize = true;
            this.healthCareSystemLabel.Location = new System.Drawing.Point(355, 140);
            this.healthCareSystemLabel.Name = "healthCareSystemLabel";
            this.healthCareSystemLabel.Size = new System.Drawing.Size(99, 18);
            this.healthCareSystemLabel.TabIndex = 12;
            this.healthCareSystemLabel.Text = "Sub-sistema :";
            // 
            // healthCareSystemComboBox
            // 
            this.healthCareSystemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthCareSystemComboBox.FormattingEnabled = true;
            this.healthCareSystemComboBox.Items.AddRange(new object[] {
            "ADSE",
            "ADM"});
            this.healthCareSystemComboBox.Location = new System.Drawing.Point(460, 135);
            this.healthCareSystemComboBox.Name = "healthCareSystemComboBox";
            this.healthCareSystemComboBox.Size = new System.Drawing.Size(121, 26);
            this.healthCareSystemComboBox.TabIndex = 13;
            // 
            // jobLabel
            // 
            this.jobLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(736, 97);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(80, 18);
            this.jobLabel.TabIndex = 8;
            this.jobLabel.Text = "Profissão :";
            // 
            // jobTextBox
            // 
            this.jobTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobTextBox.Location = new System.Drawing.Point(822, 94);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(376, 24);
            this.jobTextBox.TabIndex = 9;
            // 
            // fiscalNumberLabel
            // 
            this.fiscalNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiscalNumberLabel.AutoSize = true;
            this.fiscalNumberLabel.Location = new System.Drawing.Point(604, 140);
            this.fiscalNumberLabel.Name = "fiscalNumberLabel";
            this.fiscalNumberLabel.Size = new System.Drawing.Size(39, 18);
            this.fiscalNumberLabel.TabIndex = 14;
            this.fiscalNumberLabel.Text = "NIF :";
            // 
            // fiscalNumberTextBox
            // 
            this.fiscalNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiscalNumberTextBox.Location = new System.Drawing.Point(649, 136);
            this.fiscalNumberTextBox.MaxLength = 9;
            this.fiscalNumberTextBox.Name = "fiscalNumberTextBox";
            this.fiscalNumberTextBox.Size = new System.Drawing.Size(194, 24);
            this.fiscalNumberTextBox.TabIndex = 15;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPatientButton.Location = new System.Drawing.Point(1292, 94);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(204, 66);
            this.addPatientButton.TabIndex = 18;
            this.addPatientButton.Text = "Adicionar Doente";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(281, 10);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(198, 25);
            this.clearFieldsButton.TabIndex = 20;
            this.clearFieldsButton.Text = "Limpar campos";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // searchPatientsButton
            // 
            this.searchPatientsButton.Location = new System.Drawing.Point(19, 185);
            this.searchPatientsButton.Name = "searchPatientsButton";
            this.searchPatientsButton.Size = new System.Drawing.Size(312, 35);
            this.searchPatientsButton.TabIndex = 21;
            this.searchPatientsButton.Text = "Procurar doentes";
            this.searchPatientsButton.UseVisualStyleBackColor = true;
            this.searchPatientsButton.Click += new System.EventHandler(this.searchPatientsButton_Click);
            // 
            // patientsListView
            // 
            this.patientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.healthCareNumCol,
            this.nameCol,
            this.addressCol,
            this.contactCol,
            this.emailCol,
            this.healthCareSystemCol,
            this.birthDateCol,
            this.jobCol,
            this.fiscalNumCol});
            this.patientsListView.FullRowSelect = true;
            this.patientsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.patientsListView.Location = new System.Drawing.Point(19, 249);
            this.patientsListView.MultiSelect = false;
            this.patientsListView.Name = "patientsListView";
            this.patientsListView.Size = new System.Drawing.Size(1179, 303);
            this.patientsListView.TabIndex = 22;
            this.patientsListView.UseCompatibleStateImageBehavior = false;
            this.patientsListView.View = System.Windows.Forms.View.Details;
            this.patientsListView.SelectedIndexChanged += new System.EventHandler(this.patientsListView_SelectedIndexChanged);
            // 
            // healthCareNumCol
            // 
            this.healthCareNumCol.Text = "Numero Utente";
            // 
            // nameCol
            // 
            this.nameCol.Text = "Nome";
            // 
            // addressCol
            // 
            this.addressCol.Text = "Morada";
            // 
            // contactCol
            // 
            this.contactCol.Text = "Contacto";
            // 
            // emailCol
            // 
            this.emailCol.Text = "Email";
            // 
            // healthCareSystemCol
            // 
            this.healthCareSystemCol.Text = "Sub sistema";
            // 
            // birthDateCol
            // 
            this.birthDateCol.Text = "Data Nascimento";
            // 
            // jobCol
            // 
            this.jobCol.Text = "Profissao";
            // 
            // fiscalNumCol
            // 
            this.fiscalNumCol.Text = "NIF";
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatePatientButton.Location = new System.Drawing.Point(1292, 185);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(204, 66);
            this.updatePatientButton.TabIndex = 23;
            this.updatePatientButton.Text = "Atualizar Doente";
            this.updatePatientButton.UseVisualStyleBackColor = true;
            this.updatePatientButton.Click += new System.EventHandler(this.updatePatientButton_Click);
            // 
            // setAppointmentButton
            // 
            this.setAppointmentButton.Location = new System.Drawing.Point(1292, 280);
            this.setAppointmentButton.Name = "setAppointmentButton";
            this.setAppointmentButton.Size = new System.Drawing.Size(204, 66);
            this.setAppointmentButton.TabIndex = 24;
            this.setAppointmentButton.Text = "Marcar Consulta";
            this.setAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 564);
            this.Controls.Add(this.setAppointmentButton);
            this.Controls.Add(this.updatePatientButton);
            this.Controls.Add(this.patientsListView);
            this.Controls.Add(this.searchPatientsButton);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.fiscalNumberTextBox);
            this.Controls.Add(this.fiscalNumberLabel);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.healthCareSystemComboBox);
            this.Controls.Add(this.healthCareSystemLabel);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.healthCareNumberTextBox);
            this.Controls.Add(this.healthCareNumberLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.moradaLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addPatientLabel);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração Médica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addPatientLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label moradaLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label healthCareNumberLabel;
        private System.Windows.Forms.TextBox healthCareNumberTextBox;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Label healthCareSystemLabel;
        private System.Windows.Forms.ComboBox healthCareSystemComboBox;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.Label fiscalNumberLabel;
        private System.Windows.Forms.TextBox fiscalNumberTextBox;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.Button searchPatientsButton;
        private System.Windows.Forms.ListView patientsListView;
        private System.Windows.Forms.ColumnHeader healthCareNumCol;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader addressCol;
        private System.Windows.Forms.ColumnHeader contactCol;
        private System.Windows.Forms.ColumnHeader emailCol;
        private System.Windows.Forms.ColumnHeader healthCareSystemCol;
        private System.Windows.Forms.ColumnHeader birthDateCol;
        private System.Windows.Forms.ColumnHeader jobCol;
        private System.Windows.Forms.ColumnHeader fiscalNumCol;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.Button setAppointmentButton;
    }
}

