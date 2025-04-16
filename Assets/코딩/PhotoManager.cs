using UnityEngine;

public class CameraCapture : MonoBehaviour
{
    public void TakePhoto()
    {
        // 반환값 없음! 그냥 호출만 하면 됨
        NativeCamera.TakePicture((path) =>
        {
            if (path != null)
            {
                Debug.Log("📸 사진 경로: " + path);

                Texture2D texture = NativeCamera.LoadImageAtPath(path, 1024);
                if (texture == null)
                {
                    Debug.Log("이미지 로드 실패");
                    return;
                }

                // 사진을 UI 이미지로 보여주거나, OCR 처리로 넘기기
            }
        }, 1024);
    }
}
