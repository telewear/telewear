using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelewearNew {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAccount : ContentPage {
        public AddAccount() {
            InitializeComponent();
            App.AccountManager.Register(new SharedAccount {
                name = "Sheev Palpatine",
                displayName = "Palps",
                email = "thesenate@thesenate.io",
            });
            foreach (string s in App.AccountManager.features) {
                label.Text += s + "\n";
            }
        }
    }
}