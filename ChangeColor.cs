using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Button nextColorButton;
    [SerializeField] private Button prevColorButton;
    
    public int currentIndex = 0;
    //private Color colorToTurnTo = colors[currentIndex];
    private SpriteRenderer spriteRenderer;
    //private Color firstColor = colors[0];

    private Color[] colors =
    {
        Color.blue,
        Color.green,
        Color.red,
        Color.cyan,
        Color.magenta,
        Color.yellow



    };


    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = colors[0];
        
    }

    

    public void NextColor()
    {
         
        if(currentIndex < colors.Length - 1)
        {
            currentIndex += 1;
            spriteRenderer.color = colors[currentIndex];

        }
        else if(currentIndex == colors.Length - 1)
        {
            currentIndex = 0;
            spriteRenderer.color = colors[currentIndex];
        }
    }

    public void PrevColor()
    {
        if (currentIndex > 0)
        {
            currentIndex -= 1;
            spriteRenderer.color = colors[currentIndex];

        }
        else if (currentIndex == 0)
        {
            int lastIndex = colors.Length - 1;
            currentIndex = lastIndex;
            spriteRenderer.color = colors[currentIndex];
        }
    }

    

    

   
        
    
  
    
    
   
   
}
