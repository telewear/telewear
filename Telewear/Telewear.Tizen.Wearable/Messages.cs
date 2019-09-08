using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telewear.Tizen.Wearable {
    public class Messages : ContentPage {
        public Messages(string grpName) {
            Content = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot("Telewear") {
                    new TableSection (grpName) {
                        new TextCell {
                            Text = "Message",
                            Detail = "John Smith"
                        },
                        new TextCell {
                            Text = "Another message!",
                            Detail = "Jane Smith"
                        },
                        new TextCell {
                            Text = "creeper",
                            Detail = "John Smith"
                        },
                        new TextCell {
                            Text = "AWWW MANNN",
                            Detail = "Jane Smith"
                        },
                        new TextCell {
                            Text = "So we back",
                            Detail = "Kyle Smith"
                        },
                        new TextCell {
                            Text = "in the mine",
                            Detail = "John Smith"
                        },
                        new TextCell {
                            Text = "aww man",
                            Detail = "Ben Smith"
                        }
                    },
                }
            };
        }
    }
}