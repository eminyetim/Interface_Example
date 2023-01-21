namespace arayuz_ornek
{
    public abstract class Otomobiller
    {
        public int KacTekerlekOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRegiNe() // Override edilerek içi değiştirilebilir.
        {
            return Renk.Beyaz;
        }

        //Abstract olduğu için override edilmek zorunda.
        public abstract Marka HangiMarkaninAraci(); //Hepsi için farklı değer dönderceği için abstract oluşturursun.

    }
}