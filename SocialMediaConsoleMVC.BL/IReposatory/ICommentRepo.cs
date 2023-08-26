using SocialMediaConsoleMVC_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConsoleMVC.BL.IReposatory
{
    public interface ICommentRepo
    {
        void AddComment(Comment comment, int userid);
        void UpdateComment(Comment comment);
        void DeleteComment(int id);
        Comment GetComment(int id);
    }
}
