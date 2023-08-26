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
    public class PostRepo : IPostRepo
    {
        ApplicationDbContext _Context = new ApplicationDbContext();
        public void AddPost(Post post,int id)
        {
            var user = _Context.Users.Find(id);

            if(post != null&&user!=null)
            {
                post.UserId = user.Id;
                var addpost = new Post
                {
                    body = post.body,
                    PublishDate = post.PublishDate,
                    UserId = post.UserId
                };
                _Context.Add(addpost);
                _Context.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is no post or user were added :(");
            }
        }

        public void DeletePost(int id)
        {
            if(id!=null)
            {
               var post= _Context.Posts.Find(id);
                if(post.IsDleted==false)
                {
                    if (post != null)
                    { post.IsDleted = true; }
                    else { Console.WriteLine("there id no posts were found"); }
                }
                else { Console.WriteLine("This post were deleted before"); }
            }
            else { Console.WriteLine("there is no id werer found"); }
        }

        public Post GetPost(int id)
        {
            if (id!=null)
            {
                var post=_Context.Posts.Find(id);
                if( post != null)
                {
                    return post;
                }
                else { return null; }
            }else { return null; }
        }

        public void UpdatePost(Post uppost)//updated post=uppost
        {
            if(uppost != null)
            {
                var post = _Context.Posts.Find(uppost.Id);
                if(post != null)
                {
                    if(post.IsDleted==false)
                    {
                        post.body = uppost.body;
                        post.PublishDate = uppost.PublishDate;
                        _Context.Posts.Update(post);
                        _Context.SaveChanges();
                    }
                    else { Console.WriteLine("This post were deleted"); }
                }
                else { Console.WriteLine("This post were not found"); }
            }
            else { Console.WriteLine("There no posts in this id"); }
        }
    }
}
