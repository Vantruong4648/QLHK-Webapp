using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.Helpers
{
    public class ValidationHelper
    {
        internal static void ModelValidation(object obj)
        {
            //Model validations
            ValidationContext validationContext = new ValidationContext(obj);
            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            if (!isValid)
            {
                throw new ArgumentException(validationResults.FirstOrDefault()?.ErrorMessage);
            }
        }
    }

    public class CommonHelper
    {
        public const string SessionKeyUser = "SessionKeyUser";
        public const string SessionKeyID = "SessionKeyID";
        public static bool IsGuid(string guid) {
            Guid x;
            return Guid.TryParse(guid, out x);
        }
    }

    public enum SessionKeyEnum
    {
        SessionKeyUser = 0,
        SessionKeyID = 1

    }

    public enum SortOrderOptions
    {
        ASC, DESC
    }
}
