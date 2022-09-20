using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TutorialOnEventsAndDelegates.VideoEncoder;

namespace TutorialOnEventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video 1" };
            VideoEncoder videoEncoder = new VideoEncoder(); // Publisher

            AttachMediaServicesToVideoEncodedEventHandler(videoEncoder);

            videoEncoder.Encode(video);
            Thread.Sleep(3000);
        }

        static void AttachMediaServicesToVideoEncodedEventHandler(VideoEncoder videoEncoder)
        {
            MediaService mediaService = new MediaService(); // parent Subscriber

            foreach (var mediaObject in mediaService.GetType().GetNestedTypes())

                if (mediaObject.GetMethod("OnVideoEncoded") != null)

                    videoEncoder.VideoEncoded += (VideoEncodedEventHandler)Delegate
                        .CreateDelegate(typeof(VideoEncodedEventHandler),
                                        Activator.CreateInstance(mediaObject),
                                        mediaObject.GetMethod("OnVideoEncoded"));
        }
    }
}
