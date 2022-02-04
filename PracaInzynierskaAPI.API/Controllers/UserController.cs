﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;
using PracaInzynierska.Application.DTO.User;
using PracaInzynierska.Application.Services.User;
using PracaInzynierskaAPI.API.PoliciesAndPermissions;
using System;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.API.Controllers
{
    [EnableCors("CorsPolicy")]   
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        private ILogger _logger;

        public UserController(IUserService service)
        {
            _service = service;
            _logger = LogManager.GetCurrentClassLogger();
        }

        [AllowAnonymous]
        [HttpGet("GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllUsers()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _service.GetAllUsers();
                    if (result.Success)
                        return await Task.FromResult(Ok(result));
                    else
                        return await Task.FromResult(BadRequest(result));
                }
                catch (Exception err)
                {
                    _logger.Error(err, "UserController.GetAllUsers");
                    throw;
                }
                
            }
            return await Task.FromResult(BadRequest());    
        }

        [HttpGet("GetUserById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _service.GetUserById(id);
                    if (result.Success)
                        return await Task.FromResult(Ok(result));
                    else
                        return await Task.FromResult(BadRequest(result));
                }
                catch(Exception err)
                {
                    _logger.Error(err, "UserController.GetAllUsers");
                    throw;
                }
            }
            return await Task.FromResult(BadRequest());
        }

        [AllowAnonymous]
        [HttpGet("GetUserNameById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUserNameById(Guid id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _service.GetUserNameById(id);
                    if (result.Success)
                        return await Task.FromResult(Ok(result));
                    else
                        return await Task.FromResult(BadRequest(result));
                }
                catch (Exception err)
                {
                    _logger.Error(err, "UserController.GetAllUsers");
                    throw;
                }
            }
            return await Task.FromResult(BadRequest());
        }

        [HttpGet("GetMe")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetMe()
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
                return await Task.FromResult(Ok(null));
            try
            {
                var me = _service.GetUserById(Guid.Parse(User.Identity.Name));
                if (me.Object != null)
                    return await Task.FromResult(Ok(me.Object));
                else
                    return await Task.FromResult(Ok(null));
            }
            catch(Exception err)
            {
                _logger.Error(err, "UserController.GetMe");
                throw;
            }
        }

        [HttpGet("GetMeWithPassword")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetMeWithPassword()
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
                return await Task.FromResult(Ok(null));
            try
            {
                var me = _service.GetUserByIdForModAndAdmin(Guid.Parse(User.Identity.Name));
                if (me != null)
                    return await Task.FromResult(Ok(me.Object));
                else
                    return await Task.FromResult(Ok(null));
            }
            catch (Exception err)
            {
                _logger.Error(err, "UserController.GetMe");
                throw;
            }
        }


        [HttpPut("UpdateUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUser(UserDTO user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _service.UpdateUser(user);
                    if (result.Success)
                        return await Task.FromResult(Ok(result));
                    else
                        return await Task.FromResult(BadRequest(result));
                }
                catch (Exception err)
                {
                    _logger.Error(err, "UserController.UpdateUser");
                    throw;
                }

            }
            return await Task.FromResult(BadRequest());
        }

        [Authorize(Policy = Policies.User.Delete)]
        [HttpDelete("DeleteUser/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _service.DeleteUser(id);
                    if (result.Success)
                        return await Task.FromResult(Ok(result));
                    else
                        return await Task.FromResult(BadRequest(result));
                }
                catch (Exception err)
                {
                    _logger.Error(err, "UserController.DeleteUser");
                    throw;
                }
            }
            return await Task.FromResult(BadRequest());
        }
    }
}
