using UnityEngine;

public class EnemyPanel : MonoBehaviour
{
    public GameObject panel; // Посилання на панель

    void Start()
    {
        // Приховати панель при запуску
        panel.SetActive(true);
    }

    public void HidePanel()
    {
        // Приховати панель
        panel.SetActive(false);
    }
}
