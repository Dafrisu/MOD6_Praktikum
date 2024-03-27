using System;
using System.Security.Cryptography.X509Certificates;

public class SayaTubeUser
{
	private int id;
	List<SayaTubeVideo> uploadedVideos;
	public string Username;

	public SayaTubeUser(string Username)
	{
		this.Username = Username;
		this.uploadedVideos = new List<SayaTubeVideo>();
	}
	public int GetTotalVideoPlayCount() {
		int total=0;
		for (int i = 0; i < uploadedVideos.Count; i++) {
			total += uploadedVideos[i].getPlayCount();
		}
		return total;
	}
	public void addVideo(SayaTubeVideo video) {
		uploadedVideos.Add(video);
	}
	public void PrintAllVideoPlayCount() {
        Console.WriteLine("User :" + this.Username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
			Console.WriteLine("Video "+ (i+1) +" Judul :" + uploadedVideos[i].getTitle());
		}
    }
}
