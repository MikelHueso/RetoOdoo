using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODOO.Models
{
    /*Los parametros que tienen la etiqueta [Required] verifican que se introduzca algo en los campos de forma
      que la aplicacion no falla al intentar crear o editar Eventos*/
    public partial class EventEvent
    {
        public int Id { get; set; }
        public int? MessageMainAttachmentId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool? Active { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public int? OrganizerId { get; set; }
        public int? EventTypeId { get; set; }
        public int? Color { get; set; }
        [Required]
        public int? SeatsMax { get; set; }
        [Required]
        public string SeatsAvailability { get; set; }
        [Required]
        public int? SeatsMin { get; set; }
        [Required]
        public int? SeatsReserved { get; set; }
        [Required]
        public int? SeatsAvailable { get; set; }
        public int? SeatsUnconfirmed { get; set; }
        [Required]
        public int? SeatsUsed { get; set; }
        [Required]
        public string DateTz { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        [Required]
        public string State { get; set; }
        public bool? AutoConfirm { get; set; }
        [Required]
        public bool? IsOnline { get; set; }
        public int? AddressId { get; set; }
        public int? CountryId { get; set; }
        public string TwitterHashtag { get; set; }
        [Required]
        public string Description { get; set; }
        public string BadgeFront { get; set; }
        public string BadgeBack { get; set; }
        public string BadgeInnerleft { get; set; }
        public string BadgeInnerright { get; set; }
        public string EventLogo { get; set; }
        public int? CreateUid { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? WriteUid { get; set; }
        public DateTime? WriteDate { get; set; }
        public string WebsiteMetaTitle { get; set; }
        public string WebsiteMetaDescription { get; set; }
        public string WebsiteMetaKeywords { get; set; }
        public string WebsiteMetaOgImg { get; set; }
        public int? WebsiteId { get; set; }
        public bool? IsPublished { get; set; }
        public bool? WebsiteMenu { get; set; }
        public int? MenuId { get; set; }
    }
}
