using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FurntureWebAPP_ASP_NET_CORE_MVC.Models;

public partial class UserTbl
{
    public int UserId { get; set; }

    [Required]
    public string? UserName { get; set; }

    [Required]
    public string? UserEmail { get; set; }


    [DataType(DataType.Password)]
    [Required(ErrorMessage ="Password must be required")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "confirm password must be match with password")]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string? ConfirmPassword { get; set; }
}
