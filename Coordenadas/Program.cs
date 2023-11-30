using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int quadrante;
            double x, y;

            Console.Write("Valor de X: ");
            x = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de Y: ");
            y = double.Parse(Console.ReadLine(), CI);

            quadrante = 0;
            if (x > 0 && y > 0) {
                quadrante = 1;
            }
            else if (x > 0 && y < 0) {
                quadrante = 4;
            }
            else if (x < 0 && y < 0) {
                quadrante = 3;
            }
            else if (x < 0 && y > 0) {
                quadrante = 2;
            }
            if (quadrante != 0) {
                Console.WriteLine("Q" + quadrante);
            }
            
            else if (x == 0 && y == 0) {
                Console.WriteLine("Origem.");
            }
            else if (x == 0) {
                Console.WriteLine("Eixo Y.");
            }
            else if (y == 0) {
                Console.WriteLine("Eixo X.");
            }

            
                    
                    
        }
    }
}
