using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject panel; // Посилання на панель

    // Викликається при натисканні кнопки
    public void ShowPanel()
    {
        // Показати панель
        panel.SetActive(true);
    }
}
