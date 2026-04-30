using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject panelMenu;
    public GameObject panelTownMap;
    public GameObject panelStore;

    [Header("현재 정보")]
    public string currentStore = "";

    // START 버튼
    public void StartGame()
    {
        Debug.Log("✅ 게임 시작!");

        panelMenu.SetActive(false);
        panelTownMap.SetActive(true);
    }

    // 상점 입장
    public void EnterStore(string storeName)
    {
        currentStore = storeName;
        Debug.Log("🏪 " + storeName + " 입장!");

        panelTownMap.SetActive(false);
        panelStore.SetActive(true);
    }

    // 상점 나가기
    public void ExitStore()
    {
        panelStore.SetActive(false);
        panelTownMap.SetActive(true);
    }
}