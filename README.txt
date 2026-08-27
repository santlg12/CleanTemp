CLEAN TEMP
==========

Guida all’utilizzo di CleanTempGui.exe. Percorso del File .exe: CleanTemp\bin\Release\net8.0-windows

ITALIANO
========

REQUISITI
- Windows 10 o Windows 11 a 64 bit.
- .NET 8 Desktop Runtime per eseguire l’applicazione pubblicata; .NET 8 SDK per compilare il progetto.
- PowerShell 5.1 o versione successiva.
- Account con privilegi amministrativi, richiesti tramite UAC per cartelle protette e pianificazione.
- I file CleanTemp.ps1 e Register-CleanTempTask.ps1 devono essere accanto all’applicazione.

AVVIO
1. Aprire CleanTempGui.exe.
2. Se Windows mostra una richiesta UAC, scegliere Sì. L’applicazione richiede privilegi
   amministrativi per pulire le cartelle protette.
3. Selezionare la lingua dal menu Lingua.

CONFIGURAZIONE
1. In Opzioni di pulizia selezionare ciò che si desidera pulire:
   - file temporanei;
   - file temporanei di Windows Defender;
   - cache di Windows Update;
   - file temporanei di SYSTEM;
   - Cestino.
2. Impostare il Percorso log. Il valore predefinito è C:\Logs\CleanTemp.log.
3. Usare Sfoglia... per scegliere il file di log.
4. Fare clic su Salva impostazioni.

ESECUZIONE CONSIGLIATA
1. Fare clic su Simula (dry-run) per provare la pulizia senza eliminare file.
2. Controllare l’area di stato e il file di log.
3. Se il risultato è corretto, fare clic su Esegui ora.
4. I file bloccati o protetti vengono saltati e indicati nel log.

PIANIFICAZIONE AUTOMATICA
1. Configurare e salvare le opzioni.
2. Fare clic su Registra pianificazione.
3. Confermare la richiesta UAC, se visualizzata.
4. L’attività viene registrata come SYSTEM con privilegi elevati.

ATTENZIONE
La pulizia reale può eliminare definitivamente i file. Usare sempre la simulazione prima
della prima esecuzione. Le impostazioni vengono salvate in settings.json accanto all’applicazione.

ENGLISH
=======

REQUIREMENTS
- Windows 10 or Windows 11, 64-bit.
- .NET 8 Desktop Runtime to run the published application; .NET 8 SDK to build the project.
- PowerShell 5.1 or later.
- An administrator account, required through UAC for protected folders and scheduling.
- CleanTemp.ps1 and Register-CleanTempTask.ps1 must be next to the application.

START
1. Open CleanTempGui.exe.
2. If Windows displays a UAC prompt, select Yes. Administrator rights are required for
   protected folders.
3. Select a language from the Language menu.

CONFIGURE
1. Under Cleanup options, select temporary files, Windows Defender temporary files,
   Windows Update cache, SYSTEM temporary files and/or the Recycle Bin.
2. Set the Log path. The default is C:\Logs\CleanTemp.log.
3. Use Browse... to select a log file.
4. Select Save settings.

RUN
1. Select Simulate (dry-run) to test without deleting files.
2. Review the status area and the log.
3. If everything is correct, select Run now.
4. Locked or protected files are skipped and reported in the log.

SCHEDULE
Save the options, select Register schedule and confirm the UAC prompt if displayed.
The task is registered as SYSTEM with elevated privileges.

WARNING
Real cleanup can permanently delete files. Always use the dry-run before the first real run.
Settings are saved in settings.json next to the application.

ESPAÑOL
=======

REQUISITOS
- Windows 10 o Windows 11 de 64 bits.
- .NET 8 Desktop Runtime para ejecutar la aplicación publicada; .NET 8 SDK para compilar el proyecto.
- PowerShell 5.1 o posterior.
- Una cuenta de administrador, necesaria mediante UAC para carpetas protegidas y programación.
- CleanTemp.ps1 y Register-CleanTempTask.ps1 deben estar junto a la aplicación.

INICIO
1. Abra CleanTempGui.exe.
2. Si Windows muestra una solicitud UAC, pulse Sí. Se necesitan permisos de administrador
   para las carpetas protegidas.
