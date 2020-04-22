using System;
using System.Collections.Generic;
using System.Text;

namespace TelewearNew {

    // This is just to call Tizen APIs from shared code.
    // This is fine as Telewear will only run on Tizen watches.

    public interface IAccountManager {
        void Register(SharedAccount account);
        IEnumerable<string> features { get; }
    }

    public class SharedAccount {
        public string name;
        public string displayName;
        public string domainName;
        public string email;
        public string iconPath;
    }
}
