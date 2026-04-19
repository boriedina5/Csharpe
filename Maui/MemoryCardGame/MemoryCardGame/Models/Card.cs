using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryCardGame.Models
{
    public partial class Card : ObservableObject
    {
        [ObservableProperty]
        private string imageSource;

        //public string ImageSource {get; set} ->a háttérben létrehozza ezt és automatikusan ráteszi
        //az event figyelőt, hogy változik e majd az értéke a futás során

        [ObservableProperty]
        private bool isFlipped;

        [ObservableProperty]
        private bool isMatched;
    }
}
