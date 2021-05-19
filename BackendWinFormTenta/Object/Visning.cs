using System;

namespace BackendWinFormTenta
{
    public class Visning
    {
        public virtual int ID { get; set; }
        public virtual DateTime start { get; set; }
        public virtual Salong visningsSalong { get; set; }
        public virtual Film visningsFilm { get; set; }

        public Visning(string _start, Salong _VisningsSalong, Film _visningsFilm)
        {
            start = DateTime.Parse(_start);
            visningsSalong = _VisningsSalong;
            visningsFilm = _visningsFilm;
        }
        public Visning()
        {

        }
    }
}