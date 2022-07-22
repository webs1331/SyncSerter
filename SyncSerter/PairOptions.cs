namespace SyncSerter;

public class PairOptions
{
    public ActionType ActionType { get; set; }

    public bool AllFilesIncluded { get; set; }

    public bool ExcludeHiddenFiles { get; set; }

    public List<string> ExcludedFileTypes { get; set; }

    public DateTime? LastRunDate { get; set; }

    //future features
    //public bool IncludeInRunAll { get; set; }

    //public int GroupId { get; set; }
}

public enum ActionType
{
    Synchronize = 1, //takes the two folders and makes sure they have exactly the same files. Will delete and rename files
    Upsert = 2,      //looks for changes (file modifications, new files, renames, deletes) in the left folder and makes the right folder match the left folder in every way
    Additive = 3     //like an Upsert, but it does not delete any files.
}