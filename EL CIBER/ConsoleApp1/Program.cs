using EL_CIBER;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Ciber c1 = new Ciber();

            Computadoras e1 = new Computadoras(Computadoras.ESoftware.Messenger, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.AgeOfEmpiresII, "i5", "C1", false);
            Computadoras e2 = new Computadoras(Computadoras.ESoftware.Ares, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.AgeOfEmpiresII, "i5", "C2", true);
            Computadoras e3 = new Computadoras(Computadoras.ESoftware.Icq, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.AgeOfEmpiresII, "wi5", "C3", false);
            Computadoras e4 = new Computadoras(Computadoras.ESoftware.Office, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.AgeOfEmpiresII, "ri5", "C3", false);
            Computadoras e5 = new Computadoras(Computadoras.ESoftware.Nero, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.AgeOfEmpiresII, "cci5", "C3", false);


          


            c1 += e1;
            c1 += e2;
            c1 += e3;
            c1 += e4;
            c1 += e5;

  

            //foreach (Computadoras item in lista)
            //{
            //    if (item.Estado == false)
            //    {
            //        Console.WriteLine(item.Listar());
            //    }
            //}
            //foreach (Computadoras item in c1.Computadora)
            //{
            //    if(item.Estado == true)
            //        Console.WriteLine(item.Listar());
            //}

            //Console.WriteLine(c1.listarCompus());
            //Console.WriteLine(c1.listarClientes());
            //double cobro = 0;

            //int opciones=0;
            //Stopwatch timeMeasure = new Stopwatch();
            //TimeSpan w = new TimeSpan();
            //timeMeasure.Start();
            //do
            //{
            //    if (timeMeasure.ElapsedMilliseconds > 30000)
            //    {
            //        Console.WriteLine("Se acabo el tiempo... YA VETE DEL CIIIIIBEEER");
            //        timeMeasure.Stop();
            //        opciones = 10;
            //    }

            //} while (opciones != 10);
           
            //opciones = Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    switch (opciones)
            //    {
            //        case 1:
            //            Console.WriteLine(c1.listarCompus());
            //            Console.WriteLine("Ingrese las opciones: " +
            //                "\n1.Mostrar" +
            //                "\n2.Agregar cliente" +
            //                "\n3.Expulsar Cliente");
            //            opciones = Convert.ToInt32(Console.ReadLine());

            //            break;
            //        case 2:
            //            timeMeasure.Start();
            //            if (timeMeasure.ElapsedMilliseconds == 5000)
            //            {
            //                opciones = 3;
            //            }
            //            break;
            //        case 3:
            //            timeMeasure.Stop();
            //            TimeSpan r = timeMeasure.Elapsed;
            //            cobro = 2.5 * r.TotalSeconds;
            //            Console.WriteLine(cobro);

            //            Console.WriteLine("Ingrese las opciones: " +
            //             "\n1.Mostrar" +
            //             "\n2.Agregar cliente" +
            //             "\n3.Expulsar Cliente");
            //            opciones = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 4:
            //            Console.WriteLine("Ingrese las opciones: " +
            //             "\n1.Mostrar" +
            //             "\n2.Agregar cliente" +
            //             "\n3.Expulsar Cliente");
            //            opciones = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //} while (opciones != 10);





        }
    }
}
