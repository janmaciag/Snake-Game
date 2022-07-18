using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;



namespace waz
{
    public partial class Form1 : Form
    {
        private List<Kwadrat> waz = new List<Kwadrat>();
        private Jedzenie jedzenie = new Jedzenie();
        public bool kolory1;
        public bool kolory2;
        public bool kolory3;
        public Form1()
        {
            InitializeComponent();

            new Ustawienia();

            timer1.Interval = 1000 / Ustawienia.Predkosc;
            timer1.Tick += Odswiezanie;
            timer1.Start();

        }

        private void ZacznijGre()
        {
            new Ustawienia();

            label3.Visible = false;
            waz.Clear();
            Kwadrat glowa = new Kwadrat
            {
                X = 10,
                Y = 20
            };

            waz.Add(glowa);

            label2.Text = Ustawienia.Wynik.ToString();
            TworzenieJedzenia();



        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ZacznijGre();
                    break;
                case Keys.Right:
                    if(Ustawienia.kierunek != Kierunek.Lewo)                 
                        Ustawienia.kierunek = Kierunek.Prawo;      
                    break;
                case Keys.Left:
                    if (Ustawienia.kierunek != Kierunek.Prawo)
                        Ustawienia.kierunek = Kierunek.Lewo;
                    break;
                case Keys.Up:
                    if (Ustawienia.kierunek != Kierunek.Dol)
                        Ustawienia.kierunek = Kierunek.Gora;
                    break;
                case Keys.Down:
                    if (Ustawienia.kierunek != Kierunek.Gora)
                        Ustawienia.kierunek = Kierunek.Dol;
                    break;

            }


        }

        private void Odswiezanie(object sender, EventArgs e)
        {

            Ruch();
            pictureBox1.Invalidate();

        }

        private void TworzenieJedzenia()
        {
            int maxY = pictureBox1.Size.Height/Ustawienia.Wysokosc;
            int maxX = pictureBox1.Size.Width / Ustawienia.Szerokosc; 

            Random random = new Random();
            jedzenie = new Jedzenie();
            jedzenie.X = random.Next(0, maxX);
            jedzenie.Y = random.Next(0, maxY);
        }

        private void Ruch()
        {
            for (int i = waz.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Ustawienia.kierunek)
                    {
                        case Kierunek.Prawo:
                            waz[i].X++;
                            break;
                        case Kierunek.Lewo:
                            waz[i].X--;
                            break;
                        case Kierunek.Gora:
                            waz[i].Y--;
                            break;
                        case Kierunek.Dol:
                            waz[i].Y++;
                            break;



                    }

                    if (i == 0 && waz[i].X == jedzenie.X && waz[i].Y == jedzenie.Y)
                        Zjedzenie();

                }
                else
                {
                    waz[i].X = waz[i - 1].X;
                    waz[i].Y = waz[i - 1].Y;
                }
                CzySmierc();


            }

            

        }

        private void RysowanieWeza(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            
            Brush kolor_weza;
            Brush kolor_glowy;
            Brush kolor_ciala;

            if (kolory1)
            {
                kolor_ciala = Brushes.Black;
                kolor_glowy = Brushes.Yellow;
            }
            else if (kolory2)
            {
                kolor_ciala = Brushes.Blue;
                kolor_glowy = Brushes.Green;
            }
            else if (kolory3)
            {
                kolor_ciala = Brushes.Red;
                kolor_glowy = Brushes.White;
            }

            else
            {
                kolor_ciala = Brushes.WhiteSmoke;
                kolor_glowy = Brushes.Tan;

            }

             
            if (Ustawienia.KoniecGry == false)
            {              
                for (int i = 0; i < waz.Count; i++) 
                {
                    if (i == 0)
                        kolor_weza = kolor_glowy;
                    else {
                        kolor_weza = kolor_ciala;
                    }

                    if (i  == 0)
                        canvas.FillEllipse(kolor_weza, new Rectangle(waz[i].X * Ustawienia.Szerokosc, waz[i].Y * Ustawienia.Wysokosc, Ustawienia.Szerokosc, Ustawienia.Wysokosc));
                    else
                        canvas.FillRectangle(kolor_weza, new Rectangle(waz[i].X * Ustawienia.Szerokosc, waz[i].Y * Ustawienia.Wysokosc, Ustawienia.Szerokosc, Ustawienia.Wysokosc));


                    canvas.FillRectangle(Brushes.Red,new Rectangle(jedzenie.X * Ustawienia.Szerokosc,jedzenie.Y * Ustawienia.Wysokosc, Ustawienia.Szerokosc, Ustawienia.Wysokosc));

                }                 
            }

            else
            {
                string koniec_gry = "    Koniec gry\nTwój wynik to: " + Ustawienia.Wynik + "\n   Kliknij enter ";
                label3.Text = koniec_gry;
                label3.Visible = true;
            }
        }

        private void CzySmierc()
        {
            for (int i = waz.Count - 1; i >= 2; i--)
            {
                if(waz[0].X == waz[i].X && waz[0].Y == waz[i].Y)
                    Ustawienia.KoniecGry = true;
            }

            if(waz[0].X >= pictureBox1.Width/Ustawienia.Szerokosc || waz[0].Y >= pictureBox1.Height/Ustawienia.Wysokosc || waz[0].X < 0 || waz[0].Y < 0)
                Ustawienia.KoniecGry = true;

        }


        private void Zjedzenie()
        {
            Kwadrat cialo = new Kwadrat
            {
                X = waz[waz.Count-1].X,
                Y = waz[waz.Count - 1].Y
            };
            waz.Add(cialo);
            Ustawienia.Wynik += Ustawienia.DodanePkt;
            label2.Text = Ustawienia.Wynik.ToString();
            TworzenieJedzenia();
        }

        public void czarnożToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolory1 = true;
            kolory2 = false;
            kolory3 = false;

        }

        private void niebieskizielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolory1 = false;
            kolory2 = true;
            kolory3 = false;
        }

        private void czerwonybiałyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolory1 = false;
            kolory2 = false;
            kolory3 = true;
        }
    }
}
