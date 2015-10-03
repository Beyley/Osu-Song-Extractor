namespace OsuSongExtractor
{
	partial class OsuExtractForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsuExtractForm));
			this.label1 = new System.Windows.Forms.Label();
			this.OsuFolderPathTextBox = new System.Windows.Forms.TextBox();
			this.BrowseOsuFolderButton = new System.Windows.Forms.Button();
			this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.ExtractFolderTextBox = new System.Windows.Forms.TextBox();
			this.BrowseSaveFolderButton = new System.Windows.Forms.Button();
			this.ExtractSongsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Osu! Songs Folder:";
			// 
			// OsuFolderPathTextBox
			// 
			this.OsuFolderPathTextBox.Location = new System.Drawing.Point(117, 13);
			this.OsuFolderPathTextBox.Name = "OsuFolderPathTextBox";
			this.OsuFolderPathTextBox.Size = new System.Drawing.Size(282, 20);
			this.OsuFolderPathTextBox.TabIndex = 1;
			// 
			// BrowseOsuFolderButton
			// 
			this.BrowseOsuFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BrowseOsuFolderButton.Location = new System.Drawing.Point(405, 12);
			this.BrowseOsuFolderButton.Name = "BrowseOsuFolderButton";
			this.BrowseOsuFolderButton.Size = new System.Drawing.Size(30, 21);
			this.BrowseOsuFolderButton.TabIndex = 2;
			this.BrowseOsuFolderButton.Text = "...";
			this.BrowseOsuFolderButton.UseVisualStyleBackColor = true;
			this.BrowseOsuFolderButton.Click += new System.EventHandler(this.BrowseOsuFolderButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Extract To Folder:";
			// 
			// ExtractFolderTextBox
			// 
			this.ExtractFolderTextBox.Location = new System.Drawing.Point(117, 40);
			this.ExtractFolderTextBox.Name = "ExtractFolderTextBox";
			this.ExtractFolderTextBox.Size = new System.Drawing.Size(282, 20);
			this.ExtractFolderTextBox.TabIndex = 4;
			// 
			// BrowseSaveFolderButton
			// 
			this.BrowseSaveFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BrowseSaveFolderButton.Location = new System.Drawing.Point(405, 39);
			this.BrowseSaveFolderButton.Name = "BrowseSaveFolderButton";
			this.BrowseSaveFolderButton.Size = new System.Drawing.Size(30, 21);
			this.BrowseSaveFolderButton.TabIndex = 5;
			this.BrowseSaveFolderButton.Text = "...";
			this.BrowseSaveFolderButton.UseVisualStyleBackColor = true;
			this.BrowseSaveFolderButton.Click += new System.EventHandler(this.BrowseSaveFolderButton_Click);
			// 
			// ExtractSongsButton
			// 
			this.ExtractSongsButton.Location = new System.Drawing.Point(12, 66);
			this.ExtractSongsButton.Name = "ExtractSongsButton";
			this.ExtractSongsButton.Size = new System.Drawing.Size(423, 23);
			this.ExtractSongsButton.TabIndex = 6;
			this.ExtractSongsButton.Text = "Extract That Shit";
			this.ExtractSongsButton.UseVisualStyleBackColor = true;
			this.ExtractSongsButton.Click += new System.EventHandler(this.ExtractSongsButton_Click);
			// 
			// OsuExtractForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 103);
			this.Controls.Add(this.ExtractSongsButton);
			this.Controls.Add(this.BrowseSaveFolderButton);
			this.Controls.Add(this.ExtractFolderTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BrowseOsuFolderButton);
			this.Controls.Add(this.OsuFolderPathTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "OsuExtractForm";
			this.Text = "Osu Song Extractor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox OsuFolderPathTextBox;
		private System.Windows.Forms.Button BrowseOsuFolderButton;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ExtractFolderTextBox;
		private System.Windows.Forms.Button BrowseSaveFolderButton;
		private System.Windows.Forms.Button ExtractSongsButton;
	}
}

