using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Application.Catalog.Tasks;
using TodoListApp.ViewModels.Catalog.Products;
using TodoListApp.ViewModels.Catalog.Products.Manage;

namespace TodoListApp.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IPublicTaskService _publicTaskService;
        private readonly IManageTaskService _manageTaskService;
        public TasksController(IPublicTaskService publicTaskService, IManageTaskService manageTaskService)
        {
            _publicTaskService = publicTaskService;
            _manageTaskService = manageTaskService;
        }

        //http//localhost:port/task
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tasks = await _publicTaskService.GetAll();
            return Ok(tasks);
        }

        //http//localhost:port/task/public-paging
        [HttpGet("{public-paging}")]
        public async Task<IActionResult> Get([FromQuery]GetPublicTaskPagingRequest request)
        {
            var tasks = await _publicTaskService.GetAll();
            return Ok(tasks);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var result = await _manageTaskService.GetbyId(id);
            if (result == null)
                return BadRequest("Cannot find Task");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]TaskCreateRequest request)
        {
            var taskID = await _manageTaskService.Create(request);
            if (taskID == 0)
                return BadRequest();
            var result = await _manageTaskService.GetbyId(taskID);
            return Created(nameof(GetbyId), result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] TaskUpdateRequest request)
        {
            var affectedResult = await _manageTaskService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var affectedResult = await _manageTaskService.Delete(id);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}
