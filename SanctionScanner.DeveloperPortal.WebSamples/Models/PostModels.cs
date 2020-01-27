using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanctionScanner.DeveloperPortal.WebSamples.Models
{
    public class PostModels
    {
    }

    public class AssignUserModels
    {
        public string ScanId { get; set; }
        public int UserId { get; set; }
    }

    public class MatchStatusModels
    {
        public string ScanId { get; set; }
        public int StatusId { get; set; }
    }

    public class RiskLevelModels
    {
        public string ScanId { get; set; }
        public int RiskLevelId { get; set; }
    }

    public class AddMemoModels
    {
        public string ScanId { get; set; }
        public string Memo { get; set; }
    }

    public class SafeListModels
    {
        public string ScanId { get; set; }
    }

    public class DeleteFromSafeListModels
    {
        public string ReferenceNumber { get; set; }
    }

    public class NewBlackListModels
    {
        public int TypeId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string BirthDayDate { get; set; }
        public string NationalityId { get; set; }
        public int DocumentNumber { get; set; }
        public string OtherInformation { get; set; }
        public string ExtraInfo { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public class UpdateBlackListModels
    {
        public int TypeId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string BirthDayDate { get; set; }
        public string NationalityId { get; set; }
        public int DocumentNumber { get; set; }
        public string OtherInformation { get; set; }
        public string ExtraInfo { get; set; }
        public string Guid { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public class DeleteBlackListModels
    {
        public string Guid { get; set; }
    }

    public class NewWhiteListModels
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PassportNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string Description { get; set; }
    }

    public class UpdateWhiteListModels
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PassportNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string Description { get; set; }
        public string Guid { get; set; }
    }
}