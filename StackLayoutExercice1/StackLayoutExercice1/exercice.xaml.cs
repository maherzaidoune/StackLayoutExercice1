using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayoutExercice1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exercice : ContentPage
	{
        public exercice()
        {
            InitializeComponent();
            StackLayout layout = new StackLayout();
            //layout.BackgroundColor = Color.FromHex("#127ac7");
            layout.VerticalOptions = LayoutOptions.Center;
            //layout.VerticalOptions = LayoutOptions.Fill;
            layout.Spacing = 20;

            Label welcom = new Label
            {
                Text = "Welcome to Xamarin",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions= LayoutOptions.Center,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };

            Label desc = new Label
            {
                Text = "Cross Platform app made easy",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,
                FontSize = 18,
                FontAttributes = FontAttributes.None
            };

            Button login = new Button
            {
                TextColor = Color.White,
                Text = "Login",
                // VerticalOptions = LayoutOptions.Center,

                BackgroundColor = Color.FromHex("#1dabf0")

            };
            Button Register = new Button
            {
                TextColor = Color.White,
                // VerticalOptions = LayoutOptions.Center,

                Text = "Register",
                BackgroundColor = Color.FromHex("#1dabf0")

            };
            layout.Children.Add(welcom);
            layout.Children.Add(desc);
            layout.Children.Add(login);
            layout.Children.Add(Register);

            this.Content = layout;

        }
	}
}