using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using API.Interfaces;
using API.DTOs;
using AutoMapper;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository repository;
        private readonly IMapper mapper;

        public UsersController(IUserRepository repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetUsers()
        {
            return Ok(await repository.GetMembersAsync());
        }

        // api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDTO>> GetUser(int id)
        {
            return await repository.GetMemberByIdAsync(id);
        }

        // api/users/John
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDTO>> GetUser(string username)
        {
            return await repository.GetMemberByUsernameAsync(username);
        }
    }
}