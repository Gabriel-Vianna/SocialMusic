using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMusicApp.Models.Posts
{
    public class PostsViewModel
    {
        public PostsModel Formulario { get; set }
        public List<PostsModel> Posts { get; set; }
    }
}
