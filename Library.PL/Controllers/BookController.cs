using AutoMapper;
using Library.BLL.Interfaces;
using Library.BLL.Models;
using Library.DAL.Entities;
using Library.PL.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Library.PL.Controllers
{
    public class BookController : Controller
    {
        private readonly IGenericService<Book, BookModel> _service;
        private readonly IMapper _mapper;

        public BookController(IGenericService<Book, BookModel> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _service.GetAllAsync();
            var vm = _mapper.Map<IEnumerable<BookViewModel>>(books);
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var model = _mapper.Map<BookModel>(vm);
            await _service.AddAsync(model);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await _service.GetByIdAsync(id);
            if (model == null) return NotFound();

            var vm = _mapper.Map<BookViewModel>(model);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BookViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var model = _mapper.Map<BookModel>(vm);
            await _service.UpdateAsync(vm.Id, model);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await _service.GetByIdAsync(id);
            if (model == null) return NotFound();

            var vm = _mapper.Map<BookViewModel>(model);
            return View(vm);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _service.GetByIdAsync(id);
            if (model == null) return NotFound();

            var vm = _mapper.Map<BookViewModel>(model);
            return View(vm);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}