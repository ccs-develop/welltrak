using Foundation;
using System;
using UIKit;
using CoreGraphics;
using System.Linq;

namespace welltrak.iOS
{
	public partial class ResponsiveTextView : UITextView
	{
		public ResponsiveTextView(IntPtr handle) : base(handle)
		{

		}

		public ResponsiveTextView(CGRect frame, NSTextContainer textContainer) : base(frame, textContainer)
		{
			this.DelaysContentTouches = false;
			this.ScrollEnabled = false;
			this.Editable = false;
			this.UserInteractionEnabled = true;
			this.Selectable = true;
		}

		public override UIView HitTest(CoreGraphics.CGPoint point, UIEvent uievent)
		{

			var location = point;
			location.X -= this.TextContainerInset.Left;
			location.Y -= this.TextContainerInset.Top;
			nfloat n = 0;

			var cIndex = this.LayoutManager.CharacterIndexForPoint(location, this.TextContainer, ref n);
			if ((int)cIndex < this.TextStorage.Length)
			{
				NSRange effectiveRange;
				var dict = this.TextStorage.GetAttributes((nint)cIndex, out effectiveRange);
				var link = dict.Keys.SingleOrDefault(x => x.ToString() == "NSLink");
				if (link != null && effectiveRange.Location + effectiveRange.Length >= (nint)cIndex)
				{
					return this;
				}
			}

			return null;

		}
	}
}