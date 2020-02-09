namespace StorygenCC
{
    partial class Window
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer

        private void InitializeComponent()
        {
            this.loadBeatmap = new System.Windows.Forms.Button();
            this.loadProject = new System.Windows.Forms.Button();
            this.loadedBeatmapPath = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sectionsPanel = new System.Windows.Forms.ListView();
            this.sectionStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionSubTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionBGID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionBGM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionTID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btbAddSection = new System.Windows.Forms.Button();
            this.btnRemoveSection = new System.Windows.Forms.Button();
            this.btnModifySection = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.titleSections = new System.Windows.Forms.Label();
            this.sectionsPanelContainer = new System.Windows.Forms.Panel();
            this.subTitle = new System.Windows.Forms.Label();
            this.sectionsPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadBeatmap
            // 
            this.loadBeatmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.loadBeatmap.FlatAppearance.BorderSize = 0;
            this.loadBeatmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBeatmap.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBeatmap.ForeColor = System.Drawing.Color.White;
            this.loadBeatmap.Location = new System.Drawing.Point(9, 10);
            this.loadBeatmap.Margin = new System.Windows.Forms.Padding(0);
            this.loadBeatmap.Name = "loadBeatmap";
            this.loadBeatmap.Size = new System.Drawing.Size(130, 30);
            this.loadBeatmap.TabIndex = 0;
            this.loadBeatmap.Text = "LOAD BEATMAP";
            this.loadBeatmap.UseVisualStyleBackColor = false;
            this.loadBeatmap.Click += new System.EventHandler(this.loadBeatmap_Click);
            // 
            // loadProject
            // 
            this.loadProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.loadProject.FlatAppearance.BorderSize = 0;
            this.loadProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadProject.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadProject.ForeColor = System.Drawing.Color.White;
            this.loadProject.Location = new System.Drawing.Point(150, 10);
            this.loadProject.Name = "loadProject";
            this.loadProject.Size = new System.Drawing.Size(130, 30);
            this.loadProject.TabIndex = 1;
            this.loadProject.Text = "LOAD PROJECT";
            this.loadProject.UseVisualStyleBackColor = false;
            this.loadProject.Click += new System.EventHandler(this.loadProject_Click);
            // 
            // loadedBeatmapPath
            // 
            this.loadedBeatmapPath.AutoSize = true;
            this.loadedBeatmapPath.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedBeatmapPath.ForeColor = System.Drawing.Color.DimGray;
            this.loadedBeatmapPath.Location = new System.Drawing.Point(9, 40);
            this.loadedBeatmapPath.Margin = new System.Windows.Forms.Padding(0);
            this.loadedBeatmapPath.Name = "loadedBeatmapPath";
            this.loadedBeatmapPath.Size = new System.Drawing.Size(0, 16);
            this.loadedBeatmapPath.TabIndex = 2;
            this.loadedBeatmapPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(692, 364);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(71, 30);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // title
            // 
            this.title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.title.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.title.Location = new System.Drawing.Point(680, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(95, 23);
            this.title.TabIndex = 4;
            this.title.Text = "storygenCC";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sectionsPanel
            // 
            this.sectionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sectionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionsPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sectionStartTime,
            this.sectionEndTime,
            this.sectionTitle,
            this.sectionSubTitle,
            this.sectionBGID,
            this.sectionBGM,
            this.sectionTID});
            this.sectionsPanel.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionsPanel.ForeColor = System.Drawing.Color.White;
            this.sectionsPanel.FullRowSelect = true;
            this.sectionsPanel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.sectionsPanel.HideSelection = false;
            this.sectionsPanel.Location = new System.Drawing.Point(0, 22);
            this.sectionsPanel.Name = "sectionsPanel";
            this.sectionsPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sectionsPanel.Size = new System.Drawing.Size(763, 336);
            this.sectionsPanel.TabIndex = 5;
            this.sectionsPanel.UseCompatibleStateImageBehavior = false;
            this.sectionsPanel.View = System.Windows.Forms.View.Details;
            // 
            // sectionStartTime
            // 
            this.sectionStartTime.Text = "Start Time";
            // 
            // sectionEndTime
            // 
            this.sectionEndTime.Text = "End Time";
            // 
            // sectionTitle
            // 
            this.sectionTitle.Text = "Title";
            this.sectionTitle.Width = 150;
            // 
            // sectionSubTitle
            // 
            this.sectionSubTitle.Text = "Sub-Title";
            this.sectionSubTitle.Width = 150;
            // 
            // sectionBGID
            // 
            this.sectionBGID.Text = "BGID";
            this.sectionBGID.Width = 35;
            // 
            // sectionBGM
            // 
            this.sectionBGM.Text = "BGM";
            this.sectionBGM.Width = 35;
            // 
            // sectionTID
            // 
            this.sectionTID.Text = "TID";
            this.sectionTID.Width = 35;
            // 
            // btbAddSection
            // 
            this.btbAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(30)))));
            this.btbAddSection.FlatAppearance.BorderSize = 0;
            this.btbAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbAddSection.Location = new System.Drawing.Point(743, 0);
            this.btbAddSection.Name = "btbAddSection";
            this.btbAddSection.Size = new System.Drawing.Size(20, 20);
            this.btbAddSection.TabIndex = 6;
            this.btbAddSection.UseVisualStyleBackColor = false;
            // 
            // btnRemoveSection
            // 
            this.btnRemoveSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnRemoveSection.FlatAppearance.BorderSize = 0;
            this.btnRemoveSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSection.Location = new System.Drawing.Point(713, 0);
            this.btnRemoveSection.Name = "btnRemoveSection";
            this.btnRemoveSection.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveSection.TabIndex = 7;
            this.btnRemoveSection.UseVisualStyleBackColor = false;
            // 
            // btnModifySection
            // 
            this.btnModifySection.BackColor = System.Drawing.Color.White;
            this.btnModifySection.FlatAppearance.BorderSize = 0;
            this.btnModifySection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifySection.Location = new System.Drawing.Point(683, 0);
            this.btnModifySection.Name = "btnModifySection";
            this.btnModifySection.Size = new System.Drawing.Size(20, 20);
            this.btnModifySection.TabIndex = 8;
            this.btnModifySection.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(556, 364);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(130, 30);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.Text = "GENERAL CONFIG";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // titleSections
            // 
            this.titleSections.AutoSize = true;
            this.titleSections.BackColor = System.Drawing.Color.Transparent;
            this.titleSections.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSections.ForeColor = System.Drawing.Color.White;
            this.titleSections.Location = new System.Drawing.Point(0, 0);
            this.titleSections.Margin = new System.Windows.Forms.Padding(0);
            this.titleSections.Name = "titleSections";
            this.titleSections.Size = new System.Drawing.Size(114, 19);
            this.titleSections.TabIndex = 10;
            this.titleSections.Text = "Storyboard Sections";
            this.titleSections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sectionsPanelContainer
            // 
            this.sectionsPanelContainer.Controls.Add(this.btnConfig);
            this.sectionsPanelContainer.Controls.Add(this.btnExport);
            this.sectionsPanelContainer.Controls.Add(this.titleSections);
            this.sectionsPanelContainer.Controls.Add(this.sectionsPanel);
            this.sectionsPanelContainer.Controls.Add(this.btbAddSection);
            this.sectionsPanelContainer.Controls.Add(this.btnRemoveSection);
            this.sectionsPanelContainer.Controls.Add(this.btnModifySection);
            this.sectionsPanelContainer.Location = new System.Drawing.Point(12, 59);
            this.sectionsPanelContainer.Name = "sectionsPanelContainer";
            this.sectionsPanelContainer.Size = new System.Drawing.Size(763, 394);
            this.sectionsPanelContainer.TabIndex = 11;
            this.sectionsPanelContainer.Visible = false;
            // 
            // subTitle
            // 
            this.subTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.subTitle.AutoSize = true;
            this.subTitle.BackColor = System.Drawing.Color.Transparent;
            this.subTitle.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.subTitle.Location = new System.Drawing.Point(734, 32);
            this.subTitle.Margin = new System.Windows.Forms.Padding(0);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(41, 16);
            this.subTitle.TabIndex = 12;
            this.subTitle.Text = "by PoNo";
            this.subTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.loadedBeatmapPath);
            this.Controls.Add(this.loadProject);
            this.Controls.Add(this.loadBeatmap);
            this.Controls.Add(this.sectionsPanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Window";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "storygenCC";
            this.sectionsPanelContainer.ResumeLayout(false);
            this.sectionsPanelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBeatmap;
        private System.Windows.Forms.Button loadProject;
        private System.Windows.Forms.Label loadedBeatmapPath;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label title;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader sectionEndTime;
        private System.Windows.Forms.ColumnHeader sectionTitle;
        private System.Windows.Forms.ColumnHeader sectionSubTitle;
        private System.Windows.Forms.ColumnHeader sectionBGID;
        private System.Windows.Forms.ColumnHeader sectionBGM;
        private System.Windows.Forms.ColumnHeader sectionTID;
        private System.Windows.Forms.ColumnHeader sectionStartTime;
        private System.Windows.Forms.ListView sectionsPanel;
        private System.Windows.Forms.Button btbAddSection;
        private System.Windows.Forms.Button btnRemoveSection;
        private System.Windows.Forms.Button btnModifySection;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label titleSections;
        private System.Windows.Forms.Panel sectionsPanelContainer;
        private System.Windows.Forms.Label subTitle;
    }
}