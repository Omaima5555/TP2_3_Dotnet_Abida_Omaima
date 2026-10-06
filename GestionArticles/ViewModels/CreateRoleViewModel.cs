using System.ComponentModel.DataAnnotations;
    namespace GestionArticles.ViewModels
    {
        public class CreateRoleViewModel
        {
            [Required]
            [Display(Name = "Role")]
            public string RoleName { get; set; }
        }
    }

