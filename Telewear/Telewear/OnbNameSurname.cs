using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Tizen.Account.AccountManager;

namespace Telewear {
    public class OnbNameSurname : ContentPage {
        // No newUser bool since this isn't whatspoop
        public OnbNameSurname() {
            var name = new Entry {
                Margin = new Thickness(20, 70, 20, 10),
                Placeholder = "Name"
            };
            var surname = new Entry {
                Placeholder = "Surname"
            };
            var chatlist = new Command(() => Next(name, surname));
            Content = new StackLayout {
                Children = {
                    name,
                    surname,
                    new Label {
                        Text = "Please enter your name and surname.",
                        HorizontalTextAlignment = TextAlignment.Center,
                    },
                    new Button {
                        Text = "Next",
                        Command = chatlist,
                        Margin = new Thickness (20, 20, 20, 10)
                    }
                }
            };
        }
        void Next(Entry n, Entry s) {
            Comms.user.name = n.Text;
            Comms.user.surname = s.Text;
            Account account = Account.CreateAccount();
            string userName = "Marcus";
            string displayName = "Marcus_display";
            string domainName = "Marcus_domain";
            string emailId = "marcus@example.com";
            string iconPath = "image_path";

            account.UserName = userName;
            account.DisplayName = displayName;
            account.DomainName = domainName;
            account.EmailId = emailId;
            account.IconPath = iconPath;
            AccountService.AddAccount(account);
            App.Current.MainPage = Comms.root;
        }
    }
}