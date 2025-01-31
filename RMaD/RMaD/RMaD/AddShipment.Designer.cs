﻿namespace RMaD
{
    partial class AddShipment
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
            this.lblTracking = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblShipped = new System.Windows.Forms.Label();
            this.lblCreateShipment = new System.Windows.Forms.Label();
            this.mtbTracking = new System.Windows.Forms.MaskedTextBox();
            this.btnAddShipment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpShipped = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.tbCarrierdpdn = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracking.Location = new System.Drawing.Point(58, 122);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(137, 20);
            this.lblTracking.TabIndex = 0;
            this.lblTracking.Text = "Tracking Number: ";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrier.Location = new System.Drawing.Point(58, 227);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(64, 20);
            this.lblCarrier.TabIndex = 2;
            this.lblCarrier.Text = "Carrier: ";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(58, 192);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(117, 20);
            this.lblArrival.TabIndex = 3;
            this.lblArrival.Text = "Date of Arrival: ";
            // 
            // lblShipped
            // 
            this.lblShipped.AutoSize = true;
            this.lblShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipped.Location = new System.Drawing.Point(58, 157);
            this.lblShipped.Name = "lblShipped";
            this.lblShipped.Size = new System.Drawing.Size(115, 20);
            this.lblShipped.TabIndex = 4;
            this.lblShipped.Text = "Date Shipped: ";
            // 
            // lblCreateShipment
            // 
            this.lblCreateShipment.AutoSize = true;
            this.lblCreateShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateShipment.Location = new System.Drawing.Point(160, 56);
            this.lblCreateShipment.Name = "lblCreateShipment";
            this.lblCreateShipment.Size = new System.Drawing.Size(256, 37);
            this.lblCreateShipment.TabIndex = 5;
            this.lblCreateShipment.Text = "Create Shipment";
            // 
            // mtbTracking
            // 
            this.mtbTracking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTracking.Location = new System.Drawing.Point(231, 117);
            this.mtbTracking.Name = "mtbTracking";
            this.mtbTracking.Size = new System.Drawing.Size(257, 26);
            this.mtbTracking.TabIndex = 0;
            this.mtbTracking.ValidatingType = typeof(int);
            // 
            // btnAddShipment
            // 
            this.btnAddShipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShipment.Location = new System.Drawing.Point(185, 325);
            this.btnAddShipment.Name = "btnAddShipment";
            this.btnAddShipment.Size = new System.Drawing.Size(95, 33);
            this.btnAddShipment.TabIndex = 4;
            this.btnAddShipment.Text = "Submit";
            this.btnAddShipment.UseVisualStyleBackColor = true;
            this.btnAddShipment.Click += new System.EventHandler(this.btnAddShipment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(286, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpShipped
            // 
            this.dtpShipped.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShipped.Location = new System.Drawing.Point(231, 152);
            this.dtpShipped.Name = "dtpShipped";
            this.dtpShipped.Size = new System.Drawing.Size(257, 26);
            this.dtpShipped.TabIndex = 1;
            this.dtpShipped.ValueChanged += new System.EventHandler(this.dtpShipped_ValueChanged);
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrival.Location = new System.Drawing.Point(231, 187);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(257, 26);
            this.dtpArrival.TabIndex = 2;
            // 
            // tbCarrierdpdn
            // 
            this.tbCarrierdpdn.FormattingEnabled = true;
            this.tbCarrierdpdn.Location = new System.Drawing.Point(231, 227);
            this.tbCarrierdpdn.Margin = new System.Windows.Forms.Padding(2);
            this.tbCarrierdpdn.Name = "tbCarrierdpdn";
            this.tbCarrierdpdn.Size = new System.Drawing.Size(257, 21);
            this.tbCarrierdpdn.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(231, 270);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(257, 21);
            this.cbStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(58, 271);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // AddShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 419);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbCarrierdpdn);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpShipped);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddShipment);
            this.Controls.Add(this.mtbTracking);
            this.Controls.Add(this.lblCreateShipment);
            this.Controls.Add(this.lblShipped);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.lblCarrier);
            this.Controls.Add(this.lblTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Shipment";
            this.Load += new System.EventHandler(this.AddShipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblShipped;
        private System.Windows.Forms.Label lblCreateShipment;
        private System.Windows.Forms.Button btnAddShipment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpShipped;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.ComboBox tbCarrierdpdn;
        private System.Windows.Forms.MaskedTextBox mtbTracking;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}