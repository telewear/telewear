using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class Messages : ContentPage {
        public Messages() {
            // The root page of your application
            Content = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot("Telewear Community") {
                    new TableSection ("Telewear Community") {
                        // buf
                        new TextCell {
                            Text = " ",
                            Detail = " "
                        },
                        new TextCell {
                            Text = "Successfully set up notifications from telewear/telewear in this group chat!",
                            Detail = "GitHub"
                        },
                        new TextCell {
                            Text = "/start@GitHubBot",
                            Detail = "Narek Torosyan"
                        },
                        new TextCell {
                            Text = "Hey there GitHub, and welcome to Telewear Community! How are you?",
                            Detail = "Rose, replying to Narek Torosyan"
                        },
                        new TextCell {
                            Text = "Narek Torosyan added GitHub",
                            Detail = " "
                        },
                        new TextCell {
                            Text = "UI only. TDlib docs are confusing.",
                            Detail = "Narek, replying to Filippo Fedelli"
                        },
                        new TextCell {
                            Text = "Have you tried to implement TDLib or is it ui only atm?",
                            Detail = "Filippo Fedelli"
                        }
                    }
                }
            };
        }
        protected override bool OnBackButtonPressed() {
            App.Current.MainPage = Comms.root;
            return true;
        }
    }
}