using System.Security;
using Newtonsoft.Json;

namespace SyncSerter;

public partial class CreatePairForm : Form
{
    private readonly string PairDatabaseFilePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Data\Pairs.json"));

    private List<Pair> Pairs;
    private Pair NewPair;

    public CreatePairForm() => InitializeComponent();

    private void CreatePairForm_Load(object sender, EventArgs e)
    {
        NewPair = new Pair();

        if (File.Exists(PairDatabaseFilePath))
        {
            try
            {
                var pairData = File.ReadAllText(PairDatabaseFilePath);

                Pairs = JsonConvert.DeserializeObject<List<Pair>>(pairData);
            }
            catch (Exception ex)
            {
                Pairs = new List<Pair>();
                Console.WriteLine(ex);
            }
        }
        else
        {
            using var file = File.CreateText(PairDatabaseFilePath);
            var serializer = new JsonSerializer();
            serializer.Serialize(file, new List<Pair>());
        }

        cBoxSyncAction.DataSource = Enum.GetValues(typeof(ActionType)).Cast<ActionType>()
            .Select(x => new { Value = x, Text = x.ToString() })
            .ToList();
    }

    private string ValidatePair()
    {
        var message = string.Empty;

        if (!File.Exists(NewPair.LeftFolder)) message += "Left Folder could not be accessed or no longer exists. \n";
        if (!File.Exists(NewPair.RightFolder)) message += "Right Folder could not be accessed or no longer exists. \n";
        if (NewPair.Options.ActionType == default) message += "Please select an Action Type.";

        return message;
    }

    //Events
    private void btnBrowseLeft_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialogLeft.ShowDialog() != DialogResult.OK) return;

        try
        {
            txtLeftFolder.Text = NewPair.LeftFolder = folderBrowserDialogLeft.SelectedPath;
        }
        catch (SecurityException ex)
        {
            MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
        }
    }

    private void btnBrowseRight_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialogRight.ShowDialog() != DialogResult.OK) return;
        try
        {
            txtRightFolder.Text = NewPair.RightFolder = folderBrowserDialogRight.SelectedPath;
        }
        catch (SecurityException ex)
        {
            MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) => Close();

    private void btnSave_Click(object sender, EventArgs e)
    {
        this.NewPair = new Pair();

        NewPair.LeftFolder = txtLeftFolder.Text;
        NewPair.RightFolder = txtRightFolder.Text;
        NewPair.Options = new PairOptions
        {
            AllFilesIncluded = cbAllFilesIncluded.Checked,
            ActionType = (ActionType)cBoxSyncAction.SelectedValue,
            ExcludedFileTypes = new List<string>()
        };

        foreach (var t in lstExcludedFileTypes.Items) NewPair.Options.ExcludedFileTypes.Add(t.ToString());

        var message = ValidatePair();
        if (!string.IsNullOrEmpty(message))
        {
            MessageBox.Show(message);
            return;
        }

        Pairs.Add(NewPair);

        var pairsJson = JsonConvert.SerializeObject(Pairs);

        using var file = File.CreateText(PairDatabaseFilePath);
        var serializer = new JsonSerializer();
        serializer.Serialize(file, pairsJson);
    }

    private void cbAllFilesIncluded_CheckedChanged(object sender, EventArgs e)
    {
        var checkbox = (CheckBox)sender;

        txtExcludeFileType.Enabled = !checkbox.Checked;
        btnAddFileType.Enabled = !checkbox.Checked;
        lstExcludedFileTypes.Enabled = !checkbox.Checked;
    }
}