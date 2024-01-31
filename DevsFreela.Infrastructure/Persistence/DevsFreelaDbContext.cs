using DevsFreela.Core.Entities;

namespace DevsFrella.Infrastructure.Persistence
{
    public class DevsFreelaDbContext
    {
        public DevsFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("title", "description", 1, 1, 100),
                new Project("title1", "description1", 1, 1, 2),
                new Project("title1", "description1", 1, 1, 3),
            };

            Users = new List<User>
            {
                new User("fullname", "email", DateTime.Now.AddYears(-10)),
                new User("fullname1", "email2", DateTime.Now.AddYears(-11)),
                new User("fullname1", "email2", DateTime.Now.AddYears(-12)),
            };

            Skills = new List<Skill>
            {
                new Skill("description"),
                new Skill("description1"),
                new Skill("description2"),
            };
        }

        public List<Project> Projects { get; set; }

        public List<User> Users { get; set; }

        public List<Skill> Skills { get; set; }

        public List<ProjectComment> ProjectComments { get; set; }
    }
}
