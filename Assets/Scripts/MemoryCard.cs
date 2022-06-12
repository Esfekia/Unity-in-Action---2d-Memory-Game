using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    // variable that appears in the inspector
    [SerializeField] GameObject cardBack;
    [SerializeField] SceneController sceneController;

    private int _id;

    // added getter function
    public int Id
    {
        get { return _id; }
    }

    // public method that other scripts can use to pass new sprites to this object
    public void SetCard(int id, Sprite image)
    {
        _id = id;
        
        // spriterenderer code line just as in the deleted code demonstration
        GetComponent<SpriteRenderer>().sprite = image;
    }
    
    public void OnMouseDown()
    {
        // run deactivate code only if the object is currently active/visible
        // also check the controller's canReveal property to make sure only two cards are revealed at a time
        if (cardBack.activeSelf && sceneController.canReveal)
        {
            // set the object to inactive/invisible
            cardBack.SetActive(false);

            // notify the controller when this card is revealed
            sceneController.CardRevealed(this);
        }
    }

    // a public method so that SceneController can hide the card again (by turning card_back back on)
    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
        
    void Start()
    {

    }
        
    void Update()
    {
        
    }
}
