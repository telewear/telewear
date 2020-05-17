using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Telewear {
    public class Colors {
        public Color messageBackground;
        public Color messageForeground;

        public static Colors Dark => new Colors {
            messageBackground = Color.DimGray,
            messageForeground = Color.White
        };

        public static Colors Light => new Colors {
            messageBackground = Color.White,
            messageForeground = Color.Black
        };

        public static Colors SMS => new Colors {
            messageBackground = Color.LightYellow,
            messageForeground = Color.Black
        };
    }
}
