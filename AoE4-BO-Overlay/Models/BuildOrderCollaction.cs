using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE4_BO_Overlay.Models
{
    public static class BuildOrderCollaction
    {
        public static List<BuildOrderModel> _buildOrders = new List<BuildOrderModel>();
        private static List<string> _buildOrderNames = new List<string>();

        private static void ReadBuildorderNames()
        {
            _buildOrderNames = Directory.GetFiles(JsonParser.dirPath).Select(f => Path.GetFileName(f)).ToList();
        }

        public static void UpdatebuildOrders()
        {
            if (_buildOrders != null)
            {
                _buildOrders.Clear();
            };

            ReadBuildorderNames();

            foreach (var buildOrder in _buildOrderNames)
            {
                _buildOrders.Add(JsonParser.GetBuildOrder(buildOrder));
            }
        }
    }
}
