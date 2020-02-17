using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioASP.Models
{
    public class Data
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public Operacion op { get; set; }
        public enum Operacion
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Potencia,
            Raiz
        }
    }
}
