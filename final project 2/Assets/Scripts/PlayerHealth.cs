using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public Text healthText;

    private void Start()
    {
        healthText.text = playerHealth.ToString();
        // Підписуємось на подію
        EnemyMovement.OnEnemyReachedLastPoint += HandleEnemyReachedLastPoint;
    }

    private void OnDestroy()
    {
        // Відписуємось від події, щоб уникнути витоку пам'яті
        EnemyMovement.OnEnemyReachedLastPoint -= HandleEnemyReachedLastPoint;
    }

    private void HandleEnemyReachedLastPoint()
    {
        // Зменшуємо здоров'я гравця
        ChangeHealth(-1); // В цьому випадку зменшуємо на 1 хп
    }

    public void ChangeHealth(int count)
    {
        playerHealth += count;
        healthText.text = playerHealth.ToString();
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}