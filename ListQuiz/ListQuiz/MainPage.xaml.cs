using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListQuiz
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int score = 0;
        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            if (score < 5)
            {
                score++;
                DisplayAlert("Assassin Action", mi.CommandParameter + "your assassin score increased to " + score, "OK");
            }
            else
            {
                score++;
                DisplayAlert("Assassin Action", mi.CommandParameter + "your assassin score is max", "OK");
            }
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            if (score != 0)
            {
                score--;
                DisplayAlert("Templar Action", mi.CommandParameter + "your templar score decreased to " + score, "OK");
            }
            else
            {
                DisplayAlert("Templar Action", mi.CommandParameter + "your templar score is max", "OK");
            }
        }
    }
}
