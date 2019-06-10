using System;

using AppKit;
using Foundation;

enum HexColor { Off, Yellow, Red, Both };

namespace MantaMateTestBuilder
{

    public partial class ViewController : NSViewController
    {
        private const int NumberHexes = 32;

        private int numberOfTimesClicked = 0;
        private HexColor[] hexStates = new HexColor[NumberHexes];

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            ClickMeLabel.StringValue = "Button has not been clicked yet.";
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

        partial void ClickMeButton(Foundation.NSObject sender)
        {
            // Update counter and label
            ClickMeLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
        }

        private HexColor GetNextHexColor(HexColor color)
        {
            switch (color)
            {
                case HexColor.Off: return HexColor.Yellow;
                case HexColor.Yellow: return HexColor.Red;
                case HexColor.Red: return HexColor.Both;
                case HexColor.Both: return HexColor.Off;
                default: return HexColor.Off;
            }
        }

        private NSImage GetHexImage(HexColor color)
        {
            switch (color)
            {
                case HexColor.Off: return NSImage.ImageNamed("MantaHex");
                case HexColor.Yellow: return NSImage.ImageNamed("MantaHexYellow");
                case HexColor.Red: return NSImage.ImageNamed("MantaHexRed");
                case HexColor.Both: return NSImage.ImageNamed("MantaHexBoth");
                default: return NSImage.ImageNamed("MantaHex");
            }
        }

        partial void HexTest(Foundation.NSObject sender)
        {
            // Update counter and label
            hexStates[0] = GetNextHexColor(hexStates[0]);
            NSImage image = GetHexImage(hexStates[0]);
            HexOutlet.Image = image;
        }

    }
}
