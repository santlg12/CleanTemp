# CleanTemp

Guida rapida all’utilizzo di `CleanTempGui.exe`. Percorso del File .exe: CleanTemp\bin\Release\net8.0-windows

## Italiano

### Requisiti

- Windows 10 o Windows 11 a 64 bit.
- .NET 8 Desktop Runtime per eseguire il programma pubblicato; per compilare il progetto è necessario il .NET 8 SDK.
- PowerShell 5.1 o versione successiva.
- Un account con privilegi amministrativi: l’applicazione li richiede tramite UAC per operare sulle cartelle protette e registrare la pianificazione.
- `CleanTemp.ps1` e `Register-CleanTempTask.ps1` devono essere presenti nella cartella dell’applicazione.

### Avvio

1. Aprire `CleanTempGui.exe`.
2. Se Windows visualizza una richiesta UAC, confermare con **Sì**. L’applicazione richiede privilegi amministrativi per pulire le cartelle protette.
3. Selezionare la lingua dal menu **Lingua**.

### Configurazione

1. Nella sezione **Opzioni di pulizia**, selezionare le operazioni desiderate:
   - pulizia dei file temporanei;
   - pulizia dei file temporanei di Windows Defender;
   - pulizia della cache di Windows Update;
   - pulizia dei file temporanei di SYSTEM;
   - svuotamento del Cestino.
2. Nel campo **Percorso log**, inserire il percorso in cui salvare il registro. Il valore predefinito è `C:\Logs\CleanTemp.log`.
3. Usare **Sfoglia...** per scegliere il file di log.
4. Fare clic su **Salva impostazioni**.

Le impostazioni vengono salvate automaticamente nel file `settings.json` nella cartella dell’applicazione.

### Esecuzione consigliata

1. Fare clic su **Simula (dry-run)** per eseguire una prova senza eliminare file.
2. Controllare il risultato nell’area di stato e nel file di log.
3. Se il risultato è corretto, fare clic su **Esegui ora** per avviare la pulizia reale.
4. I file bloccati o protetti vengono saltati e segnalati nel log.

### Pianificazione automatica

1. Configurare e salvare le opzioni desiderate.
2. Fare clic su **Registra pianificazione**.
3. Confermare la richiesta UAC, se visualizzata.
4. L’attività viene registrata in Windows con l’account `SYSTEM` e privilegi elevati.

### Attenzione

La pulizia reale può eliminare definitivamente i file. Usare sempre la simulazione prima della prima esecuzione. Il programma pulisce solo le destinazioni previste dall’applicazione e non invia file o log a servizi esterni.

---

## English

### Requirements

- Windows 10 or Windows 11, 64-bit.
- .NET 8 Desktop Runtime to run the published application; the .NET 8 SDK is required to build the project.
- PowerShell 5.1 or later.
- An account with administrator privileges: the application requests them through UAC to access protected folders and register the schedule.
- `CleanTemp.ps1` and `Register-CleanTempTask.ps1` must be present next to the application.

### Start the application

1. Open `CleanTempGui.exe`.
2. If Windows displays a UAC prompt, select **Yes**. Administrator privileges are required for protected folders.
3. Select a language from the **Language** menu.

### Configure cleanup

1. Under **Cleanup options**, choose the operations to perform:
   - clean temporary files;
   - clean Windows Defender temporary files;
   - clean the Windows Update cache;
   - clean SYSTEM temporary files;
   - empty the Recycle Bin.
2. Set the **Log path**. The default is `C:\Logs\CleanTemp.log`.
3. Use **Browse...** to choose a log file.
4. Select **Save settings**.

Settings are saved in `settings.json` next to the application.

### Run safely

1. Select **Simulate (dry-run)** to test without deleting files.
2. Review the status area and the log file.
3. If the result is correct, select **Run now** to perform the real cleanup.
4. Locked or protected files are skipped and reported in the log.

### Automatic schedule

