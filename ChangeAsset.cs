using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAsset : MonoBehaviour
{
    public Button nextButton;
    public Button prevButton;
    public int currentIndex = 0;
    

    public GameObject[] assetChildren;
    




    // Start is called before the first frame update
    void Start()
    {
        
        
        assetChildren[currentIndex].SetActive(true);
    }

    public void NextAsset()
    {

        if (currentIndex < assetChildren.Length - 1)
             {
            assetChildren[currentIndex].SetActive(false);
            currentIndex += 1;
            assetChildren[currentIndex].SetActive(true);

        }
        else if (currentIndex == assetChildren.Length - 1)
        {

            assetChildren[currentIndex].SetActive(false);
            currentIndex = 0;
            assetChildren[currentIndex].SetActive(true);
        }
    }

    public void PrevAsset()
    {
        if (currentIndex > 0)
        {
            assetChildren[currentIndex].SetActive(false);
            currentIndex -= 1;
            assetChildren[currentIndex].SetActive(true);

        }
        else if (currentIndex == 0)
        {
            int lastIndex = assetChildren.Length - 1;
            assetChildren[currentIndex].SetActive(false);
            currentIndex = lastIndex;
            assetChildren[currentIndex].SetActive(true);
        }
    }

}
