using System;

using UIKit;

namespace Liu.iOS
{
    public partial class ViewController : UIViewController
    {
        

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Event
            var workerEvent = new EventWebWorker();

            workerEvent.HtmlStringReceived += (object sender, HtmlReceivedEventArgs e) => {
                WriteLine($"event html:{ e.Html }");
                
            };

            workerEvent.DownloadHtmlStringWithEvent(url);

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {
                this.PerformSegue("moveToMasterViewSegue",this);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
