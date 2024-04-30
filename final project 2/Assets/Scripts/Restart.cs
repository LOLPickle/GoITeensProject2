using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // Метод, який буде викликаний при натисканні на кнопку "Restart"
    public void RestartLevel()
    {
        // Отримати індекс поточної сцени
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Завантажити поточну сцену знову
        SceneManager.LoadScene(currentSceneIndex);
    }
}