1. Configure and save the desired options.
2. Select **Register schedule**.
3. Confirm the UAC prompt if Windows displays one.
4. The task is registered as `SYSTEM` with elevated privileges.

### Warning

Real cleanup can permanently delete files. Always use the dry-run before the first real execution. CleanTemp does not upload files or logs to external services.

---

## Español

### Requisitos

- Windows 10 o Windows 11 de 64 bits.
- .NET 8 Desktop Runtime para ejecutar la aplicación publicada; se necesita el .NET 8 SDK para compilar el proyecto.
- PowerShell 5.1 o posterior.
- Una cuenta con permisos de administrador: la aplicación los solicita mediante UAC para acceder a carpetas protegidas y registrar la programación.
- `CleanTemp.ps1` y `Register-CleanTempTask.ps1` deben estar junto a la aplicación.

### Iniciar

1. Abra `CleanTempGui.exe`.
2. Si Windows muestra una solicitud UAC, pulse **Sí**. Se necesitan permisos de administrador para las carpetas protegidas.
3. Elija el idioma en el menú **Idioma**.

### Configurar

1. En **Opciones de limpieza**, seleccione las operaciones: archivos temporales, archivos temporales de Windows Defender, caché de Windows Update, archivos temporales de SYSTEM y Papelera.
2. Configure la **Ruta del registro**. El valor predeterminado es `C:\Logs\CleanTemp.log`.
3. Use **Examinar...** para elegir el archivo de registro.
4. Pulse **Guardar configuración**.

La configuración se guarda en `settings.json` junto al programa.

### Ejecutar

1. Pulse **Simular (dry-run)** para probar sin borrar archivos.
2. Revise el estado y el registro.
3. Si todo es correcto, pulse **Ejecutar ahora**.
4. Los archivos bloqueados o protegidos se omiten y se indican en el registro.

Para activar la ejecución automática, guarde la configuración, pulse **Registrar programación** y confirme UAC si aparece. La tarea se registra como `SYSTEM` con privilegios elevados.

**Advertencia:** la limpieza real puede borrar archivos permanentemente. Use siempre la simulación antes de la primera ejecución.

---

## Deutsch

### Voraussetzungen

- Windows 10 oder Windows 11, 64-Bit.
- .NET 8 Desktop Runtime zum Ausführen der veröffentlichten Anwendung; zum Kompilieren ist das .NET 8 SDK erforderlich.
- PowerShell 5.1 oder höher.
- Ein Konto mit Administratorrechten: Die Anwendung fordert diese über UAC für geschützte Ordner und die Registrierung des Zeitplans an.
- `CleanTemp.ps1` und `Register-CleanTempTask.ps1` müssen neben der Anwendung vorhanden sein.

### Start

1. `CleanTempGui.exe` öffnen.
2. Eine UAC-Abfrage mit **Ja** bestätigen. Für geschützte Ordner sind Administratorrechte erforderlich.
3. Die Sprache im Menü **Sprache** auswählen.

### Einstellungen

1. Unter **Bereinigungsoptionen** die gewünschten Ziele auswählen: temporäre Dateien, temporäre Windows-Defender-Dateien, Windows-Update-Cache, SYSTEM-Temp-Dateien und Papierkorb.
2. Den **Protokollpfad** festlegen. Standard: `C:\Logs\CleanTemp.log`.
3. Mit **Durchsuchen...** eine Protokolldatei auswählen.
4. **Einstellungen speichern** anklicken.

Die Einstellungen werden in `settings.json` neben der Anwendung gespeichert.

### Ausführen

1. Zuerst **Simulation (dry-run)** verwenden, um ohne Löschen zu testen.
2. Status und Protokoll prüfen.
3. Für die echte Bereinigung **Jetzt ausführen** anklicken.
4. Gesperrte oder geschützte Dateien werden übersprungen und protokolliert.

