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
        private Random random = new Random();// Inicjalizacja generatora losowych liczb
        private string[] images = { "banan1.jpg", "arbuz1.jpg", "ananas1.jpg" };//tablica z obrazkami
        private int liczbaMonet;//zmienna przechowujaca liczbe monet/pieniedzy
        public Forml()
        {
            InitializeComponent();
            button1.Enabled = false;//ZABLKOWANIE PRZYCISKU losowania na poczatek
        }

        private void buttonSetCoins_Click(object sender, EventArgs e)
        {
            //PUSTE
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
            int index1 = random.Next(images.Length);// Losowanie indeksu dla pierwszego obrazka
            int index2 = random.Next(images.Length);// Losowanie indeksu dla drugiego obrazka
            int index3 = random.Next(images.Length);// Losowanie indeksu dla trzeciego obrazka


            pictureBox1.Image = Image.FromFile(images[index1]);// Ustawienie losowego obrazka dla `pictureBox1`
            pictureBox2.Image = Image.FromFile(images[index2]);// Ustawienie losowego obrazka dla `pictureBox2`
            pictureBox3.Image = Image.FromFile(images[index3]);// Ustawienie losowego obrazka dla `pictureBox3`

            //Sprawdzanie różnych kombinacji wygranych
            bool wygrana = (images[index1] == "ananas1.jpg" && images[index2] == "ananas1.jpg" && images[index3] == "ananas1.jpg");//trzy ananasy
            bool wygrana2 = (images[index1] == "arbuz1.jpg" && images[index2] == "arbuz1.jpg" && images[index3] == "arbuz1.jpg");//trzy arbuzy
            bool wygrana3 = (images[index1] == "banan1.jpg" && images[index2] == "banan1.jpg" && images[index3] == "banan1.jpg");//trzy banany
            bool wygrana4 = (images[index1] == "banan1.jpg" && images[index2] == "banan1.jpg");//dwa obrazki
            bool wygrana5 = (images[index1] == "arbuz1.jpg" && images[index2] == "arbuz1.jpg");//dwa obrazki
            bool wygrana6 = (images[index1] == "ananas1.jpg" && images[index2] == "ananas1.jpg");//dwa obrazki
            bool wygrana7 = (images[index3] == "banan1.jpg" && images[index2] == "banan1.jpg");//dwa obrazki
            bool wygrana8 = (images[index3] == "arbuz1.jpg" && images[index2] == "arbuz1.jpg");//dwa obrazki
            bool wygrana9 = (images[index3] == "ananas1.jpg" && images[index2] == "ananas1.jpg");//dwa obrazki
            bool wygrana10 = (images[index1] == "banan1.jpg" && images[index3] == "banan1.jpg");//dwa obrazki
            bool wygrana11 = (images[index1] == "arbuz1.jpg" && images[index3] == "arbuz1.jpg");//dwa obrazki
            bool wygrana12 = (images[index1] == "ananas1.jpg" && images[index3] == "ananas1.jpg");//dwa obrazki


            // Wywołanie metody aktualizującej liczbę monet, ktora zawiera 12zmiennych bool
            AktualizujKase(wygrana,wygrana2,wygrana3,wygrana4,wygrana5,wygrana6,wygrana7,wygrana8,wygrana9, wygrana10, wygrana11, wygrana12);
            

        }
        private void AktualizujKase(bool wygrana, bool wygrana2, bool wygrana3,bool wygrana4, bool wygrana5,bool wygrana6,bool wygrana7,bool wygrana8,bool wygrana9,bool wygrana10,bool wygrana11,bool wygrana12)//
        {
            if (wygrana)
            {
                liczbaMonet += 50;//Dodanie uzytkownikowi 50momnet jak trafi jackpot
                label2.Text = "Jackpot ANANASOWY! Wygrywasz 50 monet!";
            }
            else if (wygrana2)
            {
                liczbaMonet += 30;//Dodanie uzytkownikowi 30momnet jak trafi 3 arbuzy
                label2.Text = "Wygrywasz 30 monet za trzy arbuzy!";
            }
            else if (wygrana3)
            {
                liczbaMonet += 10;//Dodanie uzytkownikowi 10momnet jak trafi 3 banany
                label2.Text = "Wygrywasz 10 monet za trzy banany!";
            }
            else if (wygrana4)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana5)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana6)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana7)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana8)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana9)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana10)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana11)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else if (wygrana12)
            {
                liczbaMonet += 1;//gdy uzytkownik trafi dwa takie same owoce to dostaje
                label2.Text = "Masz 1monete za dwa";// jedna monete na pocieszenie
            }
            else 
            {
                liczbaMonet -= 30;//za przegrana jest zabierane 30monet/pieniedzy
                label2.Text="Brak wygranej. Tracisz 30 monet.";
            }


            label1.Text = $"Monety: {liczbaMonet}";
            // Wyświetlenie aktualnej liczby monet. `$` oznacza interpolację ciągu znaków
            //- pozwala wstawiać zmienne w środku łańcucha.

            if (liczbaMonet <= 0)
            {//jesli zabraaknie monet to gra jest stopowana i zamykana
                MessageBox.Show("Nie masz już monet. GAME OVER!");//MessageBox informujący
                Close();//Zamknięcie aplikacji
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Brak instrukcji, licznik przechowujący liczbe mone/pieniedzy
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
