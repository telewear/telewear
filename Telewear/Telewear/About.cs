using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Telewear {
    public class Settings : ContentPage {

        private int easterctr;

        public Settings() {
            var settings = new Command(() => TestPageEasterEgg());
            Content = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot("Settings") {
                    new TableSection ("Settings") {
                        // buffer
                        new TextCell {
                            Text = "About",
                            Detail = "The scroll of truth!"
                        },
                        new TextCell {
                            Text = "Version",
                            Detail = "0.0.1"
                        },
                        new TextCell {
                            Text = "TDLib version",
                            Detail = "none",
                            Command = settings
                        },
                        new TextCell {
                            Text = "LibTGVoip version",
                            Detail = "none"
                        },
                        new TextCell {
                            Text = "Open Source",
                            Detail = "Fork this app: bit.ly/31dKzcQ"
                        },
                        // another buffer
                        new TextCell {
                            Text = "",
                            Detail = "NYEHHH"
                        }
                    }
                }
            };
        }

        protected override bool OnBackButtonPressed() {
            App.Current.MainPage = Comms.root;
            return true;
        }

        private void TestPageEasterEgg() {
            if (easterctr == 5)
                App.Current.MainPage = new TestPage();
            else
                easterctr++;
        }
    }
}