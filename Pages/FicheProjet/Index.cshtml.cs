using Microsoft.AspNetCore.Mvc.RazorPages;
using projetPromamec.Models;
using projetPromamec.Data;




namespace projetPromamec.Pages.FicheProjet
{
    public class IndexModel(ApplicationDbContext context) : PageModel
    {
        private readonly ApplicationDbContext _context = context;

        public IList<Project> Projects { get; set; } = new List<Project>();

        public void OnGet()
        {
            Projects = _context.Projects.OrderByDescending(p => p.ProjectDate).
                ToList();
        }
    }
    public class CreateModel : PageModel
    {
        public List<ProjectViewModel> Projects { get; set; }

        public void OnGet()
        {
           
            Projects = new List<ProjectViewModel>
            {
                new ProjectViewModel { Id = 1, ProjectNumber = "PRJ001", ClientName = "Client A", ProjectDate = DateTime.Now },
                new ProjectViewModel { Id = 2, ProjectNumber = "PRJ002", ClientName = "Client B", ProjectDate = DateTime.Now.AddDays(-1) }
            };
        }
    }

    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string ProjectNumber { get; set; }
        public string ClientName { get; set; }
        public DateTime ProjectDate { get; set; }
    }
}