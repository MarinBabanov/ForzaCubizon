using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    //Object that triggers the end of the level upon player colission
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
