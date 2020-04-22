using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Tizen.Account.AccountManager;

namespace TelewearNew.Tizen.Wearable {
    class TizenAccountManager : IAccountManager {
        public void Register(SharedAccount sAccount) {
            Debug.WriteLine(AccountProvider.GetFeaturesByAppId("tlwr"));
            Account account = Account.CreateAccount();

            account.UserName = sAccount.name;
            account.DisplayName = sAccount.displayName;
            account.DomainName = sAccount.domainName;
            account.EmailId = sAccount.email;
            account.IconPath = sAccount.iconPath;
            AccountService.AddAccount(account);
        }
        public IEnumerable<string> features {
            get {
                return AccountProvider.GetFeaturesByAppId("tlwr");
            }
        }
    }
}
