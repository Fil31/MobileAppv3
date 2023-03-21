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
    public partial class EntryPage : ContentPage
    {
        Editor ed;
        Label lbl;
        public EntryPage()
        {
            ed = new Editor
            {
                Placeholder = "Sisesta siia tekst",
                BackgroundColor = Color.MidnightBlue,
                TextColor = Color.White
            };
            ed.TextChanged += Ed_TextChanged;
            lbl = new Label
            {
                Text = "Mingi text",
                TextColor = Color.White
            };
            Button Start_btn = new Button
            {
                Text = "Tagasi",
                TextColor = Color.Turquoise,
                BackgroundColor = Color.DarkRed
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { ed, lbl, Start_btn },
                BackgroundColor = Color.Orange
            };
            Content = st;
            Start_btn.Clicked += Start_btn_Clicked;
        }
        private async void Start_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartPage());
        }
        int i = 0;
        private void Ed_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbl.Text = ed.Text;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';

            if (key == 'A')
            {
                i++;
                lbl.Text = key.ToString() + ": " + i;
            }

        }
    }
}
