using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE4_BO_Overlay
{
    public class BuildOrderActionModel
    {
        private int index = 0;
        private string time = null;
        private int supply = 0;
        private string action = null; 
        
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public int Supply
        {
            get { return supply; }
            set { supply = value; }
        }
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        public BuildOrderActionModel(int index, string time, int supply, string action)
        {
            this.index = index;
            this.time = time;
            this.supply = supply;
            this.action = action;
        }
    }
}