Für die automatische Ausführung Einstellungen speichern, **Zeitplan registrieren** anklicken und eine UAC-Abfrage bestätigen. Die Aufgabe läuft als `SYSTEM` mit erhöhten Rechten.

**Warnung:** Die echte Bereinigung kann Dateien dauerhaft löschen. Vor dem ersten Lauf immer die Simulation verwenden.

---

## Français

### Prérequis

- Windows 10 ou Windows 11 en 64 bits.
- .NET 8 Desktop Runtime pour exécuter l’application publiée ; le .NET 8 SDK est nécessaire pour compiler le projet.
- PowerShell 5.1 ou version ultérieure.
- Un compte disposant des droits administrateur : l’application les demande via l’UAC pour accéder aux dossiers protégés et enregistrer la planification.
- `CleanTemp.ps1` et `Register-CleanTempTask.ps1` doivent se trouver à côté de l’application.

### Démarrage

1. Ouvrez `CleanTempGui.exe`.
2. Si Windows affiche une demande UAC, cliquez sur **Oui**. Les dossiers protégés nécessitent les droits administrateur.
3. Choisissez la langue dans le menu **Langue**.

### Configuration

1. Dans **Options de nettoyage**, sélectionnez les cibles souhaitées : fichiers temporaires, fichiers temporaires de Windows Defender, cache Windows Update, fichiers temporaires SYSTEM et Corbeille.
2. Définissez le **Chemin du journal**. La valeur par défaut est `C:\Logs\CleanTemp.log`.
3. Cliquez sur **Parcourir...** pour choisir le fichier journal.
4. Cliquez sur **Enregistrer les paramètres**.

Les paramètres sont enregistrés dans `settings.json` à côté de l’application.

### Exécution

1. Utilisez **Simuler (dry-run)** pour tester sans supprimer de fichiers.
2. Vérifiez l’état et le journal.
3. Si le résultat est correct, cliquez sur **Exécuter maintenant**.
4. Les fichiers verrouillés ou protégés sont ignorés et indiqués dans le journal.

Pour activer l’exécution automatique, enregistrez les paramètres, cliquez sur **Enregistrer la planification** et confirmez l’UAC si nécessaire. La tâche utilise `SYSTEM` avec des privilèges élevés.

**Attention :** le nettoyage réel peut supprimer définitivement des fichiers. Utilisez toujours la simulation avant la première exécution.

---

## Português

### Requisitos

- Windows 10 ou Windows 11 de 64 bits.
- .NET 8 Desktop Runtime para executar a aplicação publicada; o .NET 8 SDK é necessário para compilar o projeto.
- PowerShell 5.1 ou posterior.
- Uma conta com privilégios de administrador: a aplicação solicita-os através do UAC para aceder a pastas protegidas e registar o agendamento.
- `CleanTemp.ps1` e `Register-CleanTempTask.ps1` devem estar junto da aplicação.

### Iniciar

1. Abra `CleanTempGui.exe`.
2. Se o Windows apresentar uma confirmação UAC, escolha **Sim**. São necessários privilégios de administrador para pastas protegidas.
3. Escolha o idioma no menu **Idioma**.

### Configurar

1. Em **Opções de limpeza**, selecione os alvos: ficheiros temporários, ficheiros temporários do Windows Defender, cache do Windows Update, ficheiros temporários do SYSTEM e Reciclagem.
2. Defina o **Caminho do registo**. O valor predefinido é `C:\Logs\CleanTemp.log`.
3. Use **Procurar...** para selecionar o ficheiro de registo.
4. Clique em **Guardar definições**.

As definições são guardadas em `settings.json` junto da aplicação.

### Executar

1. Use **Simular (dry-run)** para testar sem eliminar ficheiros.
2. Consulte o estado e o registo.
3. Se estiver tudo correto, use **Executar agora**.
4. Ficheiros bloqueados ou protegidos são ignorados e registados.

Para ativar a execução automática, guarde as definições, clique em **Registar agendamento** e confirme o UAC, se solicitado. A tarefa usa `SYSTEM` com privilégios elevados.

