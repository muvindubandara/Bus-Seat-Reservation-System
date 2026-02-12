namespace Bus_Seat_Reservation_System
{
    partial class SeatSelectionForm
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.NameTittle = new System.Windows.Forms.Label();
            this.PhoneTitle = new System.Windows.Forms.Label();
            this.CnicTitle = new System.Windows.Forms.Label();
            this.dgvSelectedSeats = new System.Windows.Forms.DataGridView();
            this.colSeatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSeats = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSeats)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(437, 24);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(206, 32);
            this.lblFormTitle.TabIndex = 8;
            this.lblFormTitle.Text = "SEAT SELECTION";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(124, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 32);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "-";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(496, 33);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(24, 32);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "-";
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnic.ForeColor = System.Drawing.Color.White;
            this.lblCnic.Location = new System.Drawing.Point(787, 33);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(24, 32);
            this.lblCnic.TabIndex = 8;
            this.lblCnic.Text = "-";
            // 
            // NameTittle
            // 
            this.NameTittle.AutoSize = true;
            this.NameTittle.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTittle.ForeColor = System.Drawing.Color.White;
            this.NameTittle.Location = new System.Drawing.Point(23, 33);
            this.NameTittle.Name = "NameTittle";
            this.NameTittle.Size = new System.Drawing.Size(95, 32);
            this.NameTittle.TabIndex = 8;
            this.NameTittle.Text = "Name :";
            // 
            // PhoneTitle
            // 
            this.PhoneTitle.AutoSize = true;
            this.PhoneTitle.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTitle.ForeColor = System.Drawing.Color.White;
            this.PhoneTitle.Location = new System.Drawing.Point(359, 33);
            this.PhoneTitle.Name = "PhoneTitle";
            this.PhoneTitle.Size = new System.Drawing.Size(143, 32);
            this.PhoneTitle.TabIndex = 8;
            this.PhoneTitle.Text = "Phone No :";
            // 
            // CnicTitle
            // 
            this.CnicTitle.AutoSize = true;
            this.CnicTitle.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnicTitle.ForeColor = System.Drawing.Color.White;
            this.CnicTitle.Location = new System.Drawing.Point(726, 33);
            this.CnicTitle.Name = "CnicTitle";
            this.CnicTitle.Size = new System.Drawing.Size(69, 32);
            this.CnicTitle.TabIndex = 8;
            this.CnicTitle.Text = "NIC :";
            // 
            // dgvSelectedSeats
            // 
            this.dgvSelectedSeats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedSeats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSelectedSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedSeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeatNumber});
            this.dgvSelectedSeats.Location = new System.Drawing.Point(27, 224);
            this.dgvSelectedSeats.Name = "dgvSelectedSeats";
            this.dgvSelectedSeats.ReadOnly = true;
            this.dgvSelectedSeats.RowHeadersWidth = 62;
            this.dgvSelectedSeats.RowTemplate.Height = 28;
            this.dgvSelectedSeats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedSeats.Size = new System.Drawing.Size(218, 444);
            this.dgvSelectedSeats.TabIndex = 9;
            // 
            // colSeatNumber
            // 
            this.colSeatNumber.HeaderText = "Seat Number";
            this.colSeatNumber.MinimumWidth = 8;
            this.colSeatNumber.Name = "colSeatNumber";
            this.colSeatNumber.ReadOnly = true;
            // 
            // pnlSeats
            // 
            this.pnlSeats.AutoScroll = true;
            this.pnlSeats.Location = new System.Drawing.Point(274, 224);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(425, 444);
            this.pnlSeats.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(740, 556);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 53);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(740, 615);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 53);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lblCnic);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.CnicTitle);
            this.groupBox1.Controls.Add(this.PhoneTitle);
            this.groupBox1.Controls.Add(this.NameTittle);
            this.groupBox1.Location = new System.Drawing.Point(8, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 94);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SeatSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1039, 740);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlSeats);
            this.Controls.Add(this.dgvSelectedSeats);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "SeatSelectionForm";
            this.Text = "SeatSelectionForm";
            this.Load += new System.EventHandler(this.SeatSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSeats)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label NameTittle;
        private System.Windows.Forms.Label PhoneTitle;
        private System.Windows.Forms.Label CnicTitle;
        private System.Windows.Forms.DataGridView dgvSelectedSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeatNumber;
        private System.Windows.Forms.FlowLayoutPanel pnlSeats;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}