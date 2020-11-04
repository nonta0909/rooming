using UnityEngine;
using System.Collections;
using UnityEngine.UI;//UI オブジェクトを扱う時は必須
public class QuizMgr : MonoBehaviour {

    //アタッチしたオブジェクトが呼ばれた時に実行される。
    void Start () {
        QuestionLabelSet ();
        AnswerLabelSet ();
    }

    private void QuestionLabelSet(){
        //特定の名前のオブジェクトを検索してアクセス
        Text qLabel = GameObject.Find("Quiz/QLabel").GetComponentInChildren<Text> ();
        //データをセットすることで、既存情報を上書きできる
        qLabel.text = "生理を馬鹿にしてはいけない理由とは？";
    }

    private void  AnswerLabelSet(){
        //回答文面の作成
        string[] array = new string[]{"生理は妊娠するために必要な機能だから","生理があるからこそ君は今ここにいるから","女性としては当たり前のことだから","自分の意思でどうすることもできないから"};
        //ボタンが4つあるのでそれぞれ代入
        for (int i=1; i<=4 ; i++){
            Text ansLabel = GameObject.Find("Quiz/AnsButton" + i).GetComponentInChildren<Text> ();
            ansLabel.text = array[i-1];
        }
    }

}
