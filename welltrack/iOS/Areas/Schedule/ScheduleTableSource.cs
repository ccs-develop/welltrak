using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace welltrak.iOS
{
    public class ScheduleTableSource: UITableViewSource
    {
		List<Appointment> Items;
		UITabBarController tabBarController;
		ScheduleListViewController ScheduleListViewController;
		public static string AppointmentItemCell_ID = "AppointmentCell";
        private List<Appointment> appointments;

        //AppointmentService Service = new AppointmentService();

        public override nint RowsInSection(UITableView tableview, nint section)
		{
			return Items.Count;
		}

        public ScheduleTableSource(List<Appointment> items, ScheduleListViewController controller)
        {
            Items = items;
            ScheduleListViewController = controller;
        }

        public void SetItems(List<Appointment> items)
		{
			Items = items;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = (AppointmentCell)tableView.DequeueReusableCell(AppointmentItemCell_ID);
			cell.UpdateData(Items[indexPath.Row]);
			return cell;

		}

		//public override async void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
		//{
		//	switch (editingStyle)
		//	{
		//		case UITableViewCellEditingStyle.Delete:

		//			if (Items[indexPath.Row].IsRead == false)
		//			{
		//				await UserService.Instance.DecrimentUnreadMessageCount();
		//				SetUnreadMessageCountBadge();
		//			}

		//			await DeleteMessage(Items[indexPath.Row].MessageID);

		//			//Order matters here. if we dont remove the item from the source before we remove from the table, we will get an error.
		//			Items.RemoveAt(indexPath.Row);
		//			tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);

		//			if (Items.Count == 0)
		//			{
		//				MessagesController.DrawNoMessagesView();
		//			}
		//			break;

		//		case UITableViewCellEditingStyle.None:
		//			Console.WriteLine("CommitEditingStyle:None called");
		//			break;
		//	}
		//}

		public override bool ShouldHighlightRow(UITableView tableView, NSIndexPath rowIndexPath)
		{
			return true;
		}

		//private async Task<bool> DeleteMessage(int messageId)
		//{
		//	return await new MailService().DeleteMessage(messageId);
		//}

		//public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
		//{
		//	return true; // return false if you wish to disable editing for a specific indexPath or for all rows
		//}
		//public override string TitleForDeleteConfirmation(UITableView tableView, NSIndexPath indexPath)
		//{   // Optional - default text is 'Delete'
		//	return "Delete";
		//}

		//set rows height
		public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
            return 102f;
		}

	
		//public MessageSummaryResponse GetItem(nint id)
		//{
		//	return Items[(int)id];
		//}

    }
}
