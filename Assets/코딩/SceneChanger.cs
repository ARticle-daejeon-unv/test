using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // ī�޶� ������ �̵�
    public void GoToCameraScene()
    {
        SceneManager.LoadScene("CameraScene"); // ���� �� �̸����� ����
    }

    // ������ ������ �̵�
    public void GoToGalleryScene()
    {
        SceneManager.LoadScene("GalleryScene"); // ���� �� �̸����� ����
    }
}
