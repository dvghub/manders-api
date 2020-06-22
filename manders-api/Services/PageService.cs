using manders_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Services {
    public class PageService {
        private readonly DbService db = new DbService();

        public string Read(string page) {
            PageContent pageContent = db.Contents.Where(c => c.Page == page).FirstOrDefault();
            if (pageContent == null) return null;

            return pageContent.Content;
        }

        public string Update(PageContent content) {
            PageContent pageContent = db.Contents.Where(c => c.Page == content.Page).FirstOrDefault();
            if (pageContent == null) {
                pageContent = new PageContent();
                pageContent.Page = content.Page;
                pageContent.Content = content.Content;
                db.Contents.Add(pageContent);
            } else {
                pageContent.Content = content.Content;
            }
           
            db.SaveChanges();
            return pageContent.Content;
        }
    }
}