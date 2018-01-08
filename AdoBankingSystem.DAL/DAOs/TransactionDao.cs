using AdoBankingSystem.DAL.Interfaces;
using AdoBankingSystem.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoBankingSystem.DAL.DAOs
{
    public class TransactionDao : IDAO<TransactionDto>
    {
        private SqlConnection sqlConnection;
        public string Create(TransactionDto record)
        {
            throw new NotImplementedException();
        }

        public TransactionDto Read(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<TransactionDto> Read()
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            string baseQuery = "DELETE FROM [dbo].[Transactions] WHERE Id = " + id;
            using (sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand( baseQuery,sqlConnection))
                {
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public string Update(TransactionDto record)
        {
            string baseQuery = "";
            using (sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(baseQuery, sqlConnection))
                {
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
    }
}
