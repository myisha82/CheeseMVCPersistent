using System;
using System.Collections.Generic;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

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

        public int CheeseID { get; internal set; }
        public int MenuID { get; internal set; }
    }
}