﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trifolia.Web.Models.TemplateManagement
{
    public class EditModel
    {
        public int TemplateId { get; set; }
        public int? DefaultImplementationGuideId { get; set; }
    }
}