namespace test
{
	partial class btn_display
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnDisplay = new Button();
			SuspendLayout();
			// 
			// btnDisplay
			// 
			btnDisplay.Location = new Point(91, 192);
			btnDisplay.Name = "btnDisplay";
			btnDisplay.Size = new Size(104, 38);
			btnDisplay.TabIndex = 0;
			btnDisplay.Text = "Display message";
			btnDisplay.UseVisualStyleBackColor = true;
			btnDisplay.Click += btnDisplay_Click;
			// 
			// btn_display
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(344, 534);
			Controls.Add(btnDisplay);
			Name = "btn_display";
			Text = "Ver Mensaje";
			ResumeLayout(false);
		}

		#endregion

		private Button btnDisplay;
	}
}
