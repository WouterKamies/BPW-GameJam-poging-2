using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    public Text displayText;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(9, 9);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("Score: {0}", score);
    }

    public void ShowText(string displayString)
    {
        Debug.Log(displayString);
        displayText.text = displayString;
    }
}
