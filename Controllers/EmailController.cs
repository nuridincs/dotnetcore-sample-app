using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Myapp.Web.Models;
using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Logging;

namespace Myapp.Web.Controllers
{
  public class EmailController : Controller
  {
      private readonly ILogger<EmailController> _logger;

      public EmailController(ILogger<EmailController> logger)
      {
          _logger = logger;
      }

      public IActionResult Index(EmailModel emailModel)
      {
        //string to = "nuridin50@gmail.com";
        //string from = "d3veL0pm3nt";
        if (emailModel.Email != null && emailModel.To != null)
        {
            using (MailMessage mm = new MailMessage(emailModel.Email, emailModel.To))
            {
                mm.Subject = emailModel.Subject;
                mm.Body = emailModel.Body;
                if (emailModel.Attachment.Length > 0)
                {
                    string fileName = Path.GetFileName(emailModel.Attachment.FileName);
                    mm.Attachments.Add(new Attachment(emailModel.Attachment.OpenReadStream(), fileName));
                }

                mm.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(emailModel.Email, emailModel.Password);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    ViewBag.Message = "Email sent.";
                }
            }
        }

        return View();
      }
  }
}