using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Actividades
    {
        public void A21()
        {
            Console.WriteLine($"La fecha actual es: {DateTime.Now}");
        }

        public void A22()
        {
            DateTime Fecha = DateTime.Now;
            Console.Write("La fecha actual con formato dd/mm/yyyy es: {0}", Fecha.ToString("dd/MM/yyyy"));
        }

        public void A23() // Ver cómo lo hizo el profesor
        {
            bool IngresoValido = false;
            do
            {
                Console.WriteLine("Ingrese una fecha: ");
                string Ingreso = Console.ReadLine();



                if (!DateTime.TryParse(Ingreso, out DateTime FechaOK))
                {
                    Console.WriteLine("No ingresó una fecha válida");
                    continue;
                }
                if(FechaOK > DateTime.Now)
                {
                    Console.WriteLine("Debe ingresar una fecha menor al día de hoy");
                    continue;
                }
                IngresoValido = true;
                Console.Write("La fecha ingresada es: {0}", FechaOK.ToString("dd/MM/yyyy"));

            } while (!IngresoValido);
        }

        public void A24() // Ver cómo lo hizo el profesor
        {
            bool IngresoValido = false;
            DateTime FechaValida = new DateTime();

            do
            {
                Console.WriteLine("Ingrese una fecha con el siguiente formato 'dd/mm/yyyy': ");
                string Ingreso = Console.ReadLine();

                string format = "dd/MM/yyyy";

                if (!DateTime.TryParseExact(Ingreso, format, new CultureInfo("es-ES"), DateTimeStyles.None, out FechaValida))
                {
                    Console.WriteLine("No ingresó una fecha en el formato correcto");
                    continue;
                }
                if (FechaValida > DateTime.Now)
                {
                    Console.WriteLine("Debe ingresar una fecha menor al día de hoy");
                    continue;
                }

                IngresoValido = true;
                Console.Write("La fecha ingresada es: {0}", FechaValida.ToString("dd/MM/yyyy"));

            } while (!IngresoValido);

        }



    }
}
