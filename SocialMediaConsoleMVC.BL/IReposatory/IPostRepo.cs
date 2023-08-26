using SocialMediaConsoleMVC_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConsoleMVC.BL.IReposatory
{
    public interface IPostRepo
    {
        void AddPost(Post user,int userid);
        void UpdatePost(Post user);
        void DeletePost(int id);
        Post GetPost(int id);
    }
}
