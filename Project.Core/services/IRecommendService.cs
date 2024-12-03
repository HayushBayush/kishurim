
using Project.Entities;
using System.Collections.Generic;

namespace Project.Core.services
{
    public interface IRecommendService
    {
        List<Recommend> GetList();           // GET - מחזירה רשימה של המלצות
        Recommend GetById(int id);           // GET BY ID - מחזירה המלצה לפי מזהה
        void AddRecommend(Recommend recommend); // POST - מוסיפה המלצה חדשה
        void UpdateRecommend(Recommend recommend); // PUT - מעדכנת המלצה קיימת
        void DeleteRecommend(int id);         // DELETE - מסירה המלצה לפי מזהה (אופציונלי)
    }
}



