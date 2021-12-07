using System;
using System.Collections.Generic;
using System.Text;


namespace events
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("encoding video.....");
            
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
