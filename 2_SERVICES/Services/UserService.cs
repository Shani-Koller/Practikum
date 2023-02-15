using _2_SERVICES.Interfaces;
using _2_SERVICES.Models;
using _3_REPOSITORY.Entities;
using _3_REPOSITORY.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SERVICES.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserModel> AddAsync(UserModel user)
        {
            return _mapper.Map<UserModel>(await _userRepository.AddAsync(_mapper.Map<User>(user)));
        }
        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }
        public async Task<List<UserModel>> GetAllAsync()
        {
            return _mapper.Map<List<UserModel>>(await _userRepository.GetAllAsync());
        }
        public async Task<UserModel> GetByIdAsync(int id)
        {
            return _mapper.Map<UserModel>(await _userRepository.GetByIdAsync(id));
        }
        public async Task<UserModel> UpdateAsync(UserModel user)
        {
            return _mapper.Map<UserModel>(await _userRepository.UpdateAsync(_mapper.Map<User>(user)));
        }
    }
}
