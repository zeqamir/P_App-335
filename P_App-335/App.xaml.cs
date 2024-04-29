using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace P_App_335
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Description { get; set; }
        public int NombrePages { get; set; }
        public int NombrePagesLues { get; set; }
        public string Texte { get; set; }
        public int ProgressionLecture { get; set; } // Ajout de la propriété ProgressionLecture
    }

    public class App : Page
    {
        public ObservableCollection<Livre> Livres { get; set; } = new ObservableCollection<Livre>();

        public App()
        {
            Livres.Add(new Livre
            {
                Titre = "Hamlet",
                Auteur = "Jean Yves",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim ven",
                NombrePages = 300,
                NombrePagesLues = 150,
                ProgressionLecture = 50
            });

        }
    }
}
