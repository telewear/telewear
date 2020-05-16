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

        public static readonly BindableProperty ColorProperty =
            BindableProperty.Create(nameof(Color), typeof(string), typeof(Message), default(string), BindingMode.OneWay);
        public Color Color {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public Message() {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(string propertyName = null) {
            base.OnPropertyChanged(propertyName);

            if (propertyName == SenderProperty.PropertyName) {
                sender.Text = Sender;
            }
            else if (propertyName == MessageTextProperty.PropertyName) {
                message.Text = MessageText;
            }
            else if (propertyName == ColorProperty.PropertyName) {
                this.BackgroundColor = Color;
            }
        }
    }
}