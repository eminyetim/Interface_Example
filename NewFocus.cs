using System;

namespace arayuz_ornek
{
    public class NewFocus : Otomobiller
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }


        public override Renk StandartRegiNe()
        {
            return Renk.Gri;
        }
    }
}