using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class InterestsManager :IInterestsManager
    {
        private readonly ApplicationContext _applicationContext;
        public InterestsManager(ApplicationContext context)
        {
            _applicationContext = context;
        }
        public void Dispose()
        {
            _applicationContext.Dispose();
        }

        public IEnumerable<Interests> GetAll()
        {
            return _applicationContext.Interests.ToList();
        }

        public Interests Get(int id)
        {
            return _applicationContext.Interests.Find(id);
        }

        public IEnumerable<Interests> Find(Func<Interests, bool> predicate)
        {
            return _applicationContext.Interests.Where(predicate).ToList();
        }

        public void Create(Interests item)
        {
            _applicationContext.Interests.Add(item);
        }

        public void Update(Interests item)
        {
            _applicationContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var interests = _applicationContext.Interests.Find(id);
            if (interests != null)
            {
                _applicationContext.Interests.Remove(interests);
            }
        }
    }
}
