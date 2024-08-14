using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1.Model
{
    public class PointRecord
    {
        public DateTime RecordDate { get; set; }
        public int Points { get; set; } // Pastikan menggunakan `Points`, bukan `Amount`
        public PointRecordTypeEnum RecordType { get; set; } // Pastikan menggunakan `RecordType`

        public PointRecord(DateTime recordDate, int points, PointRecordTypeEnum recordType)
        {
            RecordDate = recordDate;
            Points = points; // Pastikan menggunakan `Points`, bukan `Amount`
            RecordType = recordType;
        }
    }
}
