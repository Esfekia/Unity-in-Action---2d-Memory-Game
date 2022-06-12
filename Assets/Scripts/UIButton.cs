using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    // reference a target object to inform about clicks
    [SerializeField] GameObject targetObject;
    [SerializeField] string targetMessage;
    public Color highlightColor = Color.cyan;

    public void OnMouseEnter()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            // tint the button when the mouse hovers over it.
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            // tint the button when the mouse hovers over it.
            sprite.color = Color.white;
        }
    }

    public void OnMouseDown()
    {
        // button size pops a bit when it's clicked
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    public void OnMouseUp()
    {
        transform.localScale = Vector3.one;
        if (targetObject != null)
        {
            // send a message to the target object when the button is clicked
            targetObject.SendMessage(targetMessage);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
