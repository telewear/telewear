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
            var testpage = new Command(() => App.Current.MainPage = new TestPage());
            var messages = new Command(() => App.Current.MainPage = new Messages("Telewear Community"));
            // The root page of your application
            MainPage = new ContentPage {
                Content = new TableView {
                    Intent = TableIntent.Form,
                    Root = new TableRoot("Telewear") {
                        new TableSection ("Telewear") {
                            // buffer
                            new TextCell {
                                Text = "Telewear",
                                Detail = "The scroll of truth!"
                            },
                            new TextCell {
                                Text = "Saved Messages",
                                Detail = "No messages here...",
                                Command = messages
                            },
                            new TextCell {
                                Text = "Archived Chats",
                                Detail = "Spider Fans, Tizenreport",
                                Command = messages
                            },
                            new TextCell {
                                Text = "John Smith",
                                Detail = "Did you bring the apples?",
                                Command = messages
                            },
                            new TextCell {
                                Text = "Jane Smith",
                                Detail = "Happy birthday!",
                                Command = messages
                            },
                            new TextCell {
                                Text = "Dead Memes",
                                Detail = "Senator: What's 9+10?",
                                Command = messages
                            },
                            new TextCell {
                                Text = "Minecrafters",
                                Detail = "Kyle: aw man",
                                Command = messages
                            },
                            new TextCell {
                                Text = "Telewear",
                                Detail = "No messages here...",
                                Command = messages
                            },
                            new TextCell {
                                Text = "",
                                Detail = "Tap to open test page",
                                Command = testpage
                            },
                            // another buffer
                            new TextCell {
                                Text = "",
                                Detail = "NYEHHH"
                            }
                        },
                    }
                }
            };
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
