using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ITEnterpriseTest
{
    class DBManager
    {
        SqlConnection connection;
        String conName = "ITEnterpriseTest.Properties.Settings.ITEnterpriseTestTaskDBConnectionString";

        public DBManager() {
        }

        //Создание связи с базой данных
        public void createConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[conName].ConnectionString;
                connection = new SqlConnection(connectionString);
            }
            catch(NullReferenceException e) {
                Console.WriteLine(e);
            }           
        }

        //Получение результата по строке запроса
        public DataSet getQueryResult(String query)
        {
            var ds = new DataSet();
            try
            {
                var dataAdapter = new SqlDataAdapter(query, connection);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                try
                {
                    dataAdapter.Fill(ds);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e);
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            return ds;

        }



    }
}
