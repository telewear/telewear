using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen.Wearable.CircularUI.Forms;

namespace Telewear {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CirclePage {
        public MainPage() {
            InitializeComponent();
            StackLayout stack = (StackLayout)Content;
            stack.Children.Add(new Message {
                Sender = "Telewear",
                MessageText = "Hello!",
                ColorScheme = Colors.Dark
            });
            stack.Children.Add(new Message {
                Sender = "Telewear",
                MessageText = "Hello!",
                ColorScheme = Colors.Light
            });
            stack.Children.Add(new Message {
                Sender = "Telewear",
                MessageText = "Hello!",
                ColorScheme = Colors.SMS
            });
        }
    }
}