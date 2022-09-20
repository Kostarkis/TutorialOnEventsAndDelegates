using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialOnEventsAndDelegates
{
    public partial class MediaService
    {
        public class MailService
        {
            public void OnVideoEncoded(object source, ObjectEventArgs<Video> args)
            {
                Console.WriteLine("MailService: Sending an email..." + args.Object.Title);
            }
        }
    }
}
