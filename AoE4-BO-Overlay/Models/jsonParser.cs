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
            List<BuildOrderActionModel> buildOrderActions = JsonConvert.DeserializeObject<List<BuildOrderActionModel>>(json);
            return buildOrderActions;
        }

        public static BuildOrderModel GetBuildOrder()
        {
            var temp = DeserelizeBuildOrder(readJson(@"G:\BuilderOrder\generated.json"));
            return new BuildOrderModel(temp);
        }
    }
}
