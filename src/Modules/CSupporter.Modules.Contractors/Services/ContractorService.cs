using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.Contractors.Entities;
using CSupporter.Modules.Contractors.Exceptions;
using CSupporter.Modules.Contractors.Repositories.Abstractions;
using CSupporter.Modules.Contractors.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Services
{
    internal class ContractorService : IContractorService
    {
        private readonly IContractorRepository _contractorRepository;

        public ContractorService(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;
        }

        public async Task AddAsync(ContractorDto dto)
        {
            dto.Id = Guid.NewGuid();
            await _contractorRepository.AddAsync(new Contractor 
            { 
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Address = dto.Address,
                CompanyName = dto.CompanyName,
                CompanyDetails = dto.CompanyDetails,
                NIP = dto.NIP,
                InsertDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
        }

        public Task<ContractorDetailsDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ContractorDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ContractorDto dto)
        {
            var contractor = await _contractorRepository.GetAsync(dto.Id);
            if (contractor is null)
            {
                throw new ContractNotFoundException(dto.Id);
            }

            contractor.FirstName = dto.FirstName;
            contractor.LastName = dto.LastName;
            contractor.CompanyName = dto.CompanyName;
            contractor.Address = dto.Address;
            await _contractorRepository.UpdateAsync(contractor);
        }

        public async Task DeleteAsync(Guid id)
        {
            var contractor = await _contractorRepository.GetAsync(id);
            if (contractor is null)
            {
                throw new ContractNotFoundException(id);
            }

            await _contractorRepository.DeleteAsync(contractor);
        }
    }
}
