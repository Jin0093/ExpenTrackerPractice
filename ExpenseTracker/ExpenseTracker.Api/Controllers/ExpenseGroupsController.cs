using ExpenseTracker.Repository;
using ExpenseTracker.Repository.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpenseTracker.Api.Controllers
{
    public class ExpenseGroupsController : ApiController
    {
        IExpenseTrackerRepository _repo;
        ExpenseGroupFactory _expenseGroupFactory = new ExpenseGroupFactory();

        public ExpenseGroupsController()
        {
            _repo = new ExpenseTrackerEFRepository(new Repository.Entities.ExpenseTrackerContext());
        }

        public ExpenseGroupsController(IExpenseTrackerRepository repo)
        {
            _repo = repo;
        }


        // Get : Return All ExpenseGroups in a list
        public IHttpActionResult GET()
        {
            try
            {
                var expenseGroups = _repo.GetExpenseGroups();

                return Ok(expenseGroups.ToList()
                    .Select(e => _expenseGroupFactory.CreateExpenseGroup(e)));

            }
            catch (Exception)
            {

                return InternalServerError();
            }
        }

        // GET : Single ExpenseGroup
        public IHttpActionResult GET(int id)
        {
            try
            {
                var expenseGroup = _repo.GetExpenseGroup(id);
                if (expenseGroup != null)
                {
                    return Ok(_expenseGroupFactory.CreateExpenseGroup(expenseGroup));
                }
                return NotFound();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // POST
        public IHttpActionResult POST([FromBody] DTO.ExpenseGroup expenseGroup)
        {
            try
            {
                //Check if null
                if (expenseGroup == null)
                {
                    return BadRequest();
                }
                // Map DTO to entity to be used:
                var eG = _expenseGroupFactory.CreateExpenseGroup(expenseGroup);
                var result = _repo.InsertExpenseGroup(eG);

                if (result.Status == RepositoryActionStatus.Created)
                {
                    var newExpenseGroup = _expenseGroupFactory.CreateExpenseGroup(result.Entity);
                    return Created(Request.RequestUri + "/" + newExpenseGroup.Id, newExpenseGroup);
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // PUT : Update
        public IHttpActionResult PUT(int id, [FromBody] DTO.ExpenseGroup expenseGroup)
        {
            try
            {
                if(expenseGroup==null)
                {
                    return BadRequest();
                }

                var eg = _expenseGroupFactory.CreateExpenseGroup(expenseGroup);

                var result = _repo.UpdateExpenseGroup(eg);

                if(result.Status == RepositoryActionStatus.Created)
                {
                    var updatedExpenseGroup = _expenseGroupFactory.CreateExpenseGroup(result.Entity);
                    return Ok(updatedExpenseGroup);
                }

                else if(result.Status == RepositoryActionStatus.NotFound)
                {
                    return NotFound();
                }
                return BadRequest();
            }
            catch (Exception)
            {

                return InternalServerError();
            }
        }
    }

}
