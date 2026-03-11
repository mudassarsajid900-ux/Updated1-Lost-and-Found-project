namespace GAC.Common.Constants
{
    public static class ErrorConstants
    {
        public const string Error204Message = "No Content Found";
        public const string Error404Message = "Not Found";
        public const string Error401Message = "UnAuthorized";
        public const string ValidationErrorMessage = "Validation error";
        public const string ErrorOccurred = "Error occurred";
        public const string InternalServerErrorAccured = "Internal Server Error";
        public const string LockedOut = "Your account has been locked out. Please try again later.";
        public const string NotAllowed = "You are not allowed to sign in. Please contact the administrator.";
        public const string FormupdationError = "Error occurred while updating the form.";
        public const string FormDeletionError = "Error occurred while deleting the form.";
        public const string ErrorUserNotFound = "User Not Found";
        public const string ErrorValidationNotFound = "Invalid validation name or missing validation data.";
        public const string InvalidPermissionType = "Invalid permission type.";
        public const string InvalidOfficialPermissionType = "Invalid or missing official permission type for 'Official Permission'.";
        public const string ExceededOfficialPermissionHours = "Submitted hours cannot exceed 5 hours for 'Official Permission' with 'Hours' type.";
        public const string MaleCannotApplyNursary = "Male cannot apply for nursery permission.";
        public const string NursaryHoursExceeded = "Nursery Permission hours exceed the allowed limit.";
        public const string MissingMaternityLeave = "Nursery Permission can only be submitted if there is an approved Delivery Leave request.";
        public const string ExceededNursaryTimeLimit = "Nursery Permission can only be applied within 2 years of the last Delivery Leave Resumption.";
        public const string NursaryBeyondOneYear = "Nursery Permission cannot be submitted more than 1 year after the last Delivery Leave Resumption.";
        public const string InvalidLoginData = "Invalid login data provided.";
        public const string InvalidCredentials = "Invalid username or password.";
        public const string InvalidId = "Invalid Id";
        public const string UserNameHeadersRequired = "UserName headers is required";
        public const string InvalidEndpoint = "Invalid Endpoint: {0}";
        public const string InvalidRoleId = "Role ID mismatch.";
        public const string PermissionMissingRoleId = "Permissions for role with ID {0} not found.";
        public const string RoleIdRequired = "Role ID is required.";
        public const string InvalidOrganizationDomain = "Enter a valid Email Address which matches the company domain";
        public const string InvalidToken = "Invalid token";
        public const string AnnouncementsNotmatching = "No matching announcements to dismiss.";
        public const string AnnouncementsDismissedSuccessfully = "All announcements dismissed successfully.";
        public const string FailedUserCreation = "User creation failed: {0}";
        public const string FailedRoleAssignment = "Failed to assign role : {0}";
        public const string FailedRemoveRole = "Failed to remove role : {0}";
        public const string RoleAlreadyExistst = "This user already has already assign role : {0}";
        public const string OrganizationNotFound = "Organization with ID '{0}' not found.";
        public const string EmailDomainMismatch = "Email domain '{0}' does not match with company domain '{1}'.";
        public const string CountryNameRequired = "CountryName is required.";
        public const string CreatorUserNotFound = "Creator user with username '{0}' not found.";
        public const string UserWithUsernameNotFound = "User with username '{0}' not found.";
        public const string InvalidInput = "Invalid input data.";
        public const string NoAnnouncementsFound = "No announcements found to dismiss.";
        public const string AnnouncementDismissed = "Announcement dismissed successfully";
        public const string ValidationNotNull = "Validation ID cannot be null.";
        public const string UpdateRoleFail = "Failed to update role";
        public const string UserNotFound = "User not found.";
        public const string RoleNotFound = "Role not found.";
        public const string UserHasNoRoles = "User has no assigned roles.";
        public const string UnhandledException = "Unhandled exception occurred: {0}";
        public const string InvalidFileType = "Invalid file type.";
        public const string InvalidFileUrl = "Invalid file URL.";
        public const string FileNotFoundById = "File with ID '{0}' not found.";
        public const string FileDownloadFailed = "Failed to download file.";


    }
}
