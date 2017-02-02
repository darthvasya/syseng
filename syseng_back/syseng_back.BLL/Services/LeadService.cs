using AutoMapper;
using syseng_back.BLL.DTO;
using syseng_back.BLL.Infrastructure;
using syseng_back.BLL.Interfaces;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.BLL.Services
{
    public class LeadService : ILeadService
    {
        IUnitOfWork _context { get; set; }

        public LeadService(IUnitOfWork uow)
        {
            _context = uow;
        }

        public void AddLead(LeadDTO lead)
        {
            lead.Date = DateTime.Now;
            Mapper.Initialize(c => c.CreateMap<LeadDTO, Lead>());
            _context.Leads.Create(Mapper.Map<LeadDTO, Lead>(lead));
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public LeadDTO GetLead(int id)
        {
            var lead = _context.Leads.Get(id);
            Mapper.Initialize(c => c.CreateMap<Lead, LeadDTO>());
            return Mapper.Map<Lead, LeadDTO>(lead);
        }

        public IEnumerable<LeadDTO> GetLeads()
        {
            Mapper.Initialize(c => c.CreateMap<Lead, LeadDTO>());
            return Mapper.Map<IEnumerable<Lead>, List<LeadDTO>>(_context.Leads.GetAll());
        }

        public void RemoveLead(int id)
        {
            throw new NotImplementedException();
        }
    }
}
