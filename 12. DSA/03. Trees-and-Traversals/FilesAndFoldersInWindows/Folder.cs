namespace FilesAndFoldersInWindows
{
    using System.Collections.Generic;

    public class Folder
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.Folders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> Folders { get; set; }
    }
}
