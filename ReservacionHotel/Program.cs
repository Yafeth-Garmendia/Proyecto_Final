﻿using System;

namespace ReservacionHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Reservacion reservacion = new Reservacion ();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("*       Bienvenido Hotel Santa Barbara     *");
                Console.WriteLine("");
                Console.WriteLine("1 - Registrar Informacion del Cliente");
                Console.WriteLine("2 - Ver clientes Registrados");
                Console.WriteLine("3 - Registrar informacion de Habitacion");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        DatosReservacion.RegistrarInformaciondelCliente();
                        break;
                    case "2":
                        DatosReservacion.VerClientesRegistrados();
                        break;
                    case "3":
                        DatosReservacion.RegistrarInformaciondelaHabitacion();
                        break;
                    
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}