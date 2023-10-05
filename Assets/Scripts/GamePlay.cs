using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    private float n1;
    private float n2;
    [SerializeField] private Button[] GridButtons;
    private int whoseTurn=0;
    [SerializeField] private TextMeshProUGUI[] btnTexts;
    private int[] markGrid;
    // Start is called before the first frame update
    void Start()
    {
        markGrid = new int[9];
        for (int i = 0; i < 9; i++)
        {
            markGrid[i] = -100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBtn(int num)
    {
        if (whoseTurn == 0) 
        {
            GridButtons[num].GetComponentInChildren<TextMeshProUGUI>().text = "O";
            Debug.Log("O");
            
        }
        else if (whoseTurn == 1) 
        {
            GridButtons[num].GetComponentInChildren<TextMeshProUGUI>().text = "X";
        }
        changeTurn();
        
    }

    private void changeTurn()
    {
        if(whoseTurn == 0)
        {
            whoseTurn = 1;
        }
        else if(whoseTurn==1) 
        { 
            whoseTurn = 0;
        }
        CheckWin();
    }
    private void CheckWin()
    {
        if (markGrid[0] + markGrid[1] + markGrid[2] == 3 * whoseTurn)
        {
            if(whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
        }
        else if (markGrid[3] + markGrid[4] + markGrid[5] == 3 * whoseTurn)
        {
            if (whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
        }
        else if (markGrid[6] + markGrid[7] + markGrid[8] == 3 * whoseTurn)
        {
            if (whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
        }
        //else if (markGrid[0] + markGrid[3] + markGrid[6] == 3 * whoseTurn)
        //{
        //    if (whoseTurn == 0)
        //    {
        //        Debug.Log("Player1 Win");
        //    }
        //    else
        //    {
        //        Debug.Log("Player2 Win");
        //    }
        //}
        //else if (markGrid[1] + markGrid[4] + markGrid[7] == 3 * whoseTurn)
        //{
        //    if (whoseTurn == 0)
        //    {
        //        Debug.Log("Player1 Win");
        //    }
        //    else
        //    {
        //        Debug.Log("Player2 Win");
        //    }
        //}
        //else if (markGrid[2] + markGrid[5] + markGrid[8] == 3 * whoseTurn)
        //{
        //    if (whoseTurn == 0)
        //    {
        //        Debug.Log("Player1 Win");
        //    }
        //    else
        //    {
        //        Debug.Log("Player2 Win");
        //    }
        //}
        //else if (markGrid[0] + markGrid[4] + markGrid[8] == 3 * whoseTurn)
        //{
        //    if (whoseTurn == 0)
        //    {
        //        Debug.Log("Player1 Win");
        //    }
        //    else
        //    {
        //        Debug.Log("Player2 Win");
        //    }
        //}
        //else if (markGrid[2] + markGrid[4] + markGrid[6] == 3 * whoseTurn)
        //{
        //    if (whoseTurn == 0)
        //    {
        //        Debug.Log("Player1 Win");
        //    }
        //    else
        //    {
        //        Debug.Log("Player2 Win");
        //    }
        //}
        //else
        //{

        //}

    }

}
