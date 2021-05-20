using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendWinFormTenta
{
    public class BokningsHantering
    {
        public bool Boka(string namn, string tele, string adress, int persNr, string film, string tid, string platser)
        {
            bool succes = false;
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                bool sammaKund = false;
                try
                {
                   sammaKund = dbContext.kunder.First().teleNr == tele ? true : false;
                }
                catch(Exception)
                {
 
                }
                
                if(sammaKund == true)
                {
                    var hittad = dbContext.kunder.First(k => k.teleNr == tele);
                    var vis = dbContext.visningar.First(v => v.visningsFilm.filmNamn == film && v.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay);

                    Bokning bok = new Bokning(hittad, vis, platser);

                    dbContext.bokningar.Add(bok);
                    succes = true;
                    dbContext.SaveChanges();
                    return succes;
                }
                var kund = new Kund(tele, namn, adress, persNr);
                
                var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == film && v.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay);

                Bokning bokning = new Bokning(kund, visning, platser);

                    dbContext.bokningar.Add(bokning);
                    succes = true;
                    dbContext.SaveChanges();
                    return succes;                
            }
        }

        public void SparaPlatser(string tid, string film, bool[] nyPlatser)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {                
                var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == film && v.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay);
                visning.visningsSalong.ArrayToPlats(nyPlatser);
                dbContext.SaveChanges();
            }
        }


        public bool[] createArray(Visning visning)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                bool[] boolArray = new bool[20];

                var hitta = dbContext.bokningar.Where(b => b.bokadVisning == visning);

                string appendad = "";

                foreach (var item in hitta)
                {
                    appendad += item.platser;
                }

                string[] biljetter = appendad.Split(',');
                if (appendad == "")
                {
                    for (int i = 0; i < boolArray.Length; i++)
                    {
                        boolArray[i] = false;

                    }
                    dbContext.SaveChanges();
                    return boolArray;
                }

                else if(biljetter.Length > 0)
                {
                    for (int i = 0; i < biljetter.Length; i++)
                    {
                        if(biljetter[i] == " ")
                        {
                            break;
                        }
                        boolArray[int.Parse(biljetter[i])-1] = true;
                    }
                }



                dbContext.SaveChanges();
                return boolArray;
            }

            

        }


        public List<string> findBokning(string teleNr)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                List<string> bokat = new List<string>();
                var bokningar = dbContext.bokningar.Where(b => b.bokadKund.teleNr == teleNr);
                foreach (var item in bokningar)
                {
                   bokat.Add($"Film:{item.bokadVisning.visningsFilm.filmNamn}, Tid: {item.bokadVisning.start.TimeOfDay}, Plats: {item.platser}");
                }
                return bokat;
            }
        }

        public Kund FindKund(string tele)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                var kund = dbContext.kunder.First(k => k.teleNr == tele);
                dbContext.SaveChanges();
                return kund;
            }
        }


        public bool DeleteBokning(string tele, string film, string tid)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                bool succes = false;
                var bokning = dbContext.bokningar.First(b => b.bokadKund.teleNr == tele &&
                              b.bokadVisning.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay 
                              && b.bokadVisning.visningsFilm.filmNamn == film);

                dbContext.bokningar.Remove(bokning);

                dbContext.SaveChanges();
                return succes;
            }

        }

        public string HittaPlatser(string tele, string film, string tid)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                var kund = FindKund(tele);
                var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == film && v.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay);
                var bokning = dbContext.bokningar.First(b => b.bokadVisning == visning && b.bokadKund == kund);
                string platser = bokning.platser;
                dbContext.SaveChanges();
                return platser;
            }

        }

    }
}
