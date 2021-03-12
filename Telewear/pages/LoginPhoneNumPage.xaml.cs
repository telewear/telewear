using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen.Wearable.CircularUI.Forms;
using TgSharp.Core;

namespace Telewear.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPhoneNumPage : CirclePage {
        public LoginPhoneNumPage() {
            InitializeComponent();
        }
    }
}