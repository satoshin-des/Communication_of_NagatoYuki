using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YuUtuPrint : MonoBehaviour
{
    public Text t;
    public ScrollRect ScrollRect;

    async void Start()
    {
        ScrollRect.verticalNormalizedPosition = 0;
        await NagatoPrints(t, "見えてる？");
        await Task.Delay(500);

        await KyonPrints(t, "ああ");
        await Task.Delay(500);

        await NagatoPrints(t, "そっちの時空間とはまだ完全に連結を絶たれていない。でも時間の問題。そうなれば最後。");
        await Task.Delay(500);

        await KyonPrints(t, "どうすりゃいい？");
        await Task.Delay(500);

        await NagatoPrints(t, "どうにもならない。情報統合思念体は失望している。これで進化の可能性は失われた。");
        await Task.Delay(50);
        await NagatoPrints(t, "涼宮ハルヒは何もない所から情報を生み出す力を持っていた。");
        await Task.Delay(50);
        await NagatoPrints(t, "それは情報統合思念体にもない力。この情報創造能力を解析すれば自律進化の糸口がつかめるかもしれないと考えた。");
        await Task.Delay(50);
        await NagatoPrints(t, "あなたに賭ける。");
        await Task.Delay(500);

        await KyonPrints(t, "何をだよ");
        await Task.Delay(500);

        await NagatoPrints(t, "もう一度こちらへ回帰することを我々は望んでる。涼宮ハルヒは重要な監視対象。わたしという固体もあなたには戻ってきて欲しい\nと感じている。");
        await Task.Delay(50);
        await NagatoPrints(t, "また図書館に");
        await Task.Delay(50);
        await NagatoPrints(t, "sleeping deauty");
        await Task.Delay(5000);

        SceneManager.LoadScene("TitleScene");
    }


    async Task NagatoPrints(Text t, string tmp)
    {
        t.text += "\n\nYUKI.N> ";
        ScrollRect.verticalNormalizedPosition = 0;
        t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
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
        ScrollRect.verticalNormalizedPosition = 0;
        t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == '。') await Task.Delay(1000);
            else if (tmp[i] == '、') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }
}
