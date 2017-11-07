using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarkDeanilVicente : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
        public string FirstName => "Mark Deanil";
        public string LastName => "Vicente";
        public string StateOrRegion => "Manila, Philippines";
        public string EmailAddress => "markdeanilvicente@gmail.com";
        public string ShortBioOrTagLine => "Mark Deanil Vicente is a Microsoft MVP. He's currently working as programmer & a developer. He's also one of the founders of Mobile .Net Developers PH (MondPH) Community. He enjoys drinking wine and hot tea";
        public Uri WebSite => new Uri("https://deanilvincent.github.io/");
        public string TwitterHandle => "DeanilVincent03";
        public string GitHubHandle => "deanilvincent";
        public string GravatarHash => "a90b830f123ffdcac52f8e16c8bcd829";
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://deanilvincent.github.io/feed"); }
        }
        public GeoPosition Position => new GeoPosition(14.5547, 121.0244);
    }
}
