using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelBd.Controllers
{
    //public class PaypalController : Controller
    //{

    //    public PaypalController()
    //    {
    //        ViewBag.org_id = TempData["org_id"];
    //    }
    //    // GET: Paypal
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    public ActionResult DonateOrganization(string org_id)
    //    {

    //        var payment = PaypalPaymentService.CreatePayment("http://localhost:51138", "sale", org_id);

    //        return Redirect(payment.GetApprovalUrl());

    //    }

    //    public ActionResult PaymentCancelled()
    //    {
    //        // TODO: Handle cancelled payment
    //        return RedirectToAction("Error");
    //    }

    //    public ActionResult PaymentSuccessful(string paymentId, string token, string PayerID)
    //    {
    //        // Execute Payment
    //        var payment = PaypalPaymentService.ExecutePayment(paymentId, PayerID);


    //        //return Content("Fn"+payment.payer.payer_info.last_name+ "phn"+payment.payer.payer_info.phone+ "country"+payment.payer.payer_info.country_code);
    //        return Content(payment.ConvertToJson());

    //    }
    //    public ActionResult Error()
    //    {
    //        return Content("Error in transaction");
    //    }


    //    public ActionResult Test()
    //    {

    //        return View();
    //    }

    //}
}