using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Loads first level
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Quits application
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
