using StorygenCC.utils;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

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

        private void btbAddSection_Click(object sender, EventArgs e)
        {
            SectionWindow sectionForm = new SectionWindow();
            if(sectionForm.ShowDialog() == DialogResult.OK)
            {
                AddSection(sectionForm.section);
            }
        }

        public void AddSection(StoryboardSection section) => sectionsPanel.Items.Add(new ListViewItem(section.ConvertSectionToString()));

        private void btnRemoveSection_Click(object sender, EventArgs e)
        {
            if(sectionsPanel.SelectedItems.Count > 0)
                sectionsPanel.Items.RemoveAt(sectionsPanel.SelectedIndices[0]);
        }
    }
}