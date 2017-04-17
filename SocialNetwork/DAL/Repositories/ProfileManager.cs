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
    public class ProfileManager : IProfileManager
    {
        private readonly ApplicationContext _applicationContext;

        public ProfileManager(ApplicationContext context)
        {
            _applicationContext = context;       
        }
        public IEnumerable<Profile> GetAll()
        {
            return _applicationContext.Profiles;
        }

        public Profile Get(int id)
        {
            return _applicationContext.Profiles.Find(id);
        }

        public IEnumerable<Profile> Find(Func<Profile, bool> predicate)
        {
            return _applicationContext.Profiles.Where(predicate).ToList();
        }

        public void Create(Profile item)
        {
            _applicationContext.Profiles.Add(item); 
        }

        public void Update(Profile item)
        {
            _applicationContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var profile = _applicationContext.Profiles.Find(id);
            if (profile != null)
                _applicationContext.Profiles.Remove(profile);
        }
    }
}
