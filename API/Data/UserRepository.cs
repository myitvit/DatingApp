using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public UserRepository(DataContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await context.Users
            .Include(photos => photos.Photos)
            .ToListAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByUsernameAsync(string username)
        {
            return await context.Users.SingleOrDefaultAsync(user => user.UserName == username);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            context.Entry(user).State = EntityState.Modified;
        }

        public async Task<IEnumerable<MemberDTO>> GetMembersAsync()
        {
            return await context.Users
            .ProjectTo<MemberDTO>(mapper.ConfigurationProvider)
            .ToListAsync();
        }

        public async Task<MemberDTO> GetMemberByIdAsync(int id)
        {
            return await context.Users
            .Where(user => user.Id == id)
            .ProjectTo<MemberDTO>(mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
        }

        public async Task<MemberDTO> GetMemberByUsernameAsync(string username)
        {
            return await context.Users
            .Where(user => user.UserName == username)
            .ProjectTo<MemberDTO>(mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
        }

    }
}