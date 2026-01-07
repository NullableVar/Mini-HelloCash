using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HelloCash.Models;

public class RoleModel
{
    public Guid Id { get; set; }

    public string RoleName { get; set; } = null!;
}
