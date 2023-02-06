using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBrain : MonoBehaviour
{


    [SerializeField] CardsDeck scriptapleObject;

    GameObject[] cards;

    [SerializeField] List<GameObject> listCardsDeck;


    [SerializeField] Transform[] cardsPlacesBottom;
    [SerializeField] Transform[] cardsPlacesTop;
    [SerializeField] Transform[] cardsPlacesRight;
    [SerializeField] Transform[] cardsPlacesLeft;



    // Start is called before the first frame update
    void Start()
    {

        
        /*
        foreach (GameObject card in scriptapleObject.cardsDeck)
        {

            listCardsDeck.Add(card);

        }
        */

        

        ShuffleCardsDeck();
        AddCards();
    }

    private void ShuffleCardsDeck()
    {
        int currentIndex = listCardsDeck.Count;
        GameObject temporaryValue;
        int randomIndex;

        while (currentIndex != 0)
        {
            randomIndex = Random.Range(0, currentIndex);
            currentIndex--;

            temporaryValue = listCardsDeck[currentIndex];
            listCardsDeck[currentIndex] = listCardsDeck[randomIndex];
            listCardsDeck[randomIndex] = temporaryValue;
        }
    }

    void AddCards()
    {

        for (int i = 0; i < cardsPlacesBottom.Length; i++)
        {
            GameObject GameCard =
            Instantiate(listCardsDeck[0], cardsPlacesBottom[i].position, Quaternion.identity) as GameObject;


            listCardsDeck.Remove(listCardsDeck[0]);

            GameCard.layer = 6;


        }

        // Right




        for (int i = 0; i < cardsPlacesTop.Length; i++)
        {
            GameObject GameCard =
            Instantiate(listCardsDeck[0], cardsPlacesTop[i].position, Quaternion.identity) as GameObject;


            listCardsDeck.Remove(listCardsDeck[0]);

            GameCard.layer = 8;

        }



        for (int i = 0; i < cardsPlacesRight.Length; i++)
        {
            GameObject GameCard =
            Instantiate(listCardsDeck[0], cardsPlacesRight[i].position, Quaternion.Euler(0, 0, 90)
) as GameObject;


            listCardsDeck.Remove(listCardsDeck[0]);
            GameCard.layer = 7;


        }



        for (int i = 0; i < cardsPlacesLeft.Length; i++)
        {
            GameObject GameCard =
            Instantiate(listCardsDeck[0], cardsPlacesLeft[i].position, Quaternion.Euler(0, 0, 270)
) as GameObject;

            GameCard.transform.localScale = new Vector3(-1, 1, 1);


            listCardsDeck.Remove(listCardsDeck[0]);
            GameCard.layer = 9;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
