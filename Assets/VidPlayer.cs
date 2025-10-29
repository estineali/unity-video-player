using UnityEngine;
using UnityEngine.Video;

public class VidPlayer : MonoBehaviour
{

    [SerializeField]
    private string url = "https://hbmpvnzgcwawetng.public.blob.vercel-storage.com/girl_design_video.mp4";

    private VideoPlayer videoPlayer;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        if (videoPlayer)
        {
            videoPlayer.url = url;
            videoPlayer.playOnAwake = false;
            videoPlayer.Prepare();

            videoPlayer.prepareCompleted += OnVideoPrepared;
        }
    }

    private void OnVideoPrepared(VideoPlayer source)
    {
        videoPlayer.Play();
    }
}
