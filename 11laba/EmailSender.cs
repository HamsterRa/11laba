using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace _11laba
{
    public class EmailSender
    {
        MailAddress from = new MailAddress("Ronanbbacc@mail.ru", "System");
        MailAddress to;
        public EmailSender(string to)
        {
            this.to = new MailAddress(to);
        }
        public void SendMessage(string letter)
        {
            MailMessage Letter = new(from, to)
            {
                Subject = "Сообщение безопасности",
                Body = letter
            };
            SmtpClient smtp = new("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("Ronanbbacc@mail.ru", "sAmArDeScHG7m3cLzJm7");
            smtp.EnableSsl = true;
            smtp.Send(Letter);
            MessageBox.Show("Письмо отправленно");
        }

    }
}
