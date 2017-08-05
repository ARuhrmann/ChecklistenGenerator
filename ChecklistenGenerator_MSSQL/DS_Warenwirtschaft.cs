using ChecklistenGenerator_Logik;
using System.Collections.Generic;

namespace ChecklistenGenerator_MSSQL
{
    public class DS_Warenwirtschaft
    {
        public DS_Warenwirtschaft()
        {
            WaWis = new List<Warenwirtschaft>();
            WaWis.Add(new Warenwirtschaft());
            WaWis.Add(new Warenwirtschaft());
            WaWis.Add(new Warenwirtschaft());
            WaWis.Add(new Warenwirtschaft());
        }

        public List<Warenwirtschaft> WaWis { get; set; }
    }
}