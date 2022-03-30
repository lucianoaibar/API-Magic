namespace APIMagic.Views {
	partial class FormProjectSave {
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.ForeColor = System.Drawing.Color.Black;
			this.textBox1.Location = new System.Drawing.Point(137, 159);
			this.textBox1.MaxLength = 255;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(508, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.ForeColor = System.Drawing.Color.Black;
			this.textBox2.Location = new System.Drawing.Point(137, 187);
			this.textBox2.MaxLength = 2048;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(508, 22);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.ForeColor = System.Drawing.Color.Black;
			this.textBox3.Location = new System.Drawing.Point(137, 215);
			this.textBox3.MaxLength = 2048;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(508, 22);
			this.textBox3.TabIndex = 2;
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonOk.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonOk.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.buttonOk.ForeColor = System.Drawing.Color.White;
			this.buttonOk.Location = new System.Drawing.Point(238, 435);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(120, 32);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "Save";
			this.buttonOk.UseVisualStyleBackColor = false;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
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
			this.buttonCancel.Location = new System.Drawing.Point(364, 435);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(120, 32);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(65, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(90, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "URL:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(62, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "API URL:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(715, 425);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.textBox3);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(707, 396);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(707, 396);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Redirections";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// FormProjectSave
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(723, 479);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormProjectSave";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}