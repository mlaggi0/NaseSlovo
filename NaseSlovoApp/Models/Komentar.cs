//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NaseSlovoApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komentar
    {
        public int KomentarID { get; set; }
        public int KorisnikID { get; set; }
        public int TekstID { get; set; }
        public string Sadrzaj { get; set; }
        public System.DateTime DatumVrijeme { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Tekst Tekst { get; set; }
    }
}