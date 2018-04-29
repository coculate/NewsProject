using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public  class DBHelper
    {
        private static string DBConnectString="server=.;database=DBNews;uid=sa;pwd=123456;";
        private static SqlConnection conn;
        private static SqlDataAdapter da;
        private static SqlCommand cmd;
        private static DBHelper dBHelper;

        public DBHelper()
        {
            conn = new SqlConnection(DBConnectString);           
        }

        public static DBHelper Instance()
        {
           if(dBHelper==null)
           {
               dBHelper = new DBHelper();          
           }
           return dBHelper;      
        }

         void DBOpen()
        { 
            if(conn.State== ConnectionState.Closed)
            {
                conn.Open();
            }       
        }
         void DBClose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public  DataTable GetDataTableBySql(string sql)
        {
            DBOpen();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                DBClose();
            }      
        }

        public  bool ExcuteSql(string sql)
        {
            DBOpen();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                DBClose();
            }
        }

        public  bool ExcuteProcedure(string proName,SqlParameter[] paras)
        {
            DBOpen();
            cmd = new SqlCommand(proName,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for(int i=0;i< paras.Length;i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                DBClose();
            }
        
        }

        /// <summary>
        /// 执行存储过程获得数据集
        /// </summary>
        /// <param name="proName">存储过程名</param>
        /// <param name="paras">存储过程参数</param>
        /// <returns>DataTable数据集</returns>
        public DataTable GetDataTableByProcedure(string proName, SqlParameter[] paras)
        {
            DBOpen();
            cmd = new SqlCommand(proName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            for (int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                DBClose();
            }

        }

    }
}
