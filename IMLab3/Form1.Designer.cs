namespace IMLab3
{
	partial class Form1
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
			rulee = new NumericUpDown();
			label2 = new Label();
			button1 = new Button();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)rulee).BeginInit();
			SuspendLayout();
			// 
			// rulee
			// 
			rulee.Location = new Point(822, 65);
			rulee.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			rulee.Name = "rulee";
			rulee.Size = new Size(150, 27);
			rulee.TabIndex = 0;
			rulee.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(818, 95);
			label2.Name = "label2";
			label2.Size = new Size(38, 20);
			label2.TabIndex = 2;
			label2.Text = "Rule";
			// 
			// button1
			// 
			button1.Location = new Point(822, 118);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 3;
			button1.Text = "Start";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel1
			// 
			panel1.Location = new Point(16, 15);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 800);
			panel1.TabIndex = 4;
			panel1.Paint += panel1_Paint;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1015, 695);
			Controls.Add(panel1);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(rulee);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)rulee).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private NumericUpDown rulee;
		private Label label2;
		private Button button1;
		private Panel panel1;
	}
}
