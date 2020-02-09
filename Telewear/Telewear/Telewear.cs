using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Td = Telegram.Td;
using TdApi = Telegram.Td.Api;

namespace Telewear {
    public class App : Application {
        public Page root;
        public App() {
            Comms.client = Comms.GetClient();
            if (true) {
                MainPage = new OnbEnterPhone(false);
            } else {
                MainPage = new Chats();
            }
            // Set it as a root page
            Comms.root = MainPage;
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

        private void UpdateList() {

        }

        
    }

}
