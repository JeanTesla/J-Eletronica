using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEletronicaC_.model
{
    internal class HistoryModel
    {
        public int id {  get; set; }
        public string customer {  get; set; }
        public string electronic { get; set; }
        public string defect { get; set; }
        public int warrantyDays { get; set; }
        public DateTime inDate { get; set; }
        public DateTime? outDate { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public HistoryModel(){}

        public HistoryModel(
            string _customer, string _electronic, string _defect,
            int _warrantyDays, DateTime _inDate, DateTime? _outDate) {
            customer = _customer;
            electronic = _electronic;
            defect = _defect;
            warrantyDays = _warrantyDays;
            inDate = _inDate;
            outDate = _outDate;
        }

        public HistoryModel(
            int _id, string _customer, string _electronic, string _defect,
            int _warrantyDays, DateTime _inDate, DateTime? _outDate)
        {
            id = _id;
            customer = _customer;
            electronic = _electronic;
            defect = _defect;
            warrantyDays = _warrantyDays;
            inDate = _inDate;
            outDate = _outDate;
        }

        public HistoryModel(
            int _id, string _customer, string _electronic, string _defect,
            int _warrantyDays, DateTime _inDate)
        {
            id = _id;
            customer = _customer;
            electronic = _electronic;
            defect = _defect;
            warrantyDays = _warrantyDays;
            inDate = _inDate;
        }
    }
}
