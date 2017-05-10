using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;

namespace BLL.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IUnitOfWork _database;

        public ProfileService(IUnitOfWork database)
        {
            _database = database;
        }
        public void Dispose()
        {
            _database.Dispose();
        }

        public BllProfile GetProfileByUserId(int id)
        {
            return _database.ProfileManager.Get(id).ToBllProfile();
        }

        public void UpdateProfile(BllProfile bllProfile)
        {
            _database.ProfileManager.Update(bllProfile.ToDalProfile());
            _database.SaveAsync();
        }

        public List<BllProfile> GetConfirmedFriendsProfiles(int id)
        {
            var friends = _database.FriendManager.GetFriends(id, true);
            List<BllProfile> friendsProfiles = new List<BllProfile>();

            foreach (var friend in friends)
            {
                if (id == friend.UserFromId)
                    friendsProfiles.Add(friend.FromUser.Profile.ToBllProfile());
                else
                    friendsProfiles.Add(friend.ToUser.Profile.ToBllProfile());
            }
            return friendsProfiles;
        }
    }
}
