using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject panel;
    public int playerHealth;
    public Text healthText;

    private void Start()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
        healthText.text = playerHealth.ToString();
        // ѕ≥дписуЇмось на под≥ю
        EnemyMovement.OnEnemyReachedLastPoint += HandleEnemyReachedLastPoint;
    }

    private void OnDestroy()
    {
        // ¬≥дписуЇмось в≥д под≥њ, щоб уникнути витоку пам'€т≥
        EnemyMovement.OnEnemyReachedLastPoint -= HandleEnemyReachedLastPoint;
    }

    private void HandleEnemyReachedLastPoint()
    {

        // «меншуЇмо здоров'€ гравц€ в залежност≥ в≥д типу ворога
        if (Enemy1)
        {
            ChangeHealth(-1); // «меншуЇмо на 1 хп
        }
        else if (Enemy2)
        {
            ChangeHealth(-4); // «меншуЇмо на 4 хп
        }
        else if (Enemy3)
        {
            ChangeHealth(-5); // «меншуЇмо на 5 хп
        }
        else if (Enemy4)
        {
            ChangeHealth(-2); // «меншуЇмо на 2 хп
        }
    }

    public void ChangeHealth(int count)
    {
        playerHealth += count;
        healthText.text = playerHealth.ToString();
        if (playerHealth <= 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}