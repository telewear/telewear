using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear {
    public class Chats : Tizen.Wearable.CircularUI.Forms.CirclePage {
        public Chats() {
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
            // Set our TableView as content
            Content = tv;
        }
    }
}