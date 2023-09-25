using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    private float n1;
    private float n2;
    [SerializeField] private Button[] GridButtons;
    private bool whoseTurn=false;
    [SerializeField] private TextMeshProUGUI[] btnTexts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBtn(int num)
    {
        if (whoseTurn == false) 
        {
            GridButtons[num].GetComponentInChildren<TextMeshProUGUI>().text = "O";
            Debug.Log("X");
            
        }
        else if (whoseTurn == true) 
        {
            GridButtons[num].GetComponentInChildren<TextMeshProUGUI>().text = "X";
        }
        changeTurn();
        
    }

    private void changeTurn()
    {
        if(whoseTurn == false)
        {
            whoseTurn = true;
        }
        else if(whoseTurn==true) 
        { 
            whoseTurn = false;
        }
        Winsrcene();
    }
    private void Winsrcene()
    {
        if (btnTexts[0].text== btnTexts[1].text && btnTexts[0].text == btnTexts[2].text)
        {
            
        }
        else if (btnTexts[3].text == btnTexts[4].text && btnTexts[3].text == btnTexts[5].text)
        {

        }
        else if (btnTexts[6].text == btnTexts[7].text && btnTexts[6].text == btnTexts[8].text)
        {

        }
        //else if (btnTexts[0].text == btnTexts[3].text && btnTexts[0].text == btnTexts[6].text)
        //{

        //}
        //else if (btnTexts[1].text == btnTexts[4].text && btnTexts[1].text == btnTexts[7].text)
        //{

        //}
        //else if (btnTexts[2].text == btnTexts[5].text && btnTexts[2].text == btnTexts[8].text)
        //{

        //}
        //else if (btnTexts[0].text == btnTexts[4].text && btnTexts[0].text == btnTexts[8].text)
        //{

        //}
        //else if (btnTexts[2].text == btnTexts[4].text && btnTexts[2].text == btnTexts[6].text)
        //{

        //}
        //else 
        //{

        //}

    }

}
