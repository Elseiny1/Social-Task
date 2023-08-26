using SocialMediaConsoleMVC_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConsoleMVC.BL.IReposatory
{
    public interface IUserRepo
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        User GetUser(int id);
    }
}
