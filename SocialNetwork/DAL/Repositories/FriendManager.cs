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
    public class FriendManager : IFriendManager
    {
        private readonly ApplicationContext _applicationContext;

        public FriendManager(ApplicationContext context)
        {
            _applicationContext = context;
        }
        public IEnumerable<Friend> GetAll()
        {
            return _applicationContext.Friends;
        }

        public Friend Get(int id)
        {
            return _applicationContext.Friends.Find(id);
        }

        public IEnumerable<Friend> Find(Func<Friend, bool> predicate)
        {
            return _applicationContext.Friends.Where(predicate).ToList();
        }

        public void Create(Friend item)
        {
            _applicationContext.Friends.Add(item);
        }

        public void Update(Friend item)
        {
            _applicationContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var friend = _applicationContext.Friends.Find(id);
            if (friend != null)
                _applicationContext.Friends.Remove(friend);
        }

        public IEnumerable<Friend> GetFriends(int id, bool isConfirmed)
        {
            return _applicationContext.Friends
                .Where(friend => (friend.UserFromId == id || friend.UserToId == id) && friend.IsConfirmed == true)
                .ToList();
        }

        public IEnumerable<Friend> GetNotConfirmedFriends(int userId)
        {
            return _applicationContext.Friends
                .Where(friend => friend.UserToId == userId && friend.IsConfirmed == false)
                .ToList();
        }
    }
}
