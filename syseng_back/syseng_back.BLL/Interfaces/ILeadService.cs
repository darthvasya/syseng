using syseng_back.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.BLL.Interfaces
{
    public interface ILeadService
    {
        LeadDTO GetLead(int id);
        IEnumerable<LeadDTO> GetLeads();
        void AddLead(LeadDTO lead);
        void RemoveLead(int id);
        void Dispose();
    }
}
