﻿namespace toplantıuygulamasıserver.DTOS
{
    public class googleresponsedto
    {
        public string access_type { get; set; }
        public long expires_in { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
        public string token_type { get; set; }
    }
}
