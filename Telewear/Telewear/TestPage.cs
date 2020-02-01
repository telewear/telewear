using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Telewear {
    public class TestPage : ContentPage {
        public TestPage() {
            bool nu = false;
            var messages = new Command(() => App.Current.MainPage = new Messages("Telewear Community"));
            var chatlist = new Command(() => App.Current.MainPage = Comms.root);
            var nuToggle = new Command(() => nu = !nu);
            var onbPhone = new Command(() => App.Current.MainPage = new OnbEnterPhone(nu));
            var onbAuth = new Command(() => App.Current.MainPage = new OnbTypeAuthCode(nu));
            var onbNs = new Command(() => App.Current.MainPage = new OnbNameSurname());
            //var onboarding1 = new Command(() => App.Current.MainPage = new FirstSetupBullet1());
            /*
                    new Label { Text = DeviceInfo.Model },
                    new Label { Text = DeviceInfo.VersionString},
                    new Label { Text = DeviceInfo.Idiom.ToString() }
            */
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
                            Text = "Device",
                            Detail = DeviceInfo.Model + " " + DeviceInfo.Idiom.ToString().ToLower() + ", " + DeviceInfo.VersionString
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
                            Text = "Toggle New User",
                            Detail = "Toggle new user experience",
                            Command = nuToggle
                        },
                        new TextCell {
                            Text = "Launch Enter Phone Number Page",
                            Detail = "Tap here to launch enter phone page",
                            Command = onbPhone
                        },
                        new TextCell {
                            Text = "Launch Name Surname Page",
                            Detail = "Tap here to launch name/surname page",
                            Command = onbNs
                        },
                        new TextCell {
                            Text = "Launch Type Auth Code Page",
                            Detail = "Tap here to launch auth code page",
                            Command = onbAuth
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
    }
}