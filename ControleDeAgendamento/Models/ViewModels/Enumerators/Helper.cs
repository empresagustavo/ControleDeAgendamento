using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ControleDeAgendamento.Models.ViewModels.Enumerators
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";

        public static List<SelectListItem> GetHelperList()
        {
            return new List<SelectListItem> { 
            new SelectListItem{Value=Admin, Text = Admin },
            new SelectListItem{Value=Patient, Text = Patient },
            new SelectListItem{Value=Doctor, Text = Doctor }};
        }
    }
}
