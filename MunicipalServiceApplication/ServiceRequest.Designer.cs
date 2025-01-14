//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MunicipalServiceApplication
//{
//    public partial class ServiceRequest
//    {
//        private System.Windows.Forms.Label lblRequestId;
//        private System.Windows.Forms.TextBox txtRequestId;
//        private System.Windows.Forms.Button btnTrackRequest;
//        private System.Windows.Forms.Label lblRequestStatus;
//        private System.Windows.Forms.ListView listViewRequests;

//        private void InitializeComponent()
//        {
//            this.lblRequestId = new System.Windows.Forms.Label();
//            this.txtRequestId = new System.Windows.Forms.TextBox();
//            this.btnTrackRequest = new System.Windows.Forms.Button();
//            this.lblRequestStatus = new System.Windows.Forms.Label();
//            this.listViewRequests = new System.Windows.Forms.ListView();

//            // Label for Request ID
//            lblRequestId.Text = "Enter Request ID:";
//            lblRequestId.Location = new System.Drawing.Point(20, 20);

//            // TextBox for Request ID input
//            txtRequestId.Location = new System.Drawing.Point(150, 20);

//            // Track Request Button
//            btnTrackRequest.Text = "Track Request";
//            btnTrackRequest.Location = new System.Drawing.Point(300, 20);
//            btnTrackRequest.Click += new System.EventHandler(this.btnTrackRequest_Click);

//            // Status Label
//            lblRequestStatus.Text = "Status: ";
//            lblRequestStatus.Location = new System.Drawing.Point(20, 60);

//            // ListView for requests
//            listViewRequests.Location = new System.Drawing.Point(20, 100);
//            listViewRequests.Size = new System.Drawing.Size(500, 200);

//            // Add controls to form
//            this.Controls.Add(lblRequestId);
//            this.Controls.Add(txtRequestId);
//            this.Controls.Add(btnTrackRequest);
//            this.Controls.Add(lblRequestStatus);
//            this.Controls.Add(listViewRequests);

//            this.Text = "Service Request Status";
//            this.Size = new System.Drawing.Size(600, 400);
//        }
//    }
//}

