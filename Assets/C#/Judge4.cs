using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge4 : MonoBehaviour {

    //選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
    public void JudgeAnswer(){
        //正解のデータをテキストでセットする
        string answerText = "自分の意思でどうすることもできないから";
        //選択したボタンのテキストラベルを取得する
        Text selectedBtn = this.GetComponentInChildren<Text> ();

        if (selectedBtn.text == "自分の意思でどうすることもできないから") {
            Debug.Log("正解");
                            Application.LoadLevel ("Result");
        } else {
            Debug.Log("不正解");
        }
    }
}
