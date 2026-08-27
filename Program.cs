using System.Diagnostics;
using System.Text.Json;
using System.Text;

namespace CleanTempGui;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}

internal sealed class AppSettings
{
    public bool CleanTemporaryFiles { get; set; } = true;
    public bool CleanDefenderTemp { get; set; } = true;
    public bool CleanWindowsUpdate { get; set; } = true;
    public bool CleanSystemTemp { get; set; } = true;
    public bool EmptyRecycleBin { get; set; } = true;
    public string LogPath { get; set; } = @"C:\Logs\CleanTemp.log";
    public string Language { get; set; } = "en";
}

internal sealed record Translation(string Name, string Title, string Options, string Language, string LogPath, string Browse, string Save, string Run, string DryRun, string Register, string Saved, string Started, string ScriptsMissing, string SearchPath, string Cancelled, string AdminNote, string Temporary, string Defender, string Update, string System, string Recycle, string TaskRegistered);

internal static class Translations
{
    public static readonly IReadOnlyDictionary<string, Translation> All = new Dictionary<string, Translation>
    {
        ["en"] = new("English", "CleanTemp", "Cleanup options", "Language", "Log path", "Browse...", "Save settings", "Run now", "Simulate (dry-run)", "Register schedule", "Settings saved to", "Cleanup started", "Required PowerShell scripts were not found.", "Searched in", "Operation cancelled or failed: ", "Run as administrator to clean protected Windows folders.", "Clean temporary files", "Clean Windows Defender temporary files", "Clean Windows Update cache", "Clean SYSTEM temporary files", "Empty Recycle Bin", "Schedule registered"),
        ["it"] = new("Italiano", "CleanTemp", "Opzioni di pulizia", "Lingua", "Percorso log", "Sfoglia...", "Salva impostazioni", "Esegui ora", "Simula (dry-run)", "Registra pianificazione", "Impostazioni salvate in", "Pulizia avviata", "Gli script PowerShell richiesti non sono stati trovati.", "Percorso cercato", "Operazione annullata o fallita: ", "Esegui come amministratore per pulire le cartelle protette di Windows.", "Pulisci file temporanei", "Pulisci file temporanei di Windows Defender", "Pulisci cache di Windows Update", "Pulisci file Temp di SYSTEM", "Svuota il Cestino", "Pianificazione registrata"),
        ["es"] = new("Español", "CleanTemp", "Opciones de limpieza", "Idioma", "Ruta del registro", "Examinar...", "Guardar configuración", "Ejecutar ahora", "Simular (dry-run)", "Registrar programación", "Configuración guardada en", "Limpieza iniciada", "No se encontraron los scripts de PowerShell necesarios.", "Ruta buscada", "Operación cancelada o fallida: ", "Ejecute como administrador para limpiar carpetas protegidas de Windows.", "Limpiar archivos temporales", "Limpiar archivos temporales de Windows Defender", "Limpiar caché de Windows Update", "Limpiar archivos temporales de SYSTEM", "Vaciar la Papelera", "Programación registrada"),
        ["de"] = new("Deutsch", "CleanTemp", "Bereinigungsoptionen", "Sprache", "Protokollpfad", "Durchsuchen...", "Einstellungen speichern", "Jetzt ausführen", "Simulation (dry-run)", "Zeitplan registrieren", "Einstellungen gespeichert unter", "Bereinigung gestartet", "Die erforderlichen PowerShell-Skripte wurden nicht gefunden.", "Gesucht in", "Vorgang abgebrochen oder fehlgeschlagen: ", "Führen Sie die Anwendung als Administrator aus, um geschützte Windows-Ordner zu bereinigen.", "Temporäre Dateien bereinigen", "Temporäre Windows-Defender-Dateien bereinigen", "Windows-Update-Cache bereinigen", "SYSTEM-Temp-Dateien bereinigen", "Papierkorb leeren", "Zeitplan registriert"),
        ["fr"] = new("Français", "CleanTemp", "Options de nettoyage", "Langue", "Chemin du journal", "Parcourir...", "Enregistrer les paramètres", "Exécuter maintenant", "Simuler (dry-run)", "Enregistrer la planification", "Paramètres enregistrés dans", "Nettoyage démarré", "Les scripts PowerShell requis sont introuvables.", "Chemin recherché", "Opération annulée ou échouée : ", "Exécutez en tant qu’administrateur pour nettoyer les dossiers Windows protégés.", "Nettoyer les fichiers temporaires", "Nettoyer les fichiers temporaires de Windows Defender", "Nettoyer le cache Windows Update", "Nettoyer les fichiers temporaires SYSTEM", "Vider la Corbeille", "Planification enregistrée"),
        ["pt"] = new("Português", "CleanTemp", "Opções de limpeza", "Idioma", "Caminho do registo", "Procurar...", "Guardar definições", "Executar agora", "Simular (dry-run)", "Registar agendamento", "Definições guardadas em", "Limpeza iniciada", "Os scripts PowerShell necessários não foram encontrados.", "Caminho pesquisado", "Operação cancelada ou falhou: ", "Execute como administrador para limpar pastas protegidas do Windows.", "Limpar ficheiros temporários", "Limpar ficheiros temporários do Windows Defender", "Limpar cache do Windows Update", "Limpar ficheiros temporários do SYSTEM", "Esvaziar a Reciclagem", "Agendamento registado"),
        ["zh"] = new("中文", "CleanTemp", "清理选项", "语言", "日志路径", "浏览...", "保存设置", "立即运行", "模拟（dry-run）", "注册计划", "设置已保存到", "清理已开始", "未找到所需的 PowerShell 脚本。", "搜索路径", "操作已取消或失败：", "请以管理员身份运行，以清理受保护的 Windows 文件夹。", "清理临时文件", "清理 Windows Defender 临时文件", "清理 Windows Update 缓存", "清理 SYSTEM 临时文件", "清空回收站", "计划已注册"),
        ["ja"] = new("日本語", "CleanTemp", "クリーンアップ オプション", "言語", "ログのパス", "参照...", "設定を保存", "今すぐ実行", "シミュレーション（dry-run）", "スケジュールを登録", "設定を保存しました：", "クリーンアップを開始しました", "必要な PowerShell スクリプトが見つかりません。", "検索場所", "操作がキャンセルされたか失敗しました：", "保護された Windows フォルダーを削除するには管理者として実行してください。", "一時ファイルを削除", "Windows Defender 一時ファイルを削除", "Windows Update キャッシュを削除", "SYSTEM 一時ファイルを削除", "ごみ箱を空にする", "スケジュールを登録しました"),
        ["ru"] = new("Русский", "CleanTemp", "Параметры очистки", "Язык", "Путь к журналу", "Обзор...", "Сохранить настройки", "Запустить сейчас", "Симуляция (dry-run)", "Зарегистрировать расписание", "Настройки сохранены в", "Очистка запущена", "Не найдены необходимые сценарии PowerShell.", "Проверенный путь", "Операция отменена или завершилась ошибкой: ", "Запустите от имени администратора для очистки защищённых папок Windows.", "Очистить временные файлы", "Очистить временные файлы Windows Defender", "Очистить кэш Windows Update", "Очистить временные файлы SYSTEM", "Очистить корзину", "Расписание зарегистрировано"),
        ["ar"] = new("العربية", "CleanTemp", "خيارات التنظيف", "اللغة", "مسار السجل", "استعراض...", "حفظ الإعدادات", "تشغيل الآن", "محاكاة (dry-run)", "تسجيل الجدولة", "تم حفظ الإعدادات في", "بدأ التنظيف", "لم يتم العثور على نصوص PowerShell المطلوبة.", "مسار البحث", "تم إلغاء العملية أو فشلت: ", "شغّل التطبيق كمسؤول لتنظيف مجلدات Windows المحمية.", "تنظيف الملفات المؤقتة", "تنظيف ملفات Windows Defender المؤقتة", "تنظيف ذاكرة Windows Update المؤقتة", "تنظيف ملفات SYSTEM المؤقتة", "إفراغ سلة المحذوفات", "تم تسجيل الجدولة")
    };
}

