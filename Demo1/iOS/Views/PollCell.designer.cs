// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinMALDemo1.iOS.Views
{
	[Register ("PollCell")]
	partial class PollCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblPollQuestion { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblPollResponses { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblPollQuestion != null) {
				lblPollQuestion.Dispose ();
				lblPollQuestion = null;
			}
			if (lblPollResponses != null) {
				lblPollResponses.Dispose ();
				lblPollResponses = null;
			}
		}
	}
}
