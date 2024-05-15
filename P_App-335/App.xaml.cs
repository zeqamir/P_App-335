using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace App
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Description { get; set; }
        public int NombrePages { get; set; }
        public int NombrePagesLues { get; set; }
        public string Texte { get; set; }
    }

    public class MainPage : Page
    {
        public ObservableCollection<Livre> Livres { get; set; } = new ObservableCollection<Livre>();

        public MainPage()
        {
            Livres.Add(new Livre
            {
                Titre = "Hamlet",
                Auteur = "Jean Yves",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et
