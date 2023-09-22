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
        GridButtons[num].GetComponentInChildren<TextMeshProUGUI>().text = "X";
        Debug.Log("X");
    }

}
