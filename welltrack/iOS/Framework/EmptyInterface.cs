using System;
namespace SBMobile.iOS
{
	public interface ITabPage
	{
		string TabIcon { get; }
		string SelectedTabIcon { get; }
	}
}
