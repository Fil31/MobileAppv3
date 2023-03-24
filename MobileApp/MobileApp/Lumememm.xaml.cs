using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lumememm : ContentPage
    {
        private Random _random = new Random();
        public Lumememm()
        {
            InitializeComponent();
        }
        private void HideSnowman_Clicked(object sender, EventArgs e)
        {
            Snowman.IsVisible = false;
        }

        private void ShowSnowman_Clicked(object sender, EventArgs e)
        {
            Snowman.IsVisible = true;
        }

        private void MeltSnowman_Clicked(object sender, EventArgs e)
        {
            Snowman.Opacity = Snowman.Opacity == 1 ? 0.3 : 1;
        }

        private void ColorSnowman_Clicked(object sender, EventArgs e)
        {
            Color randomColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
            BottomCircle.Fill = MiddleCircle.Fill = TopCircle.Fill = new SolidColorBrush(randomColor);
        }

        private async Task ScaleSnowmanAsync(double scaleFactor)
        {
            uint duration = 500;

            await Snowman.ScaleTo(scaleFactor, duration, Easing.CubicInOut);
        }

        private async void CustomAction_Clicked(object sender, EventArgs e)
        {
            double scaleFactor = 1.5; 
            await ScaleSnowmanAsync(scaleFactor);
        }
    }
}