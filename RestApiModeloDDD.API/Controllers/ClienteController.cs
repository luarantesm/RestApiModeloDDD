﻿using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Add(clienteDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Delete(clienteDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}