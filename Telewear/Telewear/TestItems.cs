using System;
using System.Collections.Generic;
using System.Text;

namespace Telewear {
    public static class TestItems {
        public static string[] overNames = { "Saved Messages", "Archived Chats", "John Smith", "Jane Smith", "Dead Memes", "Minecrafters", "Telewear Announcements", "501st Legion" };
        public static string[] overMessages = { "No messages here...", "Spider Fans, Tizenreport", "Did you bring the apples?", "Happy birthday!", "Senator: What's 9+10?", "Kyle: aw man", "No messages here...", "Kenobi: hello there" };
        public static User ObiWan {
            get {
                User u = new User();
                u.phone = "+1 800 555-1234";
                u.name = "Ben";
                u.surname = "Kenobi";
                u.bio = "The Force is what gives a Jedi his power. It's an energy field" +
                        " created by all living things. It surrounds us and penetrates us. It binds the galaxy together.";
                u.pic = "https://cdn.vox-cdn.com/uploads/chorus_image/image/66160392/Obi_Wan.0.jpg";
                return u;
            }
        }
    }
}
