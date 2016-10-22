using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thehost.Classes
{
    public class Funcionario : Pessoa
    {
        /// <summary>
        /// Atributos da Classe Funcionario.
        /// </summary>
        private string telefone;

        /// <summary>
        /// Propriedades da Classe Funcionario.
        /// </summary>
        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }
    }


    ///<summary>
    ///Métodos da Classe Funcionario.
    /// </summary>
}
