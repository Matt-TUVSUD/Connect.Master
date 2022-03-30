using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRC.Connect.Libraries.PowerBILib.Entities
{
    public class PBDatasetMaster
    {
        public Int32 ID { get; set; }
        public string DataSetName { get; set; }
        public Guid DatasetID { get; set; }
        public Guid WorkSpaceID { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public Int32 AccountID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
