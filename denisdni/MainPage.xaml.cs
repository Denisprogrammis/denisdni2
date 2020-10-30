using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace denisdni
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundImageSource = "bmw.jpg";

            StackLayout st = new StackLayout();
            Button esm_btn = new Button { Text = "Esmaspäev", ImageSource = "atomic.png", BackgroundColor = Color.Transparent, TextColor = Color.White };
            Button vtor_btn = new Button { Text = "Teisipäev", ImageSource = "atomic.png", BackgroundColor = Color.Transparent, TextColor = Color.White };
            Button sred_btn = new Button { Text = "Kolmapäev", ImageSource = "atomic.png", BackgroundColor = Color.Transparent, TextColor = Color.White };
            Button chet_btn = new Button { Text = "Neljapäev", ImageSource = "atomic.png", BackgroundColor = Color.Transparent, TextColor = Color.White };
            Button pyat_btn = new Button { Text = "Reede", ImageSource = "atomic.png", BackgroundColor = Color.Transparent, TextColor = Color.White };
            Button subo_btn = new Button { Text = "Laupäev", ImageSource = "gamepad.png", BackgroundColor = Color.Transparent, TextColor = Color.White };
            Button voskr_btn = new Button { Text = "Puhapäev", ImageSource = "gamepad.png", BackgroundColor = Color.Transparent, TextColor = Color.White };
            st.Children.Add(esm_btn);
            st.Children.Add(vtor_btn);
            st.Children.Add(sred_btn);
            st.Children.Add(chet_btn);
            st.Children.Add(pyat_btn);
            st.Children.Add(subo_btn);
            st.Children.Add(voskr_btn);
            esm_btn.Clicked += new EventHandler(btns_Clicked);
            vtor_btn.Clicked += new EventHandler(btns_Clicked);
            sred_btn.Clicked += new EventHandler(btns_Clicked);
            chet_btn.Clicked += new EventHandler(btns_Clicked);
            pyat_btn.Clicked += new EventHandler(btns_Clicked);
            subo_btn.Clicked += new EventHandler(btns_Clicked);
            voskr_btn.Clicked += new EventHandler(btns_Clicked);
            Content = st;
        }

        private async void btns_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)//проверяем текст на кнопке
            {
                case "Esmaspäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new ppllaan());
                    break;
                case "Teisipäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Teisipäev());
                    break;
                case "Kolmapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Kolmapäev());
                    break;
                case "Neljapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Neljapäev());
                    break;
                case "Reede":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Reede());
                    break;
                case "Laupäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Laupäev());
                    break;
                case "Puhapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Puhapäev());
                    break;
            }
        }
    }
}
