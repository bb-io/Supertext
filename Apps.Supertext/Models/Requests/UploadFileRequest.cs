﻿using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.Supertext.Models.Requests;

public class UploadFileRequest
{
    public FileReference File { get; set; }
}