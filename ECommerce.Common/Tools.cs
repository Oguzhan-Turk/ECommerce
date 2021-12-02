using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common
{
    public static class Tools
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection($"Server=.; DataBase=NorthWind;Integrated Security=True;");
                }
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

        public static List<ET> ToList<ET>(this DataTable dataTable) where ET : class, new()

        {
            Type type = typeof(ET);
            List<ET> list = new List<ET>();
            PropertyInfo[] properties = type.GetProperties();
            foreach (DataRow dataRows in dataTable.Rows)
            {
                ET entity = new ET();
                foreach (PropertyInfo property in properties)
                {
                    object value = dataRows[property.Name];
                    if (value != null)
                    {
                        property.SetValue(entity, value);
                    }
                }
                list.Add(entity);
            }
            return list;
        }
        public static ET DataTableToEntity<ET>(this DataTable dataTable) where ET : class, new()
        {
            Type type = typeof(ET);
            ET entity = new ET();
            PropertyInfo[] properties = type.GetProperties();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (PropertyInfo property in properties)
                {
                    object value = dataRow[property.Name];
                    if (value != null)
                        property.SetValue(entity, value);
                }
            }
            return entity;
        }

        public static bool SqlCommandConnectionWithQuery(string query)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = Tools.Connection;
            Tools.Connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            Tools.Connection.Close();
            if (affectedRows > 0)
                return true;
            else
                return false;
        }
        public static DataTable GetDataTableUseQuery(string query)
        {
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = new SqlCommand();
            adaptor.SelectCommand.CommandText = query;
            adaptor.SelectCommand.Connection = Tools.Connection; 
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            return dataTable;
        }

    }
}