3. Elija el idioma en el menú Idioma.

CONFIGURACIÓN
1. En Opciones de limpieza seleccione archivos temporales, archivos temporales de Windows
   Defender, caché de Windows Update, archivos temporales de SYSTEM y/o Papelera.
2. Configure la Ruta del registro. El valor predeterminado es C:\Logs\CleanTemp.log.
3. Use Examinar... para elegir el archivo de registro.
4. Pulse Guardar configuración.

EJECUCIÓN
1. Pulse Simular (dry-run) para probar sin borrar archivos.
2. Revise el estado y el registro.
3. Si todo es correcto, pulse Ejecutar ahora.
4. Los archivos bloqueados o protegidos se omiten y se registran.

Para activar la ejecución automática, guarde la configuración, pulse Registrar programación
y confirme UAC si aparece. La tarea se ejecuta como SYSTEM con privilegios elevados.

ADVERTENCIA: la limpieza real puede borrar archivos permanentemente. Use siempre la simulación.

DEUTSCH
=======

VORAUSSETZUNGEN
- Windows 10 oder Windows 11, 64-Bit.
- .NET 8 Desktop Runtime zum Ausführen; .NET 8 SDK zum Kompilieren.
- PowerShell 5.1 oder höher.
- Administratorkonto, erforderlich für geschützte Ordner und Zeitplanung über UAC.
- CleanTemp.ps1 und Register-CleanTempTask.ps1 müssen neben der Anwendung liegen.

START
1. CleanTempGui.exe öffnen.
2. Eine UAC-Abfrage mit Ja bestätigen. Für geschützte Ordner sind Administratorrechte nötig.
3. Die Sprache im Menü Sprache auswählen.

EINSTELLUNGEN
1. Unter Bereinigungsoptionen temporäre Dateien, Windows-Defender-Dateien, Windows-Update-
   Cache, SYSTEM-Temp-Dateien und/oder Papierkorb auswählen.
2. Den Protokollpfad festlegen. Standard: C:\Logs\CleanTemp.log.
3. Mit Durchsuchen... eine Protokolldatei auswählen.
4. Einstellungen speichern anklicken.

AUSFÜHRUNG
1. Zuerst Simulation (dry-run) verwenden, um ohne Löschen zu testen.
2. Status und Protokoll prüfen.
3. Danach Jetzt ausführen anklicken.
4. Gesperrte oder geschützte Dateien werden übersprungen und protokolliert.

Für den automatischen Start Einstellungen speichern, Zeitplan registrieren anklicken und UAC
bestätigen, falls angezeigt. Die Aufgabe läuft als SYSTEM mit erhöhten Rechten.

WARNUNG: Die echte Bereinigung kann Dateien dauerhaft löschen. Immer zuerst simulieren.

FRANÇAIS
========

PRÉREQUIS
- Windows 10 ou Windows 11 en 64 bits.
- .NET 8 Desktop Runtime pour exécuter l’application publiée ; .NET 8 SDK pour compiler.
- PowerShell 5.1 ou version ultérieure.
- Compte administrateur requis via l’UAC pour les dossiers protégés et la planification.
- CleanTemp.ps1 et Register-CleanTempTask.ps1 doivent être à côté de l’application.

DÉMARRAGE
1. Ouvrez CleanTempGui.exe.
2. Si Windows affiche une demande UAC, cliquez sur Oui. Les dossiers protégés nécessitent
   les droits administrateur.
3. Choisissez la langue dans le menu Langue.

CONFIGURATION
1. Dans Options de nettoyage, choisissez les fichiers temporaires, fichiers Windows Defender,
   cache Windows Update, fichiers SYSTEM et/ou la Corbeille.
2. Définissez le Chemin du journal. Par défaut : C:\Logs\CleanTemp.log.
3. Cliquez sur Parcourir... pour choisir le journal.
4. Cliquez sur Enregistrer les paramètres.

EXÉCUTION
1. Utilisez Simuler (dry-run) pour tester sans supprimer de fichiers.
2. Vérifiez l’état et le journal.
3. Si tout est correct, cliquez sur Exécuter maintenant.
4. Les fichiers verrouillés ou protégés sont ignorés et indiqués dans le journal.

