using ImagesStudent2023.Models;

namespace ImagesStudent2023.Operations
{
    public static class StaticPersonDetails
    {
        public static List<PersonDetails> StaticAllStaff = new List<PersonDetails>
        {
            new PersonDetails
            {
                           Id = 1,
                           Name = "Joanne",
                           Age = "25",
                           Occupation = "Developer",
                           ImagePath = "photo1.png"
                       },
            new PersonDetails
            {
                           Id = 2,
                           Name = "Joseph",
                           Age = "30",
                           Occupation = "Developer",
                           ImagePath = "photo2.png"
                       },
            new PersonDetails
            {
                           Id = 3,
                           Name = "Joe",
                           Age = "35",
                           Occupation = "Developer",
                           ImagePath = "photo3.png"
                       },
            new PersonDetails
            {
                           Id = 4,
                           Name = "John",
                           Age = "40",
                           Occupation = "Developer",
                           ImagePath = "photo4.png"
                       },
            new PersonDetails
            {
                           Id = 5,
                           Name = "Jack",
                           Age = "45",
                           Occupation = "Developer",
                           ImagePath = "photo5.png"
                       }
        };


    }
}
