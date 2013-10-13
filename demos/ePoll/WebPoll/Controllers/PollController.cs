using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPoll.Controllers
{
    using WebPoll.Models;
    using WebPoll.Workers;

    public class PollController : Controller
    {
        //
        // GET: /Poll/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            PollWorker worker = new PollWorker();
            PollQuestion question = worker.GetActiveQuestion();
            if (question == null)
            {
                //return HttpNotFound;
            }
            return View(question);
        }

        public ActionResult SaveAnswer(PollUserAnswer answer)
        {
            //PollUserAnswer answer = new PollUserAnswer();
            return View();
        }

    }
}
