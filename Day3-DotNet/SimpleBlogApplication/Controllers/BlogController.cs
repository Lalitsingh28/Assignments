using Microsoft.AspNetCore.Mvc;
using SimpleBlog.Models;
using System.Collections.Generic;

public class BlogController : Controller
{
    private List<BlogPost> _blogPosts;

    public BlogController()
    {
        _blogPosts = new List<BlogPost>
        {
            new BlogPost { Id = 1, Title = "Sample Blog Post 1", Content = "Content of Blog Post 1", Author = "Author 1" },
            new BlogPost { Id = 2, Title = "Sample Blog Post 2", Content = "Content of Blog Post 2", Author = "Author 2" },
            new BlogPost { Id = 3, Title = "Sample Blog Post 3", Content = "Content of Blog Post 3", Author = "Author 3" },
            new BlogPost { Id = 4, Title = "Sample Blog Post 4", Content = "Content of Blog Post 4", Author = "Author 4" },

        };
    }

    public IActionResult BlogPosts()
    {
        return View(_blogPosts);
    }

    public IActionResult Post(int id, string slug)
    {
        foreach(var blogPost in _blogPosts)
        {
            if(blogPost.Id == id)
            {
                return blogPost;
            }
        }

        return View("Post Not Found");

    }
}