**Aviso:** a limpeza real pode eliminar ficheiros permanentemente. Use sempre a simulação antes da primeira execução.

---

## 中文

### 要求

- 64 位 Windows 10 或 Windows 11。
- 运行已发布的应用程序需要 .NET 8 Desktop Runtime；编译项目需要 .NET 8 SDK。
- PowerShell 5.1 或更高版本。
- 具有管理员权限的帐户：应用程序通过 UAC 请求权限，以访问受保护文件夹并注册计划任务。
- `CleanTemp.ps1` 和 `Register-CleanTempTask.ps1` 必须位于应用程序旁边。

### 启动

1. 打开 `CleanTempGui.exe`。
2. 如果 Windows 显示 UAC 提示，请选择“是”。清理受保护文件夹需要管理员权限。
3. 在“语言”菜单中选择语言。

### 配置清理

1. 在“清理选项”中选择目标：临时文件、Windows Defender 临时文件、Windows Update 缓存、SYSTEM 临时文件和回收站。
2. 设置“日志路径”。默认值为 `C:\Logs\CleanTemp.log`。
3. 使用“浏览...”选择日志文件。
4. 点击“保存设置”。

设置会保存在应用程序旁边的 `settings.json` 中。

### 执行

1. 先点击“模拟（dry-run）”，在不删除文件的情况下测试。
2. 查看状态区域和日志。
3. 确认结果正确后，点击“立即运行”执行实际清理。
4. 被锁定或受保护的文件会被跳过并记录在日志中。

要启用自动运行，请保存设置，点击“注册计划”，并在出现 UAC 提示时确认。计划任务以 `SYSTEM` 身份和提升权限运行。

**警告：**实际清理可能永久删除文件。第一次运行前务必使用模拟功能。

---

## 日本語

### 必要条件

- 64 ビット版 Windows 10 または Windows 11。
- 公開済みアプリの実行には .NET 8 Desktop Runtime、プロジェクトのビルドには .NET 8 SDK が必要です。
- PowerShell 5.1 以降。
- 管理者権限を持つアカウント。保護されたフォルダーへのアクセスとスケジュール登録のため、UAC 経由で権限を要求します。
- `CleanTemp.ps1` と `Register-CleanTempTask.ps1` をアプリケーションと同じフォルダーに置いてください。

### 起動

1. `CleanTempGui.exe` を開きます。
2. Windows に UAC が表示されたら **はい** を選択します。保護されたフォルダーの操作には管理者権限が必要です。
3. **言語** メニューから言語を選択します。

### 設定

1. **クリーンアップ オプション** で対象を選択します。一時ファイル、Windows Defender 一時ファイル、Windows Update キャッシュ、SYSTEM 一時ファイル、ごみ箱を選択できます。
2. **ログのパス** を設定します。既定値は `C:\Logs\CleanTemp.log` です。
3. **参照...** でログファイルを選択します。
4. **設定を保存** をクリックします。

設定はアプリケーションの隣にある `settings.json` に保存されます。

### 実行

1. まず **シミュレーション（dry-run）** を実行し、ファイルを削除せずに確認します。
2. ステータスとログを確認します。
3. 問題がなければ **今すぐ実行** をクリックします。
4. ロックされたファイルや保護されたファイルはスキップされ、ログに記録されます。

自動実行を有効にするには、設定を保存し、**スケジュールを登録** をクリックして、UAC が表示された場合は確認します。タスクは `SYSTEM` として高い権限で実行されます。

**注意:** 実際のクリーンアップではファイルが完全に削除される可能性があります。初回は必ずシミュレーションを使用してください。

---

## Русский

### Требования

