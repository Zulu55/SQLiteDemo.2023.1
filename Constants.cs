using SQLite;

namespace SQLiteDemo
{
    public static class Constants
    {
        private const string dbFileName = "SQLite.db3";

        public const SQLiteOpenFlags flags = SQLiteOpenFlags.ReadWrite |
                                              SQLiteOpenFlags.Create |
                                              SQLiteOpenFlags.SharedCache;

        public static string DatabasePath => Path.Combine(FileSystem.AppDataDirectory, dbFileName);

    }
}
