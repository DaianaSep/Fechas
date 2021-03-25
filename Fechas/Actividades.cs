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

        public void A23() 
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

        public void A24()
        {
            bool IngresoValido = false;
            do
            {
                Console.WriteLine("Ingrese una fecha con el siguiente formato 'dd/mm/yyyy': ");
                string Ingreso = Console.ReadLine();
                string format = "dd/MM/yyyy";

                if (!DateTime.TryParseExact(Ingreso, format, new CultureInfo("es-ES"), DateTimeStyles.None, out DateTime FechaValida))
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
                Console.Write("La fecha ingresada es: {0}", FechaValida);

            } while (!IngresoValido);
        }

        public void A25()
        {
            //Console.Write("Ingrese 3 números: ");z
            //string Ingreso
        }

        public void A26()
        {
            bool IngresoValido = false;
            do
            {
                Console.WriteLine("Ingrese una fecha: ");
                string Ingreso = Console.ReadLine();

                if (!DateTime.TryParse(Ingreso, out DateTime FechaValida))
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
                Console.Write($"Día: {FechaValida.Day}, Año: {FechaValida.Year}, Mes: {FechaValida.Month}, {FechaValida.ToString("MMMM")}, Día de la semana:{FechaValida.Day}, {FechaValida.ToString("dddd")}" );

            } while (!IngresoValido);
        }

        public void A27()
        {
            bool IngresoValido = false;

            do
            {
                Console.WriteLine("Ingrese una fecha: ");
                string Ingreso = Console.ReadLine();

                if (!DateTime.TryParse(Ingreso, out DateTime FechaValida))
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

                var FechaAdd30 = FechaValida.AddDays(30);
                var FechaAdd60 = FechaValida.AddDays(60);
                var FechaAdd90 = FechaValida.AddDays(90);
                var FechaAdd180 = FechaValida.AddDays(180);

                Console.WriteLine($"Fecha 30 días posteriores: {FechaAdd30.ToString("dd/MM/yyyy")}," +
                    $" Fecha 60 días posteriores: {FechaAdd60.ToString("dd/MM/yyyy")}," +
                    $" Fecha 90 días posteriores: {FechaAdd90.ToString("dd/MM/yyyy")}," +
                    $" Fecha 180 días posteriores: {FechaAdd180.ToString("dd/MM/yyyy")}");

            } while (!IngresoValido);
        }

        public void A28()
        {

            Console.Write("Ingrese un año: ");
            int Ingreso = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(Ingreso))
            {
                Console.WriteLine($" {Ingreso} es un año bisiesto");
            }
            else
            {
                Console.WriteLine($"{Ingreso} no es un año bisiesto");
            }
        }
    }
}
