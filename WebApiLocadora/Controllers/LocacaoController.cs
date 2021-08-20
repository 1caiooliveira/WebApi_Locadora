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
    [Route("api/locacao")]
    public class LocacaoController : MainController
    {
        private readonly ILocacaoRepository _locacaoRepository;
        private readonly ILocacaoService _locacaoService;
        private readonly IMapper _mapper;

        public LocacaoController(ILocacaoRepository locacaoRepository,
                                 ILocacaoService locacaoService,
                                 IMapper mapper,
                                 INotificador notificador
            ) : base(notificador)
        {
            _locacaoRepository = locacaoRepository;
            _locacaoService = locacaoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<LocacaoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<LocacaoViewModel>>(await _locacaoRepository.ObterTodos());
        }

        [HttpPost("locar")]
        public async Task<ActionResult<LocacaoViewModel>> Locar(LocacaoViewModel locacao)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _locacaoService.LocarFilme(_mapper.Map<Locacao>(locacao));

            return CustomResponse(locacao);
        }

        [HttpPost("devolver")]
        public async Task<ActionResult<LocacaoViewModel>> Devolver(DevolverLocacaoViewModel devolucao)
        {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

                var result = await _locacaoService.DevolverFilme(devolucao.FilmeId, devolucao.ClienteId);

                return CustomResponse(result);
        }
    }
}
