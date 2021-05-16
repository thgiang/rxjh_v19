using System.Windows.Forms;

namespace RxjhServer
{
	public class ListViewHelper
	{
		public static void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ListView listView = sender as ListView;
			if (e.Column == (listView.ListViewItemSorter as ListViewColumnSorter).SortColumn)
			{
				if ((listView.ListViewItemSorter as ListViewColumnSorter).Order == SortOrder.Ascending)
				{
					(listView.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Descending;
				}
				else
				{
					(listView.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
				}
			}
			else
			{
				(listView.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
				(listView.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
			}
			((ListView)sender).Sort();
		}
	}
}
