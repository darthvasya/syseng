using AutoMapper;
using syseng_back.BLL.DTO;
using syseng_back.BLL.Infrastructure;
using syseng_back.BLL.Interfaces;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;


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
            SendEmail();
            _context.Save();
        }

        private void SendEmail()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("from@gmail.com", "Tom");
            // кому отправляем
            MailAddress to = new MailAddress("vasyamakarchuk@outlook.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;

            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("vasyamakarchuk@gmail.com", "");
            smtp.EnableSsl = true;
            smtp.Send(m);
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
