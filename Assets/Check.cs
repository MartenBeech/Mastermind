using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{
    public void ClickCheck()
    {
        if (Value.value[0] < 10 && Value.value[1] < 10 && Value.value[2] < 10 && Value.value[3] < 10 && Value.value[4] < 10)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Value.value[i] == Value.answer[i])
                {
                    Value.correctPlace++;
                    Value.answerCounted[i] = true;
                    Value.valueCounted[i] = true;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int ii = 0; ii < 5; ii++)
                {
                    if (Value.answerCounted[ii] == false && Value.valueCounted[i] == false)
                    {
                        if (Value.value[i] == Value.answer[ii] && ii != i && Value.value[ii] != Value.answer[ii])
                        {
                            Value.correctNumber++;
                            Value.valueCounted[i] = true;
                            Value.answerCounted[ii] = true;
                            break;
                            
                        }
                    }
                }
            }

            Value.text[Value.round].GetComponentInChildren<Text>().text = "Correct Place: " + Value.correctPlace + "\n" + "Correct Number: " + Value.correctNumber;

            if (Value.correctPlace >= 5 || Value.round >= 8)
            {
                for (int i = 0; i < 5; i++)
                {
                    Board.board[i + 45].GetComponentInChildren<Text>().text = Value.answer[i].ToString();
                }
            }

            else if (!Value.youWon)
            {
                Value.round++;
                for (int i = 0; i < 5; i++)
                {
                    Board.board[i + (Value.round * 5)].GetComponentInChildren<Image>().color = Color.white;
                    Value.value[i] = 10;
                }
            }

            Value.correctNumber = 0;
            Value.correctPlace = 0;
            Board.iBoard = 5;
            for (int i = 0; i < 5; i++)
            {
                Value.answerCounted[i] = false;
                Value.valueCounted[i] = false;
            }
        }
    }
}