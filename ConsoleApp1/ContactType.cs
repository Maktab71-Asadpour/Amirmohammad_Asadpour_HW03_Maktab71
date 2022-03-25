
//--------------- Part1 - Tamrin 1, 2, 3 ---------------

using System.ComponentModel.DataAnnotations;

public enum ContactType
{
    [Display(Name = "Farsi: پیامک\nFinglish: Payamak\n")]
    SMS = 1,
    [Display(Name = "Farsi: رایانامه\nFinglish: Rayanameh\n")]
    Email = 2,
}
