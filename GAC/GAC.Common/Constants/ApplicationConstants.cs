namespace GAC.Common.Constants
{
    public static class ApplicationConstants
    {
        public const string AdministratorRole = "Administrator";

        // Login
        public const string LoginFailed_UserNotFound = "Invalid username or password.";
        public const string LoginFailed_InvalidPassword = "Invalid username or password.";

        // Register
        public const string UserCreated = "User created successfully.";
        public const string UserCreationFailed = "User creation failed: ";

        // Role
        public const string RoleCreated = "Role created.";
        public const string RoleAlreadyExists = "Role already exists.";
        public const string RoleCreationFailed = "Role creation failed: ";
        public const string RoleCreatedSuceessfuly = "Role created using repository.";

        // Assign Role
        public const string UserNotFound = "User not found.";
        public const string RoleNotFound = "Role not found.";
        public const string RoleAssignedToUser = "Role assigned to user.";
        public const string RoleAssignFailed = "Role assignment failed: ";

        public const string ApiBaseRoute = "api/[controller]";
        public const string AnnouncementGetDetailsRoute = "/Announcements/GetAnnouncementDetails";
        public const string LoginWithMicrosoft = "login-with-microsoft";
        public const string RegisterRoute = "register";
        public const string CreateRole = "createrole";
        public const string AssignRole = "assignrole";
        public const string UserFound = "User found successfully.";
        public const string Base64CannotBeNull = "Base64 data cannot be null or empty";
        public const string ListCannotBeNull = "The list cannot be null or empty";
        public const string LoginSuccessful = "Login Successful";
        public const string UpdateTokenSuccessful = "Token Updated Successfully";

        public const string RedirectUrl = "redirect-url";

        public const string GenerateToken = "generate-token";

        public const string InvalidCredentials = "Invalid Credentials";
        public const string InvalidToken = "Invalid Token";

        public const string JsonContentType = "application/json";
        public const string GenericExceptionResponse = "An unexpected exception has occurred.";
        public const string Bearer = "Bearer";

        public const string OrganizationCreated = "Organization created successfully.";
        public const string OrganizationUpdated = "Organization updated successfully.";
        public const string OrganizationDeleted = "Organization deleted successfully.";
        public const string OrganizationNotFound = "Organization not found.";

        public const string Sucess = "Success";
        public const string DeleteAnnouncementSuccess = "Announcement deleted successfully.";
        public const string UpdateAnnouncementSuccess = "Announcement Updated successfully.";

        public const string HomeController = "Home";
        public const string HomeIndexAction = "Index";

        public const string AccountController = "Account";
        public const string AddUpdate = "AddUpdate";


    }
}
