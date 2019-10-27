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
            
            if (score <= 4)
            {
                score++;
                if (score <= 3)
                {
                    DisplayAlert("Assassin Action", mi.CommandParameter + "your score increased to " + score + " you are Leonardo Da Vinci", "OK");
                }
                else if (score == 4)
                {
                    DisplayAlert("Assassin Action", mi.CommandParameter + "your assassin score increased to " + score + " you are Desmond", "OK");
                }
                else
                {
                    DisplayAlert("Assassin Action", mi.CommandParameter + "your assassin score is max you are Ezio", "OK");
                }
            }
            else
            {
                DisplayAlert("Assassin Action", mi.CommandParameter + "your assassin score is max you are Ezio", "OK");
            }
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            if (score >= 1)
            {
                score--;
                if (score <= 3)
                {
                    DisplayAlert("Templar Action", mi.CommandParameter + "your score decreased to " + score + " you are Leonardo Da Vinci", "OK");
                }
                else if (score == 4)
                {
                    score--;
                    DisplayAlert("Templar Action", mi.CommandParameter + "your templar score increased to " + score + " you are a Templar Knight", "OK");
                }
                else
                {
                    DisplayAlert("Templar Action", mi.CommandParameter + "your templar score is max you are Vivere", "OK");
                }
            }
            else
            {
                DisplayAlert("Templar Action", mi.CommandParameter + "your templar score is max you are Vivere", "OK");
            }
        }
    }
}
