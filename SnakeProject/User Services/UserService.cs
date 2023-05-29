using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.User_Services
{
    public class UserService
    {
        List<User> users;

        public UserService()
        {
            users = UserInitializer.GetSampleUserData();
        }

        public IEnumerable<User> GetUsers()
        { 
            return users.OrderByDescending(x => x.Score);
        }

        public User CreateUser(string username)
        {
            User user = new User();

            var existUser = users.Select(x => x.Name);

            try
            {
                if (username == "")
                    throw new ArgumentException("Empty name`s");

                if (existUser.Contains(username))
                    throw new ArgumentException("The user exists");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            user.Name = username;

            users.Add(user);    

            return user;
        }

        public void SaveScore(User user)
        {
            if (user.Name == null)
                return;
            users.Add(user);
        }
    }
}
