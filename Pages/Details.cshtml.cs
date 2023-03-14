using ImagesStudent2023.Models;
using ImagesStudent2023.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ImagesStudent2023.Pages
{

    public class DetailsModel : PageModel
    {
        //this holds the SelectList of all the staff, with default setup for values and textfield
        //DO NOT BIND THE STAFF IT ERRORS OUT       
        public SelectList Staff { get; set; }
        //the selected image

        [BindProperty]
        //this hold the details of the staff person that has been selected.
        public PersonDetails? SelectedStaff { get; set; }
        //this holds the ID of the image selected
        [BindProperty]
        public int SelectedStaffId { get; set; }

        public DetailsModel()
        {
            PopulateStaffWithData();
        }
        public void OnGet()
        {
            PopulateStaffWithData();
        }

        public void OnPost()
        {
            //the only data that comes back from the page to here is the ID of the staff member you selected
            //after you have selected a person from the dropdown list then loop through all the staff, until the ID of the one you selected = the id of the one being looped through
            foreach (var item in StaticPersonDetails.StaticAllStaff)
            {
                if (SelectedStaffId == item.Id)
                {
                    SelectedStaff.Id = item.Id;
                    SelectedStaff.Name = item.Name;
                    SelectedStaff.Age = item.Age;
                    SelectedStaff.ImagePath = item.ImagePath;
                    SelectedStaff.Occupation = item.Occupation;
                }
            }
        }

        private void PopulateStaffWithData()
        {
            //Create a selectlist for the dropdown
            Staff = new SelectList(StaticPersonDetails.StaticAllStaff, nameof(PersonDetails.Id), nameof(PersonDetails.Name), null);
            //Instantiate a new select list when you load the page.
            SelectedStaff = new PersonDetails();

        }

    }
}
