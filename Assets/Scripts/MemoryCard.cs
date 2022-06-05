using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    // variable that appears in the inspector
    [SerializeField] GameObject cardBack;

    // reference to the sprite asset that will be loaded
    [SerializeField] Sprite image;
    public void OnMouseDown()
    {
        // run deactivate code onlyu if the object is currently active/visible
        if (cardBack.activeSelf)
        {
            // set the object to inactive/invisible
            cardBack.SetActive(false);
        }
    }
        
    void Start()
    {
        // set the sprite for this SpriteRenderer component.
        GetComponent<SpriteRenderer>().sprite = image;
    }
        
    void Update()
    {
        
    }
}
