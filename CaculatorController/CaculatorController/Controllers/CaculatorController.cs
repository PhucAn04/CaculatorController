using Microsoft.AspNetCore.Mvc;

namespace CaculatorController.Controllers
{
    public class CaculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Caculator(double a, double b, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "%":
                    result = a % b;
                    break;
                case "^":
                    result = Math.Pow(a, b);
                    break;
            }

            ViewBag.Result = result;
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Op = op;

            return View("Index");
        }
    }
}
