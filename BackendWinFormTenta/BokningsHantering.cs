using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendWinFormTenta
{
    public class BokningsHantering
    {
        public bool Boka(string namn, string tele, string adress, int persNr, string film, string tid, int biljetter, string platser)
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
                Bokning bokning = new Bokning(kund, visning, biljetter, platser);

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

        public Visning GetVisning(string tid, string film)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
              var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == film && v.start.TimeOfDay == DateTime.Parse(tid).TimeOfDay);
                dbContext.SaveChanges();
              return visning;  
            }           
        }

        public bool[] GetPlatser(Visning visning)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                var boolArr = createArray(visning.visningsSalong);
                dbContext.SaveChanges();
                return boolArr;
            }

        }
        public bool[] createArray(Salong salong)
        {

                bool[] boolArray = new bool[20];
                boolArray[0] = salong.plats1;
                boolArray[1] = salong.plats2;
                boolArray[2] = salong.plats3;
                boolArray[3] = salong.plats4;
                boolArray[4] = salong.plats5;
                boolArray[5] = salong.plats6;
                boolArray[6] = salong.plats7;
                boolArray[7] = salong.plats8;
                boolArray[8] = salong.plats9;
                boolArray[9] = salong.plats10;
                boolArray[10] = salong.plats11;
                boolArray[11] = salong.plats12;
                boolArray[12] = salong.plats13;
                boolArray[13] = salong.plats14;
                boolArray[14] = salong.plats15;
                boolArray[15] = salong.plats16;
                boolArray[16] = salong.plats17;
                boolArray[17] = salong.plats18;
                boolArray[18] = salong.plats19;
                boolArray[19] = salong.plats20;
                return boolArray;
            

        }
    }
}
