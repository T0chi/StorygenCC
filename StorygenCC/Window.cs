using storygen;
using StorygenCC.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StorygenCC
{
    public partial class Window : Form
    {
        private string mapsetPath;
        private string filePath;
        private List<StoryboardSection> sections = new List<StoryboardSection>();

        public Window()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportStoryboard();
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
                mapsetPath = new FileInfo(filePath).Directory.FullName + "\\";
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

        public void AddSection(StoryboardSection section)
        {
            sectionsPanel.Items.Add(new ListViewItem(section.ConvertSectionToString()));
            sections.Add(section);
        }

        private void btnRemoveSection_Click(object sender, EventArgs e)
        {
            if(sectionsPanel.SelectedItems.Count > 0)
                sectionsPanel.Items.RemoveAt(sectionsPanel.SelectedIndices[0]);
        }

        private void ExportStoryboard()
        {
            Storyboard storyboard = new Storyboard(mapsetPath, sections);
            storyboard.Export();
        }
    }
}