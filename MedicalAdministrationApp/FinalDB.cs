using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MedicalAdministrationApp
{
    public static class FinalDB
    {
        public static SqlConnection GetConnection()
        {
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitHub\MedicalAdministration\MedicalAdministrationApp\Database.mdf;Integrated Security=True;Connect Timeout=30
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;";
            connStr += @"AttachDbFilename=""C:\GitHub\MedicalAdministration\MedicalAdministrationApp\Database.mdf"";";
            connStr += @"Integrated Security=True";
            SqlConnection connection = new SqlConnection(connStr);
            return connection;
        }

        public static int InsertClient(string nome, string morada, string contacto, string email, string numeroUtente, string subSistema, string numeroSubSistema, string profissao, int nif, DateTime? dataNascimento = null)
        {
            int return_code = 0;
            string insertStatement = "INSERT INTO Cliente " +
                " ([NumUtente], [Nome], [Morada], [Contacto], [Email], [SubSistema], [NumSubSistema], [DataNasc], [Profissao], [NIF]) " +
                " VALUES (@NumeroUtente, @Nome, @Morada, @Contacto, @Email, @SubSistema, @NumSubSistema, @DataNascimento, @Profissao, @NIF)";
            SqlConnection connection = GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@NumeroUtente", numeroUtente);
            insertCommand.Parameters.AddWithValue("@Nome", nome);
            insertCommand.Parameters.AddWithValue("@Morada", morada);
            insertCommand.Parameters.AddWithValue("@Contacto", contacto);
            insertCommand.Parameters.AddWithValue("@Email", email);
            insertCommand.Parameters.AddWithValue("@SubSistema", subSistema);
            insertCommand.Parameters.AddWithValue("@NumSubSistema", numeroSubSistema);
            insertCommand.Parameters.AddWithValue("@DataNascimento", (object) dataNascimento ?? DBNull.Value);
            insertCommand.Parameters.AddWithValue("@Profissao", profissao);
            insertCommand.Parameters.AddWithValue("@NIF", nif);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return_code = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return return_code;
        }

        public static List<Patient> GetPatients(string nome, string morada, string contacto, string email, string numeroUtente, string subSistema, string numeroSubSistema, DateTime dataNascimento, string profissao, string nif)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = GetConnection();
            string selectStatement = "SELECT NumUtente, Nome, Morada, Contacto, Email, " +
                " SubSistema, NumSubSistema, DataNasc, Profissao, NIF " +
                " FROM Cliente " +
                " WHERE NumUtente = '" + numeroUtente + "'" +
                " OR Nome LIKE '%" + nome + "%'" +
                " OR Morada = '" + morada + "'" +
                " OR Contacto = '" + contacto + "'" +
                " OR Email = '" + email + "'" +
                " OR SubSistema = '" + subSistema + "'" +
                " OR NumSubSistema = '" + numeroSubSistema + "'" +
                " OR DataNasc = '" + dataNascimento.ToString("yyyyMMdd") + "'" +
                " OR Profissao = '" + profissao + "'" +
                " OR NIF = '" + nif + "'" +
                " ORDER BY Nome DESC ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.NumeroUtente = Utils.SafeGetString(reader, "NumUtente");
                    patient.Nome = Utils.SafeGetString(reader, "Nome");
                    patient.Morada = Utils.SafeGetString(reader, "Morada");
                    patient.Contacto = Utils.SafeGetString(reader, "Contacto");
                    patient.Email = Utils.SafeGetString(reader, "Email");
                    patient.SubSistema = Utils.SafeGetString(reader, "SubSistema");
                    patient.NumSubSistema = Utils.SafeGetString(reader, "NumSubSistema");
                    patient.DataNascimento = Utils.SafeGetDate(reader, "DataNasc");
                    patient.Profissao = Utils.SafeGetString(reader, "Profissao");
                    patient.NIF = Utils.SafeGetInt(reader, "NIF");
                    patientList.Add(patient);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            return patientList;
        }

        public static void UpdateClient(string nome, string morada, string contacto, string email, string numeroUtente, string subSistema, string numeroSubSistema, DateTime dataNascimento, string profissao, int nif)
        {
            string updateStatement = "UPDATE Cliente " +
                " SET Nome = @Nome, Morada = @Morada, Contacto = @Contacto, Email = @Email, SubSistema = @SubSistema," +
                " NumSubSistema = @NumSubSistema, DataNasc = @DataNascimento, Profissao = @Profissao, NumUtente = @NumeroUtente" +
                " WHERE NIF = @NIF";
            SqlConnection connection = GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NumeroUtente", numeroUtente);
            updateCommand.Parameters.AddWithValue("@Nome", nome);
            updateCommand.Parameters.AddWithValue("@Morada", morada);
            updateCommand.Parameters.AddWithValue("@Contacto", contacto);
            updateCommand.Parameters.AddWithValue("@Email", email);
            updateCommand.Parameters.AddWithValue("@SubSistema", subSistema);
            updateCommand.Parameters.AddWithValue("@NumSubSistema", numeroSubSistema);
            updateCommand.Parameters.AddWithValue("@DataNascimento", dataNascimento);
            updateCommand.Parameters.AddWithValue("@Profissao", profissao);
            updateCommand.Parameters.AddWithValue("@NIF", nif);
            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}