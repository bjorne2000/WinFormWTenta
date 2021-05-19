namespace BackendWinFormTenta
{
    public class Kund
    {
        public virtual int ID { get; set; }
        public virtual string teleNr { get; set; }
        public virtual string namn { get; set; }
        public virtual string adress { get; set; }
        public virtual int perssonNr { get; set; }

        public Kund(string _teleNr, string _namn, string _adress, int _perssonNr)
        {
            teleNr = _teleNr;
            namn = _namn;
            adress = _adress;
            perssonNr = _perssonNr;
        }
        public Kund()
        {

        }
    }
}