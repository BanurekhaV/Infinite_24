using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Async_Controllers.Models
{
    public class Friend
    {
        public string FriendName { get; set; }
    }

    public class Post
    {
        public string SPosts { get; set; }
    }

    public class Questions 
    {
     public string questions { get; set; }
    }

    public class DashBoardViewModel
    {
        public List<Friend> Friends { get; set; }
        public List<Post> Posts { get; set; }
        public List<Questions> Question { get; set; }
    }
}
