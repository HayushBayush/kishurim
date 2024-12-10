using Project.Core.services;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.Services
{
    public class WebService : IWebService
    {
        private readonly List<Web> _webs;

        //public WebService()
        //{
        //    _webs = new List<Web>
        //    {
        //        new Web { id = 1, name = "Google", link = "https://www.google.com" },
        //        new Web { id = 2, name = "Facebook", link = "https://www.facebook.com" }
        //    };
        //}

        public List<Web> GetList()
        {
            return _webs;
        }

        public Web GetById(int id)
        {
            return _webs.FirstOrDefault(w => w.id == id);
        }

        public Web Add(Web web)
        {
            _webs.Add(web);
            return web;
        }

        public Web Update(int id, Web web)
        {
            var existingWeb = _webs.FirstOrDefault(w => w.id == id);
            if (existingWeb != null)
            {
                existingWeb.name = web.name;
                existingWeb.link = web.link;
                return existingWeb;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var web = _webs.FirstOrDefault(w => w.id == id);
            if (web != null)
            {
                _webs.Remove(web);
                return true;
            }
            return false;
        }
    }
}
