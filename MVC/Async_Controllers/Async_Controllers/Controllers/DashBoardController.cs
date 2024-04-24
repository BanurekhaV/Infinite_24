using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Async_Controllers.Models;

namespace Async_Controllers.Controllers
{
    public class DashBoardController : AsyncController
    {
        public async Task<ActionResult> DashBoard()
        {
            Task<List<Friend>> tsk1 = Task.Factory.StartNew(() => GetFriends());
            Task<List<Post>> tsk2 = Task.Factory.StartNew(() => GetPosts());
            Task<List<Questions>> tsk3 = Task.Factory.StartNew(() => GetQuestions());
            await Task.WhenAll(tsk1, tsk2, tsk3);
            DashBoardViewModel dvm = new DashBoardViewModel();
            dvm.Friends = tsk1.Result;
            return View();
        }

        //methods to call upon the different objects
        public List<Friend> GetFriends()
        {
            List<Friend> frlist = new List<Friend>();
            Thread.Sleep(5000);
            return frlist;
        }

        public List<Post>GetPosts()
        {
            List<Post> pstlist = new List<Post>();
            Thread.Sleep(5000);
            return pstlist;
        }

        public List<Questions>GetQuestions()
        {
            List<Questions> qlist = new List<Questions>();
            Thread.Sleep(5000);
            return qlist;
        }
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}