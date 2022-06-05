using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // reference for the card in the scene
    [SerializeField] MemoryCard originalCard;

    // an array for references to the sprite assets;
    [SerializeField] Sprite[] images;
        
    void Start()
    {
        int id = Random.Range(0, images.Length);

        // call the public method we added to MemoryCard
        originalCard.SetCard(id, images[id]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
