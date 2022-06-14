
namespace WindowsFormsApp110 {
	partial class Form1 {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.myTextControl1 = new WindowsFormsApp110.MyTextControl();
			this.SuspendLayout();
			// 
			// myTextControl1
			// 
			this.myTextControl1.Location = new System.Drawing.Point(35, 35);
			this.myTextControl1.Name = "myTextControl1";
			this.myTextControl1.Size = new System.Drawing.Size(660, 489);
			this.myTextControl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 564);
			this.Controls.Add(this.myTextControl1);
			this.Name = "Form1";
			this.Text = "Custom Margin and Scrolling";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MyTextControl myTextControl1;
	}
}

