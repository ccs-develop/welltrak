using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace welltrak.iOS
{
    public class AssessmentTableSource: UITableViewSource
    {
		List<AssessmentItem> Items;
		UITabBarController tabBarController;
		ScheduleListViewController ScheduleListViewController;
		public static string booleanCellItemCell_ID = "booleanCell";
        public static string ternaryCellItemCell_ID = "ternaryCell";
        public static string decimalCellItemCell_ID = "decimalCell";
       
        public override nint RowsInSection(UITableView tableview, nint section)
		{
			return Items.Count;
		}

        public AssessmentTableSource()
        {
            Items = WelltrakAppService.Instance.CurrentAppointment.AssessmentItems;
        }

        public void SetItems(List<AssessmentItem> items)
		{
			Items = items;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
            var type = Items[indexPath.Row].AssessmentItemResponseType;
            var item = Items[indexPath.Row];

            switch(type)
            {
                case AssessmentItemResponseType.Boolean:
                    {
						var cell = (BooleanCell)tableView.DequeueReusableCell(booleanCellItemCell_ID);
						cell.UpdateData(item);
						return cell;
                    }
                case AssessmentItemResponseType.Ternary:
                    {
						var cell = (TernaryCell)tableView.DequeueReusableCell(ternaryCellItemCell_ID);
						cell.UpdateData(item);
						return cell;
                    }
                default: 
				{
						var cell = (DecimalCell)tableView.DequeueReusableCell(decimalCellItemCell_ID);
						cell.UpdateData(item);
						return cell;
				}
            }
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
            return false;
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
            return 185f;
		}

	
		//public MessageSummaryResponse GetItem(nint id)
		//{
		//	return Items[(int)id];
		//}

    }
}
