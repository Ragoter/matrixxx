
namespace matrixxx
{
	partial class About
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.razrabotalAlexeevAndrey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.razrabotalAlexeevAndrey)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(178, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 193);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // razrabotalAlexeevAndrey
            // 
            this.razrabotalAlexeevAndrey.Image = ((System.Drawing.Image)(resources.GetObject("razrabotalAlexeevAndrey.Image")));
            this.razrabotalAlexeevAndrey.Location = new System.Drawing.Point(-4, 12);
            this.razrabotalAlexeevAndrey.Name = "razrabotalAlexeevAndrey";
            this.razrabotalAlexeevAndrey.Size = new System.Drawing.Size(176, 171);
            this.razrabotalAlexeevAndrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.razrabotalAlexeevAndrey.TabIndex = 1;
            this.razrabotalAlexeevAndrey.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 194);
            this.Controls.Add(this.razrabotalAlexeevAndrey);
            this.Controls.Add(this.label1);
            this.Name = "About";
            this.Text = "О программе MatriXXX";
            ((System.ComponentModel.ISupportInitialize)(this.razrabotalAlexeevAndrey)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox razrabotalAlexeevAndrey;
	}
}