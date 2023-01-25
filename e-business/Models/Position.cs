using e_business.Models.Base;

namespace e_business.Models
{
    public class Position:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Employee> employees { get; set; }
    }
}
