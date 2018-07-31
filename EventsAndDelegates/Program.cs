using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Naslov"};

            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            MessageService messageService = new MessageService();
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);

            Console.ReadLine();

        }
    }

    //subsriber
    public class MailService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
        }
    }

    //subsriber
    public class MessageService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending an email..." + args.Video.Title);
        }
    }
}
