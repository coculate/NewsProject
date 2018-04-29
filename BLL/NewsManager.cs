using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using MODELS;
namespace BLL
{
    public class NewsManager
    {
         /// <summary>
        /// 绑定下拉列表
        /// </summary>
        /// <returns></returns>
        public static DataTable DDLBindManager()
        {
            return DAL.NewsService.DDLBindService();
        }

         /// <summary>
        /// 添加新闻
        /// </summary>
        /// <param name="ni"></param>
        /// <returns></returns>
        public static bool AddNewsManager(NewsInfo ni)
        {
            return DAL.NewsService.AddNewsService(ni);
        }

        /// <summary>
        /// 绑定新闻标题
        /// </summary>
        /// <returns></returns>
        public static DataTable RepBindManager()
        {
            return DAL.NewsService.RepBindService();
        }

        /// <summary>
        /// 绑定新闻详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable ContentManager(string id)
        {
            return DAL.NewsService.ContentService(id);
        }
    }
}
