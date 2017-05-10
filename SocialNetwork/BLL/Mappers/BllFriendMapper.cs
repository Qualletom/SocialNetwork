using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Mappers
{
    public static class BllFriendMapper
    {
        public static Friend ToDalFriend(this BllFriend bllFriend)
        {
            if (bllFriend == null)
                return null;
            Friend friend = new Friend()
            {
                FriendId = bllFriend.FriendId,
                UserFromId = bllFriend.UserFromId,
                UserToId = bllFriend.UserToId,
                IsConfirmed = bllFriend.IsConfirmed,
                RequestDate = bllFriend.RequestDate,

            };
            return friend;
        }

        public static BllFriend ToBllFriend(this Friend friend)
        {
            if (friend == null)
                return null;
            BllFriend bllFriend = new BllFriend()
            {
                FriendId = friend.FriendId,
                UserFromId = friend.UserFromId,
                UserToId = friend.UserToId,
                IsConfirmed = friend.IsConfirmed,
                RequestDate = friend.RequestDate,
            };
            return bllFriend;
        }
    }
}
