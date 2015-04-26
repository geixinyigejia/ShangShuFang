using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//
using PagedList;
using ShangShuFang.Models;

namespace ShangShuFang.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index(int p = 1)
        {
            List<BookInfo> booksInfo = ShangShuFang.Models.DALCommon.GetAllBooksInfo();
            var pagedData = booksInfo.ToPagedList(pageNumber: p, pageSize: 20);
            return View(pagedData);
        }
    }
}