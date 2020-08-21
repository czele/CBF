using CBF.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Repository
{
    public class ClubeRepository : BaseRepository
    {
        
        public Clube Obter(string Nome)
        {
            string query = @"
                SELECT [Id]
                      ,[Nome]
                      ,[Pontos]
                  FROM [dbo].[Clube] 
                  WHERE Nome = @Nome";

            var con = new SqlConnection(_connectionString);
            con.Open();
            var retorno = con.Query<Clube>(query, new { Nome }).FirstOrDefault();
            return retorno;
        }

        public Clube Obter(int Id)
        {
            string query = @"
                SELECT [Id]
                      ,[Nome]
                      ,[Pontos]
                  FROM [dbo].[Clube] 
                  WHERE Id = @Id";

            var con = new SqlConnection(_connectionString);
            con.Open();
            var retorno = con.Query<Clube>(query, new { Id }).FirstOrDefault();
            return retorno;
        }

        public List<Clube> Listar()
        {
            string query = @"
                SELECT [Id]
                      ,[Nome]
                      ,[Pontos]
                  FROM [dbo].[Clube] 
                  ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            var retorno = con.Query<Clube>(query).ToList();
            return retorno;
        }
    }
}
