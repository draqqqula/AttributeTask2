using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations;

namespace AttributeTask2.Validation
{
    public class NotNullOrDefaultValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is null)
            {
                return false;
            }
            else if (value is string)
            {
                return !value.Equals(string.Empty);
            }
            Type valueType = value.GetType();
            var defaultValue = valueType.GetDefaultValue();
            return !value.Equals(defaultValue);
        }

        private bool IsDefault(object value, Type type)
        {
            object defaultValue = Activator.CreateInstance(type);
            return value.Equals(defaultValue);
        }
    }
}
