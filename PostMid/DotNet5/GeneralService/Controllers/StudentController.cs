using GeneralService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GeneralService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> data = new List<Student>()
            {
                new Student() { ID = 1, Name = "Raheeb", RollNumber = "BCSF20M020", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new Student() { ID = 2, Name = "Azeem", RollNumber = "BCSF20M021", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new Student() { ID = 3, Name = "Naeem", RollNumber = "BCSF20M022", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new Student() { ID = 4, Name = "Abbas", RollNumber = "BCSF20M023", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new Student() { ID = 5, Name = "Huzaifa", RollNumber = "BCSF20M024", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new Student() { ID = 6, Name = "Shazil", RollNumber = "BCSF20M030", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new Student() { ID = 7, Name = "Munazza Shahzad Mughal", RollNumber = "BCSF20M001", CreatedBy = "rizwan", CreatedOn = DateTime.Now },
                new Student() { ID = 8, Name = "Beenish", RollNumber = "BCSF20M043", CreatedBy = "rizwan", CreatedOn = DateTime.Now }
            };

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return data;
        }

        [HttpGet, Route("{id}")]
        public Student GetStudentById(long id)
        {
            var result = data.Where(x => x.ID == id).FirstOrDefault();

            if (result == null)
            {
                throw new Exception("Record not found");
            }
            else
            {
                return result;
            }
        }
        [HttpPost]
        public Student Save(Student student)
        {
            return student;
        }

        [HttpPut, Route("{id}")]
        public Student Update(long id, Student student)
        {
            return student;
        }
    }
}
