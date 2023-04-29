using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class NotificationDTO
    {
        public string Message { get; set; } = null!;
        public DateTime CreatedTime { get; set; }
        public bool MarkAsRead { get; set;}
    }
}
