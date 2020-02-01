using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class OnbEnterPhone : ContentPage {
        public OnbEnterPhone(bool newUser) {
            Entry phone = new Entry {
                Margin = new Thickness(20, 70, 20, 10),
                Placeholder = "Phone Number",
                Keyboard = Keyboard.Numeric
            };
            var onbAuth = new Command(() => App.Current.MainPage = new OnbTypeAuthCode(phone.Text, newUser));
            var action = newUser ? "sign you up" : "log you in";
            Content = new StackLayout {
                Children = {
                    phone,
                    new Label {
                        Text = "Please enter your phone number so we can " + action + ".",
                        HorizontalTextAlignment = TextAlignment.Center,
                    },
                    new Button {
                        Text = "Next",
                        Command = onbAuth,
                        Margin = new Thickness (20, 20, 20, 10)
                    }
                }
            };
        }
    }
}