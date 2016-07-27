using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kermen
{
    public class YoungCouple : Couple
    {
        private const int NumberOfRomms = 2;
        private const decimal RoomElectricity = 20;

        private decimal laptopCost;

        public YoungCouple(decimal salaryOne, decimal salaryTwo, decimal tvCost, decimal fridgeCost,decimal laptop) 
            : base(NumberOfRomms, RoomElectricity,salaryOne + salaryTwo, tvCost, fridgeCost)
        {
            this.laptopCost = laptop;
        }

        protected YoungCouple(int numbersOfRooms, decimal roomElectricity, decimal income, decimal tvCost,
            decimal fridgeCost, decimal laptopCost) 
            : base(numbersOfRooms,roomElectricity,income,tvCost,fridgeCost)
        {
            this.laptopCost = laptopCost;
        }
        public override decimal Consumtion
        {
            get { return this.laptopCost * 2 + base.Consumtion; }
        }
    }
}