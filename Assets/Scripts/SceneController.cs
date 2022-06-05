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

    // an array for references to the sprite assets;
    [SerializeField] Sprite[] images;
        
    void Start()
    {
        // position of the first card; all other cards will be offset from here.
        Vector3 startPos = originalCard.transform.position;
        
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
                int id = Random.Range(0, images.Length);

                // call the public method we added to MemoryCard
                card.SetCard(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = -(offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
