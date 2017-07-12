namespace rsWoW_Tool
{
	partial class frmStart
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.listServerlist = new System.Windows.Forms.ListView();
			this.columName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columRealmlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnStart = new System.Windows.Forms.Button();
			this.notifiyIconTaskbar = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(7, 226);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(27, 26);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(40, 226);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(27, 26);
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "-";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// listServerlist
			// 
			this.listServerlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columName,
            this.columVersion,
            this.columRealmlist});
			this.listServerlist.FullRowSelect = true;
			this.listServerlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listServerlist.LabelWrap = false;
			this.listServerlist.Location = new System.Drawing.Point(7, 12);
			this.listServerlist.MultiSelect = false;
			this.listServerlist.Name = "listServerlist";
			this.listServerlist.Scrollable = false;
			this.listServerlist.Size = new System.Drawing.Size(261, 208);
			this.listServerlist.TabIndex = 3;
			this.listServerlist.UseCompatibleStateImageBehavior = false;
			this.listServerlist.View = System.Windows.Forms.View.Details;
			// 
			// columName
			// 
			this.columName.Text = "Server";
			this.columName.Width = 80;
			// 
			// columVersion
			// 
			this.columVersion.Text = "Version";
			this.columVersion.Width = 54;
			// 
			// columRealmlist
			// 
			this.columRealmlist.Text = "Realmlist";
			this.columRealmlist.Width = 119;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(193, 229);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// notifiyIconTaskbar
			// 
			this.notifiyIconTaskbar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifiyIconTaskbar.Icon")));
			this.notifiyIconTaskbar.Text = "Taskbar";
			this.notifiyIconTaskbar.Visible = true;
			this.notifiyIconTaskbar.DoubleClick += new System.EventHandler(this.notifiyIconTaskbar_DoubleClick);
			// 
			// frmStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(278, 259);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.listServerlist);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmStart";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WoW-Startup Tool";
			this.Load += new System.EventHandler(this.frmStart_Load);
			this.Resize += new System.EventHandler(this.frmStart_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.ListView listServerlist;
		private System.Windows.Forms.ColumnHeader columName;
		private System.Windows.Forms.ColumnHeader columVersion;
		private System.Windows.Forms.ColumnHeader columRealmlist;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NotifyIcon notifiyIconTaskbar;
	}
}

