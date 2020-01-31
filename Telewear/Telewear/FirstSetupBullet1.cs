using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class FirstSetupBullet1 : ContentPage {
        public FirstSetupBullet1() {
            Content = new StackLayout {
                Children = {
                    new Label { Text = "Telegram", FontSize=30},
                    new Label { Text = "it's a messaging app" }
                }
            };
        }
    }
}