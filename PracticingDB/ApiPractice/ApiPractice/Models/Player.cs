using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPractice.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string name { get; set; }

        public int age { get; set; }
        public Role role { get; set; }

    }
}
