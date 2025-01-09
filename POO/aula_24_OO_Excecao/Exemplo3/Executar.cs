using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Exemplo3
{
    public class Executar
    {
        static void Teste3(string[] args)
        {
            System.Console.WriteLine("Insira a Room Number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Insira a dada de Check-In (dd/MM/yyyy): ");
            DateTime checkin = Convert.ToDateTime(Console.ReadLine());

            System.Console.WriteLine("Insira a dada de Check-Out (dd/MM/yyyy): ");
            DateTime checkout = Convert.ToDateTime(Console.ReadLine());

            DateTime now = DateTime.Now;

            Reservation reservation = new Reservation(roomNumber, checkin, checkout);

            System.Console.WriteLine("Reserva: " + reservation);

            System.Console.WriteLine("Atualizar Reserva");
            System.Console.WriteLine("Insira a dada de Check-In (dd/MM/yyyy): ");
             checkin = Convert.ToDateTime(Console.ReadLine());

            System.Console.WriteLine("Insira a dada de Check-Out (dd/MM/yyyy): ");
            checkout = Convert.ToDateTime(Console.ReadLine());

            reservation.UpdateDates(checkin, checkout);
            System.Console.WriteLine("Reserva: " + reservation);
        }
    }
}