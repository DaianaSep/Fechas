using System;
using System.Collections.Generic;
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
                string Fecha = Console.ReadLine();

                if (!DateTime.TryParse(Fecha, out DateTime FechaOK))
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



    }
}
