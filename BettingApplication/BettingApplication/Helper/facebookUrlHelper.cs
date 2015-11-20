using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace BettingApplication.Helper
{
    public  class facebookUrlHelper
    {
        public static string GetFacebookProfilePicture(ClaimsIdentity externalInfoSoruce)
        {
            var facebookUserID = externalInfoSoruce.Claims.First(c => c.Type == "urn:facebook:id").Value;
            string profilePicturePath = string.Format("http://graph.facebook.com/{0}/picture?type=large", facebookUserID);
            return profilePicturePath;
        }
    }
}