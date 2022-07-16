using System.ComponentModel.DataAnnotations;

namespace LetsMarket.Enums
{
    public enum ClientCategory
    {
        [Display(Name = "Bronze")]
        Bronze,

        [Display(Name = "Prata")]
        Silver,

        [Display(Name = "Ouro")]
        Gold

    }

}