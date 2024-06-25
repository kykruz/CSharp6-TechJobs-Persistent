using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel 
    { 
        [Required(ErrorMessage = "Name is required.")]
        public string? Name {get; set;}

        public int EmployerId {get; set;}

        public List<SelectListItem>? Employers {get; set;}

    }
}
