//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MMC2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skill
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public int Usuario_Id { get; set; }
        public int TipoSkills_Id { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual TipoSkill TipoSkill { get; set; }
    }
}
