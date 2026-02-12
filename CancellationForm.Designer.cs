namespace Bus_Seat_Reservation_System
{
    partial class CancellationForm
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
            this.lblTicketId = new System.Windows.Forms.Label();
            this.lblCancellation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.gbTDetails = new System.Windows.Forms.GroupBox();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.lblShowStatus = new System.Windows.Forms.Label();
            this.lblShowTo = new System.Windows.Forms.Label();
            this.lblShowFrom = new System.Windows.Forms.Label();
            this.lblShowSeats = new System.Windows.Forms.Label();
            this.lblShowFare = new System.Windows.Forms.Label();
            this.lblShowTravelDate = new System.Windows.Forms.Label();
            this.lblShowPhone = new System.Windows.Forms.Label();
            this.lblShowCnic = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.lblShowTicketId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbTDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketId.ForeColor = System.Drawing.Color.White;
            this.lblTicketId.Location = new System.Drawing.Point(12, 142);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(115, 32);
            this.lblTicketId.TabIndex = 8;
            this.lblTicketId.Text = "Ticket ID";
            // 
            // lblCancellation
            // 
            this.lblCancellation.AutoSize = true;
            this.lblCancellation.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancellation.ForeColor = System.Drawing.Color.White;
            this.lblCancellation.Location = new System.Drawing.Point(393, 35);
            this.lblCancellation.Name = "lblCancellation";
            this.lblCancellation.Size = new System.Drawing.Size(191, 32);
            this.lblCancellation.TabIndex = 8;
            this.lblCancellation.Text = "CANCEL TICKET";
            this.lblCancellation.Click += new System.EventHandler(this.lblCancellation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Travel Date";
            // 
            // dtpTravelDate
            // 
            this.dtpTravelDate.Location = new System.Drawing.Point(459, 148);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(272, 26);
            this.dtpTravelDate.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(799, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtTicketId
            // 
            this.txtTicketId.Location = new System.Drawing.Point(133, 146);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.Size = new System.Drawing.Size(151, 26);
            this.txtTicketId.TabIndex = 12;
            // 
            // gbTDetails
            // 
            this.gbTDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbTDetails.Controls.Add(this.btnCancelTicket);
            this.gbTDetails.Controls.Add(this.lblShowStatus);
            this.gbTDetails.Controls.Add(this.lblShowTo);
            this.gbTDetails.Controls.Add(this.lblShowFrom);
            this.gbTDetails.Controls.Add(this.lblShowSeats);
            this.gbTDetails.Controls.Add(this.lblShowFare);
            this.gbTDetails.Controls.Add(this.lblShowTravelDate);
            this.gbTDetails.Controls.Add(this.lblShowPhone);
            this.gbTDetails.Controls.Add(this.lblShowCnic);
            this.gbTDetails.Controls.Add(this.lblShowName);
            this.gbTDetails.Controls.Add(this.lblShowTicketId);
            this.gbTDetails.Controls.Add(this.label8);
            this.gbTDetails.Controls.Add(this.label10);
            this.gbTDetails.Controls.Add(this.label6);
            this.gbTDetails.Controls.Add(this.label7);
            this.gbTDetails.Controls.Add(this.label5);
            this.gbTDetails.Controls.Add(this.label2);
            this.gbTDetails.Controls.Add(this.label9);
            this.gbTDetails.Controls.Add(this.label4);
            this.gbTDetails.Controls.Add(this.label3);
            this.gbTDetails.Controls.Add(this.lblName);
            this.gbTDetails.ForeColor = System.Drawing.Color.White;
            this.gbTDetails.Location = new System.Drawing.Point(28, 202);
            this.gbTDetails.Name = "gbTDetails";
            this.gbTDetails.Size = new System.Drawing.Size(903, 264);
            this.gbTDetails.TabIndex = 13;
            this.gbTDetails.TabStop = false;
            this.gbTDetails.Text = "Ticket Details";
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelTicket.Font = new System.Drawing.Font("Kievit Offc Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTicket.ForeColor = System.Drawing.Color.White;
            this.btnCancelTicket.Location = new System.Drawing.Point(626, 182);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(148, 64);
            this.btnCancelTicket.TabIndex = 15;
            this.btnCancelTicket.Text = "Cancel Ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = false;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // lblShowStatus
            // 
            this.lblShowStatus.AutoSize = true;
            this.lblShowStatus.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowStatus.ForeColor = System.Drawing.Color.White;
            this.lblShowStatus.Location = new System.Drawing.Point(464, 35);
            this.lblShowStatus.Name = "lblShowStatus";
            this.lblShowStatus.Size = new System.Drawing.Size(20, 28);
            this.lblShowStatus.TabIndex = 14;
            this.lblShowStatus.Text = "-";
            // 
            // lblShowTo
            // 
            this.lblShowTo.AutoSize = true;
            this.lblShowTo.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTo.ForeColor = System.Drawing.Color.White;
            this.lblShowTo.Location = new System.Drawing.Point(448, 212);
            this.lblShowTo.Name = "lblShowTo";
            this.lblShowTo.Size = new System.Drawing.Size(20, 28);
            this.lblShowTo.TabIndex = 14;
            this.lblShowTo.Text = "-";
            // 
            // lblShowFrom
            // 
            this.lblShowFrom.AutoSize = true;
            this.lblShowFrom.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowFrom.ForeColor = System.Drawing.Color.White;
            this.lblShowFrom.Location = new System.Drawing.Point(448, 158);
            this.lblShowFrom.Name = "lblShowFrom";
            this.lblShowFrom.Size = new System.Drawing.Size(20, 28);
            this.lblShowFrom.TabIndex = 14;
            this.lblShowFrom.Text = "-";
            // 
            // lblShowSeats
            // 
            this.lblShowSeats.AutoSize = true;
            this.lblShowSeats.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSeats.ForeColor = System.Drawing.Color.White;
            this.lblShowSeats.Location = new System.Drawing.Point(448, 96);
            this.lblShowSeats.Name = "lblShowSeats";
            this.lblShowSeats.Size = new System.Drawing.Size(20, 28);
            this.lblShowSeats.TabIndex = 14;
            this.lblShowSeats.Text = "-";
            // 
            // lblShowFare
            // 
            this.lblShowFare.AutoSize = true;
            this.lblShowFare.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowFare.ForeColor = System.Drawing.Color.White;
            this.lblShowFare.Location = new System.Drawing.Point(718, 102);
            this.lblShowFare.Name = "lblShowFare";
            this.lblShowFare.Size = new System.Drawing.Size(20, 28);
            this.lblShowFare.TabIndex = 14;
            this.lblShowFare.Text = "-";
            // 
            // lblShowTravelDate
            // 
            this.lblShowTravelDate.AutoSize = true;
            this.lblShowTravelDate.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTravelDate.ForeColor = System.Drawing.Color.White;
            this.lblShowTravelDate.Location = new System.Drawing.Point(718, 40);
            this.lblShowTravelDate.Name = "lblShowTravelDate";
            this.lblShowTravelDate.Size = new System.Drawing.Size(20, 28);
            this.lblShowTravelDate.TabIndex = 14;
            this.lblShowTravelDate.Text = "-";
            // 
            // lblShowPhone
            // 
            this.lblShowPhone.AutoSize = true;
            this.lblShowPhone.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPhone.ForeColor = System.Drawing.Color.White;
            this.lblShowPhone.Location = new System.Drawing.Point(131, 218);
            this.lblShowPhone.Name = "lblShowPhone";
            this.lblShowPhone.Size = new System.Drawing.Size(20, 28);
            this.lblShowPhone.TabIndex = 14;
            this.lblShowPhone.Text = "-";
            // 
            // lblShowCnic
            // 
            this.lblShowCnic.AutoSize = true;
            this.lblShowCnic.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCnic.ForeColor = System.Drawing.Color.White;
            this.lblShowCnic.Location = new System.Drawing.Point(131, 164);
            this.lblShowCnic.Name = "lblShowCnic";
            this.lblShowCnic.Size = new System.Drawing.Size(20, 28);
            this.lblShowCnic.TabIndex = 14;
            this.lblShowCnic.Text = "-";
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowName.ForeColor = System.Drawing.Color.White;
            this.lblShowName.Location = new System.Drawing.Point(131, 102);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(20, 28);
            this.lblShowName.TabIndex = 14;
            this.lblShowName.Text = "-";
            // 
            // lblShowTicketId
            // 
            this.lblShowTicketId.AutoSize = true;
            this.lblShowTicketId.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTicketId.ForeColor = System.Drawing.Color.White;
            this.lblShowTicketId.Location = new System.Drawing.Point(131, 50);
            this.lblShowTicketId.Name = "lblShowTicketId";
            this.lblShowTicketId.Size = new System.Drawing.Size(20, 28);
            this.lblShowTicketId.TabIndex = 14;
            this.lblShowTicketId.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(659, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fare : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(405, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "To : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(381, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "From : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(307, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Seat Number : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(594, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Travel Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ticket Status : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Phone No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "NIC : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 28);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Ticket ID : ";
            // 
            // CancellationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(954, 478);
            this.Controls.Add(this.gbTDetails);
            this.Controls.Add(this.txtTicketId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpTravelDate);
            this.Controls.Add(this.lblCancellation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTicketId);
            this.MaximumSize = new System.Drawing.Size(976, 534);
            this.MinimumSize = new System.Drawing.Size(976, 534);
            this.Name = "CancellationForm";
            this.Text = "CancellationForm";
            this.Load += new System.EventHandler(this.CancellationForm_Load);
            this.gbTDetails.ResumeLayout(false);
            this.gbTDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.Label lblCancellation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTravelDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.GroupBox gbTDetails;
        private System.Windows.Forms.Label lblShowTicketId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblShowStatus;
        private System.Windows.Forms.Label lblShowSeats;
        private System.Windows.Forms.Label lblShowTravelDate;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShowFrom;
        private System.Windows.Forms.Label lblShowCnic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShowFare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblShowTo;
        private System.Windows.Forms.Label lblShowPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelTicket;
    }
}