Pour l’exécution automatique, enregistrez les paramètres, cliquez sur Enregistrer la
planification et confirmez l’UAC si nécessaire. La tâche utilise SYSTEM avec des privilèges élevés.

ATTENTION : le nettoyage réel peut supprimer définitivement des fichiers. Simulez toujours d’abord.

PORTUGUÊS
=========

REQUISITOS
- Windows 10 ou Windows 11 de 64 bits.
- .NET 8 Desktop Runtime para executar; .NET 8 SDK para compilar.
- PowerShell 5.1 ou posterior.
- Conta de administrador necessária através do UAC para pastas protegidas e agendamento.
- CleanTemp.ps1 e Register-CleanTempTask.ps1 devem estar junto da aplicação.

INICIAR
1. Abra CleanTempGui.exe.
2. Se o Windows apresentar uma confirmação UAC, escolha Sim. São necessários privilégios de
   administrador para pastas protegidas.
3. Escolha o idioma no menu Idioma.

CONFIGURAÇÃO
1. Em Opções de limpeza selecione ficheiros temporários, ficheiros do Windows Defender,
   cache do Windows Update, ficheiros do SYSTEM e/ou Reciclagem.
2. Defina o Caminho do registo. O padrão é C:\Logs\CleanTemp.log.
3. Use Procurar... para selecionar o registo.
4. Clique em Guardar definições.

EXECUÇÃO
1. Use Simular (dry-run) para testar sem eliminar ficheiros.
2. Consulte o estado e o registo.
3. Se estiver tudo correto, use Executar agora.
4. Ficheiros bloqueados ou protegidos são ignorados e registados.

Para ativar a execução automática, guarde as definições, clique em Registar agendamento e
confirme o UAC, se solicitado. A tarefa usa SYSTEM com privilégios elevados.

AVISO: a limpeza real pode eliminar ficheiros permanentemente. Simule sempre primeiro.

中文
====

要求
- 64 位 Windows 10 或 Windows 11。
- 运行应用需要 .NET 8 Desktop Runtime；编译项目需要 .NET 8 SDK。
- PowerShell 5.1 或更高版本。
- 需要管理员帐户，以通过 UAC 访问受保护文件夹并注册计划。
- CleanTemp.ps1 和 Register-CleanTempTask.ps1 必须位于应用程序旁边。

启动
1. 打开 CleanTempGui.exe。
2. 如果 Windows 显示 UAC 提示，请选择“是”。受保护文件夹需要管理员权限。
3. 在“语言”菜单中选择语言。

配置
1. 在“清理选项”中选择临时文件、Windows Defender 临时文件、Windows Update 缓存、
   SYSTEM 临时文件和/或回收站。
2. 设置“日志路径”。默认值为 C:\Logs\CleanTemp.log。
3. 使用“浏览...”选择日志文件。
4. 点击“保存设置”。

执行
1. 先点击“模拟（dry-run）”，在不删除文件的情况下测试。
2. 查看状态和日志。
3. 确认无误后点击“立即运行”。
4. 被锁定或受保护的文件会被跳过并记录。

要启用自动运行，请保存设置，点击“注册计划”，并在出现 UAC 时确认。任务以 SYSTEM
身份和提升权限运行。

警告：实际清理可能永久删除文件。第一次运行前务必先使用模拟功能。

日本語
======

必要条件
- 64 ビット版 Windows 10 または Windows 11。
- 実行には .NET 8 Desktop Runtime、ビルドには .NET 8 SDK が必要です。
- PowerShell 5.1 以降。
- 保護されたフォルダーとスケジュール登録には、UAC 経由の管理者アカウントが必要です。
- CleanTemp.ps1 と Register-CleanTempTask.ps1 をアプリケーションの隣に置いてください。

起動
1. CleanTempGui.exe を開きます。
2. UAC が表示されたら「はい」を選択します。保護されたフォルダーには管理者権限が必要です。
3. 「言語」メニューから言語を選択します。

設定
1. 「クリーンアップ オプション」で一時ファイル、Windows Defender 一時ファイル、
   Windows Update キャッシュ、SYSTEM 一時ファイル、ごみ箱を選択します。
