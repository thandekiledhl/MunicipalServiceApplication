using System.Collections.Generic;

namespace MunicipalServiceApplication
{
    public class TreeNode
    {
        public ServiceRequest Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(ServiceRequest data)
        {
            Data = data;
            Left = Right = null;
        }
    }

    public class BinarySearchTree
    {
        private TreeNode root;

        public void Insert(ServiceRequest data)
        {
            root = InsertRecursive(root, data);
        }

        private TreeNode InsertRecursive(TreeNode node, ServiceRequest data)
        {
            if (node == null)
                return new TreeNode(data);

            if (data.Id < node.Data.Id)
                node.Left = InsertRecursive(node.Left, data);
            else if (data.Id > node.Data.Id)
                node.Right = InsertRecursive(node.Right, data);

            return node;
        }

        public ServiceRequest Search(int id)
        {
            return SearchRecursive(root, id);
        }

        private ServiceRequest SearchRecursive(TreeNode node, int id)
        {
            if (node == null) return null;
            if (id == node.Data.Id) return node.Data;
            if (id < node.Data.Id) return SearchRecursive(node.Left, id);
            else return SearchRecursive(node.Right, id);
        }

        // Method to get all requests in sorted order
        public List<ServiceRequest> GetAllRequests()
        {
            var requests = new List<ServiceRequest>();
            InOrderTraversal(root, requests);
            return requests;
        }

        private void InOrderTraversal(TreeNode node, List<ServiceRequest> requests)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, requests);
            requests.Add(node.Data);
            InOrderTraversal(node.Right, requests);
        }
    }
}


