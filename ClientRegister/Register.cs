using Npgsql;

namespace ClientRegister
{
    public class Register
    {
        public Connection connection = new Connection();
        public string message = "";
        private NpgsqlCommand command = new NpgsqlCommand();
        private int id = 0;
      
        public Register(string name, string email)
        {
            // command sql(crud)
            command.CommandText = "INSERT INTO clients (client_name, client_email) VALUES (@name, @email)";
            // parameters
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            id++;
            try
            {
                // connect
                command.Connection = (NpgsqlConnection?)connection.Connect();
                // command
                command.ExecuteNonQuery();
                // Disconnect
                connection.Disconnect();
                // Message
                this.message = "Registered successfully!";

            }
            catch (NpgsqlException ex)
            {
                this.message = ex.Message + ": Error connecting to database!";
            }

        }
    }
}
