using UnityEngine;
using UnityEngine.SceneManagement;
public class ResumePanel : MonoBehaviour
{

    public GameObject pausePanel;

    public static bool isGamePaused = false;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }


    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        isGamePaused = false;
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        isGamePaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
