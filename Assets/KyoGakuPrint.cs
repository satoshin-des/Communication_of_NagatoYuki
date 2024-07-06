using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KyoGakuPrint : MonoBehaviour
{
    public Text t;

    async void Start()
    {
        await NagatoPrints(t, "心配はいらない");
        await Task.Delay(500);

        await KyonPrints(t, "おまえが熱を出したのはテンガイ領域とやらのしわざなんだろ");
        await Task.Delay(500);

        await NagatoPrints(t, "そう");
        await Task.Delay(50);
        await NagatoPrints(t, "あなたと涼宮ハルヒには手出しをさせない");
        await Task.Delay(500);

        await KyonPrints(t, "俺やハルヒのことはいいんだ。自分たちでなんとかするし、現に今もピンピンしてる。手出しされて倒れてんのはおまえじゃないか。やめさせろ。");
        await Task.Delay(500);

        await NagatoPrints(t, "これは私の役目の一つ□□□□情報□□思念体は□□□域との交信□試");
        await Task.Delay(500);

        await KyonPrints(t, "どうした？");
        await Task.Delay(500);

        await NagatoPrints(t, "わたしの稼働???????僥儉儕?乕??�x?戝?暘??奧??偲???偵???�y???");
        await Task.Delay(50);
        await NagatoPrints(t, "???????働乕????抜???偵??側??側??�y??????????側??");
        await Task.Delay(50);
        await NagatoPrints(t, "少し眠る");
    }


    async Task NagatoPrints(Text t, string tmp)
    {
        t.text += "\n\nYUKI.N> ";
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == '。') await Task.Delay(1000);
            else if (tmp[i] == '、') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }

    async Task KyonPrints(Text t, string tmp)
    {
        t.text += "\n\nKYON> ";
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == '。') await Task.Delay(1000);
            else if (tmp[i] == '、') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }
}
