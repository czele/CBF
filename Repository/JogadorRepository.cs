using CBF.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CBF.Repository
{
    public class JogadorRepository : BaseRepository
    {
        
        public List<Jogador> Listar()
        {
            string query = @"
                SELECT [Id]
                      ,[Nome]
                      ,[ClubeId]
                      ,[PosicaoId]
                  FROM [dbo].[Jogador]
                  ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            var retorno = con.Query<Jogador>(query).ToList();
            return retorno;
        }

       
        public void Inserir(Jogador jogador)
        {
            string query = @"
                INSERT INTO [dbo].[Jogador]
                           ([Nome]
                           ,[ClubeId]
                           ,[PosicaoId])
                     VALUES
                           (@Nome
                           ,@ClubeId
                           ,@PosicaoId
                ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            con.Execute(query, new { jogador.ClubeId, jogador.Nome, jogador.PosicaoId });
        }

        public Jogador Obter()
        {
            string query = @"
                SELECT [Id]
                      ,[Nome]
                      ,[ClubeId]
                      ,[PosicaoId]
                  FROM [dbo].[Jogador]
                  WHERE Nome = @Nome";

            var con = new SqlConnection(_connectionString);
            con.Open();
            var retorno = con.Query<Jogador>(query).FirstOrDefault();
            return retorno;
        }
    }
}
