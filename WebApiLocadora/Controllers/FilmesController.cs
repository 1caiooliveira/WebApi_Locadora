using AutoMapper;
using Locadora.Business.Interfaces;
using Locadora.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLocadora.ViewModels;

namespace WebApiLocadora.Controllers
{
    [Route("api/filmes")]
    public class FilmesController : MainController
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IFilmeService _filmeService;
        private readonly IMapper _mapper;

        public FilmesController(IFilmeRepository filmeRepository,
                                IFilmeService filmeService,
                                IMapper mapper,
                                INotificador notificador
            ) : base(notificador)
        {
            _filmeRepository = filmeRepository;
            _filmeService = filmeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<FilmeViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<FilmeViewModel>>(await _filmeRepository.ObterTodos());
        }

        [HttpPost]
        public async Task<ActionResult<FilmeViewModel>> Adicionar(FilmeViewModel filmeViewModel)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

                await _filmeService.Adicionar(_mapper.Map<Filme>(filmeViewModel));

                return CustomResponse(filmeViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
