﻿namespace BackendWinFormTenta
{
    public class Bokning
    {
        public virtual int ID { get; set; }
        public virtual Visning bokadVisning { get; set; }
        public virtual Kund bokadKund { get; set; }

        public virtual string platser { get; set; }
        public Bokning()
        {

        }

        public Bokning(Kund _kund, Visning _visning,  string _platser)
        {
            bokadKund = _kund;
            bokadVisning = _visning;
            platser = _platser;
        }
    }
}