//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAA
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormControlOption
    {
        public int Id { get; set; }
        public string optionLabel { get; set; }
        public string optionValue { get; set; }
        public Nullable<int> formControlId { get; set; }
    
        public virtual FormControl FormControl { get; set; }
    }
}
