using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OnlinePortfolio.Models
{
    public class MailSender
    {
        public void SendMail(string fromName, string theSubject, string fromEmail, string textMessage)
        {
            // Sending from and to... Maybee...
            MailMessage mail = new MailMessage("inbetween.musicgroup@gmail.com", "Mikael.Brunnberg@gmail.com");

            mail.Subject = theSubject;

            mail.Body = textMessage + "\n" + "\n" + "From: " + fromName + "\n" + "Email: " + fromEmail + "\n\n" + "(This message was sent to you from your web portfolio.)";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587; // Koden är specifik för gmail

            // Nedan är mailadressen samt lösenordet som epostmeddelandet skickas FRÅN
            smtp.Credentials = new NetworkCredential("inbetween.musicgroup@gmail.com", "MikaelBrunnberg"); // (Skickas från epost, lösenordet till den eposten)
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}

