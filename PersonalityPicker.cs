using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersonalityPicker : MonoBehaviour
{
    //Button fields
    [SerializeField]
    private Button takeTest, introvert, extravert, sensing, intuitive, thinking, feeling, perceiving, judging, morning, afternoon, goBack, confirm;
    //Letter boxes
    [SerializeField]
    private TextMeshProUGUI iOrE, nOrS, tOrF, pOrJ, mOrA;
    //Returned personality
    public GameObject playerCharacter;

    //Display letters
    public void ChooseIntrovert()
    {
        iOrE.text = "I";
    }

    public void ChooseExtravert()
    {
        iOrE.text = "E";
    }

    public void ChooseSensing()
    {
        nOrS.text = "S";
    }

    public void ChooseIntuitive()
    {
        nOrS.text = "N";
    }

    public void ChooseThinking()
    {
        tOrF.text = "T";
    }

    public void ChooseFeeling()
    {
        tOrF.text = "F";
    }

    public void ChoosePerceiving()
    {
        pOrJ.text = "P";
    }

    public void ChooseJudging()
    {
        pOrJ.text = "J";
    }

    public void ChooseMorning()
    {
        mOrA.text = "M";
    }

    public void ChooseAfternoon()
    {
        mOrA.text = "A";
    }

    


}
