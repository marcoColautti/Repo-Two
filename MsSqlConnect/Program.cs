using Microsoft.Data.SqlClient;
//using StreamReader;

    class Program
    {
        public const bool v3rb0se = true;   // Se true, oltre a scrivere nel LogBook visualizza il messaggio anche a terminale
        public const int  lineLength = 45;  // Imposta la lunghezza delle linee separatrici nei messaggi
        public const string logPath = "/Users/marco/Repo-Two/logs/";  // Imposta la posizione per il logbook
    static void Main()
    {
        Utilities.WriteBanner("Inizio");

        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "192.168.178.31";
            builder.UserID = "anapc";
            builder.Password = "adm4ANAPC1";
            builder.InitialCatalog = "ANABASE";
            builder.TrustServerCertificate = true;

            Utilities.WriteLogBook("Data Source ... : [" + builder.DataSource + "]");
            Utilities.WriteLogBook("User ID ....... : [" + builder.UserID + "]");
            Utilities.WriteLogBook("Password ...... : [***********]");
            Utilities.WriteLogBook("Catalog ....... : [" + builder.InitialCatalog + "]");
            Utilities.WriteLine("-", lineLength);

            System.Console.Clear();
            System.Console.Write("Group ID ... : ");
            String myGroupID = System.Console.ReadLine();
            Utilities.WriteLogBook($"Elaboro Gruppo .. : [{myGroupID}]");

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))

            {
                Console.WriteLine();
                Console.WriteLine("Query data example:");
                Console.WriteLine("==============================================");

                connection.Open();

                String sql = "SELECT Alimenti_ID, Descrizione_1, UM  FROM dbo.Alimenti WHERE Gruppo_ID = " + myGroupID + " ORDER BY Alimenti_ID";
                Utilities.WriteLogBook($"SQL .... : [{sql}]");

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1} ({2})", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
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