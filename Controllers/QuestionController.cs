using Microsoft.AspNetCore.Mvc;
using DynamicQuestionApp.Data;
using DynamicQuestionApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicQuestionApp.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor to inject the ApplicationDbContext
        public QuestionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Question/Index
        public async Task<IActionResult> Index()
        {
            // Fetch questions from the database
            var questions = await _context.Questions.ToListAsync();

            // Check if there are no questions in the database
            if (questions == null || questions.Count == 0)
            {
                // Handle the case where no questions are found
                return View("Error", "No questions available.");
            }

            // Return the list of questions to the view
            return View(questions);
        }

        // POST: /Question/Submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(Dictionary<string, string> answers)
        {
            // Check if the answers dictionary is null or empty
            if (answers == null || answers.Count == 0)
            {
                ModelState.AddModelError(string.Empty, "No answers submitted.");
                return RedirectToAction("Index");  // Redirect back to the quiz page
            }

            // Optionally, you can process the answers, save them, or evaluate them here
            // Example: Save answers to the database or evaluate answers
            foreach (var answer in answers)
            {
                // Logic to handle each answer, such as saving or evaluating
                // e.g., _context.SaveAnswer(answer.Key, answer.Value);
            }

            // Redirect to a "Result" page after submission
            return RedirectToAction("Result");
        }

        // GET: /Question/Result
        public IActionResult Result()
        {
            // You can display the result of the quiz or show a confirmation message
            return View();
        }
    }
}
