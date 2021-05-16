using System.ComponentModel;
using System.Windows.Forms;

namespace RxjhServer
{
	public class FlickerFreePanel : Panel
	{
		private IContainer icontainer_0;

		protected override void Dispose(bool disposing)
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			icontainer_0 = new Container();
		}

		public FlickerFreePanel()
		{
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.UserPaint, true);
		}
	}
}
