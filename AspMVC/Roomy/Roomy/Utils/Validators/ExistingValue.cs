using Roomy.Data;
using Roomy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Roomy.Utils.Validators
{
    public class ExistingValue : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            using (RoomyDbContext db = new RoomyDbContext())
            {
                /*var dbProperties = db.GetType().GetProperties();

                Type t = validationContext.ObjectType;
               
                var ds = db.Set(validationContext.ObjectType).
                    
                    .Any(x => x.test == "test");



                    if (dbSet.Any(x => x.GetType().GetProperty(validationContext.MemberName).GetValue(x).ToString() == value.ToString()))
                  
                    return new ValidationResult("La valeur n'existe pas");
                    */


                
            }
            return ValidationResult.Success;
        }
    }
}