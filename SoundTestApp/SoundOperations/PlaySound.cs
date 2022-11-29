using System.Media;

namespace SoundTestApp.SoundOperations
{
    internal class PlaySound
    {
        private SoundPlayer player;
        private string projectDirectory;
        string currentPath = string.Empty;

        public PlaySound()
        {
            //  Get path to the project folder
            projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        }
        
        //  Play or stop sound with specified path
        public void Play(string path)
        {
            //  If sound is already playing, stop it
            if (path == currentPath)
            {
                Stop();
            }

            //  If not, create new SoundPlayer instance and play sound
            else
            {
                player = new SoundPlayer(projectDirectory + @"\Sounds\" + path);
                player.Play();
                currentPath = path;
            }
        }

        //  Stop playing sound, used here and when changing panels
        public void Stop()
        {
            //  If player exists, stop it (to avoid object exception)
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                currentPath = string.Empty;
            }
        }
    }
}
