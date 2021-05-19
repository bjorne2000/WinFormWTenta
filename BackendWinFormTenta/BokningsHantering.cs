using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendWinFormTenta
{
    public class BokningsHantering
    {
        public bool Boka(string namn, string tele, string adress, int persNr, string film, string tid, int plats)
        {
            bool succes = false;
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                var kund = new Kund(tele, namn, adress, persNr);
                var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == film && v.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay);
                    Bokning bokning = new Bokning(kund, visning, plats);
                    dbContext.bokningar.Add(bokning);
                    succes = true;
                    dbContext.SaveChanges();
                    return succes;

                
            }
        }
    }
}
