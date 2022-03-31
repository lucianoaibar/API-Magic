namespace APIMagic.Views {
	partial class FormProjectSelect {
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
			this.listViewProjects = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewProjects
			// 
			this.listViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewProjects.BackColor = System.Drawing.Color.Ivory;
			this.listViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listViewProjects.FullRowSelect = true;
			this.listViewProjects.GridLines = true;
			this.listViewProjects.HideSelection = false;
			this.listViewProjects.Location = new System.Drawing.Point(12, 12);
			this.listViewProjects.Name = "listViewProjects";
			this.listViewProjects.Size = new System.Drawing.Size(808, 352);
			this.listViewProjects.TabIndex = 0;
			this.listViewProjects.UseCompatibleStateImageBehavior = false;
			this.listViewProjects.View = System.Windows.Forms.View.Details;
			this.listViewProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProjects_MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Project";
			this.columnHeader1.Width = 271;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Website URL";
			this.columnHeader2.Width = 239;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "API base URL";
			this.columnHeader3.Width = 260;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonCancel.BackColor = System.Drawing.Color.Red;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.Color.White;
			this.buttonCancel.Location = new System.Drawing.Point(419, 377);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(120, 32);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonOk.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonOk.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.buttonOk.ForeColor = System.Drawing.Color.White;
			this.buttonOk.Location = new System.Drawing.Point(293, 377);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(120, 32);
			this.buttonOk.TabIndex = 5;
			this.buttonOk.Text = "Open";
			this.buttonOk.UseVisualStyleBackColor = false;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// FormProjectSelect
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(832, 421);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.listViewProjects);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormProjectSelect";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Projects";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProjectSelect_FormClosed);
			this.Shown += new System.EventHandler(this.FormProjectSelect_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listViewProjects;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
	}
}