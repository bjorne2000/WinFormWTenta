namespace BackendWinFormTenta
{
    public class Salong
    {
        public virtual int ID { get; set; }
        public virtual int salongNum { get; set; }
        public Salong(int _salongnum)
        {
            salongNum = _salongnum;
        }
        public Salong()
        {

        }
    }
}