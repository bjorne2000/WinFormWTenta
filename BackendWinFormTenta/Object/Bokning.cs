namespace BackendWinFormTenta
{
    public class Bokning
    {
        public virtual int ID { get; set; }
        public virtual Visning bokadVisning { get; set; }
        public virtual Kund bokadKund { get; set; }
        public virtual int biljetter { get; set; }
        public virtual string platser { get; set; }
        public Bokning()
        {

        }

        public Bokning(Kund _kund, Visning _visning, int _biljetter, string _platser)
        {
            bokadKund = _kund;
            bokadVisning = _visning;
            biljetter = _biljetter;
            platser = _platser;
        }
    }
}