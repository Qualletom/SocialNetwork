using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Mappers
{
    public static class BllInterestMapper
    {
        public static Interests ToDalIneInterests(this BllInterest bllInterest)
        {
            if (bllInterest == null)
                return null;
            Interests interests = new Interests()
            {
                InterestsId = bllInterest.Id,
                Hobbies = bllInterest.Hobbies,
                TvShows = bllInterest.TvShows,
                Movies = bllInterest.Movies,
                Games = bllInterest.Games,
                Bands = bllInterest.Bands,
                Books = bllInterest.Books,
                Writers = bllInterest.Writers,
                Other = bllInterest.Other
            };
            return interests;
        }

        public static BllInterest ToBllIneInterests(this Interests interest)
        {
            if (interest == null)
                return null;
            BllInterest bllInterests = new BllInterest()
            {
                Id = interest.InterestsId,
                Hobbies = interest.Hobbies,
                TvShows = interest.TvShows,
                Movies = interest.Movies,
                Games = interest.Games,
                Bands = interest.Bands,
                Books = interest.Books,
                Writers = interest.Writers,
                Other = interest.Other
            };
            return bllInterests;
        }
    }
}
