using UnityEngine;

public class EnemyPanel : MonoBehaviour
{
    public GameObject panel; // ��������� �� ������

    void Start()
    {
        // ��������� ������ ��� �������
        panel.SetActive(true);
    }

    public void HidePanel()
    {
        // ��������� ������
        panel.SetActive(false);
    }
}
