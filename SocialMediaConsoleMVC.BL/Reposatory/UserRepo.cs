using SocialMediaConsoleMVC.BL.IReposatory;
using SocialMediaConsoleMVC_Task.DAL.Database;
using SocialMediaConsoleMVC_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConsoleMVC.BL.Reposatory
{
    public class UserRepo: IUserRepo
    {
        ApplicationDbContext _Context = new ApplicationDbContext();
        public void AddUser(User users)
        {
            var user = new User
            {
                FName= users.FName,
                LName = users.LName,
                Email =users.Email,
                Password = users.Password,
                UserName = users.UserName,
            };
            _Context.Add(user);
            _Context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            if(id==null)
            {
                Console.WriteLine("There is no users with that id :(");
            }
            else 
            { 
                var users = _Context.Users.Find(id);
                if (users != null)
                {
                    users.IsDeleted = true;
                    _Context.Update(users);
                }
                else { Console.WriteLine("There is no users with this id :( "); }
            }
        }

        public void UpdateUser(User userup)
        {
            User user = _Context.Users.Find(userup.Id);
            if(userup != null)
            {
               if(userup.IsDeleted!=true)
                {
                    user.FName = userup.FName;
                    user.LName = userup.LName;
                    user.Email = userup.Email;
                    user.Password = userup.Password;
                    _Context.Update(user);
                    _Context.SaveChanges();
                }
                else { Console.WriteLine("this user has been deleted"); }
            }
            else
            { Console.WriteLine("this user wer not found :("); }
        }

        public User GetUser(int id)
        {
            if(id!=null)
            {
                var user = _Context.Users.Find(id);
                if(user!=null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
