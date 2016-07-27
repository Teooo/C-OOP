using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Kermen
{
    public class YoungCoupleWithChildren : YoungCouple
    {
        private const int NumberOfRomms = 2;
        private const decimal RoomElectricity = 30;
        private Child[] childrens;
        public YoungCoupleWithChildren(decimal salaryOne, decimal salaryTwo, decimal tvCost, decimal fridgeCost, decimal laptopCost, Child[] cildren) 
            : base(NumberOfRomms, RoomElectricity,salaryOne + salaryTwo,tvCost,fridgeCost,laptopCost)
        {
            this.childrens = cildren;
        }

        public override decimal Consumtion
        {
            get { return this.childrens.Sum(x => x.GetTotalConsumation()) + base.Consumtion; }
        }

        public override int Population
        {
            get { return this.childrens.Length + base.Population; }
        }
    }
}