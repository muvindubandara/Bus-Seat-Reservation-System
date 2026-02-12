namespace Bus_Seat_Reservation_System
{
    partial class DashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTicketSearch = new System.Windows.Forms.Button();
            this.btnCancellation = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.colBusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.rbNonAC = new System.Windows.Forms.RadioButton();
            this.rbAC = new System.Windows.Forms.RadioButton();
            this.lblTravelDate = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnTicketSearch);
            this.panel1.Controls.Add(this.btnCancellation);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 701);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.BackgroundImage = global::Bus_Seat_Reservation_System.Properties.Resources.logout_1;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(44, 28);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnTicketSearch
            // 
            this.btnTicketSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTicketSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicketSearch.Font = new System.Drawing.Font("Kievit Offc Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketSearch.ForeColor = System.Drawing.Color.White;
            this.btnTicketSearch.Location = new System.Drawing.Point(66, 492);
            this.btnTicketSearch.Name = "btnTicketSearch";
            this.btnTicketSearch.Size = new System.Drawing.Size(141, 55);
            this.btnTicketSearch.TabIndex = 3;
            this.btnTicketSearch.Text = "Tickets";
            this.btnTicketSearch.UseVisualStyleBackColor = false;
            this.btnTicketSearch.Click += new System.EventHandler(this.btnTicketSearch_Click);
            // 
            // btnCancellation
            // 
            this.btnCancellation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancellation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancellation.Font = new System.Drawing.Font("Kievit Offc Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellation.ForeColor = System.Drawing.Color.White;
            this.btnCancellation.Location = new System.Drawing.Point(66, 379);
            this.btnCancellation.Name = "btnCancellation";
            this.btnCancellation.Size = new System.Drawing.Size(141, 57);
            this.btnCancellation.TabIndex = 2;
            this.btnCancellation.Text = "Cancel Booking";
            this.btnCancellation.UseVisualStyleBackColor = false;
            this.btnCancellation.Click += new System.EventHandler(this.btnCancellation_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Font = new System.Drawing.Font("Kievit Offc Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(66, 272);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(141, 58);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelHome.BackgroundImage = global::Bus_Seat_Reservation_System.Properties.Resources.Bakgrd;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Controls.Add(this.btnShowAll);
            this.panelHome.Controls.Add(this.lblWelcome);
            this.panelHome.Controls.Add(this.lblLoggedIn);
            this.panelHome.Controls.Add(this.btnSearch);
            this.panelHome.Controls.Add(this.lblDashboardTitle);
            this.panelHome.Controls.Add(this.dgvTrips);
            this.panelHome.Controls.Add(this.dtpTravelDate);
            this.panelHome.Controls.Add(this.grpCategory);
            this.panelHome.Controls.Add(this.lblTravelDate);
            this.panelHome.Controls.Add(this.cmbTo);
            this.panelHome.Controls.Add(this.lblFrom);
            this.panelHome.Controls.Add(this.cmbFrom);
            this.panelHome.Controls.Add(this.lblTo);
            this.panelHome.Location = new System.Drawing.Point(279, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1298, 770);
            this.panelHome.TabIndex = 4;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(1014, 184);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(82, 32);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblWelcome.Location = new System.Drawing.Point(15, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(14, 20);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "-";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLoggedIn.Location = new System.Drawing.Point(15, 51);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(14, 20);
            this.lblLoggedIn.TabIndex = 5;
            this.lblLoggedIn.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Purple;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1121, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.White;
            this.lblDashboardTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDashboardTitle.Location = new System.Drawing.Point(642, 30);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(164, 32);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "DASHBOARD";
            // 
            // dgvTrips
            // 
            this.dgvTrips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrips.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTrips.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBusNumber,
            this.colBusClass,
            this.colTravelDate,
            this.colFrom,
            this.colTo,
            this.colDeparture,
            this.colFare});
            this.dgvTrips.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvTrips.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvTrips.Location = new System.Drawing.Point(37, 411);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.ReadOnly = true;
            this.dgvTrips.RowHeadersWidth = 62;
            this.dgvTrips.RowTemplate.Height = 28;
            this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrips.Size = new System.Drawing.Size(1244, 290);
            this.dgvTrips.TabIndex = 3;
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
            // dtpTravelDate
            // 
            this.dtpTravelDate.Location = new System.Drawing.Point(714, 190);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(272, 26);
            this.dtpTravelDate.TabIndex = 3;
            // 
            // grpCategory
            // 
            this.grpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCategory.BackColor = System.Drawing.Color.Transparent;
            this.grpCategory.Controls.Add(this.rbNonAC);
            this.grpCategory.Controls.Add(this.rbAC);
            this.grpCategory.ForeColor = System.Drawing.Color.White;
            this.grpCategory.Location = new System.Drawing.Point(35, 272);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(1247, 100);
            this.grpCategory.TabIndex = 0;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Category";
            // 
            // rbNonAC
            // 
            this.rbNonAC.AutoSize = true;
            this.rbNonAC.Location = new System.Drawing.Point(194, 45);
            this.rbNonAC.Name = "rbNonAC";
            this.rbNonAC.Size = new System.Drawing.Size(132, 24);
            this.rbNonAC.TabIndex = 1;
            this.rbNonAC.Text = "Non AC Class";
            this.rbNonAC.UseVisualStyleBackColor = true;
            // 
            // rbAC
            // 
            this.rbAC.AutoSize = true;
            this.rbAC.Checked = true;
            this.rbAC.Location = new System.Drawing.Point(53, 45);
            this.rbAC.Name = "rbAC";
            this.rbAC.Size = new System.Drawing.Size(99, 24);
            this.rbAC.TabIndex = 0;
            this.rbAC.TabStop = true;
            this.rbAC.Text = "AC Class";
            this.rbAC.UseVisualStyleBackColor = true;
            // 
            // lblTravelDate
            // 
            this.lblTravelDate.AutoSize = true;
            this.lblTravelDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTravelDate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelDate.ForeColor = System.Drawing.Color.White;
            this.lblTravelDate.Location = new System.Drawing.Point(564, 187);
            this.lblTravelDate.Name = "lblTravelDate";
            this.lblTravelDate.Size = new System.Drawing.Size(144, 32);
            this.lblTravelDate.TabIndex = 0;
            this.lblTravelDate.Text = "Travel Date";
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(357, 190);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(183, 28);
            this.cmbTo.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(44, 190);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(73, 32);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(123, 194);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(156, 28);
            this.cmbFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(308, 190);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(43, 32);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1573, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHome);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblTravelDate;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.DateTimePicker dtpTravelDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTicketSearch;
        private System.Windows.Forms.Button btnCancellation;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.RadioButton rbNonAC;
        private System.Windows.Forms.RadioButton rbAC;
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFare;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnShowAll;
    }
}