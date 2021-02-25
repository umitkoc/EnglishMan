using System.Net.Http;
using System.Threading.Tasks;
using EnglishManWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishManWebUI.Controllers
{
    public class BookController:Controller
    {
        HttpClient client=new HttpClient();
        public IActionResult Books(){
            return View();
        }
        public async Task<IActionResult> Paragraph() {
            Paragraph paragraph=new Paragraph();
            string data=await client.GetStringAsync("https://flesk-api.herokuapp.com/paragraph");
            paragraph.text=data.Split(" ");
            return View(paragraph);
        }
        public async Task<IActionResult> Word(){
            Word word=new Word();
            word.text=await client.GetStringAsync("https://flesk-api.herokuapp.com/word");
            return View(word);
        }
    }
}