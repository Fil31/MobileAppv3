using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Кнопка ночной режим включает мигание желтого света раз в секунду.
// Чтобы выключить ночной режим, нажмите кнопку ночного режима еще раз.
// При нажатии на красный, желтый или зеленый свет, выводится соответствующее сообщение.
// Чтобы запустить светофор, нажмите кнопку "Запуск".
// Чтобы остановить светофор, нажмите кнопку "Стоп".

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        Label lb1, lb2, lb3;
        Grid gr1, gr2, gr3;
        Frame fr1, fr2, fr3;
        Button btn1, btn2, btn3;
        bool bl = false;
        public Valgusfoor()
        {
            this.BackgroundColor = Color.White;
            lb1 = new Label
            {
                Text = "Красный",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.Center
            };
            lb2 = new Label
            {
                Text = "Желтый",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.Center
            };
            lb3 = new Label
            {
                Text = "Зеленый",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.Center
            };
            fr1 = new Frame
            {
                Content = lb1,
                BackgroundColor = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 175,
                HeightRequest = 175,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };
            fr2 = new Frame
            {
                Content = lb2,

                BackgroundColor = Color.Gray,
                CornerRadius = 150,
                WidthRequest = 175,
                HeightRequest = 175,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };
            fr3 = new Frame
            {
                Content = lb3,
                BackgroundColor = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 175,
                HeightRequest = 175,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };
            btn1 = new Button
            {
                Text = "Запуск",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End

            };
            btn2 = new Button
            {
                Text = "Стоп",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End
            };
            btn3 = new Button
            {
                Text = "Ночной режим",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End
            };
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            StackLayout buttonsStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btn1, btn2, btn3 }
            };

            StackLayout mainStackLayout = new StackLayout
            {
                Children = { fr1, fr2, fr3, buttonsStackLayout },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = mainStackLayout;


            TapGestureRecognizer tap = new TapGestureRecognizer();
            TapGestureRecognizer tap2 = new TapGestureRecognizer();
            TapGestureRecognizer tap3 = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            tap2.Tapped += Tap2_Tapped;
            tap3.Tapped += Tap3_Tapped;
            fr1.GestureRecognizers.Add(tap);
            fr2.GestureRecognizers.Add(tap2);
            fr3.GestureRecognizers.Add(tap3);
        }

        private void Tap3_Tapped(object sender, EventArgs e)
        {
            if (bl)
            {
                if (fr3.BackgroundColor == Color.Green)
                {
                    lb3.Text = "Иди.";
                }
                else if (fr3.BackgroundColor == Color.Gray)
                {
                    lb3.Text = "Зеленый";
                }

            }
            else
            {
                lb3.Text = "Нажми кнопку ЗАПУСК";
            }
        }

        private void Tap2_Tapped(object sender, EventArgs e)
        {
            if (bl)
            {
                if (fr2.BackgroundColor == Color.Yellow)
                {
                    lb2.Text = "Жди!";
                }
                else if (fr2.BackgroundColor == Color.Gray)
                {
                    lb2.Text = "Желтый";
                }

            }
            else
            {
                lb2.Text = "Нажми кнопку ЗАПУСК";
            }
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            if (bl)
            {
                if (fr1.BackgroundColor == Color.Red)
                {
                    lb1.Text = "СТОП";
                }
                else if (fr1.BackgroundColor == Color.Gray)
                {
                    lb1.Text = "КРАСНЫЙ";
                }

            }
            else
            {
                lb1.Text = "Нажми кнопку ЗАПУСК";
            }
        }

        private bool bl2 = false; // флаг для отслеживания состояния цикла

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            bl2 = !bl2; 

            if (bl2) 
            {
                while (bl2) 
                {
                    fr2.BackgroundColor = Color.Yellow;
                    await Task.Delay(1000);
                    fr2.BackgroundColor = Color.Gray;
                    await Task.Delay(1000);
                }
            }

            this.BackgroundColor = bl2 ? Color.Green : Color.White;
        }
        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            bl = false;
            bl2 = !bl2;
            this.BackgroundColor = Color.White;
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            bl = true;
            if (bl)
            {
                lb1.Text = "Красный";
                lb2.Text = "Желтый";
                lb3.Text = "Зеленый";
            }
            if (fr1.BackgroundColor == Color.Gray)
            {
                lb1.Text = "Красный";
            }
            if (fr2.BackgroundColor == Color.Gray)
            {
                lb2.Text = "Желтый";
            }
            if (fr1.BackgroundColor == Color.Gray)
            {
                lb3.Text = "Зеленый";
            }

            while (bl == true)
            {

                this.BackgroundColor = Color.White;
                fr1.BackgroundColor = Color.Red;
                await Task.Delay(3000);
                fr1.BackgroundColor = Color.Gray;
                if (!bl)
                {
                    break;
                }
                fr2.BackgroundColor = Color.Yellow;
                await Task.Delay(2000);
                fr2.BackgroundColor = Color.Gray;
                if (!bl)
                {
                    break;
                }
                fr3.BackgroundColor = Color.Green;
                await Task.Delay(3000);
                fr3.BackgroundColor = Color.Gray;
                await Task.Delay(500);
                if (!bl)
                {
                    break;
                }
                fr3.BackgroundColor = Color.Green;
                await Task.Delay(500);
                fr3.BackgroundColor = Color.Gray;
                await Task.Delay(500);
                if (!bl)
                {
                    break;
                }
                fr3.BackgroundColor = Color.Green;
                await Task.Delay(500);
                fr3.BackgroundColor = Color.Gray;
                if (!bl)
                {
                    break;
                }
                fr2.BackgroundColor = Color.Yellow;
                await Task.Delay(2000);
                fr2.BackgroundColor = Color.Gray;
                if (!bl)
                {
                    break;
                }
            }

        }
    }
}