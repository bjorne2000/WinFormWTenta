
namespace TentaWinForm
{
    partial class formBokning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBokning));
            this.txt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.namn = new System.Windows.Forms.TextBox();
            this.tele = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.personNr = new System.Windows.Forms.TextBox();
            this.tidComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FilmComboBox = new System.Windows.Forms.ComboBox();
            this.thumbNail = new System.Windows.Forms.PictureBox();
            this.succeslbl = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblPersNr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txt.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt.Location = new System.Drawing.Point(640, 335);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(145, 92);
            this.txt.TabIndex = 1;
            this.txt.Text = "Lägg till bokning";
            this.txt.UseVisualStyleBackColor = false;
            this.txt.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(134, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(134, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(134, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Crimson;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(134, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "PersonNr";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(466, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 7;
            // 
            // namn
            // 
            this.namn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.namn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namn.Location = new System.Drawing.Point(134, 62);
            this.namn.Name = "namn";
            this.namn.Size = new System.Drawing.Size(125, 31);
            this.namn.TabIndex = 7;
            this.namn.TextChanged += new System.EventHandler(this.namn_TextChanged);
            // 
            // tele
            // 
            this.tele.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tele.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tele.Location = new System.Drawing.Point(134, 247);
            this.tele.Name = "tele";
            this.tele.Size = new System.Drawing.Size(125, 31);
            this.tele.TabIndex = 8;
            this.tele.TextChanged += new System.EventHandler(this.tele_TextChanged);
            // 
            // adress
            // 
            this.adress.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.adress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adress.Location = new System.Drawing.Point(134, 157);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(125, 31);
            this.adress.TabIndex = 9;
            this.adress.TextChanged += new System.EventHandler(this.adress_TextChanged);
            // 
            // personNr
            // 
            this.personNr.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.personNr.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personNr.Location = new System.Drawing.Point(134, 353);
            this.personNr.Name = "personNr";
            this.personNr.Size = new System.Drawing.Size(125, 31);
            this.personNr.TabIndex = 10;
            this.personNr.TextChanged += new System.EventHandler(this.personNr_TextChanged);
            // 
            // tidComboBox
            // 
            this.tidComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tidComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tidComboBox.FormattingEnabled = true;
            this.tidComboBox.Items.AddRange(new object[] {
            "20:00",
            "22:00",
            "00:00",
            "02:00"});
            this.tidComboBox.Location = new System.Drawing.Point(358, 62);
            this.tidComboBox.Name = "tidComboBox";
            this.tidComboBox.Size = new System.Drawing.Size(151, 31);
            this.tidComboBox.TabIndex = 11;
            this.tidComboBox.SelectedIndexChanged += new System.EventHandler(this.tidComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Crimson;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(358, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Crimson;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(358, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Film";
            // 
            // FilmComboBox
            // 
            this.FilmComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmComboBox.FormattingEnabled = true;
            this.FilmComboBox.Items.AddRange(new object[] {
            "Alien",
            "The Shining",
            "Omen",
            "Scream",
            "The Mist",
            "Saw",
            "The Others",
            "Wolf Creek",
            "Pshyco",
            "Misery"});
            this.FilmComboBox.Location = new System.Drawing.Point(358, 159);
            this.FilmComboBox.Name = "FilmComboBox";
            this.FilmComboBox.Size = new System.Drawing.Size(151, 31);
            this.FilmComboBox.TabIndex = 14;
            this.FilmComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmComboBox_SelectedIndexChanged);
            // 
            // thumbNail
            // 
            this.thumbNail.Location = new System.Drawing.Point(640, 34);
            this.thumbNail.Name = "thumbNail";
            this.thumbNail.Size = new System.Drawing.Size(187, 245);
            this.thumbNail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.thumbNail.TabIndex = 17;
            this.thumbNail.TabStop = false;
            // 
            // succeslbl
            // 
            this.succeslbl.AutoSize = true;
            this.succeslbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.succeslbl.Location = new System.Drawing.Point(667, 443);
            this.succeslbl.Name = "succeslbl";
            this.succeslbl.Size = new System.Drawing.Size(0, 38);
            this.succeslbl.TabIndex = 18;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamn.Location = new System.Drawing.Point(85, 68);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(63, 25);
            this.lblNamn.TabIndex = 19;
            this.lblNamn.Text = "label8";
            this.lblNamn.Visible = false;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdress.Location = new System.Drawing.Point(85, 165);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 25);
            this.lblAdress.TabIndex = 20;
            this.lblAdress.Text = "label8";
            this.lblAdress.Visible = false;
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTele.Location = new System.Drawing.Point(85, 254);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(63, 25);
            this.lblTele.TabIndex = 21;
            this.lblTele.Text = "label8";
            this.lblTele.Visible = false;
            // 
            // lblPersNr
            // 
            this.lblPersNr.AutoSize = true;
            this.lblPersNr.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersNr.Location = new System.Drawing.Point(85, 359);
            this.lblPersNr.Name = "lblPersNr";
            this.lblPersNr.Size = new System.Drawing.Size(63, 25);
            this.lblPersNr.TabIndex = 22;
            this.lblPersNr.Text = "label8";
            this.lblPersNr.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.checkBox20);
            this.panel1.Controls.Add(this.checkBox19);
            this.panel1.Controls.Add(this.checkBox18);
            this.panel1.Controls.Add(this.checkBox17);
            this.panel1.Controls.Add(this.checkBox16);
            this.panel1.Controls.Add(this.checkBox15);
            this.panel1.Controls.Add(this.checkBox14);
            this.panel1.Controls.Add(this.checkBox13);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(300, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 173);
            this.panel1.TabIndex = 23;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(188, 111);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(18, 17);
            this.checkBox20.TabIndex = 42;
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(151, 111);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(18, 17);
            this.checkBox19.TabIndex = 41;
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(108, 111);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(18, 17);
            this.checkBox18.TabIndex = 40;
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(61, 111);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(18, 17);
            this.checkBox17.TabIndex = 39;
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(14, 111);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(18, 17);
            this.checkBox16.TabIndex = 38;
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(188, 75);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(18, 17);
            this.checkBox15.TabIndex = 37;
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(151, 78);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(18, 17);
            this.checkBox14.TabIndex = 36;
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(108, 78);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(18, 17);
            this.checkBox13.TabIndex = 35;
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(61, 78);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(18, 17);
            this.checkBox12.TabIndex = 34;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(14, 75);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(18, 17);
            this.checkBox11.TabIndex = 33;
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(188, 43);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(18, 17);
            this.checkBox10.TabIndex = 32;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(151, 43);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(18, 17);
            this.checkBox9.TabIndex = 31;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(14, 43);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(18, 17);
            this.checkBox8.TabIndex = 30;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(61, 43);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(18, 17);
            this.checkBox7.TabIndex = 29;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(108, 43);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(18, 17);
            this.checkBox6.TabIndex = 28;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(188, 11);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 17);
            this.checkBox5.TabIndex = 27;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(151, 11);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(108, 11);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 25;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(61, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(928, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1057, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPersNr);
            this.Controls.Add(this.lblTele);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.succeslbl);
            this.Controls.Add(this.thumbNail);
            this.Controls.Add(this.FilmComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tidComboBox);
            this.Controls.Add(this.personNr);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.tele);
            this.Controls.Add(this.namn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Name = "formBokning";
            this.Text = "formBokning";
            ((System.ComponentModel.ISupportInitialize)(this.thumbNail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox namn;
        private System.Windows.Forms.TextBox tele;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox personNr;
        private System.Windows.Forms.ComboBox tidComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FilmComboBox;
        private System.Windows.Forms.PictureBox thumbNail;
        private System.Windows.Forms.Label succeslbl;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblPersNr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}