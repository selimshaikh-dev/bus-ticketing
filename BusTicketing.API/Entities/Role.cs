using BusTicketing.API.Entities.Common;

namespace BusTicketing.API.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }  

        public ICollection<User> Users { get; set; }
    }
}