// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MantaMateTestBuilder
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField ClickMeLabel { get; set; }

        [Outlet]
        AppKit.NSButton HexOutlet { get; set; }

        [Action ("ClickMeButton:")]
        partial void ClickMeButton (Foundation.NSObject sender);

        [Action ("HexTest:")]
        partial void HexTest (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (ClickMeLabel != null) {
                ClickMeLabel.Dispose ();
                ClickMeLabel = null;
            }

            if (HexOutlet != null) {
                HexOutlet.Dispose ();
                HexOutlet = null;
            }
        }
    }
}
