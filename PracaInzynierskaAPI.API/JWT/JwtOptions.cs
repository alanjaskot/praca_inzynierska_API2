using PracaInzynierskaAPI.API.JWT.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.API.JWT
{
    public class JwtOptions
    {
        public string SecretKey
        {
            get
            {
                return Helper.SECRET_KEY;
            }
            set
            {
                value = Helper.SECRET_KEY;
            }
        }
        public string Issuer
        {
            get
            {
                return Helper.ISSUER;
            }
            set
            {
                value = Helper.ISSUER;
            }
        }
        public int ExpiryHours { get; set; } = 6;
        public bool ValidateLifetime { get; set; } = false;
        public bool ValidateAudience { get; set; }
        public string ValidAudience { get; set; }
    }
}
