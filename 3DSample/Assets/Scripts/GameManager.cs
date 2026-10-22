using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject gameOverPanel;
    public GameObject clearPanel;
    public string titleSceneName = "Title";

    void Awake()
    {
        gameOverPanel.SetActive(false);
        Instance = this;
        Time.timeScale = 1f;      // 다시 불러와도 시간 정상
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Retry()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
    }

    public void GoTitle()
    {
        SceneManager.LoadScene(titleSceneName);
    }


    public void GameClear()
    {
        clearPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
