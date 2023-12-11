using AuthorizationFormDemo.Models;

namespace AuthorizationFormDemo.DataAccess
{
    public class SqlLite : ISqlCrud
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;
        private SQLiteDataAccess db = new SQLiteDataAccess();

        public SqlLite(IConfiguration config)
        {
            _config = config;
            _connectionString = config.GetConnectionString("SQLite");
        }
        public List<Agency> GetAgencies()
        {
            string sql = "SELECT Id,NombreAgencia as Name FROM agencias;";

            return db.LoadData<Agency, dynamic>(sql, new { }, _connectionString);
        }

        public List<ChannelModel> GetChanneles()
        {
            string sql = "SELECT Id,NombreCanal as Name FROM canales;";

            return db.LoadData<ChannelModel, dynamic>(sql, new { }, _connectionString);
        }

        public Agency GetUserById(int id)
        {
            string sql = "SELECT Id,Login,email,password FROM dbo.Users where Id = @id;";

            return db.FirstValue<Agency, dynamic>(sql, new { id = id }, _connectionString);
        }

        public void SavePerson(PersonModel model)
        {
            string CanalesLista = string.Join(",", model.CanalesAutorizados);

            string sql = "insert into asociado (Nombre, Apellido,Cedula,Celular,Agencia,CanalesLista,EsAutorizado,FechaRegistro,Ip) values (@Nombre, @Apellido,@Cedula,@Celular,@Agencia,@CanalesLista,@EsAutorizado,@FechaRegistro,@Ip);";

            db.SaveData(sql,
                        new
                        {
                            model.Nombre,
                            model.Apellido,
                            model.Cedula,
                            model.Celular,
                            model.Agencia,
                            CanalesLista,
                            model.EsAutorizado,
                            model.FechaRegistro,
                            model.Ip
                        },

                        _connectionString);
            Console.WriteLine("Datos Guardados");

        }
    }
}
