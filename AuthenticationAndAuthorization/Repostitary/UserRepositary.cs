
using AuthenticationAndAuthorization.Models.Domain;
using System.Collections.Generic;

namespace AuthenticationAndAuthorization.Repostitary
{
    public class UserRepositary : IUserReposiatry
    {

        public UserRepositary()
        {

        }

        List<User> _user = new List<User>()
        {
            new User()
            {
             username= "bankai",
            emailaddress="bankai@gmail.com",
            id=Guid.NewGuid(),
            firstname="Ichigo",
            lastname="kurosaki",
            password="soul123@34",
            role=new List<string>{ "arrancars" ,"soul reaper" }
            },

              new User()
            {
             username= "Naruto106",
            emailaddress="Naruto@gmail.com",
            id=Guid.NewGuid(),
            firstname="Naruto",
            lastname="Uzumaki",
            password="leaf123@34",
            role=new List<string>{ "hokage" ,"ninja" }
            },
            new User()
            {
             username= "light",
            emailaddress="light@gmail.com",
            id=Guid.NewGuid(),
            firstname="light",
            lastname="yagami",
            password="light123@34",
            role=new List<string>{ "kill bad people" }
            },



        };


        public async Task<User> Authenticate(string username, string password)
        {
            var user =  _user.Find(x => x.username.Equals(username,StringComparison.InvariantCultureIgnoreCase) && x.password == password);

            return user;
        }
    }
}