2. 「ログのパス」を設定します。既定値は C:\Logs\CleanTemp.log です。
3. 「参照...」でログファイルを選択します。
4. 「設定を保存」をクリックします。

実行
1. まず「シミュレーション（dry-run）」で削除せずにテストします。
2. ステータスとログを確認します。
3. 問題がなければ「今すぐ実行」をクリックします。
4. ロックまたは保護されたファイルはスキップされ、ログに記録されます。

自動実行には設定を保存し、「スケジュールを登録」をクリックします。UAC が表示された
場合は確認してください。タスクは SYSTEM として高い権限で実行されます。

注意：実際のクリーンアップではファイルが完全に削除される可能性があります。初回は必ずシミュレーションを使用してください。

РУССКИЙ
========

ТРЕБОВАНИЯ
- Windows 10 или Windows 11, 64-разрядная версия.
- .NET 8 Desktop Runtime для запуска; .NET 8 SDK для сборки проекта.
- PowerShell 5.1 или новее.
- Учётная запись администратора для защищённых папок и расписания через UAC.
- CleanTemp.ps1 и Register-CleanTempTask.ps1 должны находиться рядом с приложением.

ЗАПУСК
1. Откройте CleanTempGui.exe.
2. При запросе UAC нажмите «Да». Для защищённых папок нужны права администратора.
3. Выберите язык в меню «Язык».

НАСТРОЙКА
1. В «Параметрых очистки» выберите временные файлы, файлы Windows Defender, кэш Windows
   Update, временные файлы SYSTEM и/или корзину.
2. Укажите «Путь к журналу». По умолчанию: C:\Logs\CleanTemp.log.
3. Нажмите «Обзор...» для выбора журнала.
4. Нажмите «Сохранить настройки».

ВЫПОЛНЕНИЕ
1. Сначала используйте «Симуляция (dry-run)» без удаления файлов.
2. Проверьте состояние и журнал.
3. Если всё верно, нажмите «Запустить сейчас».
4. Заблокированные или защищённые файлы пропускаются и записываются в журнал.

Для автоматического запуска сохраните настройки, нажмите «Зарегистрировать расписание» и
подтвердите UAC. Задача работает от имени SYSTEM с повышенными правами.

ПРЕДУПРЕЖДЕНИЕ: реальная очистка может навсегда удалить файлы. Сначала всегда используйте симуляцию.

العربية
=======

المتطلبات
- Windows 10 أو Windows 11 بإصدار 64 بت.
- يلزم .NET 8 Desktop Runtime للتشغيل و.NET 8 SDK للبناء.
- PowerShell 5.1 أو إصدار أحدث.
- حساب مسؤول مطلوب عبر UAC للوصول إلى المجلدات المحمية وتسجيل الجدولة.
- يجب وجود CleanTemp.ps1 وRegister-CleanTempTask.ps1 بجانب التطبيق.

التشغيل
1. افتح CleanTempGui.exe.
2. إذا ظهرت مطالبة UAC من Windows، اختر «نعم». يلزم امتلاك صلاحيات المسؤول للمجلدات المحمية.
3. اختر اللغة من قائمة «اللغة».

الإعداد
1. من «خيارات التنظيف» اختر الملفات المؤقتة، وملفات Windows Defender المؤقتة، وذاكرة Windows
   Update المؤقتة، وملفات SYSTEM المؤقتة و/أو سلة المحذوفات.
2. حدّد «مسار السجل». المسار الافتراضي هو C:\Logs\CleanTemp.log.
3. استخدم «استعراض...» لاختيار ملف السجل.
4. اضغط «حفظ الإعدادات».

التنفيذ
1. اضغط «محاكاة (dry-run)» للاختبار دون حذف الملفات.
2. راجع الحالة وملف السجل.
3. إذا كانت النتيجة صحيحة، اضغط «تشغيل الآن».
4. يتم تجاوز الملفات المقفلة أو المحمية وتسجيلها.

للتشغيل التلقائي، احفظ الإعدادات واضغط «تسجيل الجدولة» ثم وافق على UAC إن ظهرت. تعمل المهمة
باسم SYSTEM بصلاحيات مرتفعة.

تحذير: قد يؤدي التنظيف الفعلي إلى حذف الملفات نهائياً. استخدم المحاكاة دائماً أولاً.
