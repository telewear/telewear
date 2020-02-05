using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class OnbWriteBio : ContentPage {
        public OnbWriteBio() {
            var chatlist = new Command(() => App.Current.MainPage = Comms.root);
            Content = new StackLayout {
                Children = {
                    new Editor {
                        Margin = new Thickness (20, 70, 20, 10),
                        Placeholder = "Bio"
                    },
                    new Label {
                        Text = "Add a short bio to help others identify you.",
                        HorizontalTextAlignment = TextAlignment.Center,
                    },
                    new Button {
                        Text = "Finish ",
                        Command = chatlist,
                        Margin = new Thickness (20, 20, 20, 10)
                    }
                }
            };
        }
    }
}