using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Interfaces
{
    public interface IViaCepClient
    {
        ViaCepResult Search(string zipCode);

        IEnumerable<ViaCepResult> Search(string stateInitials, string city, string address);

        Task<ViaCepResult> SearchAsync(string zipCode, CancellationToken cancellationToken);

        Task<IEnumerable<ViaCepResult>> SearchAsync(
            string stateInitials,
            string city,
            string address,
            CancellationToken cancellationToken
        );
    }
}
