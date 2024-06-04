using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, introduce un número del 1 al 7: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            string dia = ObtenerDiaSemana(numero);
            if (dia != null)
            {
                Console.WriteLine($"El día correspondiente al número {numero} es {dia}");
            }
            else
            {
                Console.WriteLine("Número de día inválido. Debe estar entre 1 y 7.");
            }
        }

        static string ObtenerDiaSemana(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Domingo";
                case 2:
                    return "Lunes";
                case 3:
                    return "Martes";
                case 4:
                    return "Miercoles";
                case 5:
                    return "Jueves";
                case 6:
                    return "Viernes";
                case 7:
                    return "Sábado";
                default:
                    return null;
            }
        }
    }
}
