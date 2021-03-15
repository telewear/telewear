using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telewear.Lib {
	public static class Base64Url {
		public static string Encode(byte[] arg) {
			if (arg == null) {
				throw new ArgumentNullException("arg");
			}

			var s = Convert.ToBase64String(arg);
			return s
				.Replace("=", "")
				.Replace("/", "_")
				.Replace("+", "-");
		}

		public static string ToBase64(string arg) {
			if (arg == null) {
				throw new ArgumentNullException("arg");
			}

			var s = arg
					.PadRight(arg.Length + (4 - arg.Length % 4) % 4, '=')
					.Replace("_", "/")
					.Replace("-", "+");

			return s;
		}

		public static byte[] Decode(string arg) {
			var decrypted = ToBase64(arg);

			return Convert.FromBase64String(decrypted);
		}
	}
}

