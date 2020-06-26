using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    //Quits application
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    //Reloads scene with first level
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }

}
