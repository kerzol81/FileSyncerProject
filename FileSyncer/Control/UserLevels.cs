
namespace FileSyncer.Control
{
    sealed class UserLevels
    {  
        public static string[] Levels
        {
            get
            {
                return new string[3] { "Admin", "Operator", "Viewer" };
            }
        }
    }
}
