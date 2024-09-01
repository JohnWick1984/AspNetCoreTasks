using Microsoft.AspNetCore.Mvc; 
using System; 
using System.Linq; 

namespace AspNetCoreTasks.Controllers
{
   
    public class TasksController : Controller
    {
        
        public IActionResult AllTasks(string word)
        {
            
            Random random = new Random();
            char randomLetter = (char)random.Next('A', 'Z' + 1); 

            
            string sonnetText = @"
                Стихией ты какою порожден,
                Что столько обликов являешь миру?
                Дан каждому один, но миллион
                Тебе дарован, моему кумиру.
                Восторги всех веков в тебе слились,
                И красота твоя столь совершенна,
                Что пред тобой бледнеет Адонис
                И твой двойник — Прекрасная Елена.
                Весна — лишь тень твоя, и ярких дней
                Вселенной без тебя бы не хватало,
                А Осень — символ щедрости твоей:
                Ты и Весны, и Осени начало.
                Всему ты даришь красоту и свет,
                И в мире постоянней сердца нет.
            ";
            string sonnetFormatted = $"<pre>{sonnetText}</pre>"; 

            
            bool isPalindrome = false;
            if (!string.IsNullOrEmpty(word)) 
            {
                string reversed = new string(word.Reverse().ToArray()); 
                isPalindrome = word.Equals(reversed, StringComparison.OrdinalIgnoreCase); 
            }

            
            ViewBag.RandomLetter = randomLetter; 
            ViewBag.ShakespeareSonnet = sonnetFormatted; 
            ViewBag.Author = "~ Сонет 53, Уильям Шекспир"; 
            ViewBag.Word = word; 
            ViewBag.IsPalindrome = isPalindrome; 

            return View(); 
        }
    }
}
