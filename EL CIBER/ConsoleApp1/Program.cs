using EL_CIBER;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Ciber c1 = new Ciber(4);

            Computadoras e1 = new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Nada },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium3, "C01", false);

            Computadoras e2 = new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Nada },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium3, "C02", false);

            Clientes cli1 = new Clientes("Luciano", 321, "Pezza", 20, false);
            Clientes cli2 = new Clientes("Lucas", 123, "Perez", 69, false);
            Clientes cli3 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli31 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli32 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli33 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli4 = new Clientes("Lautaro", 4, "Galarza", 23, false);
            Clientes cli5 = new Clientes("Marcos", 5, "Oppioso", 20, false);
            Clientes cli6 = new Clientes("Eric", 6, "Cartman", 8, false);
            Clientes cli7 = new Clientes("Peter", 7, "Griffin", 40, false);
            Clientes cli8 = new Clientes("Leando", 8, "Montenegro", 18, false);
            Clientes cli9 = new Clientes("Homero", 9, "Simpson", 40, false);
            Clientes cli10 = new Clientes("Troy", 10, "McClure", 40, false);
            Llamada call1 = new Llamada("Cualquiera", Llamada.ETipo.Teclado, "T01");
            Llamada call2 = new Llamada("Cualquiera", Llamada.ETipo.Teclado, "T02");
            Llamada call3 = new Llamada("Cualquiera", Llamada.ETipo.Teclado, "T03");
            Llamada call4 = new Llamada("Cualquiera", Llamada.ETipo.Teclado, "T04");


            c1 += e1;
            c1 += e2;
           

            c1 += cli1;
            c1 += cli2;
            c1 += cli3;
            c1 += cli4;
            c1 += cli5;
            c1 += cli6;
            c1 += cli7;
            c1 += cli8;
            c1 += cli9;
            c1 += cli10;
          
            c1.Llamadas[0] = call1;
            c1.Llamadas[1] = call2;
            c1.Llamadas[2] = call3;
            c1.Llamadas[3] = call4;
            double costo = 0;
            long []numerardo = { 541155,121212,548888,-15156156};
            for (int i = 0; i < c1.Llamadas.Length; i++)
            {
               costo= c1.Llamadas[i].calcularCostoLlamada(numerardo[i]);
            }


            Console.WriteLine(c1.listarLlamadas()); 
           
            //double costo;
            //long NumeroTelefonico = 54113340;
            //string numeroTel = NumeroTelefonico.ToString();
            //Console.WriteLine(numeroTel.Substring(2, 2));
            //if (numeroTel.Substring(2,2) == "11" )
            //{

            //    Console.WriteLine("prro");
            //}

            //Console.WriteLine(c1.listarCompus());
            //foreach (Computadoras item in c1.Computadora)
            //{
            //    foreach (Clientes item2 in c1.Clientes)
            //    {
            //        if (item.Estado == false && item.Hardware.ToString() == item2.HarwareDeseado)
            //        {
            //            Console.WriteLine(item.Listar());
            //            break;
            //        }
            //    }


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
