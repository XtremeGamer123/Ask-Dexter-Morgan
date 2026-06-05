using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SWZAfMath : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private void Start()
    {
        if  (videoPlayer != null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
            videoPlayer.Play();
        }
    }

    private void Update()
    {
        if (Time.timeSinceLevelLoad >= 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
