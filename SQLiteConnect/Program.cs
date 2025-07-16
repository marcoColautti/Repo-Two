using Microsoft.Data.SqlClient;
using System;
using System.Data.SQLite;

    class Program
    {

        public const bool v3rb0se = false;   // Se true, oltre a scrivere nel LogBook visualizza il messaggio anche a terminale
        public const int  lineLength = 45;  // Imposta la lunghezza delle linee separatrici nei messaggi




        static void Main()
        {

// ------------------------------------------------------------------------------------
            Utilities.WriteBanner("Inizio");

            try 
            { 
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource             = "192.168.178.31"; 
                builder.UserID                 = "anapc";            
                builder.Password               = "adm4ANAPC1";     
                builder.InitialCatalog         = "ANABASE";
                builder.TrustServerCertificate = true;
         
                Utilities.WriteLogBook("Data Source ... : [" + builder.DataSource + "]");
                Utilities.WriteLogBook("User ID ....... : [" + builder.UserID + "]");
                Utilities.WriteLogBook("Password ...... : [***********]");
                Utilities.WriteLogBook("Catalog ....... : [" + builder.InitialCatalog + "]");
                Utilities.WriteLine("-", lineLength);

 //               using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
 //               
 //               {
 //                   connection.Open();
 //                   Utilities.WriteLine("-", lineLength);
 //                   Utilities.WriteLogBook("Connessione al database MSSQL stabilita con successo.");
 //                   Utilities.WriteLine("-", lineLength);
 //                   connection.Close();
 //               }
                
            }
            catch (SqlException ex)
            {
                Utilities.WriteError(ex.Message);
            }

// ------------------------------------------------------------------------------------

            // Percorso del database SQLite (se non esiste, sarà creato)
            string connectionString = "Data Source=data/Cuba.db;Version=3;";

            // Crea la connessione al database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Apri la connessione
                    connection.Open();
                    Console.WriteLine("Connessione al database SQLite stabilita con successo.");

                    string selectDataQuery = @"SELECT id_local, originalFilename FROM agLibraryFile WHERE originalFilename like 'P2160%'";
                    using (SQLiteCommand selectDataCommand = new SQLiteCommand(selectDataQuery, connection))
                    using (SQLiteDataReader reader = selectDataCommand.ExecuteReader())
                    {
                        Console.WriteLine("Dati presenti nella tabella 'agLibraryFile':");
                        int conta = 0;
                        while (reader.Read())
                        {   
                                if ( reader["originalFilename"] is not null)
                                {
                                    int    idLocal     = Convert.ToInt32(reader["id_local"]);    
                                    string newFilename = Convert.ToString(reader["originalFilename"]);    
                                    Console.Write($"Nome originale : {newFilename} \t");    
                                    string baseName = newFilename.Replace("P2160","P2305_0");
                                    Console.WriteLine($"New : {baseName}");

                                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE agLibraryFile SET baseName = @Value1 WHERE id_local = @ID", connection))
                                    {
                                        cmd.Parameters.AddWithValue("@Value1", "{baseName}");
                                        cmd.Parameters.AddWithValue("@ID", idLocal);
                                        try
                                        {
                                            conta = conta + cmd.ExecuteNonQuery();
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("An error occurred: " + ex.Message);
                                        }
                                    }

                                }
                                
                        }

                        System.Console.WriteLine($"Aggiornate {conta} righe.");
                    }

                    // Chiudi la connessione
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Utilities.WriteError(ex.Message);
                }
            }

            Utilities.WriteBanner("Fine");
        }

    }