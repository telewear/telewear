using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelewearNew {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application {

        public static IAccountManager AccountManager { get; private set; }

        public static void Init(IAccountManager userPreferencesImpl) {
            App.AccountManager = userPreferencesImpl;
        }
        public App() {
            InitializeComponent();

            MainPage = new TelewearNew.MainPage();
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
