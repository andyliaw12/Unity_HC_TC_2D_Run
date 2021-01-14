using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位區域

    [Header("速度"), Tooltip("角色的移動速度"), Range(10, 1500)]
    public int speed = 50;
    [Header("血量"), Tooltip("角色的血量"), Range(0, 1000)]
    public float hp = 999.9f;
    [Header("金幣數量"), Tooltip("儲存角色吃了多少金幣")]
    public int coin;
    [Header("跳躍高度"), Range(100, 2000)]
    public int height = 500;
    [Header("音效區域")]
    public AudioClip soundJunp;
    public AudioClip soundSlide;
    public AudioClip soundHit;
    [Header("角色是否死亡"), Tooltip("True 代表死亡, False 代表尚未死亡")]
    public bool dead;

    #endregion

    #region 方法區域
    /// <summary>
    /// 角色的跳躍功能:跳躍動畫、撥放音效與往上跳
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 角色的滑行功能:滑行動畫、撥放音效、縮小碰撞範圍
    /// </summary>
    private void Slide()
    {

    }

    /// <summary>
    /// 碰到障礙物時受傷:扣血
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 吃金幣:金幣數量增加、更新介面、金幣音效
    /// </summary>
    private void EatCoin()
    {

    }

    /// <summary>
    /// 死亡:動畫、遊戲結束
    /// </summary>
    private void Dead()
    {

    }
    #endregion

    #region 事件區域
    //開始 Start
    //播放遊戲時執行一次
    //初始化
    private void Start()
    {

    }

    //更新 Update
    //播放遊戲後一秒執行約60次 -60Fps
    //移動、監聽玩家鍵盤、滑鼠與觸控
    private void Update()
    {
        
    }
    #endregion
}
