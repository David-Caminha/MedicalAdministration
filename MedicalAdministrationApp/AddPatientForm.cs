using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace MedicalAdministrationApp
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            contactTextBox.Text = "";
            emailTextBox.Text = "";
            healthCareNumberTextBox.Text = "";
            healthCareSystemComboBox.Text = "";
            healthCareSystemNumberTextBox.Text = "";
            jobTextBox.Text = "";
            fiscalNumberTextBox.Text = "";
            birthDatePicker.CustomFormat = " ";
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            string nome = nameTextBox.Text;
            string morada = addressTextBox.Text;
            string contacto = contactTextBox.Text;
            string email = emailTextBox.Text;
            string numeroUtente = healthCareNumberTextBox.Text;
            string subSistema = healthCareSystemComboBox.Text;
            string numeroSubSistema = healthCareSystemNumberTextBox.Text;
            DateTime dataNascimento = birthDatePicker.Value.Date;
            string profissao = jobTextBox.Text;
            int nif = Convert.ToInt32(fiscalNumberTextBox.Text);
            if (dataNascimento == birthDatePicker.MinDate)
                FinalDB.InsertClient(nome, morada, contacto, email,
                    numeroUtente, subSistema, numeroSubSistema, profissao, nif);
            else
                FinalDB.InsertClient(nome, morada, contacto, email,
                    numeroUtente, subSistema, numeroSubSistema, profissao, nif, dataNascimento);
        }

        private void searchPatientsButton_Click(object sender, EventArgs e)
        {
            List<Patient> patientList;
            string nome = nameTextBox.Text;
            string morada = addressTextBox.Text;
            string contacto = contactTextBox.Text;
            string email = emailTextBox.Text;
            string numeroUtente = healthCareNumberTextBox.Text;
            string subSistema = healthCareSystemComboBox.Text;
            string numeroSubSistema = healthCareSystemNumberTextBox.Text;
            DateTime dataNascimento = birthDatePicker.Value.Date;
            string profissao = jobTextBox.Text;
            string nif = fiscalNumberTextBox.Text;
            try
            {
                patientList = FinalDB.GetPatients(nome, morada, contacto, email,
                    numeroUtente, subSistema, numeroSubSistema, dataNascimento, profissao, nif);
                if (patientList.Count > 0)
                {
                    Patient patient;
                    patientsListView.Items.Clear();
                    for (int i = 0; i < patientList.Count; i++)
                    {
                        patient = patientList[i];
                        patientsListView.Items.Add(patient.NumeroUtente.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.Nome.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.Morada.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.Contacto.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.Email.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.SubSistema.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.NumSubSistema.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.DataNascimento.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.Profissao.ToString());
                        patientsListView.Items[i].SubItems.Add(patient.NIF.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            string nome = nameTextBox.Text;
            string morada = addressTextBox.Text;
            string contacto = contactTextBox.Text;
            string email = emailTextBox.Text;
            string numeroUtente = healthCareNumberTextBox.Text;
            string subSistema = healthCareSystemComboBox.Text;
            string numeroSubSistema = healthCareSystemNumberTextBox.Text;
            DateTime dataNascimento = birthDatePicker.Value.Date;
            string profissao = jobTextBox.Text;
            int nif = Convert.ToInt32(fiscalNumberTextBox.Text);
            FinalDB.UpdateClient(nome, morada, contacto, email,
                numeroUtente, subSistema, numeroSubSistema, dataNascimento, profissao, nif);
        }

        private void patientsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection patientInfo = patientsListView.SelectedItems;
            int lastIndex = patientInfo.Count - 1;
            if (lastIndex >= 0)
            {
                string numeroUtente = patientInfo[lastIndex].Text;
                string nome = patientInfo[lastIndex].SubItems[1].Text;
                string morada = patientInfo[lastIndex].SubItems[2].Text;
                string contacto = patientInfo[lastIndex].SubItems[3].Text;
                string email = patientInfo[lastIndex].SubItems[4].Text;
                string subSistema = patientInfo[lastIndex].SubItems[5].Text;
                string numSubSistema = patientInfo[lastIndex].SubItems[6].Text;
                string dataNascimento = patientInfo[lastIndex].SubItems[7].Text;
                string profissao = patientInfo[lastIndex].SubItems[8].Text;
                string nif = patientInfo[lastIndex].SubItems[9].Text;
                nameTextBox.Text = nome;
                addressTextBox.Text = morada;
                contactTextBox.Text = contacto;
                emailTextBox.Text = email;
                healthCareNumberTextBox.Text = numeroUtente;
                healthCareSystemComboBox.Text = subSistema;
                healthCareSystemNumberTextBox.Text = numSubSistema;
                if (dataNascimento.Equals(""))
                {
                    birthDatePicker.Value = birthDatePicker.MinDate;
                    birthDatePicker.CustomFormat = " ";
                }
                else
                {
                    birthDatePicker.Value = Convert.ToDateTime(dataNascimento);
                    birthDatePicker.CustomFormat = "dd/MMMM/yyyy";
                }
                jobTextBox.Text = profissao;
                fiscalNumberTextBox.Text = nif;
            }
        }

        private void birthDatePicker_ValueChanged(Object sender, EventArgs e)
        {
            birthDatePicker.CustomFormat = "dd/MMMM/yyyy";
        }

        private void setAppointmentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
