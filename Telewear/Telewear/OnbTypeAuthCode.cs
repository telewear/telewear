using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class OnbTypeAuthCode : ContentPage {
        public OnbTypeAuthCode(bool newUser) {
            var dojo = newUser ? "newb" : "Telegram guru";
            Content = new StackLayout {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms," + dojo + "!", HorizontalTextAlignment = TextAlignment.Center }
                }
            };
        }
    }
}