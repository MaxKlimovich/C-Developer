﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Models;
internal interface IMarried
{
    public FamilyMember Spouse { get; set; }
}
