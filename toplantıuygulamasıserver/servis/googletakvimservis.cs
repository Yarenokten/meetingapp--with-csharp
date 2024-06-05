using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using System.Text;
using toplantıuygulamasıserver.DTOS;

namespace toplantıuygulamasıserver.servis
{
    public class GoogleCalendarService
    {
        private readonly HttpClient _httpClient;

        public GoogleCalendarService()
        {
            _httpClient = new HttpClient();
        }
        public string AddToGoogleCalendar(googledto googleCalendarReqDTO)
        {
            try
            {
                var token = new TokenResponse
                {
                    RefreshToken = googleCalendarReqDTO.refreshToken
                };
                var credentials = new UserCredential(new GoogleAuthorizationCodeFlow(
                  new GoogleAuthorizationCodeFlow.Initializer
                  {
                      ClientSecrets = new ClientSecrets
                      {
                          ClientId = "436784986962-tfq9pond346vmmjpn6pbl12u0idp7oju.apps.googleusercontent.com",
                          ClientSecret = "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"
                      }

                  }), "user", token);

                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credentials,
                });

                Event newEvent = new Event()
                {
                    Summary = googleCalendarReqDTO.Summary,
                    Description = googleCalendarReqDTO.Description,
                    Start = new EventDateTime()
                    {
                        DateTime = googleCalendarReqDTO.StartTime,
                    },
                    End = new EventDateTime()
                    {
                        DateTime = googleCalendarReqDTO.EndTime,
                    },
                    Reminders = new Event.RemindersData()
                    {
                        UseDefault = false,
                        Overrides = new EventReminder[] {

                new EventReminder() {
                    Method = "email", Minutes = 30
                  },

                  new EventReminder() {
                    Method = "popup", Minutes = 15
                  },

                  new EventReminder() {
                    Method = "popup", Minutes = 1
                  },
              }
                    }

                };
                EventsResource.InsertRequest insertRequest = service.Events.Insert(newEvent, googleCalendarReqDTO.CalendarId);
                Event createdEvent = insertRequest.Execute();
                return createdEvent.Id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return string.Empty;
            }
        }
        public string GetAuthCode()
        {
            string scopeUrl = "https://accounts.google.com/o/oauth2/auth?redirect_uri={0}&prompt={1}&response_type={2}&client_id={3}&scope={4}&access_type={5}";
            var redirectURL = "https://pdedtestapi.ibrahimbagislar.com/calendar/callback";
            string prompt = "consent";
            string response_type = "code";
            string clientID = "436784986962-tfq9pond346vmmjpn6pbl12u0idp7oju.apps.googleusercontent.com";
            string scope = "https://www.googleapis.com/auth/calendar";
            string access_type = "offline";
            string redirectUrlEncode = metod.urlEncodeForGoogle(redirectURL);
            var mainURL = string.Format(scopeUrl, redirectUrlEncode, prompt, response_type, clientID, scope, access_type);

            return mainURL;
        }

        public async Task<googleresponsedto> GetTokens(string code)
        {
            var clientId = "436784986962-tfq9pond346vmmjpn6pbl12u0idp7oju.apps.googleusercontent.com";
            string clientSecret = "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";
            var redirectURL = "https://pdedtestapi.ibrahimbagislar.com/calendar/callback";
            var tokenEndpoint = "https://accounts.google.com/o/oauth2/token";
            var content = new StringContent($"code={code}&redirect_uri={Uri.EscapeDataString(redirectURL)}&client_id={clientId}&client_secret={clientSecret}&grant_type=authorization_code", Encoding.UTF8, "application/x-www-form-urlencoded");

            var response = await _httpClient.PostAsync(tokenEndpoint, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var tokenResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<googleresponsedto>(responseContent);
                return tokenResponse;
            }
            else
            {
                throw new Exception($"Failed to authenticate: {responseContent}");
            }
        }
        public async Task<string> GetCalendarId(string refreshToken)
        {
            UserCredential credential = new UserCredential(
                new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets
                    {
                        ClientId = "436784986962-tfq9pond346vmmjpn6pbl12u0idp7oju.apps.googleusercontent.com",
                        ClientSecret = "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"
                    },
                    Scopes = new[] { "https://www.googleapis.com/auth/calendar" }
                }),
                "user",
                new TokenResponse
                {
                    RefreshToken = refreshToken
                });

            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "Meeting App"
            });

            var calendarListRequest = service.CalendarList.List();
            var calendarList = calendarListRequest.Execute();
            List<CalendarListEntry> items = calendarList.Items.ToList();
            string calendarId = items[0].Id;
            return calendarId;
        }
    }
}
