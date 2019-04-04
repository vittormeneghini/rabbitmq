using System.Collections.Generic;
using System.Threading.Tasks;
using Microservices.Services.Core.Entities;

namespace Microservices.Services.Core.Services
{
    public interface IEmailService
    {
        Task<IEnumerable<Email>> GetAllAsync();
    }
}