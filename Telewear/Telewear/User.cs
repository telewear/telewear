using System;
using System.Collections.Generic;
using System.Text;

namespace Telewear {
    public class User {
        public string phone;
        public string name;
        public string surname;
        public string bio;
        public string pic;
        public string fullName {
            get { return name + " " + surname; }
        }
        public override string ToString() {
            return fullName + " (" + phone + ")";
        }
    }
}
