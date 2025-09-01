namespace DVLD.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueDrivingLicenseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicenseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowPersonHistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbFilterBy = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtFilterValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddNewApplication = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMenu,
            this.toolStripSeparator2,
            this.EditMenu,
            this.DeleteMenu,
            this.toolStripSeparator3,
            this.CancelMenu,
            this.toolStripSeparator4,
            this.ScheduleTestMenue,
            this.toolStripSeparator5,
            this.IssueDrivingLicenseMenu,
            this.toolStripSeparator6,
            this.ShowLicenseMenu,
            this.toolStripSeparator7,
            this.ShowPersonHistoryMenu,
            this.toolStripSeparator1});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(345, 350);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMenu.Image = global::DVLD.Properties.Resources.clipboard_user;
            this.ShowMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(344, 38);
            this.ShowMenu.Text = "Show Application Details";
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(341, 6);
            // 
            // EditMenu
            // 
            this.EditMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMenu.Image = global::DVLD.Properties.Resources.resume;
            this.EditMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(344, 38);
            this.EditMenu.Text = "Edit Application";
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMenu.Image = global::DVLD.Properties.Resources.delete__1_;
            this.DeleteMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(344, 38);
            this.DeleteMenu.Text = "Delete Application";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(341, 6);
            // 
            // CancelMenu
            // 
            this.CancelMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelMenu.Image = global::DVLD.Properties.Resources.cancelled;
            this.CancelMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelMenu.Name = "CancelMenu";
            this.CancelMenu.Size = new System.Drawing.Size(344, 38);
            this.CancelMenu.Text = "Cancel Application";
            this.CancelMenu.Click += new System.EventHandler(this.CancelMenu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(341, 6);
            // 
            // ScheduleTestMenue
            // 
            this.ScheduleTestMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScheduleVisionTest,
            this.ScheduleWrittenTest,
            this.ScheduleStreetTest});
            this.ScheduleTestMenue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleTestMenue.Image = global::DVLD.Properties.Resources.examination;
            this.ScheduleTestMenue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleTestMenue.Name = "ScheduleTestMenue";
            this.ScheduleTestMenue.Size = new System.Drawing.Size(344, 38);
            this.ScheduleTestMenue.Text = "Schedule Test";
            // 
            // ScheduleVisionTest
            // 
            this.ScheduleVisionTest.Image = global::DVLD.Properties.Resources.eye_scan;
            this.ScheduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleVisionTest.Name = "ScheduleVisionTest";
            this.ScheduleVisionTest.Size = new System.Drawing.Size(271, 38);
            this.ScheduleVisionTest.Text = "Schedule Vision Test";
            this.ScheduleVisionTest.Click += new System.EventHandler(this.ScheduleVisionTest_Click);
            // 
            // ScheduleWrittenTest
            // 
            this.ScheduleWrittenTest.Image = global::DVLD.Properties.Resources.writing;
            this.ScheduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleWrittenTest.Name = "ScheduleWrittenTest";
            this.ScheduleWrittenTest.Size = new System.Drawing.Size(271, 38);
            this.ScheduleWrittenTest.Text = "Schedule Written Test";
            this.ScheduleWrittenTest.Click += new System.EventHandler(this.ScheduleWrittenTest_Click);
            // 
            // ScheduleStreetTest
            // 
            this.ScheduleStreetTest.Image = global::DVLD.Properties.Resources.driving_school;
            this.ScheduleStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleStreetTest.Name = "ScheduleStreetTest";
            this.ScheduleStreetTest.Size = new System.Drawing.Size(271, 38);
            this.ScheduleStreetTest.Text = "Schedule Street Test";
            this.ScheduleStreetTest.Click += new System.EventHandler(this.ScheduleStreetTest_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(341, 6);
            // 
            // IssueDrivingLicenseMenu
            // 
            this.IssueDrivingLicenseMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDrivingLicenseMenu.Image = global::DVLD.Properties.Resources.credit;
            this.IssueDrivingLicenseMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueDrivingLicenseMenu.Name = "IssueDrivingLicenseMenu";
            this.IssueDrivingLicenseMenu.Size = new System.Drawing.Size(344, 38);
            this.IssueDrivingLicenseMenu.Text = "Issue Driving License (First Time)";
            this.IssueDrivingLicenseMenu.Click += new System.EventHandler(this.IssueDrivingLicenseMenu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(341, 6);
            // 
            // ShowLicenseMenu
            // 
            this.ShowLicenseMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseMenu.Image = global::DVLD.Properties.Resources.license;
            this.ShowLicenseMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseMenu.Name = "ShowLicenseMenu";
            this.ShowLicenseMenu.Size = new System.Drawing.Size(344, 38);
            this.ShowLicenseMenu.Text = "Show License";
            this.ShowLicenseMenu.Click += new System.EventHandler(this.ShowLicenseMenu_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(341, 6);
            // 
            // ShowPersonHistoryMenu
            // 
            this.ShowPersonHistoryMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPersonHistoryMenu.Image = global::DVLD.Properties.Resources.history;
            this.ShowPersonHistoryMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonHistoryMenu.Name = "ShowPersonHistoryMenu";
            this.ShowPersonHistoryMenu.Size = new System.Drawing.Size(344, 38);
            this.ShowPersonHistoryMenu.Text = "Show License Person Histroy";
            this.ShowPersonHistoryMenu.Click += new System.EventHandler(this.ShowPersonHistoryMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(341, 6);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1290, 682);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 49);
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.TabIndex = 117;
            this.btnClose.Values.Image = global::DVLD.Properties.Resources.cancel;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownWidth = 166;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(116, 369);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(221, 25);
            this.cbFilterBy.TabIndex = 116;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(346, 369);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(219, 27);
            this.txtFilterValue.TabIndex = 115;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Location = new System.Drawing.Point(1318, 306);
            this.btnAddNewApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(98, 85);
            this.btnAddNewApplication.TabIndex = 114;
            this.btnAddNewApplication.Values.Image = global::DVLD.Properties.Resources.add;
            this.btnAddNewApplication.Values.Text = "";
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 248);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1405, 68);
            this.lblTitle.TabIndex = 113;
            this.lblTitle.Text = "Local Driving License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(144, 696);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(28, 25);
            this.lblRecordsCount.TabIndex = 112;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 111;
            this.label2.Text = "#Records :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.add_a_management_or__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(598, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            this.dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsApplications;
            this.dgvLocalDrivingLicenseApplications.Location = new System.Drawing.Point(12, 401);
            this.dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            this.dgvLocalDrivingLicenseApplications.RowHeadersWidth = 51;
            this.dgvLocalDrivingLicenseApplications.RowTemplate.Height = 24;
            this.dgvLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1404, 274);
            this.dgvLocalDrivingLicenseApplications.TabIndex = 118;
            // 
            // frmListLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 743);
            this.Controls.Add(this.dgvLocalDrivingLicenseApplications);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListLocalDrivingLicenseApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applicaitons";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicesnseApplications_Load);
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbFilterBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFilterValue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddNewApplication;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem ShowMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu;
        private System.Windows.Forms.ToolStripMenuItem CancelMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonHistoryMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestMenue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingLicenseMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem ScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleStreetTest;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApplications;
    }
}