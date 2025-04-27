using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayNow()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1); 
    }

    public void Options()
    {
        Debug.Log("Options Button Pressed!");
       
    }

    public void ExitGame()
    {
        Debug.Log("Exit Button Pressed!");
        Application.Quit(); 
    }
}
