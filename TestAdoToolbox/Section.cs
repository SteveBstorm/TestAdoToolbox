using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdoToolbox
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

        public static Section Converter(SqlDataReader reader)
        {
            return new Section
            {
                Id = (int)reader["Id"],
                SectionName = (string)reader["SectionName"]
            };
        }
    }
}
