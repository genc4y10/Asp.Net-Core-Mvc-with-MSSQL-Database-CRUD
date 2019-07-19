using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMvcCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="Lütfen isim giriniz")]
        [DisplayName("Ad Soyad")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Şirket Kod")]
        public string EmpCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Pozisyon")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Adres")]
        public string OfficeLocation { get; set; }


    }
}
