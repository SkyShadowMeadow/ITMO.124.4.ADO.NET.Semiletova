using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class Model
    {
        public class Person
        {
            public int PersonId { get; set; }

            [Required]
            [MaxLength(30)]
            public string FirstName { get; set; }

            public string LastName { get; set; }

            [MaxLength(100)]
            public string Email { get; set; }

            public override string ToString()
            {
                string s = FirstName + LastName + ", электронный адрес: " + Email;
                return s;
            }
            // Ссылка на животных
            public virtual List<Pet> Pets { get; set; }
            public Person()
            {
                Pets = new List<Pet>();
            }
        }
        public class Pet
        {
            public int PetId { get; set; }
            public string PetName { get; set; }
            public string Type { get; set; }

            [Range(1, 30)]
            public int Age { get; set; }

            [Column(TypeName = "image")]
            public byte[] Photo { get; set; }

            // Ссылка на хозяина
            public Person Owner { get; set; }
            public override string ToString()
            {
                string s = PetName + " (" + Type + ")";
                return s;
            }
        }

    }
}
