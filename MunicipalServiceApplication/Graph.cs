using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

        public void AddDependency(int serviceId, int dependentId)
        {
            if (!adjList.ContainsKey(serviceId))
                adjList[serviceId] = new List<int>();

            adjList[serviceId].Add(dependentId);
        }

        public List<int> GetDependencies(int serviceId)
        {
            return adjList.ContainsKey(serviceId) ? adjList[serviceId] : new List<int>();
        }
    }

}
