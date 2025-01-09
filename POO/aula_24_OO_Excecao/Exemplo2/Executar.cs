using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Exemplo2
{
    public class Executar
    {
        static void Teste(string[] args)
        {
            System.Console.WriteLine("Insira a Room Number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Insira a dada de Check-In (dd/MM/yyyy): ");
            DateTime checkin = Convert.ToDateTime(Console.ReadLine());

            System.Console.WriteLine("Insira a dada de Check-Out (dd/MM/yyyy): ");
            DateTime checkout = Convert.ToDateTime(Console.ReadLine());

            DateTime now = DateTime.Now;

            Reservation reservation = new Reservation(roomNumber, checkin, checkout);

            string error = reservation.UpdateDates(checkin, checkout);

            if (error != null)
            {
                System.Console.WriteLine(error);
            } else
            {
                System.Console.WriteLine("Reserva: " + reservation);
            }
        }
    }
}