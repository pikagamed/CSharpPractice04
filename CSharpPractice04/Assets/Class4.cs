using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class4 : MonoBehaviour
{
    public int A = 60;
    public int B = 70;
    public int C = 90;

    public string singleName = "AKino";

    public int[] scores;                                                            //指定int類型之陣列，不指定初始值
    public float[] weight = new float[3];                                 //宣告指定陣列數量
    public string[] names = { "AKino", "Menear", "IVAN" };     //宣告陣列並指定內容
    public bool[] clear = { true, true, false, true, false };           //宣告陣列並指定內容
    public Color[] colors = new Color[4];                                //宣告顏色陣列

    public Transform cube;

    // Start is called before the first frame update
    void Start()
    {
        #region 課程內容

        scores = new int[] { 60, 70, 90, 50, 10, 2, 3, 6, 8, 60, 80 };  //指定初始值為3筆資料

        //存取陣列資料

        //讀取
        Debug.Log("名字陣列：" + names[2]);
        //寫入
        names[2] = "IVAN-JHANG";
        Debug.Log("名字陣列第三筆資料寫入後：" + names[2]);

        Debug.Log("分數陣列長度：" + scores.Length);

        //呼叫
        Sum(10, 7);

        //實質型別，作為引數時會將「值」傳入(只會將A的數值傳進去，不會影響原本A的內容)
        ClearA(A);

        //參考型別，作為引述時會將「位址」傳入(會將陣列scores的位址傳進去，會真正修改到陣列scores的內容)
        ClearName(singleName);
        ClearScores(scores);

        //如果將單獨陣列元素傳入則不會受影響
        ClearA(scores[3]);

        #endregion

    }

    //小括號內的「參數」
    private void Sum(int a, int b)
    {
        Debug.Log("總和為：" + (a + b));
    }

    private void ClearA(int getA)
    {
        getA = 0;
    }

    private void ClearName(string getName)
    {
        getName = "";
    }

    private void ClearScores(int[] getScores)
    {
        getScores[0] = 0;
        getScores[1] = 0;
        getScores[2] = 0;
    }

    public bool openDoor = true;
    public int healthPoint = 100;

    private void Update()
    {
        cube.transform.Rotate(0, 0, 3f, Space.Self);

        /*
        if( openDoor )
        {
            Debug.Log("開門中");
        }
        else
        {
            Debug.Log("關門中");
        }

        if(healthPoint<20)
        {
            Debug.LogError("HP低於1/5，紅血");
        }
        else if(healthPoint<50)
        {
            Debug.LogWarning("HP低於1/2，黃血");
        }
        else
        {
            Debug.Log("HP在1/2以上，綠血");
        }
        */
    }
}
