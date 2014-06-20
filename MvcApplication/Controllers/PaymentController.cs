﻿using PaymillWrapper;
using PaymillWrapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class PaymentController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submit(Models.PaymillForm form)
        {
            PaymillContext paymill = new PaymillContext("YOUR PRIVATE KEY");
            string token = Request.Form["hToken"];	
            Transaction transaction = paymill.TransactionService.CreateWithTokenAsync(token, form.Amount, form.Currency).Result;
           return Content("Payment Succeed");
        } 
    }
}