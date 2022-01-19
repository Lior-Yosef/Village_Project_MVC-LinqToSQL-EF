using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Village_Project_MVC_LinqToSQL_EF.Models;

namespace Village_Project_MVC_LinqToSQL_EF.Controllers.api
{
    public class SaniorController : ApiController
    {
        static string Stringconction = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=OldResidentDB;Integrated Security=True;Pooling=False";
        SeniorDBDataContext OldResidents = new SeniorDBDataContext(Stringconction);

        // GET: api/Sanior
        public IHttpActionResult Get()
        {

            try
            {
                return Ok(OldResidents.Seniors.ToList());

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // GET: api/Sanior/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(OldResidents.Seniors.First(res => res.Id == id));

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST: api/Sanior
        public IHttpActionResult Post([FromBody] Senior value)
        {
            try
            {
                OldResidents.Seniors.InsertOnSubmit(value);
                OldResidents.SubmitChanges();
                return Ok("rwo add");

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT: api/Sanior/5
        public IHttpActionResult Put(int id, [FromBody]Senior value)
        {
            try
            {
                Senior UpdateSenior = OldResidents.Seniors.First(Res => Res.Id == id);
                UpdateSenior.FullName = value.FullName;
                UpdateSenior.born = value.born;
                UpdateSenior.seniority = value.seniority;
                OldResidents.SubmitChanges();
                return Ok(new { UpdateSenior });

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/Sanior/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Senior DeleteSenior = OldResidents.Seniors.First(Res => Res.Id == id);
                OldResidents.Seniors.DeleteOnSubmit(DeleteSenior);
                OldResidents.SubmitChanges();
                return Ok(OldResidents.Seniors.ToList());
            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
