using System.Collections.Generic;
using Douana.Roles.Dto;

namespace Douana.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}