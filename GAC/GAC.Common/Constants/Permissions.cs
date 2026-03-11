namespace GAC.Common.Constants
{
    public static class PermissionConstants
    {
        public const string View = "View";
        public const string Create = "Create";
        public const string Edit = "Edit";
        public const string Delete = "Delete";
        public const string Manage = "Manage";

        public static List<string> GetAllPermissions()
        {
            return new List<string>
            {
                View,
                Create,
                Edit,
                Delete
            };
        }

        public static string GetDisplayName(string permission)
        {
            return permission switch
            {
                View => "View",
                Create => "Create",
                Edit => "Edit",
                Delete => "Delete",
                Manage => "Manage",
                _ => permission
            };
        }
    }
}