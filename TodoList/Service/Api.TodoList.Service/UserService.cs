﻿using Api.TodoList.Data.Entity.Model;
using Api.TodoList.Data.Repository.Contract;
using Api.TodoList.Service.Contract;

namespace Api.TodoList.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetAll().ConfigureAwait(false);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetById(id).ConfigureAwait(false);
            if (user == null)
            {
                throw new Exception($"User {id} not found.");
            }

            return user;
        }
    }
}