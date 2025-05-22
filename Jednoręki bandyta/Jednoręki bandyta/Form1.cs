using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jednoręki_bandyta
{
    public partial class Forml : Form
    {
        private Random random = new Random();
        private string[] images = { "banan1.jpg", "arbuz1.jpg", "ananas1.jpg" };
        private int liczbaMonet;
        public Forml()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void buttonSetCoins_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index1 = random.Next(images.Length);
            int index2 = random.Next(images.Length);
            int index3 = random.Next(images.Length);


            pictureBox1.Image = Image.FromFile(images[index1]);
            pictureBox2.Image = Image.FromFile(images[index2]);
            pictureBox3.Image = Image.FromFile(images[index3]);

            bool wygrana = (images[index1] == "ananas1.jpg" && images[index2] == "ananas1.jpg" && images[index3] == "ananas1.jpg");
            bool wygrana2 = (images[index1] == "arbuz1.jpg" && images[index2] == "arbuz1.jpg" && images[index3] == "arbuz1.jpg");
            bool wygrana3 = (images[index1] == "banan1.jpg" && images[index2] == "banan1.jpg" && images[index3] == "banan1.jpg");
            bool wygrana4 = (images[index1] == "banan1.jpg" && images[index2] == "banan1.jpg");
            bool wygrana5 = (images[index1] == "arbuz1.jpg" && images[index2] == "arbuz1.jpg");
            bool wygrana6 = (images[index1] == "ananas1.jpg" && images[index2] == "ananas1.jpg");
            bool wygrana7 = (images[index3] == "banan1.jpg" && images[index2] == "banan1.jpg");
            bool wygrana8 = (images[index3] == "arbuz1.jpg" && images[index2] == "arbuz1.jpg");
            bool wygrana9 = (images[index3] == "ananas1.jpg" && images[index2] == "ananas1.jpg");
            bool wygrana10 = (images[index1] == "banan1.jpg" && images[index3] == "banan1.jpg");
            bool wygrana11 = (images[index1] == "arbuz1.jpg" && images[index3] == "arbuz1.jpg");
            bool wygrana12 = (images[index1] == "ananas1.jpg" && images[index3] == "ananas1.jpg");



            AktualizujKase(wygrana,wygrana2,wygrana3,wygrana4,wygrana5,wygrana6,wygrana7,wygrana8,wygrana9, wygrana10, wygrana11, wygrana12);
            

        }
        private void AktualizujKase(bool wygrana, bool wygrana2, bool wygrana3,bool wygrana4, bool wygrana5,bool wygrana6,bool wygrana7,bool wygrana8,bool wygrana9,bool wygrana10,bool wygrana11,bool wygrana12)//
        {
            if (wygrana)
            {
                liczbaMonet += 50;
                label2.Text = "Jackpot ANANASOWY! Wygrywasz 50 monet!";
            }
            else if (wygrana2)
            {
                liczbaMonet += 30;
                label2.Text = "Wygrywasz 30 monet za trzy arbuzy!";
            }
            else if (wygrana3)
            {
                liczbaMonet += 10;
                label2.Text = "Wygrywasz 10 monet za trzy banany!";
            }
            else if (wygrana4)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete za dwa";
            }
            else if (wygrana5)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete za dwa";
            }
            else if (wygrana6)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete za dwa";
            }
            else if (wygrana7)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete za dwa";
            }
            else if (wygrana8)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete za dwa";
            }
            else if (wygrana9)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete za dwa";
            }
            else if (wygrana10)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete za dwa";
            }
            else if (wygrana11)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete na dwa";
            }
            else if (wygrana12)
            {
                liczbaMonet += 1;
                label2.Text = "Masz 1monete na dwa";
            }
            else 
            {
                liczbaMonet -= 30;
                label2.Text="Brak wygranej. Tracisz 30 monet.";
            }


            label1.Text = $"Monety: {liczbaMonet}";

            if (liczbaMonet <= 0)
            {
                MessageBox.Show("Nie masz już monet. GAME OVER!");
                //button1.Enabled = false; // Zablokowanie przycisku losowania // POPRAWIONE
                //textBox1.Enabled = true; // Odblokowanie pola do wpisania monet // POPRAWIONE
                //buttonSetCoins.Enabled = true; // Odblokuj ustawianie monet
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetCoins_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int monety) && monety > 0)
            {
                liczbaMonet = monety; // Przypisanie liczby monet // POPRAWIONE
                label1.Text = $"Monety: {liczbaMonet}"; // Wyświetlenie liczby monet // POPRAWIONE
                MessageBox.Show($"Rozpoczęto grę z {liczbaMonet} monetami!");

                button1.Enabled = true; // Odblokowanie przycisku losowania // POPRAWIONE
                textBox1.Enabled = false; // Zablokowanie zmiany liczby monet // POPRAWIONE
                buttonSetCoins.Enabled = false; // Zablokowanie przycisku ustawiania monet // POPRAWIONE
            }
            else
            {
                MessageBox.Show("Podaj poprawną liczbę monet (większą od 0).");
            }
        }
    }
}
