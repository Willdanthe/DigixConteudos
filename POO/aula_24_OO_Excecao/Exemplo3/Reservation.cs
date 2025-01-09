using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Exemplo3
{
    public class Reservation
    {
        public int  RoomNumber{ get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now && checkout < now)
            {
                // Throw new é uma exceção que é lançada quando um erro é encontrado
                throw new DomainException($"Erro Reserva: Os Checkin não podem ser menor que o dia de hoje ({DateTime.Now})...");
            }
            if ( checkin <= checkout)
            {
                // é uma exceção personalizada, mas que fica dentro do padrão de erro
                throw new DomainException("Erro reserva: A data de Chekout não pode ser menor ou igual que a de Checkin");
            }

            this.CheckIn = checkin;
            this.CheckOut = checkout;
            this.RoomNumber = roomNumber;
            }

        public int Duration()
        {
            TimeSpan tS = CheckOut.Subtract(CheckIn);
            return (int)tS.TotalDays;
        }

        public override string ToString()
        {
            return @$"
Room: {RoomNumber}
CheckIn: {CheckIn.ToString("dd/MM/yyyy")}            
CheckOut: {CheckOut.ToString("dd/MM/yyyy")}            
Dias: {Duration()}
";
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            try
            {
                DateTime now = DateTime.Now;
                if (checkin < now || checkout < now)
                {
                    // Throw new é uma exceção que é lançada quando um erro é encontrado
                    throw new DomainException($"Erro Reserva: Os Checkin não podem ser menor que o dia de hoje ({DateTime.Now})...");
                }
                if ( checkout <= checkin)
                {
                    // é uma exceção personalizada, mas que fica dentro do padrão de erro
                    throw new DomainException("Erro reserva: A data de Chekout não pode ser menor ou igual que a de Checkin");
                }

                this.CheckIn = checkin;
                this.CheckOut = checkout;
            }
            catch (DomainException e)   // Exceção Personalizada
            {
                System.Console.WriteLine("Erro na Reserva: " + e.Message);
            }
            catch (FormatException e) // Exceção de formato de entrada
            {
                System.Console.WriteLine("Erro de formato: "+ e.Message);
            }
            catch (Exception e) // Exceção Genérica
            {
                System.Console.WriteLine("Erro Inesperado: " + e.Message);
            } 
        }

    }
}