namespace Bus_Seat_Reservation_System
{
    partial class AdminPanelForm
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
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.btnAddTerminalsBuses = new System.Windows.Forms.Button();
            this.lblBooking = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRouteBusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRouteDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbFromTerminal = new System.Windows.Forms.ComboBox();
            this.cmbToTerminal = new System.Windows.Forms.ComboBox();
            this.btnDeleteRoute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoutes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colRouteBusNumber,
            this.colFrom,
            this.colTo,
            this.colDate,
            this.colTime,
            this.colFare,
            this.colSeats,
            this.colRouteDelete});
            this.dgvRoutes.GridColor = System.Drawing.Color.Black;
            this.dgvRoutes.Location = new System.Drawing.Point(34, 80);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.ReadOnly = true;
            this.dgvRoutes.RowHeadersWidth = 62;
            this.dgvRoutes.RowTemplate.Height = 28;
            this.dgvRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoutes.Size = new System.Drawing.Size(1110, 191);
            this.dgvRoutes.TabIndex = 0;
            this.dgvRoutes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoutes_CellContentClick);
            // 
            // dgvBuses
            // 
            this.dgvBuses.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBuses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBusId,
            this.colBusNum,
            this.colBusClass,
            this.colBusSeats,
            this.colBusDelete});
            this.dgvBuses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBuses.Location = new System.Drawing.Point(34, 288);
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.RowHeadersWidth = 62;
            this.dgvBuses.RowTemplate.Height = 28;
            this.dgvBuses.Size = new System.Drawing.Size(942, 191);
            this.dgvBuses.TabIndex = 8;
            // 
            // btnAddTerminalsBuses
            // 
            this.btnAddTerminalsBuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTerminalsBuses.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddTerminalsBuses.Location = new System.Drawing.Point(34, 494);
            this.btnAddTerminalsBuses.Name = "btnAddTerminalsBuses";
            this.btnAddTerminalsBuses.Size = new System.Drawing.Size(480, 53);
            this.btnAddTerminalsBuses.TabIndex = 0;
            this.btnAddTerminalsBuses.Text = "Add Terminals And Buses";
            this.btnAddTerminalsBuses.UseVisualStyleBackColor = false;
            this.btnAddTerminalsBuses.Click += new System.EventHandler(this.btnAddTerminalsBuses_Click);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblBooking.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.Color.White;
            this.lblBooking.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBooking.Location = new System.Drawing.Point(532, 21);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(258, 32);
            this.lblBooking.TabIndex = 14;
            this.lblBooking.Text = "ADMIN DASHBOARD";
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colRouteBusNumber
            // 
            this.colRouteBusNumber.HeaderText = "Bus Number";
            this.colRouteBusNumber.MinimumWidth = 8;
            this.colRouteBusNumber.Name = "colRouteBusNumber";
            this.colRouteBusNumber.ReadOnly = true;
            // 
            // colFrom
            // 
            this.colFrom.HeaderText = "From";
            this.colFrom.MinimumWidth = 8;
            this.colFrom.Name = "colFrom";
            this.colFrom.ReadOnly = true;
            // 
            // colTo
            // 
            this.colTo.HeaderText = "To";
            this.colTo.MinimumWidth = 8;
            this.colTo.Name = "colTo";
            this.colTo.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 8;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time";
            this.colTime.MinimumWidth = 8;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colFare
            // 
            this.colFare.HeaderText = "Fare";
            this.colFare.MinimumWidth = 8;
            this.colFare.Name = "colFare";
            this.colFare.ReadOnly = true;
            // 
            // colSeats
            // 
            this.colSeats.HeaderText = "Seats";
            this.colSeats.MinimumWidth = 8;
            this.colSeats.Name = "colSeats";
            this.colSeats.ReadOnly = true;
            // 
            // colRouteDelete
            // 
            this.colRouteDelete.HeaderText = "Delete";
            this.colRouteDelete.MinimumWidth = 8;
            this.colRouteDelete.Name = "colRouteDelete";
            this.colRouteDelete.ReadOnly = true;
            this.colRouteDelete.UseColumnTextForButtonValue = true;
            // 
            // colBusId
            // 
            this.colBusId.HeaderText = "Bus ID";
            this.colBusId.MinimumWidth = 8;
            this.colBusId.Name = "colBusId";
            this.colBusId.Width = 150;
            // 
            // colBusNum
            // 
            this.colBusNum.HeaderText = "Bus Number";
            this.colBusNum.MinimumWidth = 8;
            this.colBusNum.Name = "colBusNum";
            this.colBusNum.Width = 150;
            // 
            // colBusClass
            // 
            this.colBusClass.HeaderText = "Class";
            this.colBusClass.MinimumWidth = 8;
            this.colBusClass.Name = "colBusClass";
            this.colBusClass.Width = 150;
            // 
            // colBusSeats
            // 
            this.colBusSeats.HeaderText = "Seats";
            this.colBusSeats.MinimumWidth = 8;
            this.colBusSeats.Name = "colBusSeats";
            this.colBusSeats.Width = 150;
            // 
            // colBusDelete
            // 
            this.colBusDelete.HeaderText = "Delete";
            this.colBusDelete.MinimumWidth = 8;
            this.colBusDelete.Name = "colBusDelete";
            this.colBusDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBusDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colBusDelete.UseColumnTextForButtonValue = true;
            this.colBusDelete.Width = 150;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(38, 59);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(136, 28);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "BusNumber :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(676, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seater :";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(709, 166);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 28);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(712, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(684, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Time :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(103, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fare :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "From :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(95, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(170, 209);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(321, 26);
            this.dtpDate.TabIndex = 2;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(173, 59);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(313, 26);
            this.txtBusNumber.TabIndex = 3;
            // 
            // txtFare
            // 
            this.txtFare.Location = new System.Drawing.Point(170, 166);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(315, 26);
            this.txtFare.TabIndex = 4;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(760, 213);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(345, 26);
            this.txtTime.TabIndex = 4;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(760, 63);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(345, 26);
            this.txtSeats.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(760, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 26);
            this.textBox1.TabIndex = 4;
            // 
            // cmbFromTerminal
            // 
            this.cmbFromTerminal.FormattingEnabled = true;
            this.cmbFromTerminal.Location = new System.Drawing.Point(170, 112);
            this.cmbFromTerminal.Name = "cmbFromTerminal";
            this.cmbFromTerminal.Size = new System.Drawing.Size(315, 28);
            this.cmbFromTerminal.TabIndex = 5;
            // 
            // cmbToTerminal
            // 
            this.cmbToTerminal.FormattingEnabled = true;
            this.cmbToTerminal.Location = new System.Drawing.Point(760, 116);
            this.cmbToTerminal.Name = "cmbToTerminal";
            this.cmbToTerminal.Size = new System.Drawing.Size(345, 28);
            this.cmbToTerminal.TabIndex = 5;
            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteRoute.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoute.Location = new System.Drawing.Point(230, 294);
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(128, 38);
            this.btnDeleteRoute.TabIndex = 6;
            this.btnDeleteRoute.Text = "Delete";
            this.btnDeleteRoute.UseVisualStyleBackColor = false;
            this.btnDeleteRoute.Click += new System.EventHandler(this.btnDeleteRoute_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Location = new System.Drawing.Point(1027, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddRoute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRoute.Location = new System.Drawing.Point(96, 294);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(128, 38);
            this.btnAddRoute.TabIndex = 8;
            this.btnAddRoute.Text = "Add Route";
            this.btnAddRoute.UseVisualStyleBackColor = false;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefreshAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefreshAll.Location = new System.Drawing.Point(932, 297);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(89, 35);
            this.btnRefreshAll.TabIndex = 9;
            this.btnRefreshAll.Text = "Refresh";
            this.btnRefreshAll.UseVisualStyleBackColor = false;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRefreshAll);
            this.groupBox1.Controls.Add(this.btnAddRoute);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDeleteRoute);
            this.groupBox1.Controls.Add(this.cmbToTerminal);
            this.groupBox1.Controls.Add(this.cmbFromTerminal);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtSeats);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtFare);
            this.groupBox1.Controls.Add(this.txtBusNumber);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Location = new System.Drawing.Point(39, 605);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1128, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BusRoute";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Bus_Seat_Reservation_System.Properties.Resources.Bakgrd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1751, 1041);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.btnAddTerminalsBuses);
            this.Controls.Add(this.dgvBuses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRoutes);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.Button btnAddTerminalsBuses;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRouteBusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeats;
        private System.Windows.Forms.DataGridViewButtonColumn colRouteDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusSeats;
        private System.Windows.Forms.DataGridViewButtonColumn colBusDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbFromTerminal;
        private System.Windows.Forms.ComboBox cmbToTerminal;
        private System.Windows.Forms.Button btnDeleteRoute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}