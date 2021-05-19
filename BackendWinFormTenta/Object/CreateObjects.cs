using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendWinFormTenta
{
    public class CreateObjects
    {
        public static void CreateSalong()
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                for (int i = 0; i < 10; i++)
                {
                    Salong nySalong = new Salong(i + 1);
                    dbContext.salonger.Add(nySalong);
                }
                dbContext.SaveChanges();
            }

        }
        public static void CreateFilmer()
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                Film alien = new Film("Alien");
                Film theShining = new Film("The Shining");
                Film omen = new Film("Omen");
                Film scream = new Film("Scream");
                Film theMist = new Film("The Mist");
                Film saw = new Film("Saw");
                Film theOthers = new Film("The Others");
                Film wolfCreek = new Film("Wolf Creek");
                Film psycho = new Film("Psycho");
                Film misery = new Film("Misery");

                dbContext.filmer.Add(alien);
                dbContext.filmer.Add(theShining);
                dbContext.filmer.Add(omen);
                dbContext.filmer.Add(scream);
                dbContext.filmer.Add(theMist);
                dbContext.filmer.Add(saw);
                dbContext.filmer.Add(theOthers);
                dbContext.filmer.Add(wolfCreek);
                dbContext.filmer.Add(psycho);
                dbContext.filmer.Add(misery);
                dbContext.SaveChanges();
            }
        }
        public static void CreateVisning()
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {
                for (int i = 1; i < 5; i++)
                {
                    string visEtt = "20:00:00";
                    string visTvå = "22:00:00";
                    string visTre = "00:00:00";
                    string visFyra = "02:00:00";
                    string inTid = "";

                    if(i == 1)
                    {
                        inTid = visEtt;
                    }
                    else if(i == 2)
                    {
                        inTid = visTvå;
                    }
                    else if(i == 3)
                    {
                        inTid = visTre;
                    }
                    else if(i == 4)
                    {
                        inTid = visFyra;
                    }

                    var alien = (Film)dbContext.filmer.First(f => f.filmNamn == "Alien");
                    var shining = (Film)dbContext.filmer.First(f => f.filmNamn == "The Shining");
                    var omen = (Film)dbContext.filmer.First(f => f.filmNamn == "Omen");
                    var scream = (Film)dbContext.filmer.First(f => f.filmNamn == "Scream");
                    var mist = (Film)dbContext.filmer.First(f => f.filmNamn == "The Mist");
                    var saw = (Film)dbContext.filmer.First(f => f.filmNamn == "Saw");
                    var others = (Film)dbContext.filmer.First(f => f.filmNamn == "The Others");
                    var wolf = (Film)dbContext.filmer.First(f => f.filmNamn == "Wolf Creek");
                    var psycho = (Film)dbContext.filmer.First(f => f.filmNamn == "Psycho");
                    var misery = (Film)dbContext.filmer.First(f => f.filmNamn == "Misery");

                    var ett = (Salong)dbContext.salonger.First(s => s.salongNum == 1);
                    var två = (Salong)dbContext.salonger.First(s => s.salongNum == 2);
                    var tre = (Salong)dbContext.salonger.First(s => s.salongNum == 3);
                    var fyra = (Salong)dbContext.salonger.First(s => s.salongNum == 4);
                    var fem = (Salong)dbContext.salonger.First(s => s.salongNum == 5);
                    var sex = (Salong)dbContext.salonger.First(s => s.salongNum == 6);
                    var sju = (Salong)dbContext.salonger.First(s => s.salongNum == 7);
                    var åtta = (Salong)dbContext.salonger.First(s => s.salongNum == 8);
                    var nio = (Salong)dbContext.salonger.First(s => s.salongNum == 9);
                    var tio = (Salong)dbContext.salonger.First(s => s.salongNum == 10);

                    Visning salEttVisning = new Visning(inTid, ett, alien);
                    Visning salTvåVisning = new Visning(inTid, två, shining);
                    Visning salTreVisning = new Visning(inTid,tre,omen);
                    Visning salFyraVisning = new Visning(inTid,fyra,scream);
                    Visning salFemVisning = new Visning(inTid,fem,saw);
                    Visning salSexVisning = new Visning(inTid,sex,others);
                    Visning salSjuVisning = new Visning(inTid,sju,mist);
                    Visning salÅttaVisning = new Visning(inTid,åtta,wolf);
                    Visning salNioVisning = new Visning(inTid,nio,psycho);
                    Visning salTioVisning = new Visning(inTid,tio,misery);


                    dbContext.visningar.Add(salEttVisning);
                    dbContext.visningar.Add(salTvåVisning);
                    dbContext.visningar.Add(salTreVisning);
                    dbContext.visningar.Add(salFyraVisning);
                    dbContext.visningar.Add(salFemVisning);
                    dbContext.visningar.Add(salSexVisning);
                    dbContext.visningar.Add(salSjuVisning);
                    dbContext.visningar.Add(salÅttaVisning);
                    dbContext.visningar.Add(salNioVisning);
                    dbContext.visningar.Add(salTioVisning);


                    dbContext.SaveChanges();
                }
            }
           
        }

    }
}
