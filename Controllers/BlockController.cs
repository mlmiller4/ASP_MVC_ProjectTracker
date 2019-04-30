using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;
using System.Net;
using System.IO;
using System.Data.Entity.Validation;
using ProjectTracker.Models;
using ProjectTracker.ViewModels;
using PagedList;
using HDR.Helpers;
using HDR.Filters;
using Elmah;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProjectTracker.Controllers
{
    public class BlockController : Controller
    {
        private CDOT_Tracker_DB db = new CDOT_Tracker_DB();

        // GET: Block
        public ActionResult Index(int? page, int? pageSize, string q, string type, string sort, string f)
        {
            // Task: Data (WHERE to be added)
            var blocks = from b in db.BlockLinkedView1.OrderBy(p => (!String.IsNullOrEmpty(p.PageNo))) select b;

            // Task: PageList
            var pageNumber = page ?? 1;
            var _pageSize = pageSize ?? 10;

            // Task: Filter
            if (!String.IsNullOrEmpty(f))
            { }
            else { 
                    blocks = blocks.Where(b => (!String.IsNullOrEmpty(b.PageNo)));
                 }

            var filterTypes = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem {Selected = (type == "f"), Text = "No Filter", Value = "ALL"},                                     
                }, "Value", "Text");

            // Task: SearchBy // Task: Query String
            if (!String.IsNullOrEmpty(q))
            {
                if (type == "PageNo") {

                    //blocks = blocks.Where(b => (!String.IsNullOrEmpty(b.PageNo)) && b.PageNo.ToUpper().Contains(q.ToUpper()));         
                    blocks = blocks.Where(b => b.PageNo.Contains(q));
                
                }
                //else if (type == "") { }
            }

            var searchTypes = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Selected = (type == "PageNo" ? true : false) , Text = "PageNo", Value = "PageNo"},
                }, "Value", "Text");

            // Task: Sort String
            switch (sort)
            {
                case "PageNo":
                    blocks = blocks.OrderBy(p => p.PageNo);
                    break;
                case "PageNo_desc":
                    blocks = blocks.OrderByDescending(p => p.PageNo);
                    break;   
                case "Submitted":
                    blocks = blocks.OrderBy(p => p.Submitted);
                    break;
                case "Submitted_desc":
                    blocks = blocks.OrderByDescending(p => p.Submitted);
                    break;
                case "Completed":
                    blocks = blocks.OrderBy(p => p.Completed);
                    break;
                case "Completed_desc":
                    blocks = blocks.OrderByDescending(p => p.Completed);
                    break;
            }

            //var YNList = new List<YN>
            //{
            //    new YN{ID="1", Type = "Yes"},
            //    new YN{ID="0", Type = "No"}
            //};

            // Task: PagedList
            var onePageofBlocks = blocks.ToPagedList(pageNumber, _pageSize);

            // VIEWBAGS
            ViewBag.currentPage = pageNumber;
            ViewBag.pageSize = _pageSize;
            ViewBag.searchType = type;
            ViewBag.searchString = q;
            ViewBag.filter = f;
            ViewBag.currentSort = sort;
            ViewBag.searchTypes = searchTypes;
            ViewBag.filterTypes = filterTypes;
            ViewBag.idSort = sort == "PageNo" ? "PageNo_desc" : "PageNo";
            ViewBag.SubmittedSort = sort == "Submitted" ? "Submitted_desc" : "Submitted";
            ViewBag.CompletedSort = sort == "Completed" ? "Completed_desc" : "Completed";


            return View(onePageofBlocks);
        }

        // GET: Block/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Block_Track block_Track = db.Block_Track.Find(id);
            if (block_Track == null)
            {
                return HttpNotFound();
            }
            return View(block_Track);
        }

        // GET: Block/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Block/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OBJECTID,Project_Number,Block_Number,GIS_Processor,Processed_By_Date,Reviewer,Review_By_Date,StreetCalcs,ConcreteCalcs,Geometry,MXD_Export,Photoline_MXD_Export,CIC_Summary_Sheet_Export,Streets_Sketchline_Edits,Concrete_Edits,MXD_PDF,Photoline_PDF,Photolog_PDF,FTP_Upload,Submitted,Completed,PageNo, Notes, testYN")] Block_Track block_Track)
        {
            if (ModelState.IsValid)
            {
                db.Block_Track.Add(block_Track);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(block_Track);
        }

        // GET: Block/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Block_Track block_Track = db.Block_Track.Find(id);
            if (block_Track == null)
            {
                return HttpNotFound();
            }

            

            //ViewBag.YNList = new SelectList(db.testDomain, "ID", "YN_Val");

            ViewBag.YNList = new List<testDomain>();

            foreach (var YN in db.testDomain)
            {
                ViewBag.YNList.Add(YN); 
            }


            //var YNList = new List<testDomain>
            //{
            //    new YN{ID="1", Type = "Yes"},
            //    new YN{ID="0", Type = "No"}
            //};


            return View(block_Track);
        }

        // POST: Block/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OBJECTID,Project_Number,Block_Number,GIS_Processor,Processed_By_Date,Reviewer,Review_By_Date,StreetCalcs,ConcreteCalcs,Geometry,MXD_Export,Photoline_MXD_Export,CIC_Summary_Sheet_Export,Streets_Sketchline_Edits,Concrete_Edits,MXD_PDF,Photoline_PDF,Photolog_PDF,FTP_Upload,Submitted,Completed,PageNo, Notes, testYN")] Block_Track block_Track)
        {
            if (ModelState.IsValid)
            {
                db.Entry(block_Track).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(block_Track);
        }

        // GET: Block/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Block_Track block_Track = db.Block_Track.Find(id);
            if (block_Track == null)
            {
                return HttpNotFound();
            }
            return View(block_Track);
        }

        // POST: Block/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Block_Track block_Track = db.Block_Track.Find(id);
            db.Block_Track.Remove(block_Track);
            db.SaveChanges();
            return RedirectToAction("Index");
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
