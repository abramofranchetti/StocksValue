namespace StocksValue;

using System.Text.Json;
using System.Windows.Forms;

public partial class WidgetForm : Form
{
    private ApplicationConfig _config = new();
    private FinanceClient _client = new();
    private System.Windows.Forms.Timer _timer = new();

    public WidgetForm()
    {
        InitializeComponent();
        LoadConfig();
        LoadData();

        _timer.Interval = _config.refreshMinutes * 60 * 1000;
        _timer.Tick += async (_, _) => { try { await LoadData(); } catch { } };
        _timer.Start();
    }
    private void RegisterMouseEvents(Control parent)
    {
        parent.MouseEnter += (_, _) => this.Opacity = 0.2;
        parent.MouseLeave += (_, _) => this.Opacity = 1;

        foreach (Control c in parent.Controls)
            RegisterMouseEvents(c);
    }


    private void LoadConfig()
    {
        try
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.json");
            var json = File.ReadAllText(path);

            _config = JsonSerializer.Deserialize<ApplicationConfig>(json);
            if (_config == null || _config.stocks == null || _config.stocks.Count == 0)
            {
                MessageBox.Show("Nessuna Stock caricata da file di config");
                return;
            }
            _client.ApiKey = _config.apiKey;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento della config: {ex.Message}");
        }
    }

    private async Task LoadData()
    {
        try
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var stock in _config.stocks)
            {
                var price = await _client.GetPriceAsync(stock.ticker);
                if (price == null) continue;

                var deltaPct = (price.Value - stock.referencePrice) / stock.referencePrice * 100;

                var label = new Label
                {
                    AutoSize = true,
                    ForeColor = deltaPct >= 0 ? Color.LightGreen : Color.OrangeRed,
                    BackColor = Color.Transparent,
                    Text =
                        $"{stock.nome} {deltaPct:+0.00;-0.00}%\n" +
                        $"Prz: {price:0.00}\n"                        
                };

                flowLayoutPanel.Controls.Add(label);
                flowLayoutPanel.Controls.Add(new Label
                {
                    AutoSize = false,
                    Height = 1,
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = flowLayoutPanel.ClientSize.Width,
                    ForeColor = Color.Wheat,
                    BackColor = Color.Transparent,
                    Padding = new Padding(0, 4, 0, 4),
                    Margin = new Padding(0, 4, 0, 4)
                });
            }
            flowLayoutPanel.Controls.RemoveAt(flowLayoutPanel.Controls.Count - 1);
        }
        catch
        {
            var label = new Label
            {
                AutoSize = true,
                ForeColor = Color.OrangeRed,
                Text = "Errore lettura prezzo"
            };

            flowLayoutPanel.Controls.Add(label);
        }
        RegisterMouseEvents(this);
        // seleziona lo schermo dove vuoi posizionare il widget
        var screen = Screen.FromControl(this); // o Screen.PrimaryScreen
        var workingArea = screen.WorkingArea;

        this.Location = new Point(
            workingArea.Right - this.Width,  // distanza dx = larghezza finestra
            workingArea.Bottom - this.Height // distanza basso = altezza finestra
        );
    }

    private void aggiornaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            LoadConfig();
            LoadData();
        }
        catch { }
    }

    private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            Application.Exit();
        }
        catch { }
    }

    private void apriConfigurazioneToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            //apre configurazione con notepad
            var path = Path.Combine(AppContext.BaseDirectory, "config.json");
            System.Diagnostics.Process.Start("notepad.exe", path);
        }
        catch { }
    }

    private void spostaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            //sposta finestra nel primario o secondario a seconda di dove si trova
            var screen = Screen.FromControl(this);
            if (screen.Primary)
            {
                var secondary = Screen.AllScreens.FirstOrDefault(s => !s.Primary);
                if (secondary != null)
                {
                    this.Location = secondary.WorkingArea.Location;
                }
            }
            else
            {
                var primary = Screen.AllScreens.FirstOrDefault(s => s.Primary);
                if (primary != null)
                {
                    this.Location = primary.WorkingArea.Location;
                }
            }
        }
        catch { }
    }
    protected override void OnFormClosing(FormClosingEventArgs e) { _timer.Stop(); base.OnFormClosing(e); }
    protected override void OnLoad(EventArgs e)
    {
        try
        {
            base.OnLoad(e);
            var secondary = Screen.AllScreens.FirstOrDefault(s => !s.Primary);
            if (secondary != null)
            {
                this.Location = secondary.WorkingArea.Location;
            }
            else
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
        }
        catch { }
    }

    private void attivaDisattivaAlwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try {            
            this.attivaDisattivaAlwaysOnTopToolStripMenuItem.Checked = this.TopMost;
            this.TopMost = !this.TopMost;
        }
        catch { }
    }    
}