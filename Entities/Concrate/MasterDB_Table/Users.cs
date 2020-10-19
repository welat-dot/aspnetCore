using Core.Entities;

namespace entities.MasterTable
{
    public class Users : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

    }
}
