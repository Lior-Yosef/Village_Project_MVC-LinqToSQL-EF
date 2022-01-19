using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Village_Project_MVC_LinqToSQL_EF.Models;

namespace Village_Project_MVC_LinqToSQL_EF.Controllers
{
    public class ResidentController : ApiController
    {
        // GET: api/Resident

        VillageDataContext db = new VillageDataContext();
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(db.Residents.ToList());

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // GET: api/Resident/5
        public async Task <IHttpActionResult> Get(int id)
        {
            try
            {
                Resident resident = await db.Residents.FindAsync(id);
                return Ok(resident);
            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST: api/Resident
        public async Task<IHttpActionResult> Post([FromBody] Resident value)
        {
            try
            {
                
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }
                    db.Residents.Add(value);    
                    await db.SaveChangesAsync();
                    return Ok("add success");
                }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT: api/Resident/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Resident resident)
        {
            try
            {
                Resident UpdateResident = await db.Residents.FindAsync(id);
                UpdateResident.FirstName = resident.FirstName;
                UpdateResident.FatherName = resident.FatherName;
                UpdateResident.Gender = resident.Gender;
                UpdateResident.IsBornInVillage=resident.IsBornInVillage;
                UpdateResident.boorn=resident.boorn;
                await db.SaveChangesAsync();
                return Ok("Update resident success");

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/Resident/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Resident ResidentRemove = await db.Residents.FindAsync(id);
                db.Residents.Remove(ResidentRemove);
                await db.SaveChangesAsync();
                return Ok("Remove Resident success");

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
