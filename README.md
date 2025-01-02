<div align="center">
<a href="http://phancyn.github.io/">
  <div>
    <img src="img(don't open)/banner.png" alt="Warp" />
  </div>
</a>

<hr />

# Fish Launcher
[English](#english) | [Русский](#русский)
</div>

<div id="english">
1. **Click Code**
&nbsp;
&nbsp;
&nbsp;
<img src="img(don't open)/Step 1.gif">
&nbsp;



2. **Fish Settings**

> [!TIP]
> Let's make a xml file where the game version will be
<a href="https://github.com/phancyn/Fish-Launcher-Public/blob/main/FishLauncher/versionServer.xml">XML File</a>


```C#
MainWindow.xaml.cs
{
87. WebClient client = new WebClient();
88. client.DownloadFileCompleted += CompleteDownloadVersionXMLServer;
89. client.DownloadFileAsync(new Uri("link on xml file"), "Assets/versionServer.xml");
90. ServerConnecting.Text = "СЕРВЕР ДОСТУПЕН!";
}
```
> [!TIP]
> Where it says link on xml file, we enter a link to the file there. it can be installed automatically, for example, Google Drive

```c#
MainWindow.xaml.cs
280.        public void NightDay(object sender, RoutedEventArgs e)
281.        {
282.            // Замените URL на нужную вам ссылку
283.            string url = "https://vk.com/market/product/enemy-night-227048711-9921519";
284.
285.            try
286.            {
287.                // Открываем ссылку в браузере по умолчанию
288.                Process.Start(new ProcessStartInfo
289.                {
290.                    FileName = url,
291.                    UseShellExecute = true
292.                });
293.            }
294.            catch (Exception ex)
295.            {
296.                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
297.            }
298.        }
```
>[!TIP]
>You can replace in line 283 here string url = "You can insert your link to the second game or delete it"



```C#
MainWindow.xaml.cs
147.  private void ButtonLaunchGame(object sender, RoutedEventArgs rea)
148.        {
149.            try
150.            {
151.                processApp = new Process();
152.                processApp.StartInfo.UseShellExecute = false;
153.                processApp.StartInfo.FileName = @"Build\Name Game.exe";
154.                processApp.StartInfo.Arguments = ArgumentsAppString;
155.                processApp.Start();
156.                idProcessApp = processApp.Id;
157.            }
158.            catch (Exception e)
159.            {
160.                LoggingProcessJobs("EXCEPTION" + e.Message.ToString());
161.            }
162.        }
```
>[!TIP]
> 153.                processApp.StartInfo.FileName = @"Build\Name Game.exe"; Replace "Name Game.exe " on your game launch

```c#
MainWindow.xaml.cs
389.                Task downloadFileHTTP = Task.Run(async () =>
390.              {
391.                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage() { Method = HttpMethod.Get, RequestUri = new Uri("a link to download the game (the main thing is that there is a file .zip with the name Build and the folder where the game will be too") };
392.                    ProgressMessageHandler progressMessageHandler = new ProgressMessageHandler(new HttpClientHandler() { AllowAutoRedirect = true });
393.                    httpClient = new HttpClient(progressMessageHandler) { Timeout = Timeout.InfiniteTimeSpan };
394.                    stopWatch.Start();
395.                    progressMessageHandler.HttpReceiveProgress += ProgressMessageHandler_HttpReceiveProgress;
396.                    Stream streamFileServer = await httpClient.GetStreamAsync(httpRequestMessage.RequestUri);
397.                    Stream fileStreamServer = new FileStream(zipPath, FileMode.OpenOrCreate, FileAccess.Write);
398.                    try
399.                    {
400.                        await streamFileServer.CopyToAsync(fileStreamServer, ArgumentsAppSpeedDownload, cancellationToken);
401.                        cancelTokenSource.Dispose();
402.                        streamFileServer.Dispose();
403.                        fileStreamServer.Dispose();
404.                        return;
405.                    }
406.                    catch (Exception e)
407.                    {
408.                        DownloadAppState.Dispatcher.Invoke(() => DownloadAppState.Text = "Состояние: " + e.Message.ToString());
409.                        cancelTokenSource.Dispose();
410.                        streamFileServer.Dispose();
411.                        fileStreamServer.Dispose();
412.                        return;
413.                    }
414.                }, cancellationToken);
```
>[!TIP]
>391.  HttpRequestMessage httpRequestMessage = new HttpRequestMessage() { Method = HttpMethod.Get, RequestUri = new Uri("a link to download the game (the main thing is that there is a file .zip with the name Build and the folder where the game will be too") }; Replace this line with "a link to >download the game (the main thing is that there is a file .zip with the name Build and the folder where the game will be too" to the Google link, the links are direct so that the installation starts immediately, you will need the Google drive API


3. **GREAT** 
>[!TIP]
>Ready! now your launcher is ready to work, change the design, background and so on in xaml

> [!WARNING]
> You cannot change the Fish icon and the logo at the top

</div>

<div id="русский">
1. **Нажмите на Code**
&nbsp;
&nbsp;
&nbsp;
<img src="img(don't open)/Step 1.gif">
&nbsp;


2. **Настройка Fish**

> [!TIP]
> Давайте создадим xml файл, где будет версия игры
<a href="https://github.com/phancyn/Fish-Launcher-Public/blob/main/FishLauncher/versionServer.xml">XML Файл</a>


```C#
MainWindow.xaml.cs
{
87. WebClient client = new WebClient();
88. client.DownloadFileCompleted += CompleteDownloadVersionXMLServer;
89. client.DownloadFileAsync(new Uri("link on xml file"), "Assets/versionServer.xml");
90. ServerConnecting.Text = "СЕРВЕР ДОСТУПЕН!";
}
```
> [!TIP]
> Где говорится link on xml file, мы вводим ссылку на файл. он может быть установлен автоматически, например, Google Drive

```c#
MainWindow.xaml.cs
280.        public void NightDay(object sender, RoutedEventArgs e)
281.        {
282.            // Замените URL на нужную вам ссылку
283.            string url = "https://vk.com/market/product/enemy-night-227048711-9921519";
284.
285.            try
286.            {
287.                // Открываем ссылку в браузере по умолчанию
288.                Process.Start(new ProcessStartInfo
289.                {
290.                    FileName = url,
291.                    UseShellExecute = true
292.                });
293.            }
294.            catch (Exception ex)
295.            {
296.                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
297.            }
298.        }
```
>[!TIP]
>Вы можете заменить в строке 283 здесь string url = "Вы можете вставить ссылку на вторую игру или удалить её"



```C#
MainWindow.xaml.cs
147.  private void ButtonLaunchGame(object sender, RoutedEventArgs rea)
148.        {
149.            try
150.            {
151.                processApp = new Process();
152.                processApp.StartInfo.UseShellExecute = false;
153.                processApp.StartInfo.FileName = @"Build\Name Game.exe";
154.                processApp.StartInfo.Arguments = ArgumentsAppString;
155.                processApp.Start();
156.                idProcessApp = processApp.Id;
157.            }
158.            catch (Exception e)
159.            {
160.                LoggingProcessJobs("EXCEPTION" + e.Message.ToString());
161.            }
162.        }
```
>[!TIP]
> 153.                processApp.StartInfo.FileName = @"Build\Name Game.exe"; Замените "Name Game.exe " на запуск вашей игры

```c#
MainWindow.xaml.cs
389.                Task downloadFileHTTP = Task.Run(async () =>
390.              {
391.                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage() { Method = HttpMethod.Get, RequestUri = new Uri("a link to download the game (the main thing is that there is a file .zip with the name Build and the folder where the game will be too") };
392.                    ProgressMessageHandler progressMessageHandler = new ProgressMessageHandler(new HttpClientHandler() { AllowAutoRedirect = true });
393.                    httpClient = new HttpClient(progressMessageHandler) { Timeout = Timeout.InfiniteTimeSpan };
394.                    stopWatch.Start();
395.                    progressMessageHandler.HttpReceiveProgress += ProgressMessageHandler_HttpReceiveProgress;
396.                    Stream streamFileServer = await httpClient.GetStreamAsync(httpRequestMessage.RequestUri);
397.                    Stream fileStreamServer = new FileStream(zipPath, FileMode.OpenOrCreate, FileAccess.Write);
398.                    try
399.                    {
400.                        await streamFileServer.CopyToAsync(fileStreamServer, ArgumentsAppSpeedDownload, cancellationToken);
401.                        cancelTokenSource.Dispose();
402.                        streamFileServer.Dispose();
403.                        fileStreamServer.Dispose();
404.                        return;
405.                    }
406.                    catch (Exception e)
407.                    {
408.                        DownloadAppState.Dispatcher.Invoke(() => DownloadAppState.Text = "Состояние: " + e.Message.ToString());
409.                        cancelTokenSource.Dispose();
410.                        streamFileServer.Dispose();
411.                        fileStreamServer.Dispose();
412.                        return;
413.                    }
414.                }, cancellationToken);
```
>[!TIP]
>391.  HttpRequestMessage httpRequestMessage = new HttpRequestMessage() { Method = HttpMethod.Get, RequestUri = new Uri("a link to download the game (the main thing is that there is a file .zip with the name Build and the folder where the game will be too") }; Замените эту строку на "a link to >download the game (the main thing is that there is a file .zip with the name Build and the folder where the game will be too" на ссылку Google, ссылки прямые, чтобы установка начиналась сразу, вам понадобится Google drive API


3. **GREAT** 
>[!TIP]
>Готово! теперь ваш лаунчер готов к работе, измените дизайн, фон и так далее в xaml

> [!WARNING]
> Вы не можете изменить иконку Fish и логотип в верхней части


</div>