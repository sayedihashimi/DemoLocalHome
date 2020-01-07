using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LocalHome.Shared {
    public class UserLinkJsonReader : IUserLinkJsonReader {
        public async Task<List<UserLink>> GetUserLinksFromFileAsync(string filepath) {
            Debug.Assert(filepath != null);
            return GetUserLinksFrom(await File.ReadAllTextAsync(filepath));
        }

        public List<UserLink> GetUserLinksFrom(string text) {
            Debug.Assert(text != null);
            List<UserLink> result = JsonConvert.DeserializeObject<List<UserLink>>(text);
            return result;
        }
    }
}

