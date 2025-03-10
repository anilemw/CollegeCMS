﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CollegeCMS.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CollegeCMSUser class
public class CollegeCMSUser : IdentityUser
{

    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }


}

