namespace Bus_Seat_Reservation_System
{
    partial class BookingForm
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
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();
            this.lblTravelDate = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerCnic = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerCnic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.rbNonAC = new System.Windows.Forms.RadioButton();
            this.rbAC = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.colBusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpCustomer.SuspendLayout();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.ForeColor = System.Drawing.Color.White;
            this.lblLoggedIn.Location = new System.Drawing.Point(399, 137);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(14, 20);
            this.lblLoggedIn.TabIndex = 12;
            this.lblLoggedIn.Text = "-";
            // 
            // dtpTravelDate
            // 
            this.dtpTravelDate.Location = new System.Drawing.Point(687, 104);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(272, 26);
            this.dtpTravelDate.TabIndex = 11;
            // 
            // lblTravelDate
            // 
            this.lblTravelDate.AutoSize = true;
            this.lblTravelDate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelDate.ForeColor = System.Drawing.Color.White;
            this.lblTravelDate.Location = new System.Drawing.Point(537, 101);
            this.lblTravelDate.Name = "lblTravelDate";
            this.lblTravelDate.Size = new System.Drawing.Size(144, 32);
            this.lblTravelDate.TabIndex = 6;
            this.lblTravelDate.Text = "Travel Date";
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(330, 104);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(183, 28);
            this.cmbTo.TabIndex = 10;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(17, 104);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(73, 32);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(96, 108);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(156, 28);
            this.cmbFrom.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(281, 104);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(43, 32);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To";
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblBooking.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.Color.White;
            this.lblBooking.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBooking.Location = new System.Drawing.Point(537, 18);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(125, 32);
            this.lblBooking.TabIndex = 13;
            this.lblBooking.Text = "BOOKING";
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpCustomer.Controls.Add(this.txtCustomerCnic);
            this.grpCustomer.Controls.Add(this.txtCustomerPhone);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblCustomerCnic);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpCustomer.Location = new System.Drawing.Point(28, 166);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(1095, 168);
            this.grpCustomer.TabIndex = 14;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Details";
            // 
            // txtCustomerCnic
            // 
            this.txtCustomerCnic.Location = new System.Drawing.Point(673, 75);
            this.txtCustomerCnic.Name = "txtCustomerCnic";
            this.txtCustomerCnic.Size = new System.Drawing.Size(257, 26);
            this.txtCustomerCnic.TabIndex = 9;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(410, 75);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(165, 26);
            this.txtCustomerPhone.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(93, 78);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(151, 26);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblCustomerCnic
            // 
            this.lblCustomerCnic.AutoSize = true;
            this.lblCustomerCnic.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCnic.ForeColor = System.Drawing.Color.White;
            this.lblCustomerCnic.Location = new System.Drawing.Point(598, 69);
            this.lblCustomerCnic.Name = "lblCustomerCnic";
            this.lblCustomerCnic.Size = new System.Drawing.Size(55, 32);
            this.lblCustomerCnic.TabIndex = 7;
            this.lblCustomerCnic.Text = "NIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phone No";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(6, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 32);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // grpCategory
            // 
            this.grpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpCategory.Controls.Add(this.rbNonAC);
            this.grpCategory.Controls.Add(this.rbAC);
            this.grpCategory.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpCategory.Location = new System.Drawing.Point(28, 356);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(1095, 100);
            this.grpCategory.TabIndex = 15;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Category";
            // 
            // rbNonAC
            // 
            this.rbNonAC.AutoSize = true;
            this.rbNonAC.BackColor = System.Drawing.Color.Transparent;
            this.rbNonAC.ForeColor = System.Drawing.Color.White;
            this.rbNonAC.Location = new System.Drawing.Point(194, 45);
            this.rbNonAC.Name = "rbNonAC";
            this.rbNonAC.Size = new System.Drawing.Size(132, 24);
            this.rbNonAC.TabIndex = 1;
            this.rbNonAC.Text = "Non AC Class";
            this.rbNonAC.UseVisualStyleBackColor = false;
            // 
            // rbAC
            // 
            this.rbAC.AutoSize = true;
            this.rbAC.BackColor = System.Drawing.Color.Transparent;
            this.rbAC.Checked = true;
            this.rbAC.ForeColor = System.Drawing.Color.White;
            this.rbAC.Location = new System.Drawing.Point(53, 45);
            this.rbAC.Name = "rbAC";
            this.rbAC.Size = new System.Drawing.Size(99, 24);
            this.rbAC.TabIndex = 0;
            this.rbAC.TabStop = true;
            this.rbAC.Text = "AC Class";
            this.rbAC.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1000, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTrips
            // 
            this.dgvTrips.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBusNumber,
            this.colBusClass,
            this.colTravelDate,
            this.colFrom,
            this.colTo,
            this.colDeparture,
            this.colFare,
            this.colBook});
            this.dgvTrips.Location = new System.Drawing.Point(23, 474);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.ReadOnly = true;
            this.dgvTrips.RowHeadersWidth = 62;
            this.dgvTrips.RowTemplate.Height = 28;
            this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrips.Size = new System.Drawing.Size(1100, 109);
            this.dgvTrips.TabIndex = 16;
            this.dgvTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrips_CellContentClick);
            // 
            // colBusNumber
            // 
            this.colBusNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBusNumber.HeaderText = "Bus Number";
            this.colBusNumber.MinimumWidth = 8;
            this.colBusNumber.Name = "colBusNumber";
            this.colBusNumber.ReadOnly = true;
            // 
            // colBusClass
            // 
            this.colBusClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBusClass.HeaderText = "Bus Class";
            this.colBusClass.MinimumWidth = 8;
            this.colBusClass.Name = "colBusClass";
            this.colBusClass.ReadOnly = true;
            // 
            // colTravelDate
            // 
            this.colTravelDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTravelDate.HeaderText = "Travel Date";
            this.colTravelDate.MinimumWidth = 8;
            this.colTravelDate.Name = "colTravelDate";
            this.colTravelDate.ReadOnly = true;
            // 
            // colFrom
            // 
            this.colFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFrom.HeaderText = "From ";
            this.colFrom.MinimumWidth = 8;
            this.colFrom.Name = "colFrom";
            this.colFrom.ReadOnly = true;
            // 
            // colTo
            // 
            this.colTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTo.HeaderText = "To";
            this.colTo.MinimumWidth = 8;
            this.colTo.Name = "colTo";
            this.colTo.ReadOnly = true;
            // 
            // colDeparture
            // 
            this.colDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDeparture.HeaderText = "Departure";
            this.colDeparture.MinimumWidth = 8;
            this.colDeparture.Name = "colDeparture";
            this.colDeparture.ReadOnly = true;
            // 
            // colFare
            // 
            this.colFare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFare.HeaderText = "Fare ";
            this.colFare.MinimumWidth = 8;
            this.colFare.Name = "colFare";
            this.colFare.ReadOnly = true;
            // 
            // colBook
            // 
            this.colBook.HeaderText = "Book";
            this.colBook.MinimumWidth = 8;
            this.colBook.Name = "colBook";
            this.colBook.ReadOnly = true;
            this.colBook.Width = 150;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1149, 603);
            this.Controls.Add(this.dgvTrips);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.dtpTravelDate);
            this.Controls.Add(this.lblTravelDate);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.lblTo);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.DateTimePicker dtpTravelDate;
        private System.Windows.Forms.Label lblTravelDate;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustomerCnic;
        private System.Windows.Forms.Label lblCustomerCnic;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.RadioButton rbNonAC;
        private System.Windows.Forms.RadioButton rbAC;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFare;
        private System.Windows.Forms.DataGridViewButtonColumn colBook;
    }
}