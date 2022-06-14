using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp110 {
	public partial class MyTextControl : UserControl {
		public MyTextControl() {
			InitializeComponent();
		}

		public Padding InnerMargin {
			get { return panel2.Padding; }
			set {
				panel2.Padding = value;
			}
		}

		private bool scrolling = false;

		private void MyTextControl_Load(object sender, EventArgs e) {
			setScrollOffset();
		}

		private void setScrollOffset() {
			// remember old scroll location
			var oldScrollLocation = textControl1.ScrollLocation;
			// scroll to bottom to get max value
			textControl1.ScrollLocation = new Point(0, int.MaxValue);
			int scrollY = textControl1.ScrollLocation.Y;

			// mirror the max value in custom scroll bar
			vScrollBar1.Maximum = scrollY;

			// restore scroll location
			textControl1.ScrollLocation = oldScrollLocation;
		}

		private void textControl1_Changed(object sender, EventArgs e) {
			setScrollOffset();
		}

		private void textControl1_VScroll(object sender, EventArgs e) {
			if (scrolling == true)
				return;

			// set the scroll location
			if (textControl1.ScrollLocation.Y <= vScrollBar1.Maximum) {
				vScrollBar1.Value = textControl1.ScrollLocation.Y;
				vScrollBar1.SmallChange = 300;
				vScrollBar1.LargeChange = 300;
			}
		}

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {
			// mirror the scroll location
			scrolling = true;
			textControl1.ScrollLocation = new Point(0, e.NewValue);
			scrolling = false;
		}
	}
}
