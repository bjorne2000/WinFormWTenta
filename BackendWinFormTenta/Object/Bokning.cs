namespace BackendWinFormTenta
{
    public class Bokning
    {
        public virtual int ID { get; set; }
        public virtual Visning bokadVisning { get; set; }
        public virtual Kund bokadKund { get; set; }
        public virtual int plats { get; set; }
        public Bokning()
        {

        }

        public Bokning(Kund _kund, Visning _visning, int _plats)
        {
            bokadKund = _kund;
            bokadVisning = _visning;
            plats = _plats;
        }
    }
}