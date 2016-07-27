using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kermen
{
    public class AloneOld : Single
    {
        private const int NumberOfRomms = 1;
        private const decimal RoomElectricity = 15;

        public AloneOld(decimal pension)
            : base(pension, NumberOfRomms, RoomElectricity)
        {
        }
    }
    
}