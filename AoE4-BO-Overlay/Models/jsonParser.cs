using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Caliburn.Micro;

namespace AoE4_BO_Overlay
{
    public static class JsonParser
    {
        public static List<BuildOrderModel> BuildOrders;
        public static string BuildOrderFolder = "BuildOrders";
        public static string dirPath = Directory.GetCurrentDirectory() + "\\" + BuildOrderFolder;
        public static BuildOrderModel CurrendBuildOrder;
        private static int _idCounter = 0;

        private static string readJson(string file)
        {
            try
            {
                return File.ReadAllText(file).ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private static List<BuildOrderActionModel> DeserelizeBuildOrder(string json)
        {
            return JsonConvert.DeserializeObject<List<BuildOrderActionModel>>(json);
        }

        public static BuildOrderModel GetBuildOrder(string BuildOrderFileName)
        {
            var bo = new BuildOrderModel(DeserelizeBuildOrder(readJson(dirPath + "\\" + BuildOrderFileName)));
            bo.Name = BuildOrderFileName;
            bo.ID = _idCounter++;
            return bo;
        }



        public static void CreateDirectory()
        {
            Directory.CreateDirectory(dirPath);
        }
    }
}
