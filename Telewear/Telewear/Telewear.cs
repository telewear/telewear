using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class App : Application {
        public App() {
            // The root page of your application
            MainPage = new ContentPage {
                Content = new TableView {
                    Intent = TableIntent.Form,
                    Root = new TableRoot("Telewear") {
                        new TableSection ("Telewear") {
                            // buf
                            new TextCell {
                                Text = "Telewear",
                                Detail = "The scroll of truth!"
                            },
                            new TextCell {
                                Text = "Saved Messages",
                                Detail = ""
                            },
                            new TextCell {
                                Text = "Archived Chats",
                                Detail = "Spider Fans, Tizenreport"
                            },
                            new TextCell {
                                Text = "John Smith",
                                Detail = "Did you bring the apples?"
                            },
                            new TextCell {
                                Text = "Jane Smith",
                                Detail = "Happy birthday!"
                            },
                            new TextCell {
                                Text = "Dead Memes",
                                Detail = "Senator: What's 9+10?"
                            },
                            new TextCell {
                                Text = "Minecrafters",
                                Detail = "Kyle: aw man"
                            },
                            new TextCell {
                                Text = "Telewear",
                                Detail = "No messages here..."
                            },
                            // another buf
                            new TextCell {
                                Text = "",
                                Detail = "NYEHHH"
                            }
                        },
                    }
                }
            };
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
