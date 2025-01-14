using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MunicipalServiceApplication
{
    public partial class ServiceRequestStatus : Window
    {
        private BinarySearchTree serviceRequestsTree;
        private Graph serviceDependencies;

        public ServiceRequestStatus()
        {
            InitializeComponent();
            serviceRequestsTree = new BinarySearchTree();
            serviceDependencies = new Graph();

            //InitializeSampleData();
            //DisplayRequests();
        }

    //    private void InitializeSampleData()
    //    {
    //        // Add sample service requests to the binary search tree
    //        var request1 = new ServiceRequestModel(1, "Repair streetlight", "Pending", DateTime.Now.AddDays(-5));
    //        var request2 = new ServiceRequestModel(2, "Clean park", "In Progress", DateTime.Now.AddDays(-2));
    //        var request3 = new ServiceRequestModel(3, "Fix pothole", "Completed", DateTime.Now.AddDays(-7));

    //        serviceRequestsTree.Insert(request1);
    //        serviceRequestsTree.Insert(request2);
    //        serviceRequestsTree.Insert(request3);

    //        // Define dependencies (for demo purposes)
    //        serviceDependencies.AddDependency(1, 2); // Request 1 depends on Request 2
    //    }

    //    private void DisplayRequests()
    //    {
    //        // Display the service requests in the ListView
    //        RequestsListView.Items.Clear();
    //        var requests = serviceRequestsTree.GetAllRequests(); // Add a method to retrieve all nodes in sorted order
    //        foreach (var request in requests)
    //        {
    //            RequestsListView.Items.Add(request);
    //        }
    //    }

    //    private void TrackRequestButton_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (int.TryParse(RequestIdTextBox.Text, out int id))
    //        {
    //            var request = serviceRequestsTree.Search(id);

    //            if (request != null)
    //            {
    //                RequestStatusLabel.Text = $"Status: {request.Status}";
    //            }
    //            else
    //            {
    //                RequestStatusLabel.Text = "Service request not found.";
    //            }
    //        }
    //        else
    //        {
    //            RequestStatusLabel.Text = "Invalid ID.";
    //        }
    //    }
    //}

    // Sample Model Class for Service Requests
    public class ServiceRequestModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }

        public ServiceRequestModel(int id, string description, string status, DateTime dateCreated)
        {
            Id = id;
            Description = description;
            Status = status;
            DateCreated = dateCreated;
        }
    }
}
