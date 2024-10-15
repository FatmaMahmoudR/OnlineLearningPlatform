using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Entities.Structs
{
    public static class EnumHelper
    {
        public static string GetDisplayName(Enum enumValue)
        {
            var displayAttribute = enumValue.GetType()
                .GetMember(enumValue.ToString())[0]
                .GetCustomAttribute<DisplayAttribute>();

            return displayAttribute != null ? displayAttribute.Name : enumValue.ToString();
        }
    }
}
