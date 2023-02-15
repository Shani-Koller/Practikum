using _2_SERVICES.Models;
using _3_REPOSITORY.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SERVICES
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Child, ChildModel>().ReverseMap();
        }
    }
}
