using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dapper;

namespace smartsuite.data.Repository
{
    class Repository : IRepository
    {

        private SqlConnection connection = new SqlConnection();

        public bool Insert(string id)
        {
            try
            {
                this.connection.Query("", new {}, commandTimeout: 0,
                    commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                this.connection.Query("", new { }, commandTimeout: 0,
                    commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(string id)
        {
            try
            {
                this.connection.Query("", new { }, commandTimeout: 0,
                    commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
