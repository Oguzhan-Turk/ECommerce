using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Common;
using ECommerce.Entity;
using ECommerce.Service.api;

namespace ECommerce.Service
{
    public class CategoryService : ICategoryService<Category>
    {
        public bool Delete(int id)
        {
            string query = $"DELETE FROM Category WHERE CategoryID = {id};";
            return Tools.SqlCommandConnectionWithQuery(query);
        }

        public bool Insert(Category entity)
        {
            string query = $"INSERT INTO Category (CategoryName, CategoryDescription) VALUES('{entity.CategoryName}', '{entity.CategoryDescription}'); ";

            return Tools.SqlCommandConnectionWithQuery(query);
        }

        public List<Category> Find()
        {
            string query = "SELECT * FROM Category";
            DataTable dataTable = Tools.GetDataTableUseQuery(query);

            return Tools.ToList<Category>(dataTable);
        }
        public Category FindById(int id)
        {
            string query = $"SELECT * FROM Address Where CategoryID = {id} ";
            DataTable dataTable = Tools.GetDataTableUseQuery(query);

            return Tools.DataTableToEntity<Category>(dataTable);
        }

        public bool Update(Category entity)
        {
            string query = $"UPDATE Category SET [CategoryName] = '{entity.CategoryName}', [CategoryDescription] = '{entity.CategoryDescription}' WHERE CategoryID = {entity.CategoryID};";
            return Tools.SqlCommandConnectionWithQuery(query);
        }
    }
}
