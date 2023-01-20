using System;

namespace arayuz_ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlekOlusur()
        {
            return 4;
        }

        public Renk StandartRegiNe()
        {
            return Renk.Gri;
        }
    }
}