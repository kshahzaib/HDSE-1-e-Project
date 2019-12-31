using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinic_Management_System.Controllers
{
    public class FrontController : Controller
    {
        // GET: Front

        Database1Entities fr = new Database1Entities();
        public ActionResult Index()
        {
            return View();
        }

   //Login Starts From Here
        public ActionResult Login_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login_Create(User a)
        {

            if (ModelState.IsValid)
            {

                fr.Users.Add(a);

                fr.SaveChanges();

                return RedirectToAction("User_Create");

            }

            return View(a);
        }

  
        //Signup Starts From Here
        public ActionResult User_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult User_Create(User a)
        {

            if (ModelState.IsValid)
            {

                fr.Users.Add(a);

                fr.SaveChanges();

                return RedirectToAction("User_Create");

            }

            return View(a);
        }


        //Seminar Starts From Here

        public ActionResult Seminar_List()
        {
            return View(fr.Seminars.ToList());
        }

        //Seminar Booking Starts From Here

        public ActionResult Seminar_Booking_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Seminar_Booking_Create(Seminar_Booking a)
        {

            if (ModelState.IsValid)
            {

                fr.Seminar_Booking.Add(a);

                fr.SaveChanges();

                return RedirectToAction("Seminar_Booking_Create");

            }

            return View(a);
        }

        //Practical Starts From Here
        public ActionResult Practical_List()
        {
            return View(fr.Practical_Conducted.ToList());
        }
     
       
        //Practical Booking Starts From Here


        public ActionResult Practical_Booking_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Practical_Booking_Create(Practical_Booking a)
        {

            if (ModelState.IsValid)
            {

                fr.Practical_Booking.Add(a);

                fr.SaveChanges();

                return RedirectToAction("Practical_Booking_Create");

            }

            return View(a);
        }

        //Lectures Starts From Here

        public ActionResult Lecture_List()
        {
            return View(fr.Lectures.ToList());
        }

        //Lectures Booking Starts From Here

        public ActionResult Lecture_Booking_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lecture_Booking_Create(Lecture_Booking a)
        {

            if (ModelState.IsValid)
            {

                fr.Lecture_Booking.Add(a);

                fr.SaveChanges();

                return RedirectToAction("Lecture_Booking_Create");

            }

            return View(a);
        }


        //Contact Us Starts From Here

        public ActionResult Contact_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact_Create(Contact a)
        {

            if (ModelState.IsValid)
            {

               fr.Contacts.Add(a);

                fr.SaveChanges();

                return RedirectToAction("Contact_Create");

            }

            return View(a);
        }



        //Feedback Starts From Here

        public ActionResult Feedback_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback_Create(Feedback a)
        {

            if (ModelState.IsValid)
            {

                fr.Feedbacks.Add(a);

                fr.SaveChanges();

                return RedirectToAction("Feedback_Create");

            }

            return View(a);
        }


        //Products Gallery Starts From Here

        public ActionResult Products_List()
        {
            return View(fr.Products.ToList());
        }


    }
}