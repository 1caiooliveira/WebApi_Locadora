using AutoMapper;
using Locadora.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLocadora.ViewModels;

namespace WebApiLocadora.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Filme, FilmeViewModel>().ReverseMap();
            CreateMap<Locacao, LocacaoViewModel>().ReverseMap();



        }
    }
}
