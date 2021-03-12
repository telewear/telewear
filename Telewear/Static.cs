using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TgSharp.Core;

namespace Telewear {

    enum LoginPhase {
        Phone,
        Pin,
        Password,
        Complete
    }

    class Static {
        public static TelegramClient tgClient;
        public static LoginPhase phase;
    }
}
