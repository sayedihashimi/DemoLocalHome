using System;
using System.Diagnostics;
using System.Security.Permissions;
using LocalHome.Shared;

namespace LocalHome.ViewModels {
    [DebuggerDisplay("{UserLink.Text} - {UserLink.Url}")]
    public class UserLinkViewModel {
        public UserLink UserLink { get; set; }
        public bool Hidden { get; set; }
    }
}

