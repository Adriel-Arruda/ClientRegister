using Npgsql;
using System.Data;

namespace ClientRegister
{
    public class Connection
    {
        private readonly IDbConnection _connection;
        private readonly string _Host = "ec2-3-227-154-49.compute-1.amazonaws.com";
        private readonly string _User = "oosqcpgbwehzdh";
        private readonly string _DBname = "davsh4a0jpvtj0";
        private readonly string _Password = "2b6e2c976ac51b5c3b00e785b9398cfa63f760dfc037eb8e57a0c4d8595d063d";
        private readonly string _Port = "5432";
        

        
        //construtor
        public Connection()
        {
            string connString = $"Server={_Host};Username={_User};Database={_DBname};Port={_Port};Password={_Password};SSLMode=Prefer";
            _connection = new NpgsqlConnection(connString);
        }
        //Conect to database method
        public IDbConnection Connect()
        {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }
        
        //Desconet to database

        public void Disconnect()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

        }
    }
}
