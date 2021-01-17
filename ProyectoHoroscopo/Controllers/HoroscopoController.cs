using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoroscopo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoroscopoController : Controller
    {
        [HttpGet]
        public string horoscopoget(int dia, int mes)
        {
            if (dia>31||dia<1)
            {
                return "error";         
            }

            if (mes < 1 || mes > 12)
            {
                return "error";
            }
            if ((dia >= 21 && mes == 3)||(dia <= 20 && mes == 4))
            { return "Aries: te va a dar covid-19"; }
            if ((dia >= 21 && mes == 4)||(dia <=20 && mes == 5))
            { return "Tauro: te van a asaltar"; }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            { return "Geminis: feliz jueves"; }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            { return "Cancer: c bb el finde semana osi osi"; }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            { return "Leo: te vas a aplazar en progra aplicada"; }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            { return "Virgo: vas a conocer a una persona importante kdiceeee"; }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            { return "Libra: nuevas oportunidades se te presentaran, no las tomes..."; }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            { return "Escorpion: tendras un mal jueves :("; }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            { return "Sagitario: sos buena gente, te va a ir bien en la vida"; }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            { return "Capricornio: vas a ser fachero el resto del año"; }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            { return "Acuarius: te van a spoilear una serie"; }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            { return "Piscis: victor arellano te va a llamar el finde"; }

            return "";
        }
        public string horoscopopost(int dia, int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "error";
            }

            if (mes < 1 || mes > 12)
            {
                return "error";
            }
            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            { return "Aries: te va a dar covid-19"; }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            { return "Tauro: te van a asaltar"; }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            { return "Geminis: feliz jueves"; }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            { return "Cancer: c bb el finde semana osi osi"; }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            { return "Leo: te vas a aplazar en progra aplicada"; }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            { return "Virgo: vas a conocer a una persona importante kdiceeee"; }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            { return "Libra: nuevas oportunidades se te presentaran, no las tomes..."; }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            { return "Escorpion: tendras un mal jueves :("; }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            { return "Sagitario: sos buena gente, te va a ir bien en la vida"; }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            { return "Capricornio: vas a ser fachero el resto del año"; }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            { return "Acuarius: te van a spoilear una serie"; }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            { return "Piscis: victor arellano te va a llamar el finde"; }

            return "";

        }
       
    }
}
