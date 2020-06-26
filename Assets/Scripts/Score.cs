using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    // Checking constantly the Z position of the player while progressing through the level
    // Values is converted to string as a whole number.
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
