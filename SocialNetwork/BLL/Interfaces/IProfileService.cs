using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Infrastructure;

namespace BLL.Interfaces
{
    public interface IProfileService : IDisposable
    {
        BllProfile GetProfileByUserId(int id);

        void UpdateProfile(BllProfile bllProfile);

        List<BllProfile> GetConfirmedFriendsProfiles(int id);
    }
}
