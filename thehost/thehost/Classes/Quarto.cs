using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thehost.Classes
{
    public class Quarto
    {
        /// <summary>
        /// Atributos da Classe Quarto.
        /// </summary>
        private int andar;
        private int numero;
        private string tipo;

        /// <summary>
        /// Popriedades da Classe Quarto.
        /// </summary>
        public int Andar
        {
            get
            {
                return andar;
            }

            set
            {
                andar = value;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }
        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
