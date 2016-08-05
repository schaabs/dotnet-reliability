using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace dumpling.web.Controllers
{
    public class DumplingApiController : ApiController
    {

        public async Task GetDumplingManifest(int dumplingId)
        {

        }

        public async Task<int> CreateDumpling(string origin, string displayName)
        {

        }

        public async Task UploadDumpFile(int dumplingId)
        {

        }

        public async Task UploadArtifact(int? dumplingId, string index = null, string format = null, string localpath = null)
        {

        }
    }
}
