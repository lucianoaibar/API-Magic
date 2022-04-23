namespace APIMagic.Views {
    partial class FormMain {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.Menu_Project = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_ManageProjects = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Menu_ProjectsReload = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Quit = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.buttonHome = new System.Windows.Forms.ToolStripButton();
			this.toolStripTextBoxURL = new System.Windows.Forms.ToolStripTextBox();
			this.butonOpenDevTools = new System.Windows.Forms.ToolStripButton();
			this.menuStripMain.SuspendLayout();
			this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
			this.toolStripContainerMain.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Project,
            this.Menu_Help});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(1384, 24);
			this.menuStripMain.TabIndex = 0;
			// 
			// Menu_Project
			// 
			this.Menu_Project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenProject,
            this.Menu_ManageProjects,
            this.toolStripSeparator1,
            this.Menu_ProjectsReload,
            this.Menu_Quit});
			this.Menu_Project.Name = "Menu_Project";
			this.Menu_Project.Size = new System.Drawing.Size(56, 20);
			this.Menu_Project.Text = "Project";
			// 
			// Menu_OpenProject
			// 
			this.Menu_OpenProject.Name = "Menu_OpenProject";
			this.Menu_OpenProject.Size = new System.Drawing.Size(171, 22);
			this.Menu_OpenProject.Text = "Open Project...";
			this.Menu_OpenProject.Click += new System.EventHandler(this.Menu_OpenProject_Click);
			// 
			// Menu_ManageProjects
			// 
			this.Menu_ManageProjects.Name = "Menu_ManageProjects";
			this.Menu_ManageProjects.Size = new System.Drawing.Size(171, 22);
			this.Menu_ManageProjects.Text = "Manage Projects...";
			this.Menu_ManageProjects.Click += new System.EventHandler(this.Menu_ManageProjects_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
			// 
			// Menu_ProjectsReload
			// 
			this.Menu_ProjectsReload.Name = "Menu_ProjectsReload";
			this.Menu_ProjectsReload.Size = new System.Drawing.Size(171, 22);
			this.Menu_ProjectsReload.Text = "Reload";
			this.Menu_ProjectsReload.Click += new System.EventHandler(this.Menu_ProjectsReload_Click);
			// 
			// Menu_Quit
			// 
			this.Menu_Quit.Name = "Menu_Quit";
			this.Menu_Quit.Size = new System.Drawing.Size(171, 22);
			this.Menu_Quit.Text = "Quit";
			this.Menu_Quit.Click += new System.EventHandler(this.Menu_Quit_Click);
			// 
			// Menu_Help
			// 
			this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_About});
			this.Menu_Help.Name = "Menu_Help";
			this.Menu_Help.Size = new System.Drawing.Size(44, 20);
			this.Menu_Help.Text = "Help";
			// 
			// Menu_About
			// 
			this.Menu_About.Name = "Menu_About";
			this.Menu_About.Size = new System.Drawing.Size(107, 22);
			this.Menu_About.Text = "About";
			this.Menu_About.Click += new System.EventHandler(this.Menu_About_Click);
			// 
			// toolStripContainerMain
			// 
			this.toolStripContainerMain.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainerMain.ContentPanel
			// 
			this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(1384, 712);
			this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainerMain.LeftToolStripPanelVisible = false;
			this.toolStripContainerMain.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainerMain.Name = "toolStripContainerMain";
			this.toolStripContainerMain.RightToolStripPanelVisible = false;
			this.toolStripContainerMain.Size = new System.Drawing.Size(1384, 737);
			this.toolStripContainerMain.TabIndex = 1;
			this.toolStripContainerMain.Text = "toolStripContainer1";
			// 
			// toolStripContainerMain.TopToolStripPanel
			// 
			this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripMain);
			// 
			// toolStripMain
			// 
			this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonHome,
            this.toolStripTextBoxURL,
            this.butonOpenDevTools});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(1384, 25);
			this.toolStripMain.Stretch = true;
			this.toolStripMain.TabIndex = 0;
			// 
			// buttonHome
			// 
			this.buttonHome.Image = global::APIMagic.Properties.Resources.home_16x16;
			this.buttonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonHome.Name = "buttonHome";
			this.buttonHome.Size = new System.Drawing.Size(60, 22);
			this.buttonHome.Text = "Home";
			this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
			// 
			// toolStripTextBoxURL
			// 
			this.toolStripTextBoxURL.BackColor = System.Drawing.Color.White;
			this.toolStripTextBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolStripTextBoxURL.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBoxURL.ForeColor = System.Drawing.Color.Black;
			this.toolStripTextBoxURL.Name = "toolStripTextBoxURL";
			this.toolStripTextBoxURL.Size = new System.Drawing.Size(600, 25);
			this.toolStripTextBoxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxURL_KeyDown);
			// 
			// butonOpenDevTools
			// 
			this.butonOpenDevTools.Image = ((System.Drawing.Image)(resources.GetObject("butonOpenDevTools.Image")));
			this.butonOpenDevTools.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.butonOpenDevTools.Name = "butonOpenDevTools";
			this.butonOpenDevTools.Size = new System.Drawing.Size(77, 22);
			this.butonOpenDevTools.Text = "Dev Tools";
			this.butonOpenDevTools.Click += new System.EventHandler(this.butonOpenDevTools_Click);
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1384, 761);
			this.Controls.Add(this.toolStripContainerMain);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
			this.toolStripContainerMain.ResumeLayout(false);
			this.toolStripContainerMain.PerformLayout();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem Menu_Project;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem Menu_Quit;
		private System.Windows.Forms.ToolStripMenuItem Menu_Help;
		private System.Windows.Forms.ToolStripMenuItem Menu_About;
		private System.Windows.Forms.ToolStripMenuItem Menu_OpenProject;
		private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
		private System.Windows.Forms.ToolStrip toolStripMain;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxURL;
		private System.Windows.Forms.ToolStripMenuItem Menu_ManageProjects;
		private System.Windows.Forms.ToolStripButton butonOpenDevTools;
		private System.Windows.Forms.ToolStripButton buttonHome;
		private System.Windows.Forms.ToolStripMenuItem Menu_ProjectsReload;
	}
}

