using System;
using System.Collections.Generic;

namespace Mission1.Model
{
    public class Customer
    {
        public string PhoneNo { get; set; }
        public string Name { get; set; } // Add this property
        public List<PointRecord> PointRecords { get; set; }
        public int Balance { get; set; }
        public int VisitCount { get; set; }
        public DateTime LastVisitDate { get; set; }

        public Customer()
        {
            PointRecords = new List<PointRecord>();
            Balance = 0;
            VisitCount = 0;
            LastVisitDate = DateTime.Now;
        }

        public Customer(string phoneNo, string name) : this() // Updated constructor
        {
            PhoneNo = phoneNo;
            Name = name;
        }

        public bool UsePoint(int point)
        {
            if (Balance >= point)
            {
                PointRecord record = new PointRecord(DateTime.Now, point, PointRecordTypeEnum.Use);
                PointRecords.Add(record);

                Balance -= point;
                VisitCount += 1;
                LastVisitDate = DateTime.Now;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void EarnPoint(int point)
        {
            PointRecord record = new PointRecord(DateTime.Now, point, PointRecordTypeEnum.Earn);
            PointRecords.Add(record);

            Balance += point;
            VisitCount += 1;
            LastVisitDate = DateTime.Now;
        }
    }
}
