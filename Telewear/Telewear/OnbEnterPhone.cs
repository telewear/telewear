using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class OnbEnterPhone : ContentPage {
        public OnbEnterPhone(bool newUser) {
            var action = newUser ? "sign you up" : "log you in";
            Content = new StackLayout {
                Children = {
                    new Entry {
                        Margin = new Thickness (20, 70, 20, 10),
                        Placeholder = "Phone Number"
                    },
                    new Label {
                        Text = "Please enter your phone number so we can " + action + ".",
                        HorizontalTextAlignment = TextAlignment.Center,
                    },
                    new Button {
                        Text = "Next"
                    }
                }
            };
        }
    }
}