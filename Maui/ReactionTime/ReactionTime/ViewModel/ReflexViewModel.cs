using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ReactionTime.ViewModel
{
    public partial class ReflexViewModel : ObservableObject
    {
        private Random rnd = new();
        private Stopwatch stopwatch = new Stopwatch();

        [ObservableProperty]
        private string statusText = "Nyomd meg a START gombot!";
        [ObservableProperty]
        private Color backgroundcolor;
        private bool canClick;

        public ReflexViewModel()
        {
            
        }
        [RelayCommand]
        private async Task StartGame() { 
           StatusText = "Várj...";
            Backgroundcolor = Colors.Pink;
            canClick = false;

            int delay = rnd.Next(1500, 4000);
            await Task.Delay(delay);

            Backgroundcolor = Colors.Green;
            StatusText = "MOST!";
            canClick = true;
            stopwatch.Restart();

        }
        [RelayCommand]
        private void GetReactionTime() {
            if (!canClick) { 
                StatusText = "Túl korán kattintottál! Próbáld újra.";
                return; 
            }
            stopwatch.Stop();
            canClick = false;

            StatusText = $"Reakcióidő: {stopwatch.ElapsedMilliseconds} ms. Nyomd meg a START gombot újra!";
            Backgroundcolor = Colors.HotPink;
        }

    }
}
