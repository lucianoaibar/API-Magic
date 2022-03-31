namespace APIMagic.Views {
	partial class FormProjects {
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
			this.toolStripContainerProjects = new System.Windows.Forms.ToolStripContainer();
			this.listViewProjects = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStripProjects = new System.Windows.Forms.ToolStrip();
			this.buttonNew = new System.Windows.Forms.ToolStripButton();
			this.buttonEdit = new System.Windows.Forms.ToolStripButton();
			this.buttonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonReload = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainerProjects.ContentPanel.SuspendLayout();
			this.toolStripContainerProjects.TopToolStripPanel.SuspendLayout();
			this.toolStripContainerProjects.SuspendLayout();
			this.toolStripProjects.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainerProjects
			// 
			this.toolStripContainerProjects.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainerProjects.ContentPanel
			// 
			this.toolStripContainerProjects.ContentPanel.Controls.Add(this.listViewProjects);
			this.toolStripContainerProjects.ContentPanel.Size = new System.Drawing.Size(1017, 425);
			this.toolStripContainerProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainerProjects.LeftToolStripPanelVisible = false;
			this.toolStripContainerProjects.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainerProjects.Name = "toolStripContainerProjects";
			this.toolStripContainerProjects.RightToolStripPanelVisible = false;
			this.toolStripContainerProjects.Size = new System.Drawing.Size(1017, 450);
			this.toolStripContainerProjects.TabIndex = 0;
			this.toolStripContainerProjects.Text = "toolStripContainer1";
			// 
			// toolStripContainerProjects.TopToolStripPanel
			// 
			this.toolStripContainerProjects.TopToolStripPanel.Controls.Add(this.toolStripProjects);
			// 
			// listViewProjects
			// 
			this.listViewProjects.BackColor = System.Drawing.Color.Ivory;
			this.listViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProjects.ForeColor = System.Drawing.Color.Black;
			this.listViewProjects.FullRowSelect = true;
			this.listViewProjects.GridLines = true;
			this.listViewProjects.HideSelection = false;
			this.listViewProjects.Location = new System.Drawing.Point(0, 0);
			this.listViewProjects.Name = "listViewProjects";
			this.listViewProjects.Size = new System.Drawing.Size(1017, 425);
			this.listViewProjects.TabIndex = 0;
			this.listViewProjects.UseCompatibleStateImageBehavior = false;
			this.listViewProjects.View = System.Windows.Forms.View.Details;
			this.listViewProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProjects_MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 228;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "URL";
			this.columnHeader2.Width = 372;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "API URL";
			this.columnHeader3.Width = 342;
			// 
			// toolStripProjects
			// 
			this.toolStripProjects.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripProjects.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNew,
            this.buttonEdit,
            this.buttonDelete,
            this.toolStripSeparator2,
            this.buttonReload});
			this.toolStripProjects.Location = new System.Drawing.Point(0, 0);
			this.toolStripProjects.Name = "toolStripProjects";
			this.toolStripProjects.Size = new System.Drawing.Size(1017, 25);
			this.toolStripProjects.Stretch = true;
			this.toolStripProjects.TabIndex = 0;
			// 
			// buttonNew
			// 
			this.buttonNew.Image = global::APIMagic.Properties.Resources.agregar_16x16;
			this.buttonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(51, 22);
			this.buttonNew.Text = "New";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Image = global::APIMagic.Properties.Resources.editar_16x16;
			this.buttonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(47, 22);
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Image = global::APIMagic.Properties.Resources.eliminar_16x16;
			this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(60, 22);
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonReload
			// 
			this.buttonReload.Image = global::APIMagic.Properties.Resources.refresh_16x16;
			this.buttonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonReload.Name = "buttonReload";
			this.buttonReload.Size = new System.Drawing.Size(63, 22);
			this.buttonReload.Text = "Reload";
			this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
			// 
			// FormProjects
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1017, 450);
			this.Controls.Add(this.toolStripContainerProjects);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.MinimizeBox = false;
			this.Name = "FormProjects";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Open Project";
			this.Shown += new System.EventHandler(this.FormProjectSelect_Shown);
			this.toolStripContainerProjects.ContentPanel.ResumeLayout(false);
			this.toolStripContainerProjects.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainerProjects.TopToolStripPanel.PerformLayout();
			this.toolStripContainerProjects.ResumeLayout(false);
			this.toolStripContainerProjects.PerformLayout();
			this.toolStripProjects.ResumeLayout(false);
			this.toolStripProjects.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainerProjects;
		private System.Windows.Forms.ListView listViewProjects;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ToolStrip toolStripProjects;
		private System.Windows.Forms.ToolStripButton buttonReload;
		private System.Windows.Forms.ToolStripButton buttonNew;
		private System.Windows.Forms.ToolStripButton buttonEdit;
		private System.Windows.Forms.ToolStripButton buttonDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}