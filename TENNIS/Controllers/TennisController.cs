using Microsoft.AspNetCore.Mvc;

namespace Tennis.Controllers
{
    public class TennisController : Controller 
    {

        private readonly ILogger<TennisController> _logger;

        public TennisController(ILogger<TennisController> logger)
        {
            _logger = logger;
        }

        public IActionResult TennisIndex()
        {
            return View("TennisIndex");
        }


        /// <summary>
        /// 回傳建立資料庫的頁面
        /// </summary>
        /// <returns>建立資料庫的頁面</returns>
        public IActionResult CreateDataBase()
        {
            return View("CreateDataBase");
        }

        /// <summary>
        /// 回傳建立選手的頁面
        /// </summary>
        /// <returns>建立選手的頁面</returns>
        public IActionResult CreatePlayer()
        {
            return View("CreatePlayer");
        }


    }
}