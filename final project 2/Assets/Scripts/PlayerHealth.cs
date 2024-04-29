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
        // �������� ������'� ������
        ChangeHealth(-1); // � ����� ������� �������� �� 1 ��
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