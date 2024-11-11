namespace TalkNet
{
    public static class UserSession
    {
        // This property will hold the username of the currently logged-in user
        public static string CurrentUsername { get; set; }
        // This property will hold the user ID of the currently logged-in user
        public static int CurrentUserId { get; set; }
    }
}
