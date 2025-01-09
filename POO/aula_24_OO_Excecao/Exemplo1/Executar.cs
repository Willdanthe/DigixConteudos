using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Exemplo1
{
    public class Executar
    {
        static void Teste0(string[] args) // Exemplo Ruim
        {
            System.Console.WriteLine("Insira a Room Number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Insira a dada de Check-In (dd/MM/yyyy): ");
            DateTime checkin = Convert.ToDateTime(Console.ReadLine());

            System.Console.WriteLine("Insira a dada de Check-Out (dd/MM/yyyy): ");
            DateTime checkout = Convert.ToDateTime(Console.ReadLine());

            if (checkin < DateTime.Now && checkout < DateTime.Now) // Verificação para se a data é menos que o dia de hoje
            {
                System.Console.WriteLine("Erro na Reserva: As datas para reserva devem ser futras");
            } else if (checkin <= DateTime.Now)
            {
                System.Console.WriteLine("Erro no CheckIn: As datas do CheckIn devem ser futras");
            } else if (checkout <= DateTime.Now)
            {
                System.Console.WriteLine("Erro no CheckOut: As datas do CheckOut devem ser futras");
            } else 
            {
                Reservation r = new Reservation(roomNumber, checkin, checkout);
                System.Console.WriteLine(r);

                

            }

        }
    }
}