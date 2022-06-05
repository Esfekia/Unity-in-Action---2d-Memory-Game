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
        // run deactivate code onlyu if the object is currently active/visible
        if (cardBack.activeSelf)
        {
            // set the object to inactive/invisible
            cardBack.SetActive(false);
        }
    }
        
    void Start()
    {

    }
        
    void Update()
    {
        
    }
}
