using UnityEngine;

/// <summary>
/// GameManagerにUnityイベントを通知
/// </summary>
public class GameEngine : MonoBehaviour
{
    public void Awake()
    {
        GameManager.Instance.Awake();
    }

    public void Update()
    {
        GameManager.Instance.Update();
    }
}
