using System;
using System.Threading;

namespace EventsAndDelegates
{
    //publisher
    public class VideoEncoder
    {
        //1. create a delegate / contract between subscriber and caller about signature method that will be called
        //2. define an event based on that delegate
        //3. raise the event

        //public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
