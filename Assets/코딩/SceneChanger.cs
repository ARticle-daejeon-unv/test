using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // 카메라 씬으로 이동
    public void GoToCameraScene()
    {
        SceneManager.LoadScene("CameraScene"); // 실제 씬 이름으로 수정
    }

    // 갤러리 씬으로 이동
    public void GoToGalleryScene()
    {
        SceneManager.LoadScene("GalleryScene"); // 실제 씬 이름으로 수정
    }
}
