﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroLibros.clases
{
    public class Autor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Autor() { }
        public Autor(int id, string firstName, string lastName) {

            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
