using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Security.Policy;

namespace AbSimpleBrowser
{
   
     class DbHelper
    {
        private static string connString = @"Data Source=..\..\Files\browser.db;Version=3;";

        public static void Migrations()
        {
            if(!File.Exists(@"Data Source=..\..\Files\browser.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\Files\browser.db");

                using (var conn = new SQLiteConnection(connString))
                {
                    conn.Open();


                    //Create History table.
                    string createHistoryTableQuery = @"
                        CREATE TABLE IF NOT EXISTS history (
                            id  INTEGER PRIMARY KEY AUTOINCREMENT,
                            url TEXT NOT NULL,
                            date_visited DATETIME NOT NULL
                        );";

                    //create favorites table.
                    string createFavoritesTableQuery = @"
                        CREATE TABLE IF NOT EXISTS favorites (
                            id  INTEGER PRIMARY KEY AUTOINCREMENT,
                            title TEXT NOT NULL UNIQUE,
                            url TEXT NOT NULL UNIQUE,
                            date_added DATETIME NOT NULL
                        );";

                    // create downloads table.
                    string createDownloadsTableQuery = @"
                        CREATE TABLE IF NOT EXISTS downloads (
                            id  INTEGER PRIMARY KEY AUTOINCREMENT,
                            filename TEXT NOT NULL,
                            url TEXT NOT NULL,
                            date_downloaded DATETIME NOT NULL
                        );";

                    // create homepage table.
                    string createHomePageTableQuery = @"
                        CREATE TABLE IF NOT EXISTS homepage (
                            id  INTEGER PRIMARY KEY AUTOINCREMENT,
                            url TEXT NOT NULL
                        );";

                    //create menu items table
                    string createMenuItemsTableQuery = @"
                        CREATE TABLE IF NOT EXISTS menuItems (
                            id  INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL
                        );";

                    // Table Query Execution.
                    using (var command = new SQLiteCommand(conn))
                    {

                        try
                        {
                            command.CommandText = createHistoryTableQuery;
                            command.CommandText += createFavoritesTableQuery;
                            command.CommandText += createDownloadsTableQuery;
                            command.CommandText += createHomePageTableQuery;
                            command.CommandText += createMenuItemsTableQuery;
                            command.ExecuteNonQuery();


                        }
                        catch (System.Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }

                    }

                    //seeders
                    Seed(conn);

                    conn.Close();
                }
            }
        }

        private static void Seed(SQLiteConnection conn)
        {
            string seedHomePageTable = @"INSERT INTO homepage (url) VALUES (@url);";

            string seedMenuItemsTable = @"INSERT INTO menuItems (name) VALUES (@name);";

            string seedFavoriteTable = @"INSERT INTO favorites (title, url, date_added) VALUES (@title, @url, @date_added)";
            using (var command = new SQLiteCommand(conn))
            {
                // Seed Homepage.
                command.CommandText = seedHomePageTable;
                command.Parameters.AddWithValue("@url", "https://www.hw.ac.uk");
                command.ExecuteNonQuery();

                // Seed MenuItems.
                command.CommandText = seedMenuItemsTable;
                command.Parameters.AddWithValue("@name", "set homepage");
                command.ExecuteNonQuery();
                command.CommandText = seedMenuItemsTable;
                command.Parameters.AddWithValue("@name", "see all history");
                command.ExecuteNonQuery();
                command.CommandText = seedMenuItemsTable;
                command.Parameters.AddWithValue("@name", "see favorite");
                command.ExecuteNonQuery();
                command.CommandText = seedMenuItemsTable;
                command.Parameters.AddWithValue("@name", "see all downloads");
                command.ExecuteNonQuery();
                command.CommandText = seedMenuItemsTable;
                command.Parameters.AddWithValue("@name", "change theme");
                command.ExecuteNonQuery();

                // Seed Favorite.
                command.CommandText = seedFavoriteTable;
                command.Parameters.AddWithValue("@title", "Heriot Watt Unviersity");
                command.Parameters.AddWithValue("@url", "https://www.hw.ac.uk");
                command.Parameters.AddWithValue("@date_added", DateTime.Now);
                command.ExecuteNonQuery();
                command.CommandText = seedFavoriteTable;
                command.Parameters.AddWithValue("@title", "EA Sports");
                command.Parameters.AddWithValue("@url", "https://ea.com");
                command.Parameters.AddWithValue("@date_added", DateTime.Now);
                command.ExecuteNonQuery();

            }
        }

        public static void AddToHistory(WebsiteDto website)
        {
            //add visited websites to history.
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                string addToHistoryQuery = @"
                    INSERT INTO history (url, date_visited)
                    VALUES (@url, @date_visited)";

                using (var command = new SQLiteCommand(conn))
                {
                    command.CommandText = addToHistoryQuery;
                    command.Parameters.AddWithValue("@url", website.Url );
                    command.Parameters.AddWithValue("@date_visited", DateTime.Parse(website.VisitTimestamp));
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }


        public static bool isFavorite(WebsiteDto website)
        {
            bool result = false;
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                string getAllHistoryQuery = @"SELECT * FROM history WHERE url = @url";
                using (SQLiteCommand command = new SQLiteCommand(getAllHistoryQuery, conn))
                {
                    command.Parameters.AddWithValue("@url", website.Url);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            string url =  reader.GetString(1);
                            result = website.Url == url;
                        }
                    }
                }

                conn.Close();
                return result;
            }
                
        }

        public static List<WebsiteDto> getHistory()
        {
            List<WebsiteDto> history = new List<WebsiteDto>();
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                string getAllHistoryQuery = @"SELECT * FROM history";
                SQLiteCommand command = new SQLiteCommand(getAllHistoryQuery, conn);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string url = reader.GetString(reader.GetOrdinal("url"));
                        string date_visited = reader.GetString(reader.GetOrdinal("date_visited"));
                        WebsiteDto website = new WebsiteDto() { Url = url, VisitTimestamp = date_visited.ToString(), IsFavorite = false };
                        if (isFavorite(website))
                        {
                            website.IsFavorite = true;
                        }
                        history.Add(website);
                    }
                }

                conn.Close();

            }

            return history;
        }

        public static List<WebsiteDto> getFavorites()
        {
            List<WebsiteDto> favorites = new List<WebsiteDto>();
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                string getAllFavQuery = @"SELECT * FROM favorites";
                SQLiteCommand command = new SQLiteCommand(getAllFavQuery, conn);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("id"));
                        string title = reader.GetString(reader.GetOrdinal("title"));
                        string url = reader.GetString(reader.GetOrdinal("url"));
                        string date_added = reader.GetString(reader.GetOrdinal("date_added"));

                        favorites.Add(new WebsiteDto() {  Url=url, VisitTimestamp=date_added.ToString(), IsFavorite=true});
                    }

                }


                conn.Close();
            }

            return favorites;
        }


        public static string getHomepage()
        {
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                string url = "";

                string getCurrentHomeQuery = @"SELECT * FROM homepage";
                SQLiteCommand command = new SQLiteCommand(getCurrentHomeQuery, conn);

                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        url = reader.GetString(reader.GetOrdinal("url"));
                    }
                    
                }

                conn.Close();

                return url;
            }

            
        }


        public static void getBulkDownloadList()
        {
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();




                conn.Close();
            }
        }



    }
}
