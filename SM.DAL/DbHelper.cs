// ===============================================================================
// 
// DbHelper.cs
//
// This file contains custom connection and DbHelper methods. 
//

// ===============================================================================
// Release history
// VERSION	DESCRIPTION
//   1.0	New
// Author: Sharif Uddin
// Date  : 8/25/2008
// ===============================================================================
// Copyright (C) 2008 Scube Software and Consulting LLC
// All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
// ==============================================================================

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace SM.DAL
{
    public class DbHelper
    {
        private static SqlConnection conn;
       // private static String myConnectionString = "Data Source=KUKS-PC\\SQLEXPRESS;Initial Catalog=StoreManagement;User ID=sumon;Password=sumon123";

        static DbHelper()
        {
            GetConnection();
        }

        public static string ConnectionString
        {
            get
            {
                //return myConnectionString;
                return ((System.Configuration.ConnectionStringsSection)System.Configuration.ConfigurationManager.GetSection("connectionStrings")).ConnectionStrings[1].ConnectionString;
            }
        }
        public static ConnectionStringsSection GetConnectionStringsSection()
        {
            return ConfigurationManager.GetSection("connectionStrings") as ConnectionStringsSection;
        }

        private static string GetConnectionString()
        {
            //return myConnectionString;
            return GetConnectionStringsSection().ConnectionStrings[1].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(GetConnectionString());
            }
            return conn;
        }

        public static SqlConnection GetOpenConnection()
        {
            if (conn == null)
                conn = GetConnection();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            return conn;
        }

        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
                //conn.Dispose();
                
            }
            //conn = null;
        }

        public static DataSet GetDataSet(CommandType commandType, string commandText)
        {
            return GetDataSet(commandType, commandText, null);
        }
        public static DataSet GetDataSet(CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            DataSet ds;
            SqlConnection conn = GetOpenConnection();
            try
            {
                ds = SqlHelper.ExecuteDataset(conn, commandType, commandText, commandParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection(conn);
            }
            return ds;
        }

        public static int ExecuteNonQuery(CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            int result = 0;
            SqlConnection conn = GetOpenConnection();
            try
            {
                result = SqlHelper.ExecuteNonQuery(conn, commandType, commandText, commandParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection(conn);
            }
            return result;
        }

        public static SqlDataReader ExecuteReader(CommandType commandType, string commandText, SqlParameter[] commandParameters, ref SqlConnection conn)
        {
            conn = GetOpenConnection();
            return SqlHelper.ExecuteReader(conn, commandType, commandText, commandParameters);
        }


    }
}
