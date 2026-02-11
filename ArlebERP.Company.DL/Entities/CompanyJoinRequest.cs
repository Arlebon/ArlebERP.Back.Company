using ArlebERP.Company.DL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DL.Entities
{
    public class CompanyJoinRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public DateTimeOffset Date { get; set; }

        public JoinRequestStatus Status { get; set; }
    }
}
