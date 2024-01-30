using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsFreela.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        public Skill(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public int IdUser { get; private set; }

        public int IdSkill { get; private set; }
    }
}
