﻿using ConsoleApp14.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public interface ISchoolClassService
    {
        List<SchoolClass> GetAllSchoolClasses();
    }
}
