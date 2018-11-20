using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class HeaderCell : UITableViewCell
    {
        public HeaderCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateData(string v)
        {
            lblHeader.Text = v;
        }
    }
}