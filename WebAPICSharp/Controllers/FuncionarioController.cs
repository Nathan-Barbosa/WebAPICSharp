﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCSharp.Models;
using WebAPICSharp.Service.FuncionarioService;

namespace WebAPICSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioInterface;
        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioInterface = funcionarioInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionario()
        {
            return Ok( await _funcionarioInterface.GetFuncionarios());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncionarioById(int id)
        {

            ServiceResponse<FuncionarioModel> serviceResponse = await _funcionarioInterface.GetFuncionarioById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            return Ok(await _funcionarioInterface.CreateFuncionario(novoFuncionario));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {

            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.UpdateFuncionario(editadoFuncionario);

            return Ok(serviceResponse);
        }


        [HttpPut("inativaFuncionario")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativaFuncionario(int id)
        {

            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncionario(id);
            
            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.DeleteFuncionario(id);

            return Ok(serviceResponse);
        }
    }
}
