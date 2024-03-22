using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Geometrie
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public static class Globals
    {
        public static int max = 10;
        public static int score = 0;
        public static int record = 0;
        public static int forme = 0;
        public static int alea = 0;
        public static int oldUneValeur;
    }
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent(); 
            

        }
        
        private void BtnCarre_Click(object sender, RoutedEventArgs e)
        {
            

            //Affiche et cache les formes
            ImgStart.Visibility = Visibility.Hidden;
            carre.Visibility=Visibility.Visible;
            rectangle.Visibility = Visibility.Hidden;
            ellipse.Visibility = Visibility.Hidden;
            polygon.Visibility = Visibility.Hidden;
            LblDispValeur3.Visibility = Visibility.Hidden;
            LblDispValeur4.Visibility = Visibility.Hidden;
            LblValeur3.Visibility = Visibility.Hidden;
            LblValeur4.Visibility = Visibility.Hidden;

            BtnCarre.IsEnabled = false;
            BtnRectangle.IsEnabled = true;
            BtnRond.IsEnabled = true;
            BtnTriangle.IsEnabled = true;
            BtnAleatoire.IsEnabled = true;

            TxtPerimetreReponse.Focus();

            // Déclaration et instanciation d'un nouvel objet de la ClasseCarre
            ClasseCarre leCarre = new ClasseCarre();

            
            
            TxtPerimetreReponse.Text = Convert.ToString(leCarre.Perimetre());
            TxtSurfaceReponse.Text = Convert.ToString(leCarre.Surface());
            
            LblDispValeur1.Content = "Côté : ";
            LblValeur1.Content = leCarre.UneValeur;
            LblDispValeur2.Visibility = Visibility.Hidden;
            LblValeur2.Visibility = Visibility.Hidden;


            Globals.forme = 1;
            Globals.alea = 0;
        }

        private void BtnRectangle_Click(object sender, RoutedEventArgs e)
        {

            ImgStart.Visibility = Visibility.Hidden;
            carre.Visibility = Visibility.Hidden;
            rectangle.Visibility = Visibility.Visible;
            ellipse.Visibility = Visibility.Hidden;
            polygon.Visibility = Visibility.Hidden;
            LblDispValeur3.Visibility = Visibility.Hidden;
            LblDispValeur4.Visibility = Visibility.Hidden;
            LblValeur3.Visibility = Visibility.Hidden;
            LblValeur4.Visibility = Visibility.Hidden;

            BtnCarre.IsEnabled = true;
            BtnRectangle.IsEnabled = false;
            BtnRond.IsEnabled = true;
            BtnTriangle.IsEnabled = true;
            BtnAleatoire.IsEnabled = true;

            TxtPerimetreReponse.Focus();

            // Déclaration et instanciation d'un nouvel objet de la ClasseCarre
            ClasseRectangle leRectangle = new ClasseRectangle();


            TxtPerimetreReponse.Text = Convert.ToString(leRectangle.Perimetre());
            TxtSurfaceReponse.Text = Convert.ToString(leRectangle.Surface());

            LblDispValeur2.Visibility = Visibility.Visible;
            LblValeur2.Visibility = Visibility.Visible;

            LblValeur1.Content = leRectangle.UneValeur;
            LblDispValeur1.Content = "Longeur : ";
            LblValeur2.Content = leRectangle.Largeur;
            LblDispValeur2.Content = "Largeur : ";

            Globals.forme = 2;
            Globals.alea = 0;
        }

        private void BtnTriangle_Click(object sender, RoutedEventArgs e)
        {

            ImgStart.Visibility = Visibility.Hidden;
            carre.Visibility = Visibility.Hidden;
            rectangle.Visibility = Visibility.Hidden;
            ellipse.Visibility = Visibility.Hidden;
            polygon.Visibility = Visibility.Visible;
            LblDispValeur3.Visibility = Visibility.Visible;
            LblDispValeur4.Visibility = Visibility.Visible;
            LblValeur3.Visibility = Visibility.Visible;
            LblValeur4.Visibility = Visibility.Visible;




            BtnCarre.IsEnabled = true;
            BtnRectangle.IsEnabled = true;
            BtnRond.IsEnabled = true;
            BtnTriangle.IsEnabled = false;
            BtnAleatoire.IsEnabled = true;

            TxtPerimetreReponse.Focus();

            Globals.forme = 3;
            Globals.alea = 0;
            
            LblDispValeur2.Visibility = Visibility.Visible;
            LblValeur2.Visibility = Visibility.Visible;
            
            
            ClasseTriangle leTriangle = new ClasseTriangle();       
            
            LblDispValeur1.Content = "Côté 3 : ";
            LblValeur1.Content = leTriangle.UneValeur; 
            LblDispValeur2.Content = "Côté 2 : ";
            LblValeur2.Content = leTriangle._C2;
            LblDispValeur3.Content = "Côté 1 : ";
            LblValeur3.Content = leTriangle._C1;
            LblDispValeur4.Content = "Hauteur : ";
            LblValeur4.Content = leTriangle._Haut;

        }

        private void BtnRond_Click(object sender, RoutedEventArgs e)
        {

            ImgStart.Visibility = Visibility.Hidden;
            carre.Visibility = Visibility.Hidden;
            rectangle.Visibility = Visibility.Hidden;
            ellipse.Visibility = Visibility.Visible;
            polygon.Visibility = Visibility.Hidden;
            LblDispValeur3.Visibility = Visibility.Hidden;
            LblDispValeur4.Visibility = Visibility.Hidden;
            LblValeur3.Visibility = Visibility.Hidden;
            LblValeur4.Visibility = Visibility.Hidden;

            BtnCarre.IsEnabled = true;
            BtnRectangle.IsEnabled = true;
            BtnRond.IsEnabled = false;
            BtnTriangle.IsEnabled = true;
            BtnAleatoire.IsEnabled = true;

            TxtPerimetreReponse.Focus();

            Globals.forme = 4;
            Globals.alea = 0;

            ClasseRond leRond = new ClasseRond();            
            LblDispValeur1.Content = "Rayon : ";
            LblValeur1.Content = leRond.UneValeur; 
            LblDispValeur2.Visibility = Visibility.Hidden;
            LblValeur2.Visibility = Visibility.Hidden;
            
        }

        private void BtnAleatoire_Click(object sender, RoutedEventArgs e)
        {
            Globals.alea = 1;
            BtnAleatoire.IsEnabled = false;
            Suivant();
        }

        private void BtnSuivant_Click(object sender, RoutedEventArgs e)
        {
            
            if (TxtPerimetre.Text=="" || TxtSurface.Text == "")
            {
                MessageBox.Show("Veuillez saisir le périmètre et la surface");
            }
            else
            {
                try
                {
                    Globals.oldUneValeur = Convert.ToInt16(LblValeur1.Content);
                    if (TxtPerimetreReponse.Text == TxtPerimetre.Text)
                    {
                        Globals.score++;
                    }
                    else
                    {
                        Globals.score--;
                    }

                    if (TxtSurfaceReponse.Text == TxtSurface.Text)
                    {
                        Globals.score++;
                    }
                    else
                    {
                        Globals.score--;
                    }


                    if (Globals.score > Globals.record)
                    {
                        Globals.record = Globals.score;
                    }


                    lblScore.Content = Globals.score;
                    lblRecord.Content = Globals.record;
                    Suivant();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de saisie, merci de modifiez vos réponses.");
                    throw;
                }
                
            }

        }

        private void Suivant()
        {
            
            if (Globals.alea == 1)
            {
                Random rnd = new Random();
                Globals.forme = rnd.Next(1, 4);
                switch (Globals.forme)
                {
                    case 1:
                        BtnCarre_Click(BtnCarre, null);
                        Globals.alea = 1;
                        BtnAleatoire.IsEnabled = false;
                        break;
                    case 2:
                        BtnRectangle_Click(BtnRectangle, null);
                        Globals.alea = 1;
                        BtnAleatoire.IsEnabled = false;
                        break;
                    case 3:
                        BtnTriangle_Click(BtnTriangle, null);
                        Globals.alea = 1;
                        BtnAleatoire.IsEnabled = false;
                        break;
                    case 4:
                        BtnRond_Click(BtnRond, null);
                        Globals.alea = 1;
                        BtnAleatoire.IsEnabled = false;
                        break;
                }
            }
            else 
            { 
                switch (Globals.forme)
                {
                    case 1:
                        BtnCarre_Click(BtnCarre, null);
                        break;
                    case 2:
                        BtnRectangle_Click(BtnRectangle, null);
                        break;
                    case 3:
                        BtnTriangle_Click(BtnTriangle, null);
                        break;
                    case 4:
                        BtnRond_Click(BtnRond, null);
                        break;
                }
            }
        }

    }
    }

