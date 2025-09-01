namespace DVLD.Applications.International_License
{
    partial class frmListInternationalLicenseApplication
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
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbFilterBy = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtFilterValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddNewApplication = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInternationalLicensesRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonHistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cbIsReleased = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterBy)).BeginInit();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsReleased)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(783, 684);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 49);
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.TabIndex = 127;
            this.btnClose.Values.Image = global::DVLD.Properties.Resources.cancel;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownWidth = 166;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(124, 369);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(221, 25);
            this.cbFilterBy.TabIndex = 126;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(354, 369);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(219, 27);
            this.txtFilterValue.TabIndex = 125;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Location = new System.Drawing.Point(812, 309);
            this.btnAddNewApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(98, 85);
            this.btnAddNewApplication.TabIndex = 124;
            this.btnAddNewApplication.Values.Image = global::DVLD.Properties.Resources.add;
            this.btnAddNewApplication.Values.Text = "";
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(13, 248);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(898, 68);
            this.lblTitle.TabIndex = 123;
            this.lblTitle.Text = "International License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInternationalLicensesRecords
            // 
            this.lblInternationalLicensesRecords.AutoSize = true;
            this.lblInternationalLicensesRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesRecords.Location = new System.Drawing.Point(152, 696);
            this.lblInternationalLicensesRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            this.lblInternationalLicensesRecords.Size = new System.Drawing.Size(28, 25);
            this.lblInternationalLicensesRecords.TabIndex = 122;
            this.lblInternationalLicensesRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 121;
            this.label2.Text = "#Records :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 120;
            this.label1.Text = "Filter By:";
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMenu,
            this.ShowLicenseMenu,
            this.ShowPersonHistoryMenu});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(314, 118);
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMenu.Image = global::DVLD.Properties.Resources.clipboard_user;
            this.ShowMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(313, 38);
            this.ShowMenu.Text = "Show Person Details";
            this.ShowMenu.Click += new System.EventHandler(this.PesonDetailsToolStripMenuItem_Click);
            // 
            // ShowLicenseMenu
            // 
            this.ShowLicenseMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseMenu.Image = global::DVLD.Properties.Resources.license;
            this.ShowLicenseMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseMenu.Name = "ShowLicenseMenu";
            this.ShowLicenseMenu.Size = new System.Drawing.Size(313, 38);
            this.ShowLicenseMenu.Text = "Show License Details";
            this.ShowLicenseMenu.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // ShowPersonHistoryMenu
            // 
            this.ShowPersonHistoryMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPersonHistoryMenu.Image = global::DVLD.Properties.Resources.history;
            this.ShowPersonHistoryMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonHistoryMenu.Name = "ShowPersonHistoryMenu";
            this.ShowPersonHistoryMenu.Size = new System.Drawing.Size(313, 38);
            this.ShowPersonHistoryMenu.Text = "Show License Person Histroy";
            this.ShowPersonHistoryMenu.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Manage_International1;
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToResizeColumns = false;
            this.dgvInternationalLicenses.AllowUserToResizeRows = false;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsApplications;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(12, 403);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.RowHeadersWidth = 51;
            this.dgvInternationalLicenses.RowTemplate.Height = 24;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(899, 274);
            this.dgvInternationalLicenses.TabIndex = 128;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.DropDownWidth = 97;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(354, 370);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(97, 25);
            this.cbIsReleased.TabIndex = 129;
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // frmListInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 742);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.dgvInternationalLicenses);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInternationalLicensesRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListInternationalLicenseApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International License Applications";
            this.Load += new System.EventHandler(this.frmListInternationalLicesnseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterBy)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsReleased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbFilterBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFilterValue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddNewApplication;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonHistoryMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ShowMenu;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbIsReleased;
    }
}