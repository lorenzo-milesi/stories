﻿using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class ProjectsProfile : Profile
    {
        public ProjectsProfile()
        {
            CreateMap<Project, ProjectData>();
        }
    }
}