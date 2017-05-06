using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Interfaces
{
    public interface IUserProfileService : IDisposable
    {
        BllProfile GetProfileByUserId(int id);
        BllInterest GetInterestsByUserId(int id);

    }
}
