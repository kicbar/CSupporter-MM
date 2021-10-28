using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.Contractors.Entities;
using CSupporter.Modules.Contractors.Exceptions;
using CSupporter.Modules.Contractors.Repositories.Abstractions;
using CSupporter.Modules.Contractors.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Services
{
    public class ContractorService : IContractorService
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

        public async Task<ContractorDetailsDto> GetAsync(Guid id)
        {
            var contractor = await _contractorRepository.GetAsync(id);

            if (contractor is null)
                return null;

            return Map<ContractorDetailsDto>(contractor);
        }

        public async Task<IReadOnlyList<ContractorDto>> GetAllAsync()
        {
            var contractors = await _contractorRepository.GetAllAsync();

            if (contractors is null)
                return null;

            return contractors.Select(Map<ContractorDto>).ToList();
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

        private static T Map<T>(Contractor contractor) where T : ContractorDto, new()
        => new T()
        {
            Id = contractor.Id,
            FirstName = contractor.FirstName,
            LastName = contractor.LastName,
            Address = contractor.Address,
            CompanyName = contractor.CompanyName,
            CompanyDetails = contractor.CompanyDetails,
            NIP = contractor.NIP
        };
    }
}
