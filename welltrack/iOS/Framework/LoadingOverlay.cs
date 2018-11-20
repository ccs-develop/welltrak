using System;
using UIKit;
using CoreGraphics;

namespace welltrak.iOS
{
	public class LoadingOverlay : UIView
	{
		// control declarations
		UIActivityIndicatorView activitySpinner;

		public LoadingOverlay(CGRect frame, int tag = 912293847) : base(frame)
		{
			// configurable bits
			this.Tag = tag;
			Alpha = .75f;
			AutoresizingMask = UIViewAutoresizing.All;

			nfloat labelHeight = 22;
			nfloat labelWidth = Frame.Width - 20;

			// derive the center x and y
			nfloat centerX = Frame.Width / 2;
			nfloat centerY = Frame.Height / 2;

			var imageSizer = .75;
			var imageHeight = 113 * imageSizer;
			var imageWidth = 284 * imageSizer;
			var imageView = new UIImageView(UIImage.FromBundle("logo-transparent.png"));
			var imageOriginPoint = new CGPoint((Frame.Width - imageWidth) / 2, ((Frame.Height - imageHeight) / 2) - 80);
			var imageSize = new CGSize(imageWidth, imageHeight);
			imageView.Frame = new CGRect(imageOriginPoint, imageSize);
			AddSubview(imageView);

			// create the activity spinner, center it horizontall and put it 5 points above center x
			activitySpinner = new UIActivityIndicatorView(UIActivityIndicatorViewStyle.WhiteLarge);
			activitySpinner.Frame = new CGRect(
				centerX - (activitySpinner.Frame.Width / 2),
				centerY - activitySpinner.Frame.Height + 20,
				activitySpinner.Frame.Width,
				activitySpinner.Frame.Height);
			//activitySpinner.Color = colors.LightGrey;
			activitySpinner.AutoresizingMask = UIViewAutoresizing.All;
			AddSubview(activitySpinner);
			activitySpinner.StartAnimating();

			// create and configure the "Loading Data" label
			/*loadingLabel = new UILabel(new CGRect(
				centerX - (labelWidth / 2),
				centerY + 40,
				labelWidth,
				labelHeight
				));
			loadingLabel.Text = "Loading";
			loadingLabel.TextAlignment = UITextAlignment.Center;
			loadingLabel.AutoresizingMask = UIViewAutoresizing.All;
			AddSubview(loadingLabel);
			*/
		}

		/// <summary>
		/// Fades out the control and then removes it from the super view
		/// </summary>
		public void Hide()
		{
			UIView.Animate(
				.5, // duration
				() => { Alpha = 0; },
				() => { RemoveFromSuperview(); }
			);
		}
	}
}
