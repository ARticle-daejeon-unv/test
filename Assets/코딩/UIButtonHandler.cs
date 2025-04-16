using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    // 팝업 패널 연결용
    public GameObject popupPanel;

    // 문장 스캔하기 버튼 클릭 시
    public void OnClickScan()
    {
        Debug.Log("📸 문장 스캔하기 버튼 눌림!");
        popupPanel.SetActive(true); // 팝업 UI 보여주기
    }

    // 생성 기록 보기 버튼 클릭 시
    public void OnClickView()
    {
        Debug.Log("📂 생성 기록보기 버튼 눌림!");
        // 필요 시 여기서 바로 씬 이동도 가능
    }
    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        Debug.Log("팝업 닫힘");
    }

}
