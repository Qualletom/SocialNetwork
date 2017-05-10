using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class BllFriend
    {
        public int FriendId { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? UserFromId { get; set; }
        public int? UserToId { get; set; }
        public bool? IsConfirmed { get; set; }
    }
}
