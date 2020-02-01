using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class OnbNameSurname : ContentPage {
        // No newUser bool since this isn't whatspoop
        public OnbNameSurname() {
            var chatlist = new Command(() => App.Current.MainPage = Comms.root);
            Content = new StackLayout {
                Children = {
                    new Entry {
                        Margin = new Thickness (20, 70, 20, 10),
                        Placeholder = "Name"
                    },
                    new Entry {
                        Placeholder = "Surname"
                    },
                    new Label {
                        Text = "Please enter your name and surname.",
                        HorizontalTextAlignment = TextAlignment.Center,
                    },
                    new Button {
                        Text = "Next",
                        Command = chatlist,
                        Margin = new Thickness (20, 20, 20, 10)
                    }
                }
            };
        }
    }
}