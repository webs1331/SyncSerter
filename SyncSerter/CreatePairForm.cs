using System.Security;
using Newtonsoft.Json;
using SyncSerter.Data;

namespace SyncSerter;

public partial class CreatePairForm : Form
{
    private readonly string PairDatabaseFilePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Data\Pairs.json"));

    private List<Pair> Pairs;
    private Pair ActivePair;

    public CreatePairForm() => InitializeComponent();


    private string ValidatePair()
    {
        var message = string.Empty;

        if (!File.Exists(ActivePair.LeftFolder)) message += "Left Folder could not be accessed or no longer exists. \n";
        if (!File.Exists(ActivePair.RightFolder)) message += "Right Folder could not be accessed or no longer exists. \n";
        if (ActivePair.Options.ActionType == default) message += "Please select an Action Type.";

        return message;
    }

    //Events
    private void CreatePairForm_Load(object sender, EventArgs e)
    {
        ActivePair = new Pair();

        if (File.Exists(PairDatabaseFilePath))
        {
            try
            {
                var pairData = DataHelper.ReadJSON<List<Pair>>(PairDatabaseFilePath);
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

    private void btnBrowseLeft_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialogLeft.ShowDialog() != DialogResult.OK) return;

        try
        {
            txtLeftFolder.Text = ActivePair.LeftFolder = folderBrowserDialogLeft.SelectedPath;
        }
        catch (SecurityException ex)
        {
            MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\nDetails:\n\n{ex.StackTrace}");
        }
    }

    private void btnBrowseRight_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialogRight.ShowDialog() != DialogResult.OK) return;
        try
        {
            txtRightFolder.Text = ActivePair.RightFolder = folderBrowserDialogRight.SelectedPath;
        }
        catch (SecurityException ex)
        {
            MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\nDetails:\n\n{ex.StackTrace}");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) => Close();

    private void btnSave_Click(object sender, EventArgs e)
    {
        this.ActivePair = new Pair();

        ActivePair.LeftFolder = txtLeftFolder.Text;
        ActivePair.RightFolder = txtRightFolder.Text;
        ActivePair.Options = new PairOptions
        {
            AllFilesIncluded = cbAllFilesIncluded.Checked,
            ActionType = (ActionType)cBoxSyncAction.SelectedValue,
            ExcludedFileTypes = new List<string>()
        };

        foreach (var t in lstExcludedFileTypes.Items) ActivePair.Options.ExcludedFileTypes.Add(t.ToString());

        var message = ValidatePair();
        if (!string.IsNullOrEmpty(message))
        {
            MessageBox.Show(message);
            return;
        }

        this.Pairs.Add(ActivePair);

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