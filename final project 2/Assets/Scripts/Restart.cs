using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // �����, ���� ���� ���������� ��� ��������� �� ������ "Restart"
    public void RestartLevel()
    {
        // �������� ������ ������� �����
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // ����������� ������� ����� �����
        SceneManager.LoadScene(currentSceneIndex);
    }
}
