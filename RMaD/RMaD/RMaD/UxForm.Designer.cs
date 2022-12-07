﻿using RMaD.Classes;

namespace RMaD
{
    partial class UxForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxForm));
            this.pnlShipments = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewShipment = new System.Windows.Forms.DataGridView();
            this.btnAddShipment = new System.Windows.Forms.Button();
            this.lblShipments = new System.Windows.Forms.Label();
            this.pnlGroups = new System.Windows.Forms.Panel();
            this.lblGroups = new System.Windows.Forms.Label();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReports = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblSettins = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnSettingsMenu = new System.Windows.Forms.Button();
            this.btnUserMenu = new System.Windows.Forms.Button();
            this.btnReportsMenu = new System.Windows.Forms.Button();
            this.btnGroupMenu = new System.Windows.Forms.Button();
            this.btnShipmentMenu = new System.Windows.Forms.Button();
            this.pnlShipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipment)).BeginInit();
            this.pnlGroups.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShipments
            // 
            this.pnlShipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShipments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlShipments.Controls.Add(this.btnEdit);
            this.pnlShipments.Controls.Add(this.btnRemove);
            this.pnlShipments.Controls.Add(this.btnRefresh);
            this.pnlShipments.Controls.Add(this.dataGridViewShipment);
            this.pnlShipments.Controls.Add(this.btnAddShipment);
            this.pnlShipments.Controls.Add(this.lblShipments);
            this.pnlShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlShipments.Location = new System.Drawing.Point(77, 2);
            this.pnlShipments.Name = "pnlShipments";
            this.pnlShipments.Size = new System.Drawing.Size(580, 707);
            this.pnlShipments.TabIndex = 0;
            this.pnlShipments.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShipments_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(163, 636);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 43);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Shipment";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(290, 636);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Shipment";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::RMaD.Properties.Resources.Refresh;
            this.btnRefresh.Location = new System.Drawing.Point(508, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewShipment
            // 
            this.dataGridViewShipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewShipment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShipment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShipment.Location = new System.Drawing.Point(3, 57);
            this.dataGridViewShipment.Name = "dataGridViewShipment";
            this.dataGridViewShipment.ReadOnly = true;
            this.dataGridViewShipment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShipment.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShipment.Size = new System.Drawing.Size(574, 563);
            this.dataGridViewShipment.TabIndex = 2;
            // 
            // btnAddShipment
            // 
            this.btnAddShipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShipment.Location = new System.Drawing.Point(31, 636);
            this.btnAddShipment.Name = "btnAddShipment";
            this.btnAddShipment.Size = new System.Drawing.Size(126, 43);
            this.btnAddShipment.TabIndex = 1;
            this.btnAddShipment.Text = "Add Shipment";
            this.btnAddShipment.UseVisualStyleBackColor = true;
            this.btnAddShipment.Click += new System.EventHandler(this.btnAddShipment_Click);
            // 
            // lblShipments
            // 
            this.lblShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipments.Location = new System.Drawing.Point(30, 8);
            this.lblShipments.Name = "lblShipments";
            this.lblShipments.Size = new System.Drawing.Size(180, 42);
            this.lblShipments.TabIndex = 0;
            this.lblShipments.Text = "Shipments";
            // 
            // pnlGroups
            // 
            this.pnlGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGroups.Controls.Add(this.lblGroups);
            this.pnlGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGroups.Location = new System.Drawing.Point(77, 2);
            this.pnlGroups.Name = "pnlGroups";
            this.pnlGroups.Size = new System.Drawing.Size(580, 707);
            this.pnlGroups.TabIndex = 1;
            // 
            // lblGroups
            // 
            this.lblGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.Location = new System.Drawing.Point(30, 27);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(127, 42);
            this.lblGroups.TabIndex = 0;
            this.lblGroups.Text = "Groups";
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "ShipmentMenu.png");
            this.imageIcons.Images.SetKeyName(1, "GroupMenu.png");
            this.imageIcons.Images.SetKeyName(2, "ReportMenu.png");
            this.imageIcons.Images.SetKeyName(3, "UserMenu.png");
            this.imageIcons.Images.SetKeyName(4, "Settings.png");
            // 
            // pnlReports
            // 
            this.pnlReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReports.Controls.Add(this.lblReports);
            this.pnlReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReports.Location = new System.Drawing.Point(77, 2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(580, 707);
            this.pnlReports.TabIndex = 2;
            // 
            // lblReports
            // 
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(30, 27);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(127, 42);
            this.lblReports.TabIndex = 0;
            this.lblReports.Text = "Reports";
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.Controls.Add(this.pbProfilePic);
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUser.Location = new System.Drawing.Point(77, 2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(580, 707);
            this.pnlUser.TabIndex = 3;
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePic.Image")));
            this.pbProfilePic.Location = new System.Drawing.Point(250, 57);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(77, 125);
            this.pbProfilePic.TabIndex = 1;
            this.pbProfilePic.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(226, 213);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(125, 38);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.Controls.Add(this.lblSettins);
            this.pnlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSettings.Location = new System.Drawing.Point(77, 2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(580, 707);
            this.pnlSettings.TabIndex = 4;
            // 
            // lblSettins
            // 
            this.lblSettins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettins.Location = new System.Drawing.Point(30, 27);
            this.lblSettins.Name = "lblSettins";
            this.lblSettins.Size = new System.Drawing.Size(137, 42);
            this.lblSettins.TabIndex = 0;
            this.lblSettins.Text = "Settings";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnSettingsMenu
            // 
            this.btnSettingsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettingsMenu.ImageIndex = 4;
            this.btnSettingsMenu.ImageList = this.imageIcons;
            this.btnSettingsMenu.Location = new System.Drawing.Point(-1, 659);
            this.btnSettingsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettingsMenu.Name = "btnSettingsMenu";
            this.btnSettingsMenu.Size = new System.Drawing.Size(75, 50);
            this.btnSettingsMenu.TabIndex = 5;
            this.btnSettingsMenu.UseVisualStyleBackColor = true;
            this.btnSettingsMenu.Click += new System.EventHandler(this.btnSettingsMenu_Click);
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUserMenu.ImageIndex = 3;
            this.btnUserMenu.ImageList = this.imageIcons;
            this.btnUserMenu.Location = new System.Drawing.Point(-1, 609);
            this.btnUserMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Size = new System.Drawing.Size(75, 50);
            this.btnUserMenu.TabIndex = 75;
            this.btnUserMenu.UseVisualStyleBackColor = true;
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // btnReportsMenu
            // 
            this.btnReportsMenu.ImageIndex = 2;
            this.btnReportsMenu.ImageList = this.imageIcons;
            this.btnReportsMenu.Location = new System.Drawing.Point(-1, 102);
            this.btnReportsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportsMenu.Name = "btnReportsMenu";
            this.btnReportsMenu.Size = new System.Drawing.Size(75, 50);
            this.btnReportsMenu.TabIndex = 3;
            this.btnReportsMenu.UseVisualStyleBackColor = true;
            this.btnReportsMenu.Click += new System.EventHandler(this.btnReportsMenu_Click);
            // 
            // btnGroupMenu
            // 
            this.btnGroupMenu.ImageIndex = 1;
            this.btnGroupMenu.ImageList = this.imageIcons;
            this.btnGroupMenu.Location = new System.Drawing.Point(-1, 52);
            this.btnGroupMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnGroupMenu.Name = "btnGroupMenu";
            this.btnGroupMenu.Size = new System.Drawing.Size(75, 50);
            this.btnGroupMenu.TabIndex = 2;
            this.btnGroupMenu.UseVisualStyleBackColor = true;
            this.btnGroupMenu.Click += new System.EventHandler(this.btnGroupMenu_Click);
            // 
            // btnShipmentMenu
            // 
            this.btnShipmentMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnShipmentMenu.ImageIndex = 0;
            this.btnShipmentMenu.ImageList = this.imageIcons;
            this.btnShipmentMenu.Location = new System.Drawing.Point(-1, 2);
            this.btnShipmentMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnShipmentMenu.Name = "btnShipmentMenu";
            this.btnShipmentMenu.Size = new System.Drawing.Size(75, 50);
            this.btnShipmentMenu.TabIndex = 1;
            this.btnShipmentMenu.UseVisualStyleBackColor = false;
            this.btnShipmentMenu.Click += new System.EventHandler(this.btnShipmentMenu_Click);
            // 
            // UxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(657, 709);
            this.Controls.Add(this.btnSettingsMenu);
            this.Controls.Add(this.btnUserMenu);
            this.Controls.Add(this.btnReportsMenu);
            this.Controls.Add(this.btnGroupMenu);
            this.Controls.Add(this.btnShipmentMenu);
            this.Controls.Add(this.pnlShipments);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UxForm_Load);
            this.pnlShipments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipment)).EndInit();
            this.pnlGroups.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShipments;
        private System.Windows.Forms.Label lblShipments;
        private System.Windows.Forms.Button btnShipmentMenu;
        private System.Windows.Forms.Button btnGroupMenu;
        private System.Windows.Forms.Button btnReportsMenu;
        private System.Windows.Forms.Button btnUserMenu;
        private System.Windows.Forms.Button btnSettingsMenu;
        private System.Windows.Forms.Panel pnlGroups;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSettins;
        private System.Windows.Forms.Button btnAddShipment;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataGridView dataGridViewShipment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
    }
}