using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//added new using 
using System.Data;
using System.Data.SqlClient;
using ShangShuFang.Models;
using System.Reflection;

namespace ShangShuFang.Models
{
    public class DALCommon
    {
        public static string DBName = "GoSanctum";
        public static string defaultSchemaName = "dbo.";
        public static string connString = "Data Source=JENNY\\SQLEXPRESS;Integrated Security=True";

        public static SqlConnection connectonToMSSQL()
        {
            SqlConnection Sqlconn = new SqlConnection(connString);
            return Sqlconn;
        }

        public static List<BookInfo> GetAllBooksInfo()
        {
            List<BookInfo> booksInfo = new List<BookInfo>();
            SqlConnection sqlconn = connectonToMSSQL();

            string sqlCommand = string.Format(@"use {0}; select * from BookInfo ", DBName);

            sqlconn.Open();

            SqlCommand cmd = new SqlCommand(sqlCommand, sqlconn);

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {

                BookInfo aBook = new BookInfo();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PropertyInfo property = aBook.GetType().GetProperty(reader.GetName(i));
                    property.SetValue(aBook, reader.IsDBNull(i) ? "[null]" : reader.GetValue(i), null);
                }
                booksInfo.Add(aBook);
            }
            reader.Close();
            return booksInfo;
        }
    }
}