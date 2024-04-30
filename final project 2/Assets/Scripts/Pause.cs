using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject panel; // Посилання на панель

    void Start()
    {
        // Приховати панель при запуску
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    // Викликається при натисканні кнопки для відображення панелі
    public void ShowPanel()
    {
        // Показати панель
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    // Викликається при натисканні кнопки для приховування панелі
    public void HidePanel()
    {
        // Приховати панель
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
