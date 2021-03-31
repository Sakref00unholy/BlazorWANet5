using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNet5
{
    public class CovidShop
    {
        public int Id { get; set; }
        public int Antal { get; set; }
        public int AntalMax { get; set; }
        public string ButiksNavn { get; set; }

        public CovidShop(int id, int antal, int antalMax, string butiksNavn)
        {
            Id = id;
            Antal = antal;
            AntalMax = antalMax;
            ButiksNavn = butiksNavn;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Antal)}: {Antal}, {nameof(AntalMax)}: {AntalMax}, {nameof(ButiksNavn)}: {ButiksNavn}";
        }
    }
}
