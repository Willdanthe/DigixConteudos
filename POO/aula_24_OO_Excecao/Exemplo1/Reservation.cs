using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Exemplo1
{
    public class Reservation
    {
        public int  RoomNumber{ get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            this.RoomNumber = roomNumber;
            this.CheckIn = checkin;
            this.CheckOut = checkout;
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
            this.CheckIn = checkin;
            this.CheckOut = checkout; 
        }

    }
}