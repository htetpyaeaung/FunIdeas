using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment1.Net.Models;

namespace Assignment1.Net.Controllers
{
    public class IdeasController : Controller
    {
        private FunIdeasEntities db = new FunIdeasEntities();

       
        // GET: Ideas
        public ActionResult Index(int? cateID)
        {

            var ideas = db.Ideas.Include(i => i.Category).Include(i => i.Image);
            if(cateID.HasValue)
            {
                ideas = ideas.Where(c => c.categoryID == cateID);
            }
            return View(ideas.ToList());
        }

       public ActionResult NavigateDetail(int? id)
        {
            Response.Redirect(@"~/FunDetails.aspx?ideaID="+ id);
            return new EmptyResult();
        }

        public ActionResult NavigateModel()
        {
            Response.Redirect(@"~/IsolationW1.aspx");
            return new EmptyResult();
        }

        public ActionResult NavigateTraditional()
        {
            Response.Redirect(@"~/IsolationW2.aspx");
            return new EmptyResult();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
