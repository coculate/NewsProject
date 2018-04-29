using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODELS;
namespace DAL
{
    public class NewsService
    {
        /// <summary>
        /// 绑定下拉列表
        /// </summary>
        /// <returns></returns>
        public static DataTable DDLBindService()
        {
            string sql = "SELECT * FROM [dbo].[NewsType]";
            return DBHelper.Instance().GetDataTableBySql(sql);
        }
        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <param name="ni"></param>
        /// <returns></returns>
        public static bool AddNewsService(NewsInfo ni)
        {
            string sql = string.Format(@"INSERT INTO [dbo].[NewsInfo]([TypeId],[Title],[Author],[Content],[PubTime])
            VALUES ('{0}','{1}','{2}','{3}','{4}')",ni.TypeId,ni.Title,ni.Author,ni.Content,ni.PubTime);
            return DBHelper.Instance().ExcuteSql(sql);
        }
        /// <summary>
        /// 绑定新闻标题
        /// </summary>
        /// <returns></returns>
        public static DataTable RepBindService()
        {
            string sql = "SELECT * FROM [dbo].[NewsInfo]";
            return DBHelper.Instance().GetDataTableBySql(sql);
        }
        /// <summary>
        /// 绑定新闻详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable ContentService(string id)
        {
            string sql = "SELECT * FROM [dbo].[NewsInfo] where NewsId='"+id+"'";
            return DBHelper.Instance().GetDataTableBySql(sql);
        }
    }
}
