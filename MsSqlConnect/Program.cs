using Microsoft.Data.SqlClient;
//using StreamReader;

    class Program
    {
        public const bool v3rb0se = true;   // Se true, oltre a scrivere nel LogBook visualizza il messaggio anche a terminale
        public const int  lineLength = 45;  // Imposta la lunghezza delle linee separatrici nei messaggi

        static void Main()
        {
            Utilities.WriteBanner("Inizio");

            try 
            { 
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource             = "Localhost\\SQLEXPRESS"; 
                builder.UserID                 = "usql";            
                builder.Password               = "adm4SQL1";     
                builder.InitialCatalog         = "Tutorial";
                builder.TrustServerCertificate = true;
         
                Utilities.WriteLogBook("Data Source ... : [" + builder.DataSource + "]");
                Utilities.WriteLogBook("User ID ....... : [" + builder.UserID + "]");
                Utilities.WriteLogBook("Password ...... : [***********]");
                Utilities.WriteLogBook("Catalog ....... : [" + builder.InitialCatalog + "]");
                Utilities.WriteLine("-", lineLength);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                
                {
                    Console.WriteLine();
                    Console.WriteLine("Query data example:");
                    Console.WriteLine("==============================================");
                    
                    connection.Open();       

                    String sql = "SELECT codice_belfiore, denominazione_ita, sigla_provincia FROM dbo.gi_comuni WHERE flag_capoluogo = 'SI' ORDER BY denominazione_ita";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1} ({2})", reader.GetString(0), reader.GetString(1), reader.GetString(2));
                            }
                        }
                    }                    
                }
            }
            catch (SqlException e)
            {
                Utilities.WriteError(e.ToString());
            }

            Utilities.WriteBanner("Fine");
        }
    }