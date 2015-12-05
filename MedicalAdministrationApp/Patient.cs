using System;

namespace MedicalAdministrationApp
{
    public class Patient
    {
        private int numeroUtente;
        private string nome;
        private string morada;
        private string contacto;
        private string email;
        private string subSistema;
        private DateTime dataNascimento;
        private string profissao;
        private int nif;
        public Patient() { }
        public int NumeroUtente { get { return numeroUtente; } set { numeroUtente = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Morada { get { return morada; } set { morada = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Contacto { get { return contacto; } set { contacto = value; } }
        public string SubSistema { get { return subSistema; } set { subSistema = value; } }
        public DateTime DataNascimento { get { return dataNascimento; } set { dataNascimento = value; } }
        public string Profissao { get { return profissao; } set { profissao = value; } }
        public int NIF { get { return nif; } set { nif = value; } }
    }
}