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
    public class ChildService: IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }
        public async Task<ChildModel> AddAsync(ChildModel child)
        {
            return _mapper.Map<ChildModel>(await _childRepository.AddAsync(_mapper.Map<Child>(child)));
        }
        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeleteAsync(id);
        }
        public async Task<List<ChildModel>> GetAllAsync()
        {
            return _mapper.Map<List<ChildModel>>(await _childRepository.GetAllAsync());
        }
        public async Task<ChildModel> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildModel>(await _childRepository.GetByIdAsync(id));
        }
        public async Task<ChildModel> UpdateAsync(ChildModel child)
        {
            return _mapper.Map<ChildModel>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));
        }
    }
}
