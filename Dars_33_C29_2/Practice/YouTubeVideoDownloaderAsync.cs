using VideoLibrary;
namespace Dars_33_C29_2.Practice;

public class YouTubeVideoDownloaderAsync
{
    private string PathToSaveFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

    public async Task DownloadVideo(string videoUrl)
    {
        var youtubeVideo = new YouTube();
        var data = await Task.Run(() => youtubeVideo.GetVideo(videoUrl));
        File.Create(Path.Combine(PathToSaveFile, "Video.txt"));

        byte[] videoBytes = data.GetBytes();
        string path = Path.Combine(Path.Combine(PathToSaveFile, data.FullName));
        
        using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
        {
           await fileStream.WriteAsync(videoBytes, 0, videoBytes.Length);
           await fileStream.FlushAsync();
        }
    }
}
