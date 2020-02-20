using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFigures.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {

        public int NumberOfFigures { get; set; }
        public int ValueOfSlider { get; set; } = 0;
        public StartPage()
        {
            InitializeComponent();
        }

        async void Generate_Clicked(object sender, EventArgs e)
        {
            try
            {
                ShapeGenerator.QuantityOfShapes = int.Parse(NumberOfFiguresEntry.Text);
                
                justLabel.Text = ShapeGenerator.QuantityOfShapes.ToString();
                TablePage page = new TablePage();
                
                await Navigation.PushModalAsync(new NavigationPage(page));
            }
            catch(FormatException)
            {
                await DisplayAlert("Zły format", "Proszę wpisać liczbę", "OK");

            }

            //Navigation.PushModalAsync(new NavigationPage(new Page()));
            
        }

     
    }
}