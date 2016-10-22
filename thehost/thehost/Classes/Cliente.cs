using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thehost.Classes
{
    public class Cliente : Pessoa
    {
        /// <summary>
        /// Atributos da Classe Cliente.
        /// </summary>
        private string telefone;

        /// <summary>
        /// Propriedades da Classe Cliente.
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
}
