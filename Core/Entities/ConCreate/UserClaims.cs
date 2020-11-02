using System.ComponentModel.DataAnnotations;

namespace Core.Entities.ConCreate
{
    public class UserClaims: IEntity
    {
      
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
