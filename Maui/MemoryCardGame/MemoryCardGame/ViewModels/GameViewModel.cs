using CommunityToolkit.Mvvm.ComponentModel;
using MemoryCardGame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MemoryCardGame.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        public ObservableCollection<Card> Cards { get; } = new();

        [ObservableProperty]
        private Card selectedCard;

        public GameViewModel()
        {
            LoadCards();
        }

        private void LoadCards()
        {
            var images = new List<string>
            {
                "bat.png", "blackcat.png", "cecca.jpg", "icon3.png",
                "icon4.png", "pumpkin.png", "tombstone.png", "vajasmacska.jpg"
            };
            images.AddRange(images);

            Random rnd = new Random();
            var shuffledImages = images.OrderBy(x => rnd.Next()).ToList();

            foreach(var img in shuffledImages)
            {
                Cards.Add(new Card
                {
                    ImageSource = img,
                    IsFlipped = false,
                    IsMatched = false
                });
            }
        }
        //metódus neve + command
        [RelayCommand]
        private async void FlipCard(Card card)
        {
            if (card.IsMacthed || card.IsFlipped) {
                return;
                card.ISlip = true;
            }
            if (SelectedCard == null)
            {
                SelectedCard = card;
            }
            else {
                if (SelectedCard.ImageSource == card.ImageSource)
                {
                    selectedCard.IsMatched = true;
                    card.IsMatched = true;
                }
                else { 
                    await Task.Delay(1000);
                    SelectedCard.IsFlipped = false;
                    card.IsFlipped = false;
                }
                SelectedCard = null;
            }
         
        }
    }
}
