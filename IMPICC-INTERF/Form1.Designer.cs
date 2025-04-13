using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IMPICC_INTERF
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exit = new Button();
            tent = new Label();
            fac = new Button();
            med = new Button();
            dif = new Button();
            lSbagliate = new Label();
            jolly = new Label();
            scritLettera = new TextBox();
            scritParola = new TextBox();
            lettera = new Button();
            parola = new Button();
            punteggio = new Label();
            trat = new Label();
            titotlo = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            perso = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perso).BeginInit();
            SuspendLayout();
            // 
            // exit
            // 
            exit.BackColor = Color.DarkRed;
            exit.Cursor = Cursors.Cross;
            exit.Font = new System.Drawing.Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonHighlight;
            exit.Location = new Point(842, 11);
            exit.Name = "exit";
            exit.Size = new Size(126, 73);
            exit.TabIndex = 0;
            exit.Text = "ESCI";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // tent
            // 
            tent.AutoSize = true;
            tent.BackColor = Color.LightBlue;
            tent.Font = new System.Drawing.Font("Segoe UI", 18F);
            tent.Location = new Point(33, 140);
            tent.Name = "tent";
            tent.Size = new Size(167, 32);
            tent.TabIndex = 1;
            tent.Text = "TENTATIVI--->";
            tent.Visible = false;
            tent.Click += tentativi_Click;
            // 
            // fac
            // 
            fac.BackColor = Color.Lime;
            fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            fac.Location = new Point(607, 185);
            fac.Name = "fac";
            fac.Size = new Size(83, 34);
            fac.TabIndex = 3;
            fac.Text = "FACILE";
            fac.UseVisualStyleBackColor = false;
            fac.Click += fac_Click;
            // 
            // med
            // 
            med.BackColor = Color.Gold;
            med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            med.Location = new Point(708, 185);
            med.Name = "med";
            med.Size = new Size(79, 34);
            med.TabIndex = 4;
            med.Text = "MEDIA";
            med.UseVisualStyleBackColor = false;
            med.Click += med_Click;
            // 
            // dif
            // 
            dif.BackColor = Color.Red;
            dif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            dif.Location = new Point(807, 185);
            dif.Name = "dif";
            dif.Size = new Size(108, 34);
            dif.TabIndex = 5;
            dif.Text = "DIFFICILE";
            dif.UseVisualStyleBackColor = false;
            dif.Click += dif_Click;
            // 
            // lSbagliate
            // 
            lSbagliate.AutoSize = true;
            lSbagliate.BackColor = Color.LightBlue;
            lSbagliate.Font = new System.Drawing.Font("Segoe UI", 18F);
            lSbagliate.Location = new Point(25, 432);
            lSbagliate.Name = "lSbagliate";
            lSbagliate.Size = new Size(175, 32);
            lSbagliate.TabIndex = 6;
            lSbagliate.Text = "LETTERE USATE";
            lSbagliate.Visible = false;
            lSbagliate.Click += lSbagliate_Click;
            // 
            // jolly
            // 
            jolly.AutoSize = true;
            jolly.BackColor = Color.LightBlue;
            jolly.Font = new System.Drawing.Font("Segoe UI", 18F);
            jolly.Location = new Point(146, 342);
            jolly.Name = "jolly";
            jolly.Size = new Size(75, 32);
            jolly.TabIndex = 7;
            jolly.Text = "JOLLY";
            jolly.Visible = false;
            jolly.Click += jolly_Click;
            // 
            // scritLettera
            // 
            scritLettera.Cursor = Cursors.IBeam;
            scritLettera.Location = new Point(40, 396);
            scritLettera.Name = "scritLettera";
            scritLettera.Size = new Size(100, 23);
            scritLettera.TabIndex = 8;
            scritLettera.Visible = false;
            scritLettera.TextChanged += scritLettera_TextChanged;
            // 
            // scritParola
            // 
            scritParola.Cursor = Cursors.IBeam;
            scritParola.Location = new Point(227, 396);
            scritParola.Name = "scritParola";
            scritParola.Size = new Size(100, 23);
            scritParola.TabIndex = 9;
            scritParola.Visible = false;
            scritParola.TextChanged += scritParola_TextChanged;
            // 
            // lettera
            // 
            lettera.BackColor = Color.MidnightBlue;
            lettera.ForeColor = SystemColors.Control;
            lettera.Location = new Point(40, 329);
            lettera.Name = "lettera";
            lettera.Size = new Size(100, 45);
            lettera.TabIndex = 11;
            lettera.Text = "MANDA";
            lettera.UseVisualStyleBackColor = false;
            lettera.Visible = false;
            lettera.Click += lettera_Click;
            // 
            // parola
            // 
            parola.BackColor = Color.MidnightBlue;
            parola.ForeColor = SystemColors.Control;
            parola.Location = new Point(227, 329);
            parola.Name = "parola";
            parola.Size = new Size(100, 45);
            parola.TabIndex = 12;
            parola.Text = "MANDA";
            parola.UseVisualStyleBackColor = false;
            parola.Visible = false;
            parola.Click += parola_Click;
            // 
            // punteggio
            // 
            punteggio.AutoSize = true;
            punteggio.BackColor = Color.LightBlue;
            punteggio.Font = new System.Drawing.Font("Segoe UI", 18F);
            punteggio.Location = new Point(12, 108);
            punteggio.Name = "punteggio";
            punteggio.Size = new Size(188, 32);
            punteggio.TabIndex = 13;
            punteggio.Text = "PUNTEGGIO--->";
            punteggio.Visible = false;
            punteggio.Click += punteggio_Click;
            // 
            // trat
            // 
            trat.Font = new System.Drawing.Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trat.Location = new Point(66, 215);
            trat.Name = "trat";
            trat.Size = new Size(187, 70);
            trat.TabIndex = 14;
            trat.Click += trat_Click;
            // 
            // titotlo
            // 
            titotlo.Font = new System.Drawing.Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titotlo.Location = new Point(332, 11);
            titotlo.Name = "titotlo";
            titotlo.Size = new Size(376, 70);
            titotlo.TabIndex = 15;
            titotlo.Text = "IMPICCATO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightBlue;
            pictureBox1.Location = new Point(12, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 32);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(511, 108);
            label1.Name = "label1";
            label1.Size = new Size(481, 50);
            label1.TabIndex = 17;
            label1.Text = "SCEGLI UNA DIFFICOLTA'";
            // 
            // perso
            // 
            perso.Image = Properties.Resources.img_Impic;
            perso.Location = new Point(555, 238);
            perso.Name = "perso";
            perso.Size = new Size(508, 255);
            perso.SizeMode = PictureBoxSizeMode.StretchImage;
            perso.TabIndex = 18;
            perso.TabStop = false;
            perso.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Gabriola", 48F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(300, 185);
            label2.Name = "label2";
            label2.Size = new Size(286, 118);
            label2.TabIndex = 19;
            label2.Text = "HAI PERSO";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(520, 118);
            label3.Name = "label3";
            label3.Size = new Size(448, 38);
            label3.TabIndex = 20;
            label3.Text = "SE VUOI GIOCARE ANCORA SCEGLI UNA DIFFICOLTA'\r\n ALTRIMENTI CLICCA SUL PULSANTE ESCI";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Gabriola", 48F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(303, 185);
            label4.Name = "label4";
            label4.Size = new Size(283, 118);
            label4.TabIndex = 21;
            label4.Text = "HAI VINTO";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(983, 492);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(perso);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(titotlo);
            Controls.Add(trat);
            Controls.Add(punteggio);
            Controls.Add(parola);
            Controls.Add(lettera);
            Controls.Add(scritParola);
            Controls.Add(scritLettera);
            Controls.Add(jolly);
            Controls.Add(lSbagliate);
            Controls.Add(dif);
            Controls.Add(med);
            Controls.Add(fac);
            Controls.Add(tent);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)perso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label tent;
        private Button fac;
        private Button med;
        private Button dif;
        private Label lSbagliate;
        private Label jolly;
        private TextBox scritLettera;
        private TextBox scritParola;
        private Button lettera;
        private Button parola;
        private Label punteggio;
        private Label trat;
        private Label titotlo;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox perso;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
