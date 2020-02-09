using System;
using System.IO;
using System.Windows.Forms;

namespace StorygenCC
{
    public partial class Window : Form
    {
        private string mapsetPath;
        private string filePath;

        public Window()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void loadProject_Click(object sender, EventArgs e)
        {
            
        }

        private void loadBeatmap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "osu|*.osu";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                mapsetPath = new FileInfo(filePath).Directory.FullName;
                loadedBeatmapPath.Text = $"Loaded beatmap: {mapsetPath}";
                sectionsPanelContainer.Visible = true;
            }
        }
    }
}