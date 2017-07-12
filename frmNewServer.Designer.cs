namespace rsWoW_Tool
{
	partial class frmNewServer
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
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.txtRealmList = new System.Windows.Forms.TextBox();
			this.lblServerName = new System.Windows.Forms.Label();
			this.lblRealmlist = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.combVersion = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOpen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(79, 12);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(194, 20);
			this.txtServerName.TabIndex = 0;
			// 
			// txtRealmList
			// 
			this.txtRealmList.Location = new System.Drawing.Point(79, 38);
			this.txtRealmList.Name = "txtRealmList";
			this.txtRealmList.Size = new System.Drawing.Size(194, 20);
			this.txtRealmList.TabIndex = 1;
			// 
			// lblServerName
			// 
			this.lblServerName.AutoSize = true;
			this.lblServerName.Location = new System.Drawing.Point(12, 15);
			this.lblServerName.Name = "lblServerName";
			this.lblServerName.Size = new System.Drawing.Size(38, 13);
			this.lblServerName.TabIndex = 2;
			this.lblServerName.Text = "Server";
			// 
			// lblRealmlist
			// 
			this.lblRealmlist.AutoSize = true;
			this.lblRealmlist.Location = new System.Drawing.Point(12, 41);
			this.lblRealmlist.Name = "lblRealmlist";
			this.lblRealmlist.Size = new System.Drawing.Size(49, 13);
			this.lblRealmlist.TabIndex = 3;
			this.lblRealmlist.Text = "Realmlist";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(198, 125);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// combVersion
			// 
			this.combVersion.FormattingEnabled = true;
			this.combVersion.Items.AddRange(new object[] {
            "3.3.5a",
            "4.3.4"});
			this.combVersion.Location = new System.Drawing.Point(79, 90);
			this.combVersion.Name = "combVersion";
			this.combVersion.Size = new System.Drawing.Size(90, 21);
			this.combVersion.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Version";
			// 
			// txtPath
			// 
			this.txtPath.Enabled = false;
			this.txtPath.Location = new System.Drawing.Point(79, 64);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(194, 20);
			this.txtPath.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Installation";
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(198, 90);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 9;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// frmNewServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 160);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.combVersion);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblRealmlist);
			this.Controls.Add(this.lblServerName);
			this.Controls.Add(this.txtRealmList);
			this.Controls.Add(this.txtServerName);
			this.Name = "frmNewServer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add new Server";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.TextBox txtRealmList;
		private System.Windows.Forms.Label lblServerName;
		private System.Windows.Forms.Label lblRealmlist;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox combVersion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOpen;
	}
}