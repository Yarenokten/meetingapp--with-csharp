using Google.Apis.Calendar.v3.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using toplantıuygulamasıserver.DTOS;
using toplantıuygulamasıserver.models;
using toplantıuygulamasıserver.servis;
using toplantıuygulamasıserver.Static;

namespace MyMeetingApp.Server.Controllers
{
    public class CalendarController : Controller
    {
        GoogleCalendarService _googleCalendarService = new GoogleCalendarService();

        [HttpGet]
        [Route("/calendar/auth")]
        public IActionResult Auth(string meetingId)
        {
            TempData["MeetingId"] = meetingId;
            var returnUrl = _googleCalendarService.GetAuthCode();
            return Redirect(_googleCalendarService.GetAuthCode());
        }

        [HttpGet]
        [Route("/calendar/callback")]
        public async Task<IActionResult> Callback(string Code)
        {
            string code = Code;
            string meetingId = TempData["MeetingId"]?.ToString();
            //get token method
            var token = await _googleCalendarService.GetTokens(code);


            // meeting 
            var meetingListJson = System.IO.File.ReadAllText(jsonpath.toplantıbilgileri);
            var meetingList = JsonConvert.DeserializeObject<List<toplantı>>(meetingListJson);
            var meeting = meetingList.FirstOrDefault(x => x.toplantıId == meetingId);


            var dto = new googledto();
            if (meetingId != null)
            {
                if (meeting.toplantıtarihleri == null)
                {
                    dto.StartTime = meeting.toplantıtarihleri.FirstOrDefault();
                    dto.EndTime = meeting.toplantıtarihleri.FirstOrDefault().AddHours(1);
                }
                else
                {
                    dto.StartTime = meeting.toplantıtarihleri[0];
                    dto.EndTime = meeting.toplantıtarihleri[0].AddHours(1);
                }
                dto.Summary = meeting.baslik;
                dto.refreshToken = token.refresh_token;
                dto.CalendarId = await _googleCalendarService.GetCalendarId(token.refresh_token);
                dto.Description = meeting.aciklama;
            }
            var data = _googleCalendarService.AddToGoogleCalendar(dto);
            return Redirect($"https://calendar.google.com/calendar/u/0/r/day/{dto.StartTime.Year}/{dto.StartTime.Month}/{dto.StartTime.Day}");
        }
    }
}
