using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace assignment1
{
    public partial class MakeNewFriendViewController : UIViewController
    {
		public List<String> PhoneNumbers { get; set; }
		public List<String> FriendName { get; set; }
        public MakeNewFriendViewController (IntPtr handle) : base (handle)
        {
			PhoneNumbers = new List<String>();
			FriendName = new List<String>();
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			SaveButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				if (NameText.Text == "")
				{
					var alert = UIAlertController.Create("", "Please type your friend Name", UIAlertControllerStyle.Alert);
					alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
					PresentViewController(alert, true, null);
				}
				else
				{
					
					//PhoneNumbers = new List<string>();
					//FriendName = new List<string>();
					//PhoneNumbers.Add(PhoneText.Text);
					FriendName.Add(NameText.Text);


						//callHistory.PhoneNumbers = PhoneNumbers;
						//this.NavigationController.PushViewController(callHistory, true);



						// Launches a new instance of CallHistoryController
						CallHistoryController callHistory = this.Storyboard.InstantiateViewController ("CallHistoryController") as CallHistoryController;
						if (callHistory != null) {
							//callHistory.PhoneNumbers = PhoneNumbers;
							callHistory.FriendName = FriendName;
							this.NavigationController.PushViewController (callHistory, true);
						}
				

				}



			};
			//
			// Nativation without Segues
			// - if the segue was deleted from the storyboard, this code would enable the button to open the second view controller
			// 
			//			CallHistoryButton.TouchUpInside += (object sender, EventArgs e) => {
			//				// Launches a new instance of CallHistoryController
			//				CallHistoryController callHistory = this.Storyboard.InstantiateViewController ("CallHistoryController") as CallHistoryController;
			//				if (callHistory != null) {
			//					callHistory.PhoneNumbers = PhoneNumbers;
			//					this.NavigationController.PushViewController (callHistory, true);
			//				}
			//			};

		}
    }
}