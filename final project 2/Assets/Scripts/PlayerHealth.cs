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
        // ϳ��������� �� ����
        EnemyMovement.OnEnemyReachedLastPoint += HandleEnemyReachedLastPoint;
    }

    private void OnDestroy()
    {
        // ³��������� �� ��䳿, ��� �������� ������ ���'��
        EnemyMovement.OnEnemyReachedLastPoint -= HandleEnemyReachedLastPoint;
    }

    private void HandleEnemyReachedLastPoint()
    {

        // �������� ������'� ������ � ��������� �� ���� ������
        if (Enemy1)
        {
            ChangeHealth(-1); // �������� �� 1 ��
        }
        else if (Enemy2)
        {
            ChangeHealth(-4); // �������� �� 4 ��
        }
        else if (Enemy3)
        {
            ChangeHealth(-5); // �������� �� 5 ��
        }
        else if (Enemy4)
        {
            ChangeHealth(-2); // �������� �� 2 ��
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