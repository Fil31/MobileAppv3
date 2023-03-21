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
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            //initializeComponent();
            Button Entry_btn = new Button
            {
                Text = "Open main page",
                TextColor = Color.FromRgb(188, 32, 39),
                BackgroundColor = Color.FromRgb(204, 204, 204)
            };
            Button Timer_btn = new Button
            {
                Text = "Open timer page",
                TextColor = Color.FromRgb(188, 32, 39),
                BackgroundColor = Color.FromRgb(204, 204, 204)
            };
            Button BoxView_btn = new Button
            {
                Text = "Open boxview page",
                TextColor = Color.FromRgb(188, 32, 39),
                BackgroundColor = Color.FromRgb(204, 204, 204)
            };
            Button DateTime_btn = new Button
            {
                Text = "Open datetime page",
                TextColor = Color.FromRgb(188, 32, 39),
                BackgroundColor = Color.FromRgb(204,204,204)
            };
            Button StepperSlider_btn = new Button
            {
                Text = "Open stepper slider page",
                TextColor = Color.FromRgb(188, 32, 39),
                BackgroundColor = Color.FromRgb(204, 204, 204)
            };


            GradientStop red = new GradientStop { Color = Color.Red, Offset = 0 };
            GradientStop yellow = new GradientStop { Color = Color.Yellow, Offset = 0.5f };
            GradientStop green = new GradientStop { Color = Color.Green, Offset = 1 };
            GradientStopCollection gradientStops = new GradientStopCollection { red, yellow, green };

            Button Valgusfoor_btn = new Button
            {
                Text = "Valgusfoor",
                TextColor = Color.White,
                Background = new LinearGradientBrush
                {
                    GradientStops = gradientStops,
                    StartPoint = new Point(0, 0),
                    EndPoint = new Point(1, 0)
                }
            };

            GradientStop red2 = new GradientStop { Color = Color.LightCyan, Offset = 0 };
            GradientStop yellow2 = new GradientStop { Color = Color.LightBlue, Offset = 0.5f };
            GradientStop green2 = new GradientStop { Color = Color.CornflowerBlue, Offset = 1 };
            GradientStopCollection gradientStops2 = new GradientStopCollection { red2, yellow2, green2 };

            Button Lumememm_btn = new Button
            {
                Text = "Lumememm",
                TextColor = Color.White,
                Background = new LinearGradientBrush
                {
                    GradientStops = gradientStops2,
                    StartPoint = new Point(1, 1),
                    EndPoint = new Point (1, 0)
                }
            };

            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn, Timer_btn, BoxView_btn, DateTime_btn, StepperSlider_btn, Valgusfoor_btn, Lumememm_btn },
                BackgroundColor = Color.FromRgb(77,90,234)
            };
            Content= st;
            Entry_btn.Clicked += Entry_btn_clicked;
            Timer_btn.Clicked += Timer_btn_clicked;
            BoxView_btn.Clicked += BoxView_btn_clicked;
            DateTime_btn.Clicked += DateTime_btn_clicked;
            StepperSlider_btn.Clicked += StepperSlider_btn_clicked;
            Valgusfoor_btn.Clicked += Valgusfoor_btn_clicked;
            Lumememm_btn.Clicked += Lumememm_btn_clicked;
        }
        private async void Entry_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryPage());
        }
        private async void BoxView_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxViewPage());
        }
        private async void Timer_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }
        private async void DateTime_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTime_Page());
        }
        private async void StepperSlider_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_Page());
        }
        private async void Valgusfoor_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor());
        }
        private async void Lumememm_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lumememm());
        }
    }
}