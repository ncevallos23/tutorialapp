using System;

using AppKit;
using Foundation;

namespace tutorialapp
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ClickedLabel.StringValue = "Button has not been clicked yet.";
            // Do any additional setup after loading the view.
        }

        partial void ClickedButton(Foundation.NSObject sender)
        {
            // Update counter and label
            ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
