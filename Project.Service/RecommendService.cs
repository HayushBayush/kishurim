using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.services
{
    public class RecommendService : IRecommendService
    {
        private readonly List<Recommend> _recommends;

        public RecommendService()
        {
            _recommends = new List<Recommend>
            {
                new Recommend { Id = 1, Name = "Recommendation 1", Description = "Description for recommendation 1" },
                new Recommend { Id = 2, Name = "Recommendation 2", Description = "Description for recommendation 2" },
                // ניתן להוסיף המלצות נוספות לדוגמה
            };
        }

        public List<Recommend> GetList()
        {
            return _recommends;
        }

        public Recommend GetById(int id)
        {
            return _recommends.FirstOrDefault(r => r.Id == id);
        }

        public void AddRecommend(Recommend recommend)
        {
            _recommends.Add(recommend);
        }

        public void UpdateRecommend(Recommend recommend)
        {
            var existingRecommend = GetById(recommend.Id);
            if (existingRecommend != null)
            {
                existingRecommend.Name = recommend.Name;
                existingRecommend.Description = recommend.Description;
            }
        }

        public void DeleteRecommend(int id)
        {
            var recommend = GetById(id);
            if (recommend != null)
            {
                _recommends.Remove(recommend);
            }
        }
    }
}
