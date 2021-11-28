using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE4_BO_Overlay
{
    public class BuildOrderModel
    {
        private List<BuildOrderActionModel> _actions;
        private string _name;
        private int _id;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public List<BuildOrderActionModel> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        public BuildOrderModel(List<BuildOrderActionModel> actions)
        {
            this._actions = actions;
        }
    }
}
