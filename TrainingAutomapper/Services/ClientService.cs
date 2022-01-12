using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingAutomapper.Dto;
using TrainingAutomapper.Models;
using TrainingAutomapper.Repositories;

namespace TrainingAutomapper.Services
{
    public interface IClientService
    {
        ClientDto GetClient();
    }

    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public ClientDto GetClient()
        {
            var client = _clientRepository.GetClient();

            return _mapper.Map<ClientDto>(client);
        }
    }
}
