using BackendWinFormTenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentaWinForm
{
    public partial class formBokning : Form
    {
        public formBokning()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var checkBoxar = checkArray();
            string platser = "";
            for (int i = 0; i < checkBoxar.Length; i++)
            {
                if(checkBoxar[i].Checked == true && checkBoxar[i].Enabled == true)
                {
                    platser+= $"{i + 1}, ";
                }
            }
            BokningsHantering obj = new BokningsHantering();  
            if(ValidateAdress() && ValidateFirstName() && ValidatePhoneNr() && ValidatePersonNr() && checkMovie())
            {
                bool bokad = obj.Boka(namn.Text.ToString(), tele.Text.ToString(), adress.Text.ToString(), int.Parse(personNr.Text), FilmComboBox.Text.ToString(), tidComboBox.Text.ToString(), platser);
                if (bokad)
                {
                    succeslbl.Text = $"{namn.Text} har bokat plats nr:{txtBiljett.Text} till filmen {FilmComboBox.Text} klockan {tidComboBox}";
                    PlatserCheck();
                }
                else
                {
                    succeslbl.Text = "inte bokad";
                }
            }
            else
            {
                succeslbl.Text = "Kolla igenom så att du skrivit i alla rutor samt att det är korrekt information";
            }

            
        }

        public CheckBox[] checkArray()
        {
            var checkBoxes = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20 };
            return checkBoxes;
        }
        public bool PlatserCheck()
        {
            bool succes = false;
            bool[] platser = new bool[20];

            for (int i = 0; i < platser.Length; i++)
            {
                platser[i] = false;
            }

            if(checkBox1.Checked == true)
            {
                platser[0] = true;
            }

            if (checkBox2.Checked == true)
            {
                platser[1] = true;
            }

            if (checkBox3.Checked == true)
            {
                platser[2] = true;
            }

            if (checkBox4.Checked == true)
            {
                platser[3] = true;
            }

            if (checkBox5.Checked == true)
            {
                platser[4] = true;
            }

            if (checkBox6.Checked == true)
            {
                platser[5] = true;
            }

            if (checkBox7.Checked == true)
            {
                platser[6] = true;
            }

            if (checkBox8.Checked == true)
            {
                platser[7] = true;
            }

            if (checkBox9.Checked == true)
            {
                platser[8] = true;
            }

            if (checkBox10.Checked == true)
            {
                platser[9] = true;
            }

            if (checkBox11.Checked == true)
            {
                platser[10] = true;
            }

            if (checkBox12.Checked == true)
            {
                platser[11] = true;
            }

            if (checkBox13.Checked == true)
            {
                platser[12] = true;
            }

            if (checkBox14.Checked == true)
            {
                platser[13] = true;
            }

            if (checkBox15.Checked == true)
            {
                platser[14] = true;
            }

            if (checkBox16.Checked == true)
            {
                platser[15] = true;
            }

            if (checkBox17.Checked == true)
            {
                platser[16] = true;
            }

            if (checkBox18.Checked == true)
            {
                platser[17] = true;
            }

            if (checkBox19.Checked == true)
            {
                platser[18] = true;
            }

            if (checkBox20.Checked == true)
            {
                platser[19] = true;
            }
            BokningsHantering bokning = new BokningsHantering();
            bokning.SparaPlatser(tidComboBox.Text.ToString(), FilmComboBox.Text.ToString(), platser);

            return succes;
        }

        private void namn_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFirstName())
            {                
                lblNamn.Text = "✓";
                lblNamn.ForeColor = Color.Green;
                lblNamn.Visible = true;
            }
            else
            {
                lblNamn.Text = "X";
                lblNamn.ForeColor = Color.Red;
                lblNamn.Visible = true;
            }
        }
        public bool checkMovie()
        {
            bool validated = FilmComboBox.SelectedIndex != -1 && tidComboBox.SelectedIndex != -1 ? true : false;
            
            return validated;
        }


        private void FilmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(DbContextMovie dbContext = new DbContextMovie())
            {

              


                BokningsHantering bokning = new BokningsHantering();
                //var visning = bokning.GetVisning(tidComboBox.Text.ToString(), FilmComboBox.Text.ToString());

                if (FilmComboBox.SelectedIndex != -1 && tidComboBox.SelectedIndex != -1)
                {
                    //var uppagnaPlatser = bokning.GetPlatser(visning);
                    var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == FilmComboBox.Text.ToString() && v.start.TimeOfDay == DateTime.Parse(tidComboBox.Text).TimeOfDay);
                    var upptagnaPlatser = bokning.createArray(visning);
                    var checkBoxar = checkArray();

                    for (int i = 0; i < upptagnaPlatser.Length; i++)
                    {
                        if(upptagnaPlatser[i] == true)
                        {
                            checkBoxar[i].Checked = true;
                            checkBoxar[i].Enabled = false;
                        }
                        else 
                        { 
                            checkBoxar[i].Checked = false;
                            checkBoxar[i].Enabled = true;
                        }

                    }
                }
                dbContext.SaveChanges();

            }

        }


        private void tele_TextChanged(object sender, EventArgs e)
        {
            if(ValidatePhoneNr())
            {
                lblTele.Text = "✓";
                lblTele.ForeColor = Color.Green;
                lblTele.Visible = true;
            }
            else
            {
                lblTele.Text = "X";
                lblTele.ForeColor = Color.Red;
                lblTele.Visible = true;
            }
        }

        private void adress_TextChanged(object sender, EventArgs e)
        {
            if (ValidateAdress())
            {
                lblAdress.Text = "✓";
                lblAdress.ForeColor = Color.Green;
                lblAdress.Visible = true;
            }
            else
            {
                lblAdress.Text = "X";
                lblAdress.ForeColor = Color.Red;
                lblAdress.Visible = true;
            }

        }
        public bool ValidatePersonNr()
        {
            string text = personNr.Text.ToString();
            var regex = Regex.IsMatch(text, @"^[0-9]*$");
            bool validated = regex == true && text.Length > 5 ? true : false;
            return validated;
        }

        private void personNr_TextChanged(object sender, EventArgs e)
        {

            if(ValidatePersonNr())
            {
                lblPersNr.Text = "✓";
                lblPersNr.ForeColor = Color.Green;
                lblPersNr.Visible = true;

            }
            else
            {
                lblPersNr.Text = "X";
                lblPersNr.ForeColor = Color.Red;
                lblPersNr.Visible = true;
            }
        }

        public bool ValidateFirstName()
        {
            string name = namn.Text.ToString();
            var checkChar = Regex.IsMatch(name, @"^[a-öA-Ö]+$");
            bool nullCheck = String.IsNullOrWhiteSpace(name);
            var validated = name.Length > 15 || name.Length < 1 || checkChar == false || nullCheck == true ? false : true;
            return validated;
        }
        public bool ValidatePhoneNr()
        {
            string number = tele.Text.ToString();
            var regex = Regex.IsMatch(number, @"^[0-9]*$");
            bool nullCheck = String.IsNullOrWhiteSpace(number);
            bool validated = !regex || nullCheck ? false : true;
            return validated;
        }
        public bool ValidateAdress()
        {
            string text = adress.Text.ToString();
            bool nullCheck = String.IsNullOrWhiteSpace(text);
            bool validated = text.Length > 2 && text.Length < 30 && nullCheck == false ? true : false;
            return validated;

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DbContextMovie dbContext = new DbContextMovie())
            {
                BokningsHantering bokning = new BokningsHantering();
                if (FilmComboBox.SelectedIndex != -1 && tidComboBox.SelectedIndex != -1)
                {
                    var visning = dbContext.visningar.First(v => v.visningsFilm.filmNamn == FilmComboBox.Text.ToString() && v.start.TimeOfDay == DateTime.Parse(tidComboBox.Text).TimeOfDay);
                    var upptagnaPlatser = bokning.createArray(visning);


                    var checkBoxar = checkArray();

                    for (int i = 0; i < upptagnaPlatser.Length; i++)
                    {
                        if (upptagnaPlatser[i] == true)
                        {
                            checkBoxar[i].Checked = true;
                            checkBoxar[i].Enabled = false;
                        }
                        else
                        {
                            checkBoxar[i].Checked = false;
                            checkBoxar[i].Enabled = true;
                        }
                    }
                }
                dbContext.SaveChanges();

            }
        }


    }
}
