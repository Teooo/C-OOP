using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kermen
{
    public abstract class HouseHold
    {
        private int numbersOfRooms;
        private decimal roomElentricity;
        private readonly decimal income;
        private decimal money;

        protected HouseHold(decimal income,int numberOfRooms,decimal roomElectricity)
        {
            this.money = 0;
            this.income = income;
            this.numbersOfRooms = numberOfRooms;
            this.roomElentricity = roomElectricity;
        }

        public virtual int Population
        {
            get { return 1; }
        }

        public virtual decimal Consumtion
        {
            get { return this.numbersOfRooms * this.roomElentricity; }
        }

        public void GetIncome()
        {
            this.money += this.income;
        }

        public bool CanPayBills()
        {
            return this.money >= this.Consumtion;
        }

        public void PayBills()
        {
            this.money -= this.Consumtion;
        }
    }
}