using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiWithConsumer.Models;

namespace WebApiWithConsumer.Controllers
{
    public class StudentController : ApiController
    {
        public IHttpActionResult GetAllStudents()
        {
            IList<StudentViewModel> students = null;
            using (var ctx = new webapidbEntities())
            {
                students = ctx.Students.Include("StudentAddress").
                    Select(s => new StudentViewModel()
                    {
                        Id=s.StudentId,
                        FirstName = s.FirstName,
                        LastName =s.LastName

                    }).ToList<StudentViewModel>();
            }
            if (students.Count == 0)
            {
                return NotFound();
            }
            return Ok(students);
        }

        public IHttpActionResult GetAllStudentsWithAddress()
        {
            IList<StudentViewModel> students = null;

            using (var ctx = new webapidbEntities())
            {
                students = ctx.Students.Include("StudentAddress").Select(s => new StudentViewModel()
                {
                    Id = s.StudentId,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Address = s.StudentAddresses == null ? null : new AddressViewModel()
                    {
                        StudentId = s.StudentAddresses.,
                        Address1 = s.StudentAddresses.Address1,
                        Address2 = s.StudentAddresses.Address2,
                        City = s.StudentAddresses.City,
                        State = s.StudentAddresses.State
                    }
                }).ToList<StudentViewModel>();
            }


            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }
    }
}
