using System;

namespace events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mail service sending an email....");
        }
    }
}
