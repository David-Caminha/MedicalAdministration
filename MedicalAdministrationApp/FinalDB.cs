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
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\David\Documents\Visual Studio 2015\Projects\MedicalAdministrationApp\MedicalAdministrationApp\Database.mdf";Integrated Security=True;Connect Timeout=30
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;";
            connStr += @"AttachDbFilename=""C:\Users\David\Documents\Visual Studio 2015\Projects\MedicalAdministrationApp\MedicalAdministrationApp\Database.mdf"";";
            connStr += @"Integrated Security=True";
            SqlConnection connection = new SqlConnection(connStr);
            return connection;
        }

        public static int InsertClient(string nome, string morada, string contacto, string email, int numeroUtente, string subSistema, DateTime dataNascimento, string profissao, int nif)
        {
            int return_code = 0;
            string insertStatement = "INSERT INTO Cliente " +
                " ([NumeroUtente], [Nome], [Morada], [Contacto], [Email], [SubSistema], [DataNascimento], [Profissao], [NIF]) " +
                " VALUES (@NumeroUtente, @Nome, @Morada, @Contacto, @Email, @SubSistema, @DataNascimento, @Profissao, @NIF)";
            SqlConnection connection = GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@NumeroUtente", numeroUtente);
            insertCommand.Parameters.AddWithValue("@Nome", nome);
            insertCommand.Parameters.AddWithValue("@Morada", morada);
            insertCommand.Parameters.AddWithValue("@Contacto", contacto);
            insertCommand.Parameters.AddWithValue("@Email", email);
            insertCommand.Parameters.AddWithValue("@SubSistema", subSistema);
            insertCommand.Parameters.AddWithValue("@DataNascimento", dataNascimento);
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

        public static List<Patient> GetPatients(string nome, string morada, string contacto, string email, string numeroUtente, string subSistema, DateTime dataNascimento, string profissao, string nif)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = GetConnection();
            string selectStatement = "SELECT NumeroUtente, Nome, Morada, Contacto, Email, " +
                " SubSistema, DataNascimento, Profissao, NIF " +
                " FROM Cliente " +
                " WHERE NumeroUtente = '" + numeroUtente + "'" +
                " OR Nome LIKE '%" + nome + "%'" +
                " OR Morada = '" + morada + "'" +
                " OR Contacto = '" + contacto + "'" +
                " OR Email = '" + email + "'" +
                " OR SubSistema = '" + subSistema + "'" +
                " OR DataNascimento = '" + dataNascimento.Year + dataNascimento.Month + dataNascimento.Day + "'" +
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
                    patient.NumeroUtente = (int)reader["NumeroUtente"];
                    patient.Nome = reader["Nome"].ToString();
                    patient.Morada = reader["Morada"].ToString();
                    patient.Contacto = reader["Contacto"].ToString();
                    patient.Email = reader["Email"].ToString();
                    patient.SubSistema = reader["SubSistema"].ToString();
                    patient.DataNascimento = (DateTime)reader["DataNascimento"];
                    patient.Profissao = reader["Profissao"].ToString();
                    patient.NIF = (int)reader["NIF"];
                    patientList.Add(patient);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            return patientList;
        }

        public static void UpdateClient(string nome, string morada, string contacto, string email, int numeroUtente, string subSistema, DateTime dataNascimento, string profissao, int nif)
        {
            string updateStatement = "UPDATE Cliente " +
                " SET Nome = @Nome, Morada = @Morada, Contacto = @Contacto, Email = @Email, " +
                " SubSistema = @SubSistema, DataNascimento = @DataNascimento, Profissao = @Profissao, NIF = @NIF" +
                " WHERE NumeroUtente = @NumeroUtente";
            SqlConnection connection = GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NumeroUtente", numeroUtente);
            updateCommand.Parameters.AddWithValue("@Nome", nome);
            updateCommand.Parameters.AddWithValue("@Morada", morada);
            updateCommand.Parameters.AddWithValue("@Contacto", contacto);
            updateCommand.Parameters.AddWithValue("@Email", email);
            updateCommand.Parameters.AddWithValue("@SubSistema", subSistema);
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