
namespace WindowsFormsApp110 {
	partial class MyTextControl {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textControl1 = new TXTextControl.TextControl();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.vScrollBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(602, 367);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.textControl1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(20);
			this.panel2.Size = new System.Drawing.Size(584, 367);
			this.panel2.TabIndex = 2;
			// 
			// textControl1
			// 
			this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
			this.textControl1.FormattingPrinter = "Standard";
			this.textControl1.Location = new System.Drawing.Point(20, 20);
			this.textControl1.Name = "textControl1";
			this.textControl1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textControl1.Size = new System.Drawing.Size(544, 327);
			this.textControl1.TabIndex = 0;
			this.textControl1.Text = "textControl1";
			this.textControl1.UserNames = null;
			this.textControl1.ViewMode = TXTextControl.ViewMode.FloatingText;
			this.textControl1.Changed += new System.EventHandler(this.textControl1_Changed);
			this.textControl1.VScroll += new System.EventHandler(this.textControl1_VScroll);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(584, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(18, 367);
			this.vScrollBar1.TabIndex = 1;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// MyTextControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "MyTextControl";
			this.Size = new System.Drawing.Size(602, 367);
			this.Load += new System.EventHandler(this.MyTextControl_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private TXTextControl.TextControl textControl1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
	}
}
