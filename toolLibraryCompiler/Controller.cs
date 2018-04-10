using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolLibraryCompiler.Tools;

namespace toolLibraryCompiler
{
    class Controller
    {
        private List<Tool> Tools = new List<Tool>();
        private DataSet ToolSet;
        private DataTable ActiveTable;

        public void LoadSheet(DataSet dataSet)
        {
            this.ToolSet = dataSet;           
        }

        public void SetActiveSheet(DataTable table)
        {
            this.ActiveTable = table;
        }

        public string ActiveSheetToLibrary()
        {
            StringBuilder sb = new StringBuilder();

            foreach(DataRow row in ActiveTable.Rows)
            {
                string type = row.Field<string>("ToolType");
                Tool currentTool;
                switch (type)
                {
                    case "BallNose":
                        currentTool = new BallNose(row.Field<string>("Name"), row.Field<string>("ToolType"), row.Field<string>("Units"), row.Field<string>("D1"), row.Field<string>("ToolType"))
                        break;
                    case "BullNose":
                        break;
                    case "Conic":
                        break;
                    case "DrillBit":
                        break;
                    case "EndMill":
                        break;
                    case "Engrave":
                        break;
                    case "Engrave2":
                        break;
                    case "Spherical":
                        break;
                    case "Taper":
                        break;
                }
            }
        }
    }
}
