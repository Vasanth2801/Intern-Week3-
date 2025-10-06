using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
  

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

   

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Loaded to the next Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game has been Quitted");
    }
}
