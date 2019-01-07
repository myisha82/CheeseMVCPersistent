using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public AddMenuItemViewModel() { }
      
        public AddMenuItemViewModel(Menu menu, List<Cheese> cheeses)
        {
            Cheeses = new List<SelectListItem>();
            this.Menu = menu;

            foreach (var c in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Text = c.Name,
                    Value = Convert.ToString(c.ID)
                });
            }
        }

        [Required]
        [Display(Name = "Cheese Name")]
        public int CheeseID { get; set; }

        [Required]
        public int MenuID { get;  set; }
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

       

       
    }
}