namespace IMPICC_INTERF
{
    partial class Form1
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
            ris = new Button();
            label1 = new Label();
            pUsate = new TextBox();
            let = new TextBox();
            aiutino = new Button();
            jolly = new TextBox();
            tent = new Label();
            label2 = new Label();
            label3 = new Label();
            dif = new Button();
            med = new Button();
            fac = new Button();
            exit = new Button();
            punteggio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ris
            // 
            ris.Location = new Point(229, 248);
            ris.Name = "ris";
            ris.Size = new Size(75, 23);
            ris.TabIndex = 0;
            ris.Text = "INVIA";
            ris.UseVisualStyleBackColor = true;
            ris.Click += ris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 90);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "LETTERE-PROVATE";
            // 
            // pUsate
            // 
            pUsate.Location = new Point(204, 87);
            pUsate.Name = "pUsate";
            pUsate.Size = new Size(100, 23);
            pUsate.TabIndex = 3;
            pUsate.TextChanged += pUsate_TextChanged;
            // 
            // let
            // 
            let.Location = new Point(219, 277);
            let.Name = "let";
            let.Size = new Size(100, 23);
            let.TabIndex = 5;
            // 
            // aiutino
            // 
            aiutino.Location = new Point(393, 248);
            aiutino.Name = "aiutino";
            aiutino.Size = new Size(73, 23);
            aiutino.TabIndex = 6;
            aiutino.Text = "JOLLY";
            aiutino.UseVisualStyleBackColor = true;
            // 
            // jolly
            // 
            jolly.Location = new Point(381, 277);
            jolly.Name = "jolly";
            jolly.Size = new Size(100, 23);
            jolly.TabIndex = 7;
            // 
            // tent
            // 
            tent.AutoSize = true;
            tent.Location = new Point(244, 164);
            tent.Name = "tent";
            tent.Size = new Size(0, 15);
            tent.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 169);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 9;
            label2.Text = "TENTATIVI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(714, 70);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 10;
            label3.Text = "DIFFICOLTA'";
            // 
            // dif
            // 
            dif.Location = new Point(795, 104);
            dif.Name = "dif";
            dif.Size = new Size(75, 23);
            dif.TabIndex = 11;
            dif.Text = "DIFFICILE";
            dif.UseVisualStyleBackColor = true;
            dif.Click += dif_Click;
            // 
            // med
            // 
            med.Location = new Point(714, 104);
            med.Name = "med";
            med.Size = new Size(75, 23);
            med.TabIndex = 12;
            med.Text = "MEDIA";
            med.UseVisualStyleBackColor = true;
            med.Click += med_Click;
            // 
            // fac
            // 
            fac.Location = new Point(633, 104);
            fac.Name = "fac";
            fac.Size = new Size(75, 23);
            fac.TabIndex = 13;
            fac.Text = "FACILE";
            fac.UseVisualStyleBackColor = true;
            fac.Click += fac_Click;
            // 
            // exit
            // 
            exit.Location = new Point(843, 16);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 14;
            exit.Text = "ESCI";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // punteggio
            // 
            punteggio.Location = new Point(204, 128);
            punteggio.Name = "punteggio";
            punteggio.Size = new Size(100, 23);
            punteggio.TabIndex = 16;
            punteggio.TextChanged += punteggio_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 131);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 15;
            label4.Text = "PUNTEGGIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(420, 34);
            label5.Name = "label5";
            label5.Size = new Size(143, 34);
            label5.TabIndex = 17;
            label5.Text = "IMPICCATO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(449, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 490);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(punteggio);
            Controls.Add(label4);
            Controls.Add(exit);
            Controls.Add(fac);
            Controls.Add(med);
            Controls.Add(dif);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tent);
            Controls.Add(jolly);
            Controls.Add(aiutino);
            Controls.Add(let);
            Controls.Add(pUsate);
            Controls.Add(label1);
            Controls.Add(ris);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ris;
        private Label label1;
        private TextBox pUsate;
        private TextBox let;
        private Button aiutino;
        private TextBox jolly;
        private Label tent;
        private Label label2;
        private Label label3;
        private Button dif;
        private Button med;
        private Button fac;
        private Button exit;
        private TextBox punteggio;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}
