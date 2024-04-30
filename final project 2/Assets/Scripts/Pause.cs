using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject panel; // ��������� �� ������

    void Start()
    {
        // ��������� ������ ��� �������
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    // ����������� ��� ��������� ������ ��� ����������� �����
    public void ShowPanel()
    {
        // �������� ������
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    // ����������� ��� ��������� ������ ��� ������������ �����
    public void HidePanel()
    {
        // ��������� ������
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
