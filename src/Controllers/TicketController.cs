using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTracker.Models;

namespace BugTracker.Controllers
{
    public class TicketController : Controller
    {
        static IList<Ticket> ticketList = new List<Ticket>
        {
            new Ticket() { Id = 1, Title = "Issue 1", Status = "In Progress" },
            new Ticket() { Id = 2, Title = "Issue 2", Status = "New"},
            new Ticket() { Id = 3, Title = "Issue 3", Status = "In Progress"},
            new Ticket() { Id = 4, Title = "Issue 4", Status = "In Progress"},
            new Ticket() { Id = 5, Title = "Issue 5", Status = "Waiting Review"}
        };

        // GET: Ticket
        public ActionResult Index()
        {
            //Get tickets from database using entity framework here

            //return "index method";

            return View(ticketList.OrderBy(t => t.Id).ToList());
        }

        public ActionResult Edit(int Id)
        {
            //Get the ticket from database here

            var tck = ticketList.Where(t => t.Id == Id).FirstOrDefault();

            return View(tck);
        }

        [HttpPost]
        public ActionResult Edit(Ticket tck)
        {
            if (ModelState.IsValid)
            {
                //Update ticket in database

                var ticket = ticketList.Where(t => t.Id == tck.Id).FirstOrDefault();
                ticketList.Remove(ticket);
                ticketList.Add(tck);
            }

            return View(tck);
        }

        public ActionResult Delete(int Id)
        {
            if (Id <= 0)
            {
                //return error message
                return RedirectToAction("Index");
            }

            var ticket = ticketList.Where(t => t.Id == Id).FirstOrDefault();
            ticketList.Remove(ticket);

            return RedirectToAction("Index");
        }
    }
}