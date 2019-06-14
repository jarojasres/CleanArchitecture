﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Commands
{
    public abstract class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
