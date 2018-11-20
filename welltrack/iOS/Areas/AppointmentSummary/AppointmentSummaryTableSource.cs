using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace welltrak.iOS
{
    public class AppointmentSummaryTableSource: UITableViewSource
    {
		List<AssessmentItem> AssessmentItems;
        List<Action> Tasks;

		UITabBarController tabBarController;
		ScheduleListViewController ScheduleListViewController;
        public static string appointmentDetailCellItemCell_ID = "appointmentDetailCell";
        public static string headerCell_ID = "headerCell";
        public static string finalizeCell_ID = "finalizeCell";
        public static string taskSummaryCell_ID = "taskSummaryCell";
        public static string assessmentItemSummaryCell_ID = "assessmentItemSummaryCell";
       
        public override nint RowsInSection(UITableView tableview, nint section)
		{
			return AssessmentItems.Count + Tasks.Count + 1 /*AppointmentDetailCell*/ + 2 /* Header Cells */ + 1 /* Finalize Cell */;
		}

        public AppointmentSummaryTableSource()
        {
            AssessmentItems = WelltrakAppService.Instance.CurrentAppointment.AssessmentItems;
            Tasks = WelltrakAppService.Instance.CurrentAppointment.Actions;
        }

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
            if(indexPath.Row == 0)
            {
                var cell = (AppointmentDetailCell)tableView.DequeueReusableCell(appointmentDetailCellItemCell_ID);
                cell.UpdateData();
                return cell;
            }
            if(indexPath.Row == 1)
            {
				var cell = (HeaderCell)tableView.DequeueReusableCell(headerCell_ID);
                cell.UpdateData("Tasks");
                return cell;
            }
            if(indexPath.Row >= 1 && indexPath.Row <= (2 + (Tasks.Count - 1)))
            {
                var cell = (TaskSummaryCell)tableView.DequeueReusableCell(taskSummaryCell_ID);
                var task = Tasks[indexPath.Row - 2];
                cell.UpdateData(task);
                return cell;
            }
            if(indexPath.Row == (2 + Tasks.Count))
            {
				var cell = (HeaderCell)tableView.DequeueReusableCell(headerCell_ID);
				cell.UpdateData("Assessment Items");
				return cell;
            }
            if(indexPath.Row >= (3 + Tasks.Count) && indexPath.Row < (3 + Tasks.Count + AssessmentItems.Count))
            {
				var cell = (AssessmentItemSummaryCell)tableView.DequeueReusableCell(assessmentItemSummaryCell_ID);
				var assessmentItem = AssessmentItems[indexPath.Row - 3 - Tasks.Count];
				cell.UpdateData(assessmentItem);
				return cell;
            }
            //ELSE if(indexPath.Row == 3 + Tasks.Count + AssessmentItems.Count)
            //{
			var fcell = (FinalizeCell)tableView.DequeueReusableCell(finalizeCell_ID);
			return fcell;
            //}

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
            var row = indexPath.Row;

            if(row == 0)
            {
                return 91f;
            }
            if(row == 1)
            {
                return 29f;
            }
            if(row >= 1 && row <= (2 + (Tasks.Count - 1)))
            {
                return 25f;
            }
            if(row == (2 + Tasks.Count))
            {
                return 29f;
            }
			if (row >= (3 + Tasks.Count) && row < (3 + Tasks.Count + AssessmentItems.Count))
			{
				return 25f;
			}
			
            return 44f;
		}

	
		//public MessageSummaryResponse GetItem(nint id)
		//{
		//	return Items[(int)id];
		//}

    }
}
