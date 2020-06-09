using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext Db)
        {
            _db = Db;
        }

        //assumed that on post this is the object
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            //post data to db from the add book page

            //check that model state is valid with all required fields
            if (ModelState.IsValid)
            {
                //add book object to queue and then push/save changes to db
                await _db.Book.AddAsync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}