using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{


    public List<GameObject> cardsInMiddle;

    public GameScore gameScore;

    [SerializeField] GameObject back;
    [SerializeField] BackAppear backAppear;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DecideWhoAte()
    {

        if(cardsInMiddle.Count >= 4)
        {

            PlayCard.fourCards = true;

            int maxNumber = 0;
            int indexOfMaxNumber = 0;
            

                maxNumber = int.Parse(cardsInMiddle[0].tag);

            

            for(int i = 1; i < cardsInMiddle.Count; i++)
            {

                if (int.Parse(cardsInMiddle[i].tag) > maxNumber) 
                {

                    maxNumber = int.Parse(cardsInMiddle[i].tag);
                    indexOfMaxNumber = i;

                }

            }

            int isLeftRightTopBottom = cardsInMiddle[indexOfMaxNumber].layer;

            switch (isLeftRightTopBottom)
            {
                //Left
                case 6: gameScore.bottomScore++;
                    backAppear.InstantiateBack(isLeftRightTopBottom);
                    //instantiate back after he ate
                    
                    break;

                //Right
                case 7: gameScore.rightScore++;
                    backAppear.InstantiateBack(isLeftRightTopBottom);


                    break;

                //Top
                case 8: gameScore.topScore++;
                    backAppear.InstantiateBack(isLeftRightTopBottom);


                    break;

                //Bottom
                case 9: gameScore.leftScore++;
                    backAppear.InstantiateBack(isLeftRightTopBottom);


                    break;


            }


            foreach(GameObject card in cardsInMiddle)
            {

                Destroy(card, 0.4f);

            }

            cardsInMiddle.Clear();
            PlayCard.fourCards = false;




        }

    }



    void WinCondition()
    {



    }


}
