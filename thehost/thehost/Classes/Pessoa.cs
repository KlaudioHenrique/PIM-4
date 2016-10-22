using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thehost.Classes
{
    public class Pessoa
    {
        /// <summary>
        /// Atributos da Classe Pessoa.
        /// </summary>
        private string nome;
        private string cpf;

        /// <summary>
        /// Propriedades da Classe Pessoa.
        /// </summary>
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
    }
}
