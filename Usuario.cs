using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtpGui
{
    internal class Usuario
    {
        private int anioNac;

        public int Panio
        {
            get { return anioNac; }
            set { anioNac = value; }
        }
        public Usuario(int anio_nac)
        {
            this.anioNac = anio_nac;
        }

        public int CalcularEdad()
        {
            int anioActual = DateTime.Now.Year;
            return anioActual  - anioNac;
        }
    }
}
