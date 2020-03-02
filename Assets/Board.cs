using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public static int iBoard = 5;
    public static GameObject board1, board2, board3, board4, board5, board6, board7, board8, board9, board10,
        board11, board12, board13, board14, board15, board16, board17, board18, board19, board20,
        board21, board22, board23, board24, board25, board26, board27, board28, board29, board30,
        board31, board32, board33, board34, board35, board36, board37, board38, board39, board40,
        board41, board42, board43, board44, board45, board46, board47, board48, board49, board50;
    public static GameObject background, back;
    public static GameObject[] board = new GameObject[50];

    public void Start()
    {
        board1 = GameObject.Find("Board1"); board2 = GameObject.Find("Board2"); board3 = GameObject.Find("Board3"); board4 = GameObject.Find("Board4"); board5 = GameObject.Find("Board5");
        board6 = GameObject.Find("Board6"); board7 = GameObject.Find("Board7"); board8 = GameObject.Find("Board8"); board9 = GameObject.Find("Board9"); board10 = GameObject.Find("Board10");
        board11 = GameObject.Find("Board11"); board12 = GameObject.Find("Board12"); board13 = GameObject.Find("Board13"); board14 = GameObject.Find("Board14"); board15 = GameObject.Find("Board15");
        board16 = GameObject.Find("Board16"); board17 = GameObject.Find("Board17"); board18 = GameObject.Find("Board18"); board19 = GameObject.Find("Board19"); board20 = GameObject.Find("Board20");
        board21 = GameObject.Find("Board21"); board22 = GameObject.Find("Board22"); board23 = GameObject.Find("Board23"); board24 = GameObject.Find("Board24"); board25 = GameObject.Find("Board25");
        board26 = GameObject.Find("Board26"); board27 = GameObject.Find("Board27"); board28 = GameObject.Find("Board28"); board29 = GameObject.Find("Board29"); board30 = GameObject.Find("Board30");
        board31 = GameObject.Find("Board31"); board32 = GameObject.Find("Board32"); board33 = GameObject.Find("Board33"); board34 = GameObject.Find("Board34"); board35 = GameObject.Find("Board35");
        board36 = GameObject.Find("Board36"); board37 = GameObject.Find("Board37"); board38 = GameObject.Find("Board38"); board39 = GameObject.Find("Board39"); board40 = GameObject.Find("Board40");
        board41 = GameObject.Find("Board41"); board42 = GameObject.Find("Board42"); board43 = GameObject.Find("Board43"); board44 = GameObject.Find("Board44"); board45 = GameObject.Find("Board45");
        board46 = GameObject.Find("Board46"); board47 = GameObject.Find("Board47"); board48 = GameObject.Find("Board48"); board49 = GameObject.Find("Board49"); board50 = GameObject.Find("Board50");

        board[0] = board1; board[1] = board2; board[2] = board3; board[3] = board4; board[4] = board5; board[5] = board6; board[6] = board7; board[7] = board8; board[8] = board9; board[9] = board10;
        board[10] = board11; board[11] = board12; board[12] = board13; board[13] = board14; board[14] = board15; board[15] = board16; board[16] = board17; board[17] = board18; board[18] = board19; board[19] = board20;
        board[20] = board21; board[21] = board22; board[22] = board23; board[23] = board24; board[24] = board25; board[25] = board26; board[26] = board27; board[27] = board28; board[28] = board29; board[29] = board30;
        board[30] = board31; board[31] = board32; board[32] = board33; board[33] = board34; board[34] = board35; board[35] = board36; board[36] = board37; board[37] = board38; board[38] = board39; board[39] = board40;
        board[40] = board41; board[41] = board42; board[42] = board43; board[43] = board44; board[44] = board45; board[45] = board46; board[46] = board47; board[47] = board48; board[48] = board49; board[49] = board50;

        background = GameObject.Find("Background");
        background.transform.SetAsFirstSibling();
        back = GameObject.Find("Back");
        back.transform.localScale = new Vector3(2220, 1280);
        back.transform.position = new Vector3(Screen.width/2, Screen.height/2);
    }
    public void Update()
    {
        if (iBoard < 5)
        {
            if (Input.GetKeyDown("1") || Input.GetKeyDown("2") || Input.GetKeyDown("3") || Input.GetKeyDown("4") || Input.GetKeyDown("5") ||
                Input.GetKeyDown("6") || Input.GetKeyDown("7") || Input.GetKeyDown("8") || Input.GetKeyDown("9") || Input.GetKeyDown("0"))
            {
                board[iBoard + (Value.round * 5)].GetComponentInChildren<Text>().text = Input.inputString;
                Value.value[iBoard] = int.Parse(Input.inputString);
            }
            else if (Input.GetKeyDown("backspace"))
            {
                board[iBoard + (Value.round * 5)].GetComponentInChildren<Text>().text = "";
                Value.value[iBoard] = 10;
            }
        }
    }
    public void ClickBoard(int index)
    {
        iBoard = index;
    }
}
