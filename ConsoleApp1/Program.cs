using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ¿ que resultados  se obtienen al realizar las operaciones siguientes? Si har errores en la compilacion, corrijalos y de una explicacion de porque sucede//


            int a = 20, b = 5, c = 0, d, e;
            float x, y;

            x = a / b;
           if ((a < b) && (a < c)) //Porque tiene el operador "&&" se nececita emplear un "if"//
            d = a + b++;
            e = ++a * b;
            y = (float)a / b;  // no se puede, porque "float" se usa para inicializar variablres de tipo decimal y en la operacion genera error//


        }
    }
}
