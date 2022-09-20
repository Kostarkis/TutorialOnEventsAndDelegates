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
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Publisher

            MediaService mediaService = new MediaService(); // parent Subscriber

            foreach (var mediaObject in mediaService.GetType().GetNestedTypes())
                
                if (mediaObject.GetMethod("OnVideoEncoded") != null)
                    
                    videoEncoder.VideoEncoded += (VideoEncodedEventHandler)Delegate
                        .CreateDelegate(typeof(VideoEncodedEventHandler), 
                                        Activator.CreateInstance(mediaObject), 
                                        mediaObject.GetMethod("OnVideoEncoded"));

            videoEncoder.Encode(video);
            Thread.Sleep(3000);
        }
    }
}
