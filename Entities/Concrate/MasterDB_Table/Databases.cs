using Core.Entities;

namespace entities.MasterTable
{
    public class Databases : IEntity
    {
        public int Id { get; set; }
        public string DatabaseName { get; set; }
        public int UsersRefId { get; set; }


    }
}
