using UnityEngine;

public class PanelSettings : MonoBehaviour
{
    public GameObject panel; // Посилання на панель

    void Start()
    {
        // Приховати панель при запуску
        panel.SetActive(false);
    }

    // Викликається при натисканні кнопки для відображення панелі
    public void ShowPanel()
    {
        // Показати панель
        panel.SetActive(true);
    }

    // Викликається при натисканні кнопки для приховування панелі
    public void HidePanel()
    {
        // Приховати панель
        panel.SetActive(false);
    }
}
