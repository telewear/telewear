using System;
using System.Diagnostics;
using TelewearNew.Tizen.Wearable;
using Tizen.Account.AccountManager;

namespace TelewearNew {
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication {
        protected override void OnCreate() {
            base.OnCreate();
            LoadApplication(new App());
            App.Init(new TizenAccountManager());
            
        }

        static void Main(string[] args) {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            app.Run(args);
            //AccountProvider provider = new AccountProvider;
        }
    }
}
