using System.ComponentModel.DataAnnotations;

namespace MarketInvoice.CTE.Validations
{
    public class RequiredGreaterThanZero : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is decimal)
            {
                return value != null && decimal.TryParse(value.ToString(), out var i) && i > 0;
            }
            else if (value is int)
            {
                return value != null && int.TryParse(value.ToString(), out var i) && i > 0;
            }

            return false;
        }
    }
}
