using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;
using Telegram.Td;

namespace Telewear {

    public class OnbEnterPhone : CirclePage {
        public OnbEnterPhone(bool newUser) {
            Entry phone = new Entry {
                Margin = new Thickness(20, 70, 20, 10),
                Placeholder = "Phone Number",
                Keyboard = Keyboard.Numeric
            };
            var onbAuth = new Command(() => Next(phone.Text, newUser)) ;
            var action = newUser ? "sign you up" : "log you in";
            Content = new CircleStackLayout {
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
        void Next(string phone, bool newUser) {
            Comms.user.phone = phone;
            App.Current.MainPage = new OnbTypeAuthCode(phone, newUser);
        }
    }
}