using BLL.DTO;
using WEB.Models.Profile;

namespace WEB.Infrastructure.Mappers
{
    public static class InterestMapper
    {
        public static InterestsModel ToWebInterests(this BllInterest bllInterest)
        {
            if (bllInterest == null)
                return null;
            InterestsModel interestsModel = new InterestsModel()
            {
                Id = bllInterest.Id,
                Hobbies = bllInterest.Hobbies,
                TvShows = bllInterest.TvShows,
                Movies = bllInterest.Movies,
                Games = bllInterest.Games,
                Bands = bllInterest.Bands,
                Books = bllInterest.Books,
                Writers = bllInterest.Writers,
                Other = bllInterest.Other
            };
            return interestsModel;
        }

        public static BllInterest ToBllIneInterests(this InterestsModel interestModel)
        {
            if (interestModel == null)
                return null;
            BllInterest bllInterests = new BllInterest()
            {
                Id = interestModel.Id,
                Hobbies = interestModel.Hobbies,
                TvShows = interestModel.TvShows,
                Movies = interestModel.Movies,
                Games = interestModel.Games,
                Bands = interestModel.Bands,
                Books = interestModel.Books,
                Writers = interestModel.Writers,
                Other = interestModel.Other
            };
            return bllInterests;
        }
    }
}