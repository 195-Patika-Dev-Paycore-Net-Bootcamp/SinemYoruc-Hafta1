using Microsoft.AspNetCore.Mvc;
using System;

namespace Odev1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterestController : ControllerBase
    {
        [HttpGet("GetTotalBalance")]
        public ActionResult<Interest> Get([FromQuery] double principal, double interestAmount, double expiry) //Request body (ana para, faiz orani ve vade alindi)
        {
            Interest interest = new(); //yeni liste
            interest.InterestAmount = interestAmount; //listenin elemani InterestAmount ile kullanicidan alinan interestAmount eslestirildi
            interest.TotalBalance = principal * Math.Pow((1 + interestAmount), expiry); //bilesik faiz hesabi
            return interest; //response body (toplam bakiye ve faiz orani donduruldu)
        }
    }
}
