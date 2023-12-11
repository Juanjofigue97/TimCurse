using AuthorizationFormDemo.Models;
using System.Linq;

namespace AuthorizationFormDemo.DataAccess
{
    public class SqlCrud : ISqlCrud
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;
        private MySQLDataAccess db = new MySQLDataAccess();

        public SqlCrud(IConfiguration config)
        {
            _config = config;
            _connectionString = config.GetConnectionString("Default");
        }
        public List<Agency> GetAgencies()
        {
            string sql = "SELECT Id,NombreAgencia as Name FROM formularioautorizacion.agencias;";

            return db.LoadData<Agency, dynamic>(sql, new { }, _connectionString);
        }

        public List<ChannelModel> GetChanneles()
        {
            string sql = "SELECT Id,NombreCanal as Name FROM formularioautorizacion.canales;";

            return db.LoadData<ChannelModel, dynamic>(sql, new { }, _connectionString);
        }

        public Agency GetUserById(int id)
        {
            string sql = "SELECT Id,Login,email,password FROM dbo.Users where Id = @id;";

            return db.FirstValue<Agency, dynamic>(sql, new { id = id }, _connectionString);
        }

        public void SavePerson(PersonModel model)
        {
            string canales = string.Join(",", model.CanalesAutorizados);
            
            string sql = "insert into formularioautorizacion.asociado (Nombre, Apellido,Cedula,Celular,Agencia,Canales,EsAutorizado,FechaRegistro,Ip) values (@Nombre, @Apellido,@Cedula,@Celular,@Agencia,@Canales,@EsAutorizado,@FechaRegistro,@Ip);";

            db.SaveData(sql,
                        new { 
                            model.Nombre, 
                            model.Apellido,
                            model.Cedula,
                            model.Celular,
                            model.Agencia,
                            canales,
                            model.EsAutorizado,
                            model.FechaRegistro,
                            model.Ip
                        },

                        _connectionString);
            Console.WriteLine("Datos Guardados");

        }
    }
}
