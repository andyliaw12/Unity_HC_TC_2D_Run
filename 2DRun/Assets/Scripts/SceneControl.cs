using UnityEngine;
using UnityEngine.SceneManagement; //引用 場景管理 API

/// <summary>
/// 場景控制:切換場景、離開遊戲
/// </summary>
public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("遊戲場景"); //場景管理.載入場景("場景名稱")
    }

    public void DelayLoadScene()
    {
        //延遲呼叫
        Invoke("LoadScene", 0.7f);
    }

    public void DelayQuit()
    {
        //延遲呼叫
        Invoke("Quit", 0.87f);
    }
}
