using System;

namespace events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Message service sending a message....");
        }
    }
}
