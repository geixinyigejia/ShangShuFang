using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShangShuFang.Models
{
    public class BookInfo
    {
        // ID
        public int BookID
        {
            get;
            set;
        }

        //书的名称
        public string BookName
        {
            get;
            set;
        }

        //数量
        public int Amount
        {
            get;
            set;
        }
        //描述
        public string BookDescription
        {
            get;
            set;
        }
        //书所属的类别
        public string Bookcategory
        {
            get;
            set;
        }

        // 出版时间
        public DateTime BookPublishedDate
        {
            get;
            set;
        }
        // 出版人
        public string BookPublisher
        {
            get;
            set;
        }
        //书借出的时间
        public DateTime BookborrowedDate
        {
            get;
            set;
        }
        // 书归还的时间
        public DateTime BookReturnDate
        {
            get;
            set;
        }
        //书借出人的名称
        public string BookBorrowerName
        {
            get;
            set;
        }
        //预订人列表
        public string BookBorrowerList
        {
            get;
            set;
        }

        #region 书的评价
        public class valuation
        {
            public string valuationer
            {
                get;
                set;
            }
            public DateTime valuationDate
            {
                get;
                set;
            }

            public string valuationDescription
            {
                get;
                set;
            }
        }
        #endregion

        public enum BookCategory
        {
            少儿科普,
            计算机与互联网,
            杂志,
            哲学,
            文学,
            历史

        }
    }
}