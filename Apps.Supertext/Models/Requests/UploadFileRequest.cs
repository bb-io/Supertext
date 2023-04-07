using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Models.Requests
{
    public class UploadFileRequest
    {
        public string Filename { get; set; }

        public byte[] File { get; set; }
    }
}
