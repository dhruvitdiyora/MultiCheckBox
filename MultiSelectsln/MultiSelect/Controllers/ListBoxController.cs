using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiSelect.IServices;
using MultiSelect.Models;

namespace MultiSelect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListBoxController : ControllerBase
    {
        private readonly IListBox _listBox;
        public ListBoxController(IListBox listBox) 
        {
            _listBox = listBox;
        }

        // GET all : api/listbox
        [HttpGet]
        public ActionResult<IEnumerable<ListBoxDatum>> GetAll()
        {
            return Ok(_listBox.GetAll());
        }
    }
}
