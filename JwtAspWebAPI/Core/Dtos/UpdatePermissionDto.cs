using System.ComponentModel.DataAnnotations;

namespace JwtAspWebAPI.Core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }

       
    }
}
