namespace SnakeProject.User_Services
{
    public static class UserInitializer
    {

        public static List<User> GetSampleUserData()
        {
            List<User> users = new List<User>();

            users.Add(new User { Name = "Vladis", Score = 888 });
            users.Add(new User { Name = "Vano", Score = 456 });
            users.Add(new User { Name = "Profi777", Score = 1000 });
            users.Add(new User { Name = "Simple player", Score = 0 });

            return users;
        }

    }
}
