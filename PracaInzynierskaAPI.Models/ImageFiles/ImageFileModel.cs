﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.Models.ImageFiles
{
    public class ImageFileModel
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        public IFormFile Image { get; set; }
    }
}
