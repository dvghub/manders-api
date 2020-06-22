using manders_api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace manders_api.Services {
    public class AuthService {
        private DbService db = new DbService();
        private string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

        public User ValidateLogin(Login login) {
            if (!ValidateEmail(login.Email)) return null;

            User user = db.Users.Where(u => u.Email == login.Email).FirstOrDefault();
            if (user == null) return null;

            if (BCrypt.Net.BCrypt.Verify(login.Password, user.Password)) return user;

            return null;
        }

        public User ValidateRegister(User user) {
            if (!ValidateEmail(user.Email)) return null;

            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            db.Add(user);

            if (db.SaveChanges() > 0) return user;
            return null;
        }

        private bool ValidateEmail(string email) {
            return Regex.IsMatch(email, pattern);
        }
    }
}
