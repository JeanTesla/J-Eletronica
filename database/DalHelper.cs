using JEletronicaC_.helpers;
using JEletronicaC_.model;
using System.Data;
using System.Data.SQLite;

namespace JEletronicaC_.database
{
    internal class DalHelper
    {

        private static SQLiteConnection sqliteConnection;

        public DalHelper(){ }

        private static SQLiteConnection DbConnection()
        {
        string dataBasePath = FileHelper.ReadConfigFile()[0];

        sqliteConnection = new SQLiteConnection("Data Source="+ dataBasePath + "\\database.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public static void CriarBancoSQLite()
        {
            string dataBasePath = FileHelper.ReadConfigFile()[0];
            try
            {
                FileHelper.createFile(dataBasePath, "database.sqlite");
            }
            catch
            {
                throw;
            }
        }
        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS " +
                        "History(" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "customer Varchar(80)," +
                        "electronic VarChar(80)," +
                        "defect VarChar(500)," +
                        "warranty_days INTEGER," +
                        "in_date DATE," +
                        "out_date DATE," +
                        "created_at DATETIME," +
                        "updated_at DATETIME" +
                        ")";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetHistorys()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT " +
                        "id, customer, electronic, defect, warranty_days," +
                        "strftime('%d/%m/%Y',in_date) as in_date," +
                        "strftime('%d/%m/%Y',out_date) as out_date," +
                        "strftime('%d/%m/%Y',created_at) as created_at," +
                        "created_at as created_at_full " +
                        "FROM History ORDER BY created_at_full DESC";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetHistory(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM History Where id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Add(HistoryModel history)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO History(" +
                        "customer, electronic, defect," +
                        "warranty_days, in_date," +
                        "created_at, updated_at) " +
                        "values" +
                        "(@customer, @electronic, @defect," +
                        "@warranty_days, @in_date," +
                        "@created_at, @updated_at)";
                    cmd.Parameters.AddWithValue("@customer", history.customer);
                    cmd.Parameters.AddWithValue("@electronic", history.electronic);
                    cmd.Parameters.AddWithValue("@defect", history.defect);
                    cmd.Parameters.AddWithValue("@warranty_days", history.warrantyDays);
                    cmd.Parameters.AddWithValue("@in_date", history.inDate);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Update(HistoryModel history)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    
                    cmd.CommandText = "UPDATE History SET " +
                        "customer=@customer, electronic=@electronic," +
                        "defect=@defect, warranty_days=@warranty_days," +
                        "in_date=@in_date " +
                        "WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", history.id);
                    cmd.Parameters.AddWithValue("@customer", history.customer);
                    cmd.Parameters.AddWithValue("@electronic", history.electronic);
                    cmd.Parameters.AddWithValue("@defect", history.defect);
                    cmd.Parameters.AddWithValue("@warranty_days", history.warrantyDays);
                    cmd.Parameters.AddWithValue("@in_date", history.inDate);

                    cmd.ExecuteNonQuery();
                    
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetOutDate(int historyId, DateTime? datetime)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {

                    cmd.CommandText = "UPDATE History SET " +
                        "out_date=@out_date " +
                        "WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", historyId);
                    cmd.Parameters.AddWithValue("@out_date", datetime);

                    cmd.ExecuteNonQuery();

                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Delete(int id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM History Where id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
