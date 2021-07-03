using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion2
{
    public class Promedio
    {
        private string nombre;
        private int cuenta;
      
      


        public string Nombre { get; set; }
        public long Cuenta { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        public string Prom { get; set; }

        public Promedio() {}

        public Promedio (string _nombre, int _cuenta, int _nota1, int _nota2, int _nota3, int _nota4 )
        {
            Nombre = _nombre;
            Cuenta = _cuenta;
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
            
            
           
        }

        public string NombreYcuenta()
        {
            return (nombre + " " + cuenta);     
        }

        public int promedionotas()
        {

         return ((Nota1 + Nota2 + Nota3 + Nota4) / 4);

        }

        public string aprobacion()
        {
            string apr;
            var resultadoNotas = ((Nota1 + Nota2 + Nota3 + Nota4) /4);
                if (resultadoNotas <= 69)
            {
                apr = ("Reprobado");
            }
                else
            {
                apr = ("Aprobado");
            }
            return apr;
        }


    }
}
