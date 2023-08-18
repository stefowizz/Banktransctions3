using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banktransctions3.Models  
{
    public class Transaction 
    {
        [Key]
        public int TransactionId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only!!!")]
        [DisplayName("Full Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string? fullname { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only!!!")]
        [DisplayName("Account Number")]
        [Column(TypeName = "nvarchar(11)")]
        public string? AccountNumber { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only!!!")]
        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string? BeneficiaryName { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only!!!")]
        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string? BankName { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only!!!")]
        [DisplayName("Swift Code")]
        [Column(TypeName = "nvarchar(11)")]
        public string? swiftcode { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Amount")]
        public int Amount { get; set; }


        //[Required(ErrorMessage = "This field is required")]
        //[MaxLength(20, ErrorMessage = "Maximum 20 characters only!!!")]
        [DisplayName("Transaction Date")]
        [Column(TypeName = "nvarchar(20)")]
        public DateTime Date { get; set; } 


    }
}
