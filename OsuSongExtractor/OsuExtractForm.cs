using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace OsuSongExtractor
{
	public partial class OsuExtractForm : Form
	{
		public OsuExtractForm()
		{
			InitializeComponent();
		}

		public List<string> SkinSounds = new List<string>(new string[]
		{
			"readys",
			"count3s",
			"count2s",
			"count1s",
			"gos",
			"comboburst",
			"combobreak",
			"sectionpass",
			"sectionfail",
			"failsound",
			"applause",
			"drum-hitnormal",
			"drum-hitclap",
			"drum-hitfinish",
			"drum-hitwhistle",
			"drum-sliderslide",
			"drum-slidertick",
			"drum-sliderwhistle",
			"normal-hitnormal",
			"normal-hitclap",
			"normal-hitfinish",
			"normal-hitwhistle",
			"normal-sliderslide",
			"normal-slidertick",
			"normal-sliderwhistle",
			"soft-hitnormal",
			"soft-hitclap",
			"soft-hitfinish",
			"soft-hitwhistle",
			"soft-sliderslide",
			"soft-slidertick",
			"soft-sliderwhistle",
			"taiko-drum-hitnormal",
			"taiko-drum-hitclap",
			"taiko-drum-hitfinish",
			"taiko-drum-hitwhistle",
			"taiko-normal-hitnormal",
			"taiko-normal-hitclap",
			"taiko-normal-hitfinish",
			"taiko-normal-hitwhistle",
			"taiko-soft-hitnormal",
			"taiko-soft-hitclap",
			"taiko-soft-hitfinish",
			"taiko-soft-hitwhistle",
			"spinnerspin",
			"spinnerbonus"
		});

		private void ExtractSongsButton_Click(object sender, EventArgs args)
		{
			try
			{
				ExtractSongsButton.Enabled = false;

				DirectoryInfo songFolder = new DirectoryInfo(OsuFolderPathTextBox.Text);
				DirectoryInfo newSongFolder = new DirectoryInfo(ExtractFolderTextBox.Text);

				DirectoryInfo[] subFolders = songFolder.GetDirectories();
				foreach (DirectoryInfo di in subFolders)
				{
					FileInfo[] subFiles = di.GetFiles("*.mp3");
					foreach (FileInfo fi in subFiles)
					{
						Debug.WriteLine("Checking file: " + fi.Name);
						if (!SkinSounds.Contains(fi.Name.Substring(0, fi.Name.Length - 4)))
						{
							Debug.WriteLine("Check passed. Substring: : " + fi.Name.Substring(0, fi.Name.Length - 4));
							string newFilePath = ExtractFolderTextBox.Text + @"\" + fi.Name;
							if (File.Exists(newFilePath))
							{
								File.Delete(newFilePath);
							}
							fi.CopyTo(newFilePath);
						}
						else
						{
							Debug.WriteLine("Check failed, not copying file: " + fi.Name);
						}
					}
				}

				MessageBox.Show(this, "Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
			catch (FileNotFoundException fnfe)
			{
				MessageBox.Show("A FileNotFoundException occured:\n\r" + fnfe);
			}
			catch (DirectoryNotFoundException dnfe)
			{
				MessageBox.Show("A DirectoryNotFoundException occured:\n\r" + dnfe);
			}
			catch (IOException ioe)
			{
				MessageBox.Show("An IOException occured:\n\r" + ioe);
			}
			catch (Exception e)
			{
				MessageBox.Show("An Exception occured:\n\r" + e);
			}
			finally
			{

			}
			ExtractSongsButton.Enabled = true;
		}

		private void BrowseOsuFolderButton_Click(object sender, EventArgs e)
		{
			FolderBrowser.ShowNewFolderButton = false;
			FolderBrowser.ShowDialog(this);

			string path = FolderBrowser.SelectedPath;

			if (Directory.Exists(path))
			{
				OsuFolderPathTextBox.Text = path;
			}
			else
			{
				DialogResult dr = MessageBox.Show(this, "That path doesnt exist!", "Uh-oh!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				if (dr == DialogResult.Retry)
				{
					BrowseOsuFolderButton.PerformClick();
				}
			}
		}

		private void BrowseSaveFolderButton_Click(object sender, EventArgs e)
		{
			FolderBrowser.ShowNewFolderButton = true;
			FolderBrowser.ShowDialog(this);

			string path = FolderBrowser.SelectedPath;

			if (Directory.Exists(path))
			{
				ExtractFolderTextBox.Text = path;
			}
			else
			{
				DialogResult dr = MessageBox.Show(this, "That path doesnt exist!", "Uh-oh!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				if (dr == DialogResult.Retry)
				{
					BrowseSaveFolderButton.PerformClick();
				}
			}
		}
	}
}
