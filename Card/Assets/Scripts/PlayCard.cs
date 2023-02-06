using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCard : MonoBehaviour
{

    bool isClickable = true;
    public static bool fourCards = false;

    static float zIndex = 52;

    [SerializeField] GameRules gameRules;
    
   static List<GameObject> cardsInMiddle;

    //readonly int bottomTurn = 6;
    //readonly int rightTurn = 7;
    //readonly int topTurn = 8;
    readonly int leftTurn = 9;

    static int currentTurn = 6; 
    

    private void Start()
    {

        gameRules = FindObjectOfType<GameRules>();

    }


    private void OnMouseDown()
    {
        if (fourCards) { return; }
        if (!isClickable) { return; }
        PutTheCard();
        


    }

    void PutTheCard()
    {

        if(currentTurn == gameObject.layer)
        {
            
            switch (currentTurn)
            {
                //Left
                case 6: CardPosition(0, -1); break;

                //Right
                case 7: CardPosition(1, 0); break;

                //Top
                case 8: CardPosition(0, 1); break;

                //Bottom
                case 9: CardPosition(-1, 0); break;


            }

            gameRules.cardsInMiddle.Add(gameObject);
            gameRules.DecideWhoAte();

            currentTurn++;
            if (currentTurn == leftTurn + 1)
            {
                currentTurn = 6;
            }
        }


    }

    private void CardPosition(float XPos,float YPos)
    {
        transform.position = new Vector3(XPos, YPos, zIndex);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.localScale = new Vector3(1, 1, 1);
        zIndex--;
        isClickable = false;
    }
}
