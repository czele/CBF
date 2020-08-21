using CBF.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Repository
{
    public class PartidaRepository : BaseRepository
    {
        public void Inserir(Partida partida)
        {
            string query = @"
                INSERT INTO [dbo].[Partida]
                           ([MandanteId]
                           ,[GolsMandante]
                           ,[VisitanteId]
                           ,[GolsVisitante])
                     VALUES
                           (@MandanteId
                           ,@GolsMandante
                           ,@VisitanteId
                           ,@GolsVisitante)
";

            var con = new SqlConnection(_connectionString);
            con.Open();
            con.Execute(query, new { partida.MandanteId, partida.VisitanteId, partida.GolsMandante, partida.GolsVisitante });

        }

        public List<Partida> Listar()
        {
            string query = @"
                SELECT [Id]
                      ,[MandanteId]
                      ,[GolsMandante]
                      ,[VisitanteId]
                      ,[GolsVisitante]
                  FROM [dbo].[Partida]";

            var con = new SqlConnection(_connectionString);
            con.Open();
            var retorno = con.Query<Partida>(query).ToList();
            return retorno;
        }
    }
}
