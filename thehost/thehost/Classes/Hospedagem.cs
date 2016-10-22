using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thehost.Classes
{
    public class Hospedagem
    {
        /// <summary>
        /// Atributo da Classe Hospedagem.
        /// </summary>
        private DateTime entrada;
        private DateTime saida;
        private double valor;
        private Quarto objQuarto;
        private Cliente objCliente;
        

        /// <summary>
        /// Propriedades da Classe Hospedagem.
        /// </summary>
        public DateTime Entrada
        {
            get
            {
                return entrada;
            }

            set
            {
                entrada = value;
            }
        }
        public DateTime Saida
        {
            get
            {
                return saida;
            }

            set
            {
                saida = value;
            }
        }
        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
        public Quarto ObjQuarto
        {
            get
            {
                return objQuarto;
            }

            set
            {
                objQuarto = value;
            }
        }
        public Cliente ObjCliente
        {
            get
            {
                return objCliente;
            }

            set
            {
                objCliente = value;
            }
        }
    }
}
