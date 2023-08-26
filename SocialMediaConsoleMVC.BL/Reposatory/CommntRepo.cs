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
    public class CommntRepo : ICommentRepo
    {
        ApplicationDbContext _Context = new ApplicationDbContext();
        public void AddComment(Comment addcomment, int userid)
        {
            if(addcomment!=null&&userid!=null)
            {
                var user = _Context.Users.Find(userid);
                addcomment.UserId = user.Id;
                var commnt = new Comment
                {
                    body =addcomment.body,
                    PublishDate= addcomment.PublishDate,
                    UserId=addcomment.UserId,
                };
                _Context.Add(commnt);
                _Context.SaveChanges();
            }
            else { Console.WriteLine("ther is somthing is missing"); }
        }

        public void DeleteComment(int id)
        {
            if(id!=null)
            {
                var comment = _Context.Comments.Find(id);
                if (comment != null)
                {
                    if(comment.IsDleted==false)
                    {
                        comment.IsDleted = true;
                    }
                    else { Console.WriteLine("This comment alredy deleted"); }
                }
                else { Console.WriteLine("There is no comment to delete"); }
            }
            else { Console.WriteLine("There is no id found"); }
        }

        public Comment GetComment(int id)
        {
            if(id!=null)
            {
                var comment= _Context.Comments.Find(id);
                if(comment!=null)
                {
                    return comment;
                }
                else { return null; }
            }
            else { return null; }
        }

        public void UpdateComment(Comment upcomment)
        {
            if(upcomment!=null)
            {
                var comment = _Context.Comments.Find(upcomment.Id);
                if(comment != null)
                {
                    comment.body = upcomment.body;
                    comment.PublishDate=upcomment.PublishDate;
                    _Context.Update(comment);
                    _Context.SaveChanges();
                }
                else { Console.WriteLine("There is no commnt were found :("); }
            }
            else { Console.WriteLine("There is no comment to update"); }
        }
    }
}
