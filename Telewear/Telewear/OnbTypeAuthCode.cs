using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class OnbTypeAuthCode : ContentPage {
        public OnbTypeAuthCode(string number, bool newUser) {
            //Comms.client.Send(new TdApi.CheckAuthenticationCode(code), new AuthorizationRequestHandler());
            var onbAuth = new Command(() => App.Current.MainPage = newUser ? Comms.root : new OnbNameSurname());
            Content = new StackLayout {
                Children = {
                    new Entry {
                        Margin = new Thickness (20, 70, 20, 10),
                        Placeholder = "Code",
                        Keyboard = Keyboard.Numeric
                    },
                    new Label {
                        Text = "Please enter the code we sent to " + number + ".",
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