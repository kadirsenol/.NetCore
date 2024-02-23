using soliD_DependencyInversionPrincible_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace soliD_DependencyInversionPrincible_.Concrete
{
    public class Mail : ILoglanabilir
    {
        public void Loglan(string msg)
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("outlook.office365.com");

            mail.From = new MailAddress("kdrsnl_61@hotmail.com");
            mail.To.Add("senolkadir922@gmail.com");
            mail.Subject = "Loglama Bilgisi";
            mail.Body = msg;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential("kdrsnl_61@hotmail.com", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            Console.WriteLine("Mail başarıyla gönderildi.");
        } 
    }
}
