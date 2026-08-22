using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class AssignUserRolesRequestModel
    {
        [Required]
        [MinLength(1, ErrorMessage = "حداقل یک نقش باید انتخاب شود.")]

        public IReadOnlyCollection<long> RoleIds { get; set; } = [];
    }
}
