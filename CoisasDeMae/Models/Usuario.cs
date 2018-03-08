using System;
using System.Collections.Generic;

namespace CoisasDeMae.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Pedido> Enrollments { get; set; }
    }
}

