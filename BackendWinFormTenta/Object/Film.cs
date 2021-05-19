namespace BackendWinFormTenta
{
    public class Film
    {
        public virtual int ID { get; set; }
        public virtual string filmNamn { get; set; }
        public Film()
        {

        }
        public Film(string _filmNamn)
        {
            filmNamn = _filmNamn;
        }
    }
}