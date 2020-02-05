using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Telewear {
    public class App : Application {
        public Page root;
        public App() {
            // These are for something to fill the app with without a TDLib
            
            // Create a TableView
            var tv = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot("Telewear") {
                    new TableSection("Telewear") {}
                }
            };
            // Add buffer
            tv.Root.Add(new TableSection() {
                new TextCell {
                    Text = "Telewear",
                    Detail = "The scroll of truth!"
                }
            });
            // Iterate through the sample data and add every item as a TableSection
            for (int i = 0; i < TestItems.overMessages.Length; i++) {
                var name = TestItems.overNames[i];
                tv.Root.Add(new TableSection() {
                    new TextCell {
                        Text = TestItems.overNames[i],
                        Detail = TestItems.overMessages[i],
                        Command = new Command(() => App.Current.MainPage = new Messages(name))
                    }
                });
            }
            // Add test page
            tv.Root.Add(new TableSection() {
                new TextCell {
                    Text = "",
                    Detail = "Tap to open test page",
                    Command = new Command(() => App.Current.MainPage = new TestPage())
                }
            });
            // Add 2nd buffer
            tv.Root.Add(new TableSection() {
                new TextCell {
                    Text = "",
                    Detail = "NYEHHHH"
                }
            });
            // Create root page with our modified TableRoot
            MainPage = new Tizen.Wearable.CircularUI.Forms.CirclePage {
                Content = tv
            };
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
