using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class OnbNameSurname : ContentPage {
        // No newUser bool since this isn't whatspoop
        public OnbNameSurname() {
            Content = new StackLayout {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!", HorizontalTextAlignment = TextAlignment.Center }
                }
            };
        }
    }
}