using System;

namespace arayuz_ornek
{
    public class Corolla : IOtomobil

    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlekOlusur()
        {
            return 4;
        }

        public Renk StandartRegiNe()
        {
            return Renk.Beyaz;
        }
    }
}