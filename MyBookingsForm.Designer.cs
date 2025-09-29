namespace travel_booking
{
    partial class MyBookingsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dgvMyBookings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdateBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelBooking = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Bookings";
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
            // dgvMyBookings
            // 
            this.dgvMyBookings.AllowUserToAddRows = false;
            this.dgvMyBookings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMyBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMyBookings.ColumnHeadersHeight = 22;
            this.dgvMyBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMyBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMyBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMyBookings.Location = new System.Drawing.Point(30, 65);
            this.dgvMyBookings.MultiSelect = false;
            this.dgvMyBookings.Name = "dgvMyBookings";
            this.dgvMyBookings.ReadOnly = true;
            this.dgvMyBookings.RowHeadersVisible = false;
            this.dgvMyBookings.RowTemplate.Height = 28;
            this.dgvMyBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyBookings.Size = new System.Drawing.Size(758, 332);
            this.dgvMyBookings.TabIndex = 0;
            this.dgvMyBookings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMyBookings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMyBookings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMyBookings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMyBookings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMyBookings.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMyBookings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMyBookings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMyBookings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMyBookings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMyBookings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMyBookings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMyBookings.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvMyBookings.ThemeStyle.ReadOnly = true;
            this.dgvMyBookings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMyBookings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMyBookings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMyBookings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMyBookings.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMyBookings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMyBookings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBooking.BorderRadius = 8;
            this.btnUpdateBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBooking.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBooking.Location = new System.Drawing.Point(598, 413);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(190, 40);
            this.btnUpdateBooking.TabIndex = 1;
            this.btnUpdateBooking.Text = "Update Selected Booking";
            //this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBooking.BorderRadius = 8;
            this.btnCancelBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(402, 413);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(190, 40);
            this.btnCancelBooking.TabIndex = 2;
            this.btnCancelBooking.Text = "Cancel Selected Booking";
            //this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // MyBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 478);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.dgvMyBookings);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyBookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage My Bookings";
            //this.Load += new System.EventHandler(this.MyBookingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMyBookings;
        private Guna.UI2.WinForms.Guna2Button btnUpdateBooking;
        private Guna.UI2.WinForms.Guna2Button btnCancelBooking;
    }
}

