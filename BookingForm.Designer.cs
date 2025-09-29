namespace travel_booking
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cmbPackageType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.numPeople = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.Location = new System.Drawing.Point(30, 25);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(217, 30);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Booking: [Package]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Travel Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Package Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of People";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(33, 290);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(147, 25);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total Price: $0.00";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // cmbPackageType
            // 
            this.cmbPackageType.BackColor = System.Drawing.Color.Transparent;
            this.cmbPackageType.BorderRadius = 8;
            this.cmbPackageType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPackageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackageType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPackageType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPackageType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPackageType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPackageType.ItemHeight = 30;
            this.cmbPackageType.Items.AddRange(new object[] { "Single", "Group", "Family" });
            this.cmbPackageType.Location = new System.Drawing.Point(38, 90);
            this.cmbPackageType.Name = "cmbPackageType";
            this.cmbPackageType.Size = new System.Drawing.Size(250, 36);
            this.cmbPackageType.TabIndex = 1;
            //this.cmbPackageType.SelectedIndexChanged += new System.EventHandler(this.cmbPackageType_SelectedIndexChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 8;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(38, 160);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2025, 9, 24, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 36);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Value = new System.DateTime(2025, 9, 24, 13, 50, 0, 0);
            // 
            // numPeople
            // 
            this.numPeople.BackColor = System.Drawing.Color.Transparent;
            this.numPeople.BorderRadius = 8;
            this.numPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPeople.Location = new System.Drawing.Point(38, 230);
            this.numPeople.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(120, 36);
            this.numPeople.TabIndex = 3;
            this.numPeople.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPeople.ValueChanged += new System.EventHandler(this.numPeople_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(252, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Booking";
            //this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(126, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // BookingForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(404, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPeople);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmbPackageType);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPackageName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create/Edit Booking";
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPackageType;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPeople;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}

