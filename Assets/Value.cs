using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour
{
    public static bool youWon;
    public static bool[] answerCounted = new bool[5];
    public static bool[] valueCounted = new bool[5];
    public static int[] value = new int[5] { 10, 10, 10, 10, 10 };
    public static int[] answer = new int[5];
    public static int correctNumber = 0;
    public static int correctPlace = 0;
    public static int round;
    public static GameObject text1, text2, text3, text4, text5, text6, text7, text8, text9;
    public static GameObject[] text = new GameObject[9];
    private void Start()
    {
        text1 = GameObject.Find("Text1"); text2 = GameObject.Find("Text2"); text3 = GameObject.Find("Text3"); text4 = GameObject.Find("Text4"); text5 = GameObject.Find("Text5");
        text6 = GameObject.Find("Text6"); text7 = GameObject.Find("Text7"); text8 = GameObject.Find("Text8"); text9 = GameObject.Find("Text9");

        text[0] = text1; text[1] = text2; text[2] = text3; text[3] = text4; text[4] = text5;
        text[5] = text6; text[6] = text7; text[7] = text8; text[8] = text9;

        answer[0] = Random.Range(0, 10);
        answer[1] = Random.Range(0, 10);
        answer[2] = Random.Range(0, 10);
        answer[3] = Random.Range(0, 10);
        answer[4] = Random.Range(0, 10);

        youWon = false;
        round = 0;
    }
}