internal sealed class MainForm : Form
{
    private readonly string _basePath = AppContext.BaseDirectory;
    private readonly string _settingsPath = Path.Combine(AppContext.BaseDirectory, "settings.json");
    private AppSettings _settings = new();
    private CheckBox _temporary = null!, _defender = null!, _update = null!, _system = null!, _recycle = null!;
    private TextBox _logPath = null!, _status = null!;
    private ComboBox _language = null!;
    private Label _title = null!, _options = null!, _logLabel = null!, _languageLabel = null!, _adminNote = null!;
    private Button _browse = null!, _save = null!, _run = null!, _dryRun = null!, _register = null!;
    private Translation T => Translations.All.TryGetValue(_settings.Language, out var value) ? value : Translations.All["en"];

    public MainForm()
    {
        Text = "CleanTemp"; Width = 720; Height = 570; MinimumSize = new Size(650, 500); StartPosition = FormStartPosition.CenterScreen;
        LoadSettings(); EnsureLogFile(); BuildUi(); ApplySettings();
    }

    private void BuildUi()
    {
        var root = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(14), ColumnCount = 1, RowCount = 4 }; root.RowStyles.Add(new(SizeType.Absolute, 48)); root.RowStyles.Add(new(SizeType.Percent, 100)); root.RowStyles.Add(new(SizeType.Absolute, 55)); root.RowStyles.Add(new(SizeType.Absolute, 100)); Controls.Add(root);
        _title = new Label { Dock = DockStyle.Fill, Font = new(Font.FontFamily, 18, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft }; root.Controls.Add(_title, 0, 0);
        var panel = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(12), ColumnCount = 2, RowCount = 8 }; panel.ColumnStyles.Add(new(SizeType.Percent, 100)); panel.ColumnStyles.Add(new(SizeType.Absolute, 130)); root.Controls.Add(panel, 0, 1);
        _options = new Label { AutoSize = true, Font = new(Font.FontFamily, 11, FontStyle.Bold) }; panel.Controls.Add(_options, 0, 0); panel.SetColumnSpan(_options, 2);
        _temporary = AddCheck(panel, 1); _defender = AddCheck(panel, 2); _update = AddCheck(panel, 3); _system = AddCheck(panel, 4); _recycle = AddCheck(panel, 5);
        _logPath = new TextBox { Dock = DockStyle.Fill }; _logLabel = AddRow(panel, 6, _logPath); _browse = new Button(); _browse.Click += (_, _) => { using var dialog = new SaveFileDialog { FileName = Path.GetFileName(_logPath.Text), InitialDirectory = Path.GetDirectoryName(_logPath.Text), Filter = "Log files (*.log)|*.log|All files (*.*)|*.*" }; if (dialog.ShowDialog(this) == DialogResult.OK) _logPath.Text = dialog.FileName; }; panel.Controls.Add(_browse, 1, 6);
        _adminNote = new Label { AutoSize = true, ForeColor = Color.DimGray }; panel.Controls.Add(_adminNote, 0, 7); panel.SetColumnSpan(_adminNote, 2);
        var buttons = new FlowLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(0, 10, 0, 0) }; root.Controls.Add(buttons, 0, 2); _save = AddButton(buttons, (_, _) => SaveSettings()); _run = AddButton(buttons, (_, _) => RunCleanup(false)); _dryRun = AddButton(buttons, (_, _) => RunCleanup(true)); _register = AddButton(buttons, (_, _) => RegisterTask());
        var bottom = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight }; _languageLabel = new Label { AutoSize = true, Margin = new Padding(0, 7, 5, 0) }; bottom.Controls.Add(_languageLabel); _language = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 180 }; foreach (var t in Translations.All.Values) _language.Items.Add(t.Name); _language.SelectedIndexChanged += (_, _) => { _settings.Language = LanguageCode(_language.SelectedIndex); ApplyLanguage(); }; bottom.Controls.Add(_language); _status = new TextBox { Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Dock = DockStyle.Fill, BackColor = SystemColors.Window }; root.Controls.Add(_status, 0, 3); root.Controls.Add(bottom, 0, 2); root.Controls.SetChildIndex(bottom, 2);
    }

    private static Label AddRow(TableLayoutPanel p, int row, Control control) { var l = new Label { AutoSize = true, Anchor = AnchorStyles.Left }; p.Controls.Add(l, 0, row); p.Controls.Add(control, 1, row); return l; }
    private static CheckBox AddCheck(TableLayoutPanel p, int row) { var c = new CheckBox { AutoSize = true }; p.Controls.Add(c, 0, row); p.SetColumnSpan(c, 2); return c; }
    private static Button AddButton(FlowLayoutPanel p, EventHandler handler) { var b = new Button { AutoSize = true, Height = 32 }; b.Click += handler; p.Controls.Add(b); return b; }
    private void LoadSettings() { try { if (File.Exists(_settingsPath)) _settings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(_settingsPath)) ?? new(); } catch { _settings = new(); } if (!Translations.All.ContainsKey(_settings.Language)) _settings.Language = "en"; }
    private void EnsureLogFile() { try { var path = Environment.ExpandEnvironmentVariables(string.IsNullOrWhiteSpace(_settings.LogPath) ? @"C:\Logs\CleanTemp.log" : _settings.LogPath); var dir = Path.GetDirectoryName(path); if (!string.IsNullOrWhiteSpace(dir)) Directory.CreateDirectory(dir); if (!File.Exists(path)) File.WriteAllText(path, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [INFO] CleanTemp GUI started.{Environment.NewLine}"); } catch { } }
    private void ApplySettings() { _temporary.Checked = _settings.CleanTemporaryFiles; _defender.Checked = _settings.CleanDefenderTemp; _update.Checked = _settings.CleanWindowsUpdate; _system.Checked = _settings.CleanSystemTemp; _recycle.Checked = _settings.EmptyRecycleBin; _logPath.Text = _settings.LogPath; _language.SelectedIndex = Array.IndexOf(new[] { "en", "it", "es", "de", "fr", "pt", "zh", "ja", "ru", "ar" }, _settings.Language); if (_language.SelectedIndex < 0) _language.SelectedIndex = 0; ApplyLanguage(); }
    private void ReadUi() { _settings.CleanTemporaryFiles = _temporary.Checked; _settings.CleanDefenderTemp = _defender.Checked; _settings.CleanWindowsUpdate = _update.Checked; _settings.CleanSystemTemp = _system.Checked; _settings.EmptyRecycleBin = _recycle.Checked; _settings.LogPath = _logPath.Text; _settings.Language = LanguageCode(_language.SelectedIndex); }
    private void SaveSettings(bool quiet = false) { ReadUi(); File.WriteAllText(_settingsPath, JsonSerializer.Serialize(_settings, new JsonSerializerOptions { WriteIndented = true })); EnsureLogFile(); if (!quiet) SetStatus($"{T.Saved} {_settingsPath}"); }
    private string? FindScript(string name) { var directory = new DirectoryInfo(AppContext.BaseDirectory); while (directory != null) { var candidate = Path.Combine(directory.FullName, name); if (File.Exists(candidate)) return candidate; directory = directory.Parent; } return null; }
    private void RunCleanup(bool dryRun) { SaveSettings(true); var script = FindScript("CleanTemp.ps1"); if (script is null) { SetStatus($"{T.ScriptsMissing}\r\n{T.SearchPath}: {AppContext.BaseDirectory}"); return; } var args = $"-NoProfile -ExecutionPolicy Bypass -File \"{script}\" -LogPath \"{_settings.LogPath}\""; if (dryRun) args += " -DryRun"; StartPowerShell(args, T.Started); }
    private void RegisterTask() { SaveSettings(true); var script = FindScript("Register-CleanTempTask.ps1"); var cleanup = FindScript("CleanTemp.ps1"); if (script is null || cleanup is null) { SetStatus($"{T.ScriptsMissing}\r\n{T.SearchPath}: {AppContext.BaseDirectory}"); return; } var args = $"-NoProfile -ExecutionPolicy Bypass -File \"{script}\" -CleanupScriptPath \"{cleanup}\""; StartPowerShell(args, T.TaskRegistered, true); }
    private void StartPowerShell(string args, string message, bool elevate = false) { try { Process.Start(new ProcessStartInfo { FileName = "powershell.exe", Arguments = args, UseShellExecute = true, Verb = elevate ? "runas" : "", CreateNoWindow = !elevate }); SetStatus(message); } catch (Exception ex) { SetStatus(T.Cancelled + ex.Message); } }
    private void SetStatus(string message) => _status.Text = $"[{DateTime.Now:HH:mm:ss}] {message}\r\n" + _status.Text;
    private static string LanguageCode(int index) => new[] { "en", "it", "es", "de", "fr", "pt", "zh", "ja", "ru", "ar" }[Math.Clamp(index, 0, 9)];
    private void ApplyLanguage() { var t = T; Text = $"CleanTemp - {t.Name}"; _title.Text = t.Title; _options.Text = t.Options; _languageLabel.Text = t.Language; _logLabel.Text = t.LogPath; _browse.Text = t.Browse; _temporary.Text = t.Temporary; _defender.Text = t.Defender; _update.Text = t.Update; _system.Text = t.System; _recycle.Text = t.Recycle; _adminNote.Text = t.AdminNote; _save.Text = t.Save; _run.Text = t.Run; _dryRun.Text = t.DryRun; _register.Text = t.Register; }
}
