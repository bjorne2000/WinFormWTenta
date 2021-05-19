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
             
                BokningsHantering obj = new BokningsHantering();                
                obj.Boka(namn.Text.ToString(),tele.Text.ToString(),adress.Text.ToString(),int.Parse(personNr.Text), FilmComboBox.Text.ToString(),tidComboBox.Text.ToString(), int.Parse(txtPlats.Text));

            
        }


        private void tidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool ValidateFirstName()
        {
            string name = namn.Text.ToString();
            var checkChar = Regex.IsMatch(name, @"^[a-öA-Ö]+$");
            bool nullCheck = String.IsNullOrWhiteSpace(name);
            var validated = name.Length > 15 || name.Length < 1 || checkChar == false || nullCheck == true ? false : true;
            return validated;
        }
        public  bool ValidatePhoneNr()
        {
            string number = tele.Text.ToString();
            var regex = Regex.IsMatch(number, @"\d\-");
            bool nullCheck = String.IsNullOrWhiteSpace(number);
            bool validated = !regex || nullCheck ? false : true;
            return validated;
        }

        private void namn_TextChanged(object sender, EventArgs e)
        {

        }

        private void thumbNail_Click(object sender, EventArgs e)
        {

        }

        private void FilmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
