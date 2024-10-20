using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class Cuadrado_medio
    {
        public List<ResultadoCuadradoMedio> GenerarNumeros(int semilla, int cantidadNumeros)
        {
            List<ResultadoCuadradoMedio> resultados = new List<ResultadoCuadradoMedio>();

            for (int i = 0; i < cantidadNumeros; i++)
            {
                // Elevar la semilla al cuadrado
                int cuadrado = semilla * semilla;

                // Convertir el cuadrado a una cadena y rellenar con ceros si es necesario
                string cuadradoStr = cuadrado.ToString("D8"); // Asegura al menos 8 dígitos

                // Extraer los 4 dígitos centrales
                string digitosCentrales = cuadradoStr.Substring(2, 4);

                // Obtener los primeros y últimos 2 dígitos del centro
                string primerosDigitos = digitosCentrales.Substring(0, 2);
                string ultimosDigitos = digitosCentrales.Substring(2, 2);

                // Agregar el resultado a la lista
                resultados.Add(new ResultadoCuadradoMedio
                {
                    Numero = semilla,
                    CuadradoDelNumero = cuadrado,
                    Centro = digitosCentrales,
                    PrimerosDigitos = primerosDigitos,
                    UltimosDigitos = ultimosDigitos
                });

                // Establecer la nueva semilla como los dígitos centrales obtenidos
                semilla = int.Parse(digitosCentrales);
            }

            return resultados;
        }
    }

    public class ResultadoCuadradoMedio
    {
        public int Numero { get; set; }
        public int CuadradoDelNumero { get; set; }
        public string Centro { get; set; }
        public string PrimerosDigitos { get; set; }
        public string UltimosDigitos { get; set; }
    }
}



