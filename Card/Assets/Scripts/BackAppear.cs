using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAppear : MonoBehaviour
{

    [SerializeField] GameRules gameRules;

    //[SerializeField] GameObject back;
    [SerializeField] Sprite backSprite;

    [SerializeField] List<SpriteRenderer> backPlacesBottom;
    [SerializeField] List<SpriteRenderer> backPlacesRight;
    [SerializeField] List<SpriteRenderer> backPlacesTop;
    [SerializeField] List<SpriteRenderer> backPlacesLeft;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateBack(int player)
    {

        int index = 0;

        switch (player)
        {
            case 6:

                while(backPlacesBottom[index].GetComponent<SpriteRenderer>().sprite != null)
                {
                    index++;
                }
                backPlacesBottom[index].GetComponent<SpriteRenderer>().sprite = backSprite;

                break;
            case 7:

                while (backPlacesRight[index].GetComponent<SpriteRenderer>().sprite != null)
                {
                    index++;
                }
                backPlacesRight[index].GetComponent<SpriteRenderer>().sprite = backSprite;

                break;
            case 8:

                while (backPlacesTop[index].GetComponent<SpriteRenderer>().sprite != null)
                {
                    index++;
                }
                backPlacesTop[index].GetComponent<SpriteRenderer>().sprite = backSprite;

                break;
            case 9:

                while (backPlacesLeft[index].GetComponent<SpriteRenderer>().sprite != null)
                {
                    index++;
                }
                backPlacesLeft[index].GetComponent<SpriteRenderer>().sprite = backSprite;

                break;

            default:

                Debug.LogError("Player input is incorrect");break;

        }

    }

}