- Windows 10 или Windows 11, 64-разрядная версия.
- Для запуска опубликованного приложения требуется .NET 8 Desktop Runtime; для сборки проекта необходим .NET 8 SDK.
- PowerShell 5.1 или новее.
- Учётная запись с правами администратора: приложение запрашивает их через UAC для доступа к защищённым папкам и регистрации расписания.
- `CleanTemp.ps1` и `Register-CleanTempTask.ps1` должны находиться рядом с приложением.

### Запуск

1. Откройте `CleanTempGui.exe`.
2. Если Windows покажет запрос UAC, нажмите **Да**. Для защищённых папок нужны права администратора.
3. Выберите язык в меню **Язык**.

### Настройка

1. В разделе **Параметры очистки** выберите цели: временные файлы, временные файлы Windows Defender, кэш Windows Update, временные файлы SYSTEM и корзина.
2. Укажите **Путь к журналу**. По умолчанию используется `C:\Logs\CleanTemp.log`.
3. Нажмите **Обзор...**, чтобы выбрать файл журнала.
4. Нажмите **Сохранить настройки**.

Настройки сохраняются в `settings.json` рядом с приложением.

### Выполнение

1. Сначала нажмите **Симуляция (dry-run)**, чтобы проверить работу без удаления файлов.
2. Проверьте состояние и журнал.
3. Если всё верно, нажмите **Запустить сейчас**.
4. Заблокированные или защищённые файлы пропускаются и записываются в журнал.

Для автоматического запуска сохраните настройки, нажмите **Зарегистрировать расписание** и подтвердите UAC при необходимости. Задача работает от имени `SYSTEM` с повышенными правами.

**Предупреждение:** реальная очистка может навсегда удалить файлы. Перед первым запуском всегда используйте симуляцию.

---

## العربية

### المتطلبات

- Windows 10 أو Windows 11 بإصدار 64 بت.
- يلزم .NET 8 Desktop Runtime لتشغيل التطبيق المنشور، و.NET 8 SDK لبناء المشروع.
- PowerShell 5.1 أو إصدار أحدث.
- حساب بصلاحيات المسؤول؛ يطلب التطبيق هذه الصلاحيات عبر UAC للوصول إلى المجلدات المحمية وتسجيل الجدولة.
- يجب أن يكون الملفان `CleanTemp.ps1` و`Register-CleanTempTask.ps1` موجودين بجانب التطبيق.

### التشغيل

1. افتح `CleanTempGui.exe`.
2. إذا ظهرت مطالبة UAC من Windows، اختر **نعم**. يلزم تشغيل التطبيق بصلاحيات المسؤول للوصول إلى المجلدات المحمية.
3. اختر اللغة من قائمة **اللغة**.

### الإعداد

1. من قسم **خيارات التنظيف** اختر الأهداف المطلوبة: الملفات المؤقتة، ملفات Windows Defender المؤقتة، ذاكرة Windows Update المؤقتة، ملفات SYSTEM المؤقتة وسلة المحذوفات.
2. حدّد **مسار السجل**. المسار الافتراضي هو `C:\Logs\CleanTemp.log`.
3. استخدم **استعراض...** لاختيار ملف السجل.
4. اضغط **حفظ الإعدادات**.

تُحفظ الإعدادات في `settings.json` بجانب التطبيق.

### التنفيذ

1. اضغط **محاكاة (dry-run)** أولاً للاختبار دون حذف الملفات.
2. راجع الحالة وملف السجل.
3. إذا كانت النتيجة صحيحة، اضغط **تشغيل الآن** لتنفيذ التنظيف الفعلي.
4. يتم تجاوز الملفات المقفلة أو المحمية وتسجيلها في السجل.

لتفعيل التشغيل التلقائي، احفظ الإعدادات واضغط **تسجيل الجدولة** ثم وافق على مطالبة UAC إن ظهرت. تعمل المهمة باسم `SYSTEM` بصلاحيات مرتفعة.

**تحذير:** قد يؤدي التنظيف الفعلي إلى حذف الملفات نهائياً. استخدم المحاكاة دائماً قبل التشغيل الأول.
