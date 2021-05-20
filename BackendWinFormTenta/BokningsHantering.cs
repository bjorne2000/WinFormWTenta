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
                var kund = new Kund(tele, namn, adress, persNr);
                var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == film && v.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay);
                //foreach (var item in dbContext.bokningar)
                //{
                //    if (item.bokadVisning == visning && item.biljetter == biljetter)
                //    {
                //        return succes;                       
                //    }
                //}

                //:::::::::::::::::


                //:::::::::::::::::
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
                        dbContext.SaveChanges();
                        return boolArray;
                    }
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
    }
}
