using System;

namespace TutorialOnEventsAndDelegates
{
    public partial class MediaService
    {
        public class MessageService
        {
            public void OnVideoEncoded(object source, ObjectEventArgs<Video> args)
            {
                Console.WriteLine("MessageService: Sending a text message..." + args.Object.Title);
            }
        }
    }
}