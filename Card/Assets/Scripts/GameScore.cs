using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameScore : MonoBehaviour
{


    public int bottomScore = 0;
    public int topScore = 0;
    public int rightScore = 0;
    public int leftScore = 0;

    [SerializeField] TextMeshProUGUI bottomScoreText;
    [SerializeField] TextMeshProUGUI rightScoreText;
    [SerializeField] TextMeshProUGUI topScoreText;
    [SerializeField] TextMeshProUGUI leftScoreText;
    [SerializeField] TextMeshProUGUI winText;



    // Start is called before the first frame update
    void Start()
    {
        bottomScoreText.GetComponent<CanvasRenderer>().SetAlpha(1);
    }

    // Update is called once per frame
    void Update()
    {

        bottomScoreText.text = bottomScore.ToString();
        rightScoreText.text = rightScore.ToString();
        topScoreText.text = topScore.ToString();
        leftScoreText.text = leftScore.ToString();

        WinCondition();

    }



    void WinCondition() 
    { 
    
        if((bottomScore + rightScore + topScore + leftScore) >= 13)
        {

            winText.text = Winner();
            Time.timeScale = 0;


        }
    
    }

    string Winner()
    {

        float minValue = Mathf.Min(Mathf.Min(bottomScore, rightScore), Mathf.Min(topScore, leftScore));

        if(bottomScore == minValue)
        {

            return "Bottom win";

        }else if (rightScore == minValue)
        {

            return "Right win";

        }
        else if (topScore == minValue)
        {

            return "Top win";

        }
        else if (leftScore == minValue)
        {

            return "Left win";

        }

        return "ERROR";

    }



}
