using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    private float n1;
    private float n2;
    [SerializeField] private Button[] GridButtons;
    private int whoseTurn=0;
    [SerializeField] private TextMeshProUGUI[] btnTexts;
    private int[] markGrid;
    private int turnCount=0;
    [SerializeField] GameObject WinScrene;
    [SerializeField] GameObject DrawScrene;
    [SerializeField] TextMeshProUGUI TextWin;
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
        GridButtons[num].interactable = false;
        turnCount++;
        if (whoseTurn == 0) 
        {
            GridButtons[num].GetComponentInChildren<TextMeshProUGUI>().text = "O";
            Debug.Log("O");
            markGrid[num] = 0;
        }
        else if (whoseTurn == 1) 
        {
            GridButtons[num].GetComponentInChildren<TextMeshProUGUI>().text = "X";
            markGrid[num] = 1;
        }
        if (turnCount>=5)
        {
            CheckWin();
        }
        if(turnCount>=9)
        {
            if (CheckWin()==false)
            {
                onDraw();
            } 
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
       // CheckWin();
    }
    private bool CheckWin()
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
            onWin();
            return true;
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
            onWin();
            return true;
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
            onWin();
            return true;
        }
        else if (markGrid[0] + markGrid[3] + markGrid[6] == 3 * whoseTurn)
        {
            if (whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
            onWin();
            return true;
        }
        else if (markGrid[1] + markGrid[4] + markGrid[7] == 3 * whoseTurn)
        {
            if (whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
            onWin();
            return true;
        }
        else if (markGrid[2] + markGrid[5] + markGrid[8] == 3 * whoseTurn)
        {
            if (whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
            onWin();
            return true;
        }
        else if (markGrid[0] + markGrid[4] + markGrid[8] == 3 * whoseTurn)
        {
            if (whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
            onWin();
            return true;
        }
        else if (markGrid[2] + markGrid[4] + markGrid[6] == 3 * whoseTurn)
        {
            if (whoseTurn == 0)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
            onWin();
            return true;
        }
        return false;
    }

    private void onWin()
    {
        WinScrene.SetActive(true);
        Time.timeScale = 0f;
        if (whoseTurn == 0)
        {
            TextWin.text = "Player1:O Win";
        }
        else
        {
            TextWin.text = "Player2:X Win";
        }
    }
    private void onDraw()
    {
        DrawScrene.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        WinScrene.SetActive(false);
    }
    public void Exit()
    {
        //Application.Quit();
    }

}
