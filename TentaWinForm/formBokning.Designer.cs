
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlats = new System.Windows.Forms.TextBox();
            this.thumbNail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNail)).BeginInit();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txt.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt.Location = new System.Drawing.Point(358, 325);
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
            // 
            // adress
            // 
            this.adress.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.adress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adress.Location = new System.Drawing.Point(134, 157);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(125, 31);
            this.adress.TabIndex = 9;
            // 
            // personNr
            // 
            this.personNr.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.personNr.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personNr.Location = new System.Drawing.Point(134, 353);
            this.personNr.Name = "personNr";
            this.personNr.Size = new System.Drawing.Size(125, 31);
            this.personNr.TabIndex = 10;
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
            "Psycho",
            "Misery"});
            this.FilmComboBox.Location = new System.Drawing.Point(358, 159);
            this.FilmComboBox.Name = "FilmComboBox";
            this.FilmComboBox.Size = new System.Drawing.Size(151, 31);
            this.FilmComboBox.TabIndex = 14;
            this.FilmComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Crimson;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(358, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Plats";
            // 
            // txtPlats
            // 
            this.txtPlats.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPlats.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlats.Location = new System.Drawing.Point(358, 247);
            this.txtPlats.Name = "txtPlats";
            this.txtPlats.Size = new System.Drawing.Size(125, 31);
            this.txtPlats.TabIndex = 16;
            // 
            // thumbNail
            // 
            this.thumbNail.Image = global::TentaWinForm.Properties.Resources.alienPoster;
            this.thumbNail.Location = new System.Drawing.Point(589, 62);
            this.thumbNail.Name = "thumbNail";
            this.thumbNail.Size = new System.Drawing.Size(284, 352);
            this.thumbNail.TabIndex = 17;
            this.thumbNail.TabStop = false;
            this.thumbNail.Click += new System.EventHandler(this.thumbNail_Click);
            // 
            // formBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1057, 526);
            this.Controls.Add(this.thumbNail);
            this.Controls.Add(this.txtPlats);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlats;
        private System.Windows.Forms.PictureBox thumbNail;
    }
}