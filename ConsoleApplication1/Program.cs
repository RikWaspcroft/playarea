namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Actions taken to link VS Git to GitHub repository
             * Install Git from https://git-scm.com/download/win and used all defaults
             * Installed Visual Studio - Git Source Control Provider
             * Tools\Options, set the Source Control plugin to Git Source Control Provider
             * Installed Visual Studio - Git Extensions (provider right-click menu for all Git operations)
             * From the command line ran; puttygen.exe, clicked generate and saved ppk file with sensible name to sensible place
             * Logged into GitHub, went to Settings/SSH and GPG Keys, clicked New SSH Key and pasted in puttygen generated key
             * From Visual Studio, right-clicked on the solution and selected "Manage Remotes", entered the git URL to the repository and browsed to the ppk file saved earlier
             * 
             * Testing: 
             * Open project in visual studio you wish to push or push changes to GitHub. Right click, select "Git(<branch>)/Push" and select the remote repository and click "Push"
             * The first time you push, you will need to enter the GitHub login credentials for the GitHub project.
             * 
             */
        }
    }
}