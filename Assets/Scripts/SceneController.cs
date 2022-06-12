using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // values for how many grid spaces to make and how far apart to place them
    public const int gridRows = 2;
    public const int gridCols = 4;
    public const float offsetX = 4f;
    public const float offsetY = 5f;
    
    // reference for the card in the scene
    [SerializeField] MemoryCard originalCard;

    // an array for references to the sprite assets
    [SerializeField] Sprite[] images;
        
    void Start()
    {
        // position of the first card; all other cards will be offset from here
        Vector3 startPos = originalCard.transform.position;

        // declare an interger array with a pair of IDs for all four card sprites
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3 };
        
        // call a function that will shuffle the elements of the array
        numbers = ShuffleArray(numbers);
        
        // nested loops to define both columns and rows of the grid
        for (int i=0; i< gridCols; i++)
        { 
            for (int j=0; j< gridRows; j++)
            {
                // container reference for either the original card or the copies
                MemoryCard card;
                if (i == 0 && j == 0)
                    card = originalCard;
                else
                {
                    card = Instantiate(originalCard) as MemoryCard;
                }

                int index = j * gridCols + i;
                
                // retrieve IDs from the shiffled list
                int id = numbers[index];

                // call the public method we added to MemoryCard
                card.SetCard(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = -(offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }      

    }

    // An implementation of the Knuth shuffle algorith
    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
