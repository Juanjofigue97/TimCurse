using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace AuthorizationFormDemo.DataAccess
{
    public class MustHaveTwoElements : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var list = value as IList;
            if (list != null)
            {
                return list.Count >= 2;
            }
            return false;
        }
    }
}
