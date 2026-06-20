using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUtpGui
{
    internal class Autenticación
    {
        private string contrasenia;
        private int Mayusc, Minusc, Numeros, Caracter, Espacio;

        public string Pcontrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public int Pmayuscula
        {
            get { return Mayusc; }
            set { Mayusc = value; }
        }

        public int Pminuscula
        {
            get { return Minusc; }
            set { Minusc = value; }
        }

        public int Pnumeros
        {
            get { return Numeros; }
            set { Numeros = value; }
        }

        public int Pcaracteres
        {
            get { return Caracter; }
            set { Caracter = value; }
        }

        public int Pespacios
        {
            get { return Espacio; }
            set { Espacio = value; }
        }

        public Autenticación()
        {
            this.contrasenia = "";
        }

        public void VerificarContrasenia(string palabra)
        {
            Minusc = 0;
            Mayusc = 0;
            Numeros = 0;
            Caracter = 0;
            Espacio = 0;

            foreach (char c in palabra)
            {
                if (char.IsLower(c))
                    Minusc++;
                else if (char.IsUpper(c))
                    Mayusc++;
                else if (char.IsDigit(c))
                    Numeros++;
                else if (char.IsWhiteSpace(c))
                    Espacio++;
                else
                    Caracter++;
            }
        }

        public string EvaluarContrasenia(string texto)
        {
            if (texto.Length > 0 && char.IsWhiteSpace(texto[0]))
                return " Es invalido empieza con espacios! ";

            if (texto.Length > 0 && char.IsDigit(texto[0]))
                return " Es invalido empieza con numero! ";

            VerificarContrasenia(texto);

            string cadena = "";
            int ContadorReglas = 0;

            if (texto.Length >= 8)
                ContadorReglas++;
            if (Mayusc >= 1)
                ContadorReglas++;
            if (Minusc >= 1)
                ContadorReglas++;
            if (texto.Length > 0 && !char.IsDigit(texto[0]))
                ContadorReglas++;
            if (Numeros >= 1)
                ContadorReglas++;
            if (Caracter >= 1)
                ContadorReglas++;
            if (Espacio == 0)
                ContadorReglas++;

            if (ContadorReglas <= 3)
                cadena = "Contraseña DEBIL!";
            else if (ContadorReglas == 4 || ContadorReglas == 5)
                cadena = "Contraseña MEDIA!";
            else
                cadena = "Contraseña FUERTE!";

            return cadena;
        }

        public bool ValidarContrasenia(string contrasenia)
        {
            string resultado = EvaluarContrasenia(contrasenia);

            if (resultado == "Contraseña FUERTE!" || resultado == "Contraseña MEDIA!")
                return true;
            else
                return false;
        }
    }
}
