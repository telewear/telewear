using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class TestPage : ContentPage {
        public TestPage() {
            var messages = new Command(() => App.Current.MainPage = new Messages("Telewear Community"));
            var chatlist = new Command(() => App.Current.MainPage = Comms.root);
            var onboarding1 = new Command(() => App.Current.MainPage = new FirstSetupBullet1());
            Content = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot("Test Page") {
                    new TableSection ("Test Page") {
                        // buffer
                        new TextCell {
                            Text = "Test Page",
                            Detail = "The scroll of truth!"
                        },
                        new TextCell {
                            Text = "Version",
                            Detail = "0.0.1"
                        },
                        new TextCell {
                            Text = "TDlib version",
                            Detail = "none"
                        },
                        new TextCell {
                            Text = "LibTGVoip version",
                            Detail = "none"
                        },
                        new TextCell {
                            Text = "Launch Messages Page",
                            Detail = "Tap here to launch messages page",
                            Command = messages
                        },
                        new TextCell {
                            Text = "Launch Chat List Page",
                            Detail = "Tap here to launch chat list page",
                            Command = chatlist
                        },
                        new TextCell {
                            Text = "Launch Onboarding 1",
                            Detail = "Tap here to launch first launch page 1",
                            Command = onboarding1
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
    }
}