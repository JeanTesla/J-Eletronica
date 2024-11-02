using JEletronicaC_.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JEletronicaC_.helpers
{
    internal class GenericConverter
    {
        public static List<HistoryModel> ConvertDataTableToHistoryModelList(DataTable dataTable)
        {
            var list = dataTable.AsEnumerable().Select((row) =>
            {
                var outDate = row.IsNull("out_date") ? (DateTime?)null : row.Field<DateTime>("out_date");

                return new HistoryModel
                {
                    id = Convert.ToInt32(row.Field<long>("id")),
                    customer = row.Field<string>("customer"),
                    electronic = row.Field<string>("electronic"),
                    defect = row.Field<string>("defect"),
                    warrantyDays = Convert.ToInt32(row.Field<long>("warranty_days")),
                    inDate = row.Field<DateTime>("in_date"),
                    outDate = outDate
                };
            }
                
            ).ToList();

            return list;
        }
    }
}
