using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_SHARP_UNAM_2021.Chapter_I.SyntaxisBasica {
    class ImprimirMensajes {

        public static void inicio() {
            Console.WriteLine("Esto de un mensaje");
            double variable = 0.5;
            Console.WriteLine($"Esto en mensaje con una variable dentro {variable}");
            Console.WriteLine(
                        "(C) Currency: . . . . . . . . {0:C}\n" +
                        "(D) Decimal:. . . . . . . . . {0:D}\n" +
                        "(E) Scientific: . . . . . . . {1:E}\n" +
                        "(F) Fixed point:. . . . . . . {1:F}\n" +
                        "(G) General:. . . . . . . . . {0:G}\n" +
                        "    (default):. . . . . . . . {0} (default = 'G')\n" +
                        "(N) Number: . . . . . . . . . {0:N}\n" +
                        "(P) Percent:. . . . . . . . . {1:P}\n" +
                        "(R) Round-trip: . . . . . . . {1:R}\n" +
                        "(X) Hexadecimal:. . . . . . . {0:X}\n",
                        -123, -123.45f);

            double billTotal = 0.15;
            const double tipRate = 0.18;
            double tip = billTotal * tipRate;
            Console.WriteLine();
            Console.WriteLine($"Bill total:\t{billTotal,8:c}");
            Console.WriteLine($"Tip total/rate:\t{tip,8:c} ({tipRate:p1})");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine($"Grand total:\t{billTotal + tip,8:c}");

        }
    }
}
