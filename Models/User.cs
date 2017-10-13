using System;

namespace MvcMovie.Models
{
    public class User
    {
            public int Id { get; set; }
            public string Name { get; set; }

            public string SurName { get; set; }

            public string  FullName { get {
                return Name +" "+ SurName;
            } }
    }
}
