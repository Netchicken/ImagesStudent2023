using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImagesStudent2023.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        //the selected image
        public string ImagePath { get; set; }
        //the list of images
        public List<string> ImagePathList { get; set; }
        public void OnGet()
        {
            ImagePath = "load.png"; //default image
            //load the images when starting
            PopulateSelectWithImages();
        }
        public void OnPost()
        {
            //reload the images after post has ben hit
            PopulateSelectWithImages();
        }
        private void PopulateSelectWithImages()
        {
            ImagePathList = new List<string>
            {
     //add data to the list
     "photo1.png",
     "photo2.png",
     "photo3.png",
     "photo4.png",
     "photo4.png"
            };
        }
    }
}