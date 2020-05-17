using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Telewear {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Message : StackLayout {

        public static readonly BindableProperty SenderProperty =
            BindableProperty.Create(nameof(Sender), typeof(string), typeof(Message),  default(string), BindingMode.OneWay);
        public string Sender {
            get { return (string)GetValue(SenderProperty); }
            set { SetValue(SenderProperty, value); }
        }

        public static readonly BindableProperty MessageTextProperty =
            BindableProperty.Create(nameof(MessageText), typeof(string), typeof(Message), default(string), BindingMode.OneWay);
        public string MessageText {
            get { return (string)GetValue(MessageTextProperty); }
            set { SetValue(MessageTextProperty, value); }
        }

        public Message() {
            InitializeComponent();
            BackgroundColor = Config.scheme.messageBackground;
            sender.TextColor = Config.scheme.messageForeground;
            message.TextColor = Config.scheme.messageForeground;
        }

        protected override void OnPropertyChanged(string propertyName = null) {
            base.OnPropertyChanged(propertyName);

            if (propertyName == SenderProperty.PropertyName) {
                sender.Text = Sender;
            }
            else if (propertyName == MessageTextProperty.PropertyName) {
                message.Text = MessageText;
            }
        }
    }
}