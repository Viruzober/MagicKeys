﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace MKUpdater
{
public class HttpClientDownloadWithProgress : IDisposable
{
private bool Cancel = false;
private readonly string _downloadUrl;
private readonly string _destinationFilePath;
private HttpClient _httpClient;
public FileStream fileStream;
public delegate void ProgressChangedHandler(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage);
public event ProgressChangedHandler ProgressChanged;

public HttpClientDownloadWithProgress(string downloadUrl, string destinationFilePath)
{
_downloadUrl = downloadUrl;
_destinationFilePath = destinationFilePath;
}

public async Task StartDownload()
{
_httpClient = new HttpClient { Timeout = TimeSpan.FromDays(1) };
using (var response = await _httpClient.GetAsync(_downloadUrl, HttpCompletionOption.ResponseHeadersRead))
await DownloadFileFromHttpResponseMessage(response);
}

private async Task DownloadFileFromHttpResponseMessage(HttpResponseMessage response)
{
response.EnsureSuccessStatusCode();
var totalBytes = response.Content.Headers.ContentLength;
using (var contentStream = await response.Content.ReadAsStreamAsync())
await ProcessContentStream(totalBytes, contentStream);
}

private async Task ProcessContentStream(long? totalDownloadSize, Stream contentStream)
{
var totalBytesRead = 0L;
var readCount = 0L;
var buffer = new byte[8192];
var isMoreToRead = true;
fileStream = new FileStream(_destinationFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);
do
{
if (Cancel == true)
{
fileStream.Close();
break;
}
var bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length);
if (bytesRead == 0)
{
isMoreToRead = false;
TriggerProgressChanged(totalDownloadSize, totalBytesRead);
continue;
}
await fileStream.WriteAsync(buffer, 0, bytesRead);
totalBytesRead += bytesRead;
readCount += 1;
if (readCount % 100 == 0)
{
TriggerProgressChanged(totalDownloadSize, totalBytesRead);
}
}
while (isMoreToRead);
}

private void TriggerProgressChanged(long? totalDownloadSize, long totalBytesRead)
{
if (ProgressChanged == null)
{
return;
}
double? progressPercentage = null;
if (totalDownloadSize.HasValue)
{
progressPercentage = Math.Round((double)totalBytesRead / totalDownloadSize.Value * 100, 2);
}
ProgressChanged(totalDownloadSize, totalBytesRead, progressPercentage);
}

public void Dispose()
{
fileStream.Close();
_httpClient?.Dispose();
}

public void CancelDownload()
{
Cancel = true;
}

}
}