using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen.Wearable.CircularUI.Forms;
using Telewear.Pages;
using TgSharp.Core;

namespace Telewear {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CirclePage {
        public MainPage() {
            InitializeComponent();
            ConnectToTelegram();
        }

        private async void ConnectToTelegram() {
            var client = new TelegramClient(TdConfig.api_id, TdConfig.api_hash);
            Static.tgClient = client;
            await client.ConnectAsync();
            if (!client.IsUserAuthorized()) await Navigation.PushModalAsync(new LoginPhoneNumPage());
        }

        // test code
        void MessageDemo() {
            Config.scheme = Colors.Dark;
            stack.Children.Add(new Message
            {
                Sender = "John Smith",
                MessageText = "Incoming",
                HorizontalOptions = LayoutOptions.Start
            });
            Config.scheme = Colors.Light;
            stack.Children.Add(new Message
            {
                Sender = "Jane Smith",
                MessageText = "Are you a robot?",
                HorizontalOptions = LayoutOptions.End
            });
            Config.scheme = Colors.SMS;
            stack.Children.Add(new Message
            {
                Sender = "Tizen Hater",
                MessageText = "Samsung should die",
                HorizontalOptions = LayoutOptions.Start
            });
            Config.scheme = Colors.Dark;
            stack.Children.Add(new Message
            {
                Sender = "Jane Smith",
                MessageText = "Calm down Tizen Hater.",
                HorizontalOptions = LayoutOptions.End
            });
            stack.Children.Add(new Message
            {
                Sender = "John Smith",
                MessageText = "The Tizen dev tools need to die, not Samsung",
                HorizontalOptions = LayoutOptions.Start
            });
        }
    }
}