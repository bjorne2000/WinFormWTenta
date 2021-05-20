using BackendWinFormTenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentaWinForm
{
    public partial class ChangeBokning : Form
    {
        public ChangeBokning()
        {
            InitializeComponent();
        }

        private void namn_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txt_Click(object sender, EventArgs e)
        {
            BokningsHantering obj = new BokningsHantering();
            foreach (var item in obj.findBokning(teleNr.Text.ToString()))
            {
                bokningar.Items.Add(item);
            }

        }

        private void EnableCheckBox(string platser)
        {

        }

        private void bokningar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string change = bokningar.Text.ToString();
            change = change.Replace("Film:", "");
            change = change.Replace("Plats:", "");
            change = change.Replace("Tid:", "");
            change = change.Replace(" ", "");
            string[] split = change.Split(',');
            FilmComboBox.Text = split[0];
            tidComboBox.Text = split[1];
            checkBoxCheck();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(teleNr.Text != null && bokningar.SelectedIndex != -1)
            {
                BokningsHantering bok = new BokningsHantering();
                var checkBoxar = checkArray();
                string platser = "";
                var kund = bok.FindKund(teleNr.Text.ToString());
                for (int i = 0; i < checkBoxar.Length; i++)
                {
                    if (checkBoxar[i].Checked == true && checkBoxar[i].Enabled == true)
                    {
                        platser += $"{i + 1}, ";
                    }


                }
                bool bokad = bok.Boka(kund.namn, kund.teleNr, kund.adress, kund.perssonNr,
                 FilmComboBox.Text.ToString(), tidComboBox.Text.ToString(), platser);
                if (bokad)
                {
                    lblSucces.Text = "Bokning uppdaterad";
                    bok.DeleteBokning(kund.teleNr, FilmComboBox.Text.ToString(), tidComboBox.Text.ToString());
                    PlatserCheck();
                    bok.RemoveEmpty();
                }
                else { lblSucces.Text = "Något gick snett"; }
            }




        }
        public void checkBoxCheck()
        {
            using (DbContextMovie dbContext = new DbContextMovie())
            {
                BokningsHantering bokning = new BokningsHantering();
                if (FilmComboBox.SelectedIndex != -1 && tidComboBox.SelectedIndex != -1 && teleNr.Text != null && bokningar.SelectedIndex != -1)
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
                    string p = "";
                    try
                    {
                        p = bokning.HittaPlatser(teleNr.Text.ToString(), FilmComboBox.Text.ToString(), tidComboBox.Text.ToString());

                    }
                    catch (Exception) { return; }


                    string[] split = p.Split(',');
                    for (int i = 0; i < split.Length; i++)
                    {
                        if(split[i] == " ")
                        {
                            break;
                        }
                        checkBoxar[int.Parse(split[i]) - 1].Enabled = true;
                    }
                }
                dbContext.SaveChanges();

            }
        }
        public CheckBox[] checkArray()
        {
            var checkBoxes = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20 };
            return checkBoxes;
        }

        private void tidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        private void FilmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxCheck();
        }

        public bool PlatserCheck()
        {
            bool succes = false;
            bool[] platser = new bool[20];

            for (int i = 0; i < platser.Length; i++)
            {
                platser[i] = false;
            }

            if (checkBox1.Checked == true)
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

        private void lblSucces_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
