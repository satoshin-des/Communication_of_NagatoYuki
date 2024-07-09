using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShoShituPrint : MonoBehaviour
{
    public Text t;

    async void Start()
    {
        await NagatoPrints(t, "これをあなたが読んでいる時、わたしはわたしでないだろう。");
        await Task.Delay(500);

        await NagatoPrints(t, "このメッセージが表示されたということは、そこにはあなた、わたし、涼宮ハルヒ、朝比奈みくる、古泉一樹が存在しているはずである。");
        await Task.Delay(500);

        await NagatoPrints(t, "それが鍵。あなたは解答を見つけ出した。");
        await Task.Delay(500);

        await NagatoPrints(t, "これは緊急脱出プログラムである。起動させる場合はエンターキーを、そうでない場合はそれ以外のキーを選択せよ。起動させた場合、あなたは時空修正の機会を得る。ただし成功は保証できない。また帰還の保証もできない。");
        await Task.Delay(500);

        await NagatoPrints(t, "このプログラムが起動するのは一度きりである。実行ののち、消去される。非実行が選択された場合は起動せずに消去される。 \nReady?");
        await Task.Delay(500);

        await JikuShusei(t, "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n脱出プログラム\n");
        await Task.Delay(1000);
        await JikuShusei(t, "実行が選択されました。\n");

        await Task.Delay(1000);

        await Task.Delay(1000);
        await JikuShusei(t, "時空修正用プログラムをインストールします\n");
        await Task.Delay(1000);

        t.text += (t, "<color=#4ab13e>>" + new string('-', 109) + "\n</color>");
        await Task.Delay(2000);
        t.text += (t, "<color=#4ab13e>=>" + new string('-', 108) + "\n</color>");
        await Task.Delay(2000);
        for (int i = 2; i < 108; ++i)
        {
            t.text += ("<color=#4ab13e>" + new string('=', i) + ">" + new string('-', 110 - i - 1) + "\n</color>");
            await Task.Delay(17);
        }
        t.text += (t, "<color=#4ab13e>" + new string('=', 108) + ">-\n</color>");
        await Task.Delay(3000);
        t.text += (t, "<color=#4ab13e>" + new string('=', 109) + ">\n</color>");
        await Task.Delay(4000);
        t.text += (t, "<color=#4ab13e>" + new string('=', 110) + "\n\n\n</color>");

        await Task.Delay(2000);
        await JikuShusei(t, "時空修正を開始します\n");
        await Task.Delay(3000);

        await JikuShusei(t, "貂�＞縺溷ｿ�〒鬧�￠謚懊￠繧九＃繧√ｓ縺ｭ菴輔ｂ縺ｧ縺阪↑縺上※逞帙∩繧貞�縺九■蜷医≧縺薙→縺輔∴縺ゅ↑縺溘�險ｱ縺励※縺上ｌ縺ｪ縺�┌蝙｢縺ｫ逕溘″繧九◆繧∵険繧雁髄縺九★ 閭御ｸｭ蜷代￠縺ｦ蜴ｻ縺｣縺ｦ縺励∪縺�♀繧薙＊繧阪ｓ繧翫�繧後＞繧狗ｧ√▽縺�※縺�￥繧医←繧薙↑霎帙＞荳也阜縺ｮ髣��荳ｭ縺ｧ縺輔∴縺阪▲縺ｨ縺ゅ↑縺溘�霈昴＞縺ｦ雜�∴繧区悴譚･縺ｮ譫懊※蠑ｱ縺墓腐縺ｫ鬲ゅ％繧上＆繧後〓繧医≧縺ｫmy way 驥阪↑繧九ｈ 縺�∪縺ｵ縺溘ｊ縺ｫ 縺斐▲縺ｩ縺ｶ繧後☆螻翫￠縺ｦ辭ｱ縺上↑繧区Φ縺��迴ｾ螳滓ｺｶ縺九＠縺ｦ縺輔∪繧医≧莨壹＞縺溘＞豌玲戟縺｡縺ｫ逅�罰縺ｯ縺ｪ縺�≠縺ｪ縺溘∈縺ゅ�繧後□縺� 繧峨Χ縺�ｓ縺舌ｆ縺�○繧√※鄒弱＠縺�､｢縺�縺代ｒ謠上″縺ｪ縺後ｉ 霑ｽ縺�°縺代ｈ縺��縺峨≠繧�≠繧阪ｓ繧翫�縺ｯ縺√→繧�ａ縺ｦ蝌倥�縺ゅ↑縺溘ｉ縺励￥縺ｪ縺�ｈ逶ｮ繧定ｦ九※縺薙ｌ縺九ｉ縺ｮ縺薙→繧定ｩｱ縺昴≧遘∬ｦ壽ぁ縺励※繧区囓縺�悴譚･縺�縺｣縺ｦ蠑ｷ縺上↑縺｣縺ｦ驕句多螟峨∴繧峨ｌ繧九°繧ゅ�my wish 縺九↑縺医◆縺��縺ｫ縺吶∋縺ｦ縺ｯ God knows...縺ゅ↑縺溘′縺�※ 遘√′縺�※縺ｻ縺九�莠ｺ縺ｯ豸医∴縺ｦ縺励∪縺｣縺滓ｷ｡縺�､｢縺ｮ鄒弱＠縺輔ｒ謠上″縺ｪ縺後ｉ蛯ｷ霍｡縺ｪ縺槭ｋ縺�縺九ｉ遘√▽縺�※縺�￥繧医←繧薙↑霎帙＞荳也阜縺ｮ髣��荳ｭ縺ｧ縺輔∴縺阪▲縺ｨ縺ゅ↑縺溘�霈昴＞縺ｦ雜�∴繧区悴譚･縺ｮ譫懊※蠑ｱ縺墓腐縺ｫ鬲ゅ％繧上＆繧後〓繧医≧縺ｫ縺ｾ縺�≧縺�＞ 驥阪↑繧九ｈ 縺�∪縺ｵ縺溘ｊ縺ｫ 縺斐▲縺ｩ縺ｶ繧後☆");
        await Task.Delay(3000);

        await JikuShusei(t, "髻ｳ繧ら┌縺�ｸ也阜縺ｫ闊槭＞髯阪ｊ縺溘\u0080\u0080縺ゅ＞繧上★縺吶�縺�\u0080檎函縺ｿ蜃ｺ縺輔ｌ縺ｦ縺九ｉ荳牙ｹｴ髢薙\u0080∫ｧ√�縺壹▲縺ｨ縺昴≧繧�▲縺ｦ驕弱＃縺励※縺阪◆縲阪↑縺ｫ縺九′螢翫ｌ縺ｦ縲\u0080縺ｪ縺ｫ縺九′逕溘∪繧後ｋ郢ｰ繧願ｿ斐＠辟｡鬧�↑縺薙→縺輔∴繧�ａ縺ｪ縺�ｺｺ縺溘■縲\u0080荳肴\u0080晁ｭｰ縺ｪ縺ｲ縺ｨ縺溘■逵ｺ繧√ｋ遘√ｂ蜷ｫ縺ｾ繧後◆縺ｻ縺ｩ縺代↑縺�撫鬘後↑縺ｩ縲\u0080蝨ｨ繧翫�縺励↑縺�→遏･縺｣縺ｦ縺ｦ繧ゅ\u0080\u0080隍�尅縺ｪ谿ｵ髫弱′迚ｩ隱槫卸縺｣縺ｦ縺�￥遘√↓繧ょ髪縺ｲ縺ｨ縺､縺ｮ縲\u0080鬘俶悍縺梧戟縺ｦ繧九↑繧芽ｨ俶�縺ｮ荳ｭ縲\u0080譛\u0080蛻昴°繧峨ｒ譛ｬ縺ｫ縺励※遯楢ｾｺ縺ｧ隱ｭ繧\u0080繝壹�繧ｸ縺ｫ縺ｯ襍､縺�魂縲\u0080迴ｾ繧後※雕翫ｊ蜃ｺ縺吶▽繧峨ｌ縺昴≧縺�縺ｨ諤昴≧縺ｪ繧薙※縲\u0080縺ｩ縺�°縺励※繧九￠繧後←遖√§繧峨ｌ縺溘Ρ繝ｼ繝峨ｒ縲\u0080蜻溘￠縺ｰ譛\u0080蠕娯\u0080ｦ縲後％縺ｮ驫\u0080豐ｳ繧堤ｵｱ諡ｬ縺吶ｋ諠��ｱ邨ｱ蜷域\u0080晏ｿｵ菴薙↓繧医▲縺ｦ騾�繧峨ｌ縺溷ｯｾ譛画ｩ溽函蜻ｽ菴薙さ繝ｳ繧ｿ繧ｯ繝育畑繝偵Η繝ｼ繝槭ヮ繧､繝峨�繧､繝ｳ繧ｿ繝ｼ繝輔ぉ繝ｼ繧ｹ縲ゅ◎繧後′縲∫ｧ√\u0080阪←縺薙°縺ｸ騾�￡繧九�縲\u0080縺ｩ縺薙↓繧る\u0080�￡縺ｪ縺�◎繧後□縺代〒萓｡蛟､縺ゅｋ諢剰ｭ倥ａ縺偵↑縺�ｺｺ縺溘■縲\u0080蜆ｪ縺励＞莠ｺ縺溘■蜍輔°縺輔ｌ縺溽ｧ√�譛ｪ譚･豬√ｌ蜃ｺ縺吝ｼｷ縺�鴨縲\u0080蟷ｸ縺帛他縺ｶ縺ｨ豌励′莉倥＞縺溘\u0080\u0080縺昴�縺ｾ縺ｾ縺ｧ蠢�ｦ√↑迚ｩ隱槫魂縺輔ｌ縺溘ｉ蟄伜惠縺悟､峨ｏ繧狗ｨ九�縲\u0080螟｢繧呈戟縺｣縺ｦ縺ｿ縺溘￥縺ｪ繧区─諠�∈縺ｨ蜈ｱ諢溘∈縺ｨ縲\u0080郢九′繧後�遯楢ｾｺ縺ｫ遶九■髱吶￠縺輔↓謚ｱ縺九ｌ縺ｪ縺後ｉ縲\u0080縺ｾ縺滉ｻ頑律繧ょｾ�▲縺ｦ縺�ｋ繧�ｋ繧�°縺ｫ髯阪ｋ縲\u0080豌ｴ縺倥ｃ縺ｪ縺上※繧ゅ▲縺ｨ蟇ゅ＠縺�ｲ定牡縺檎┌縺�ｸ也阜縺ｧ隕九▽縺代◆縺ｮ縲\u0080繧�≦縺ゅ＝縺吶◆縺√\u0080悟些讖溘′霑ｫ繧九→縺励◆繧峨∪縺壹≠縺ｪ縺溘\u0080榊ｭ伜惠縺悟､峨ｏ繧狗ｨ九�縲\u0080螟｢繧呈戟縺｣縺ｦ縺ｿ縺溘￥縺ｪ繧区─諠�∈縺ｨ蜈ｱ諢溘∈縺ｨ縲\u0080郢九′繧後�遯楢ｾｺ縺ｫ遶九■髱吶￠縺輔↓謚ｱ縺九ｌ縺ｪ縺後ｉ縲\u0080縺ｾ縺滉ｻ頑律繧ょｾ�▲縺ｦ縺�ｋ繧�ｋ繧�°縺ｫ髯阪ｋ縲\u0080豌ｴ縺倥ｃ縺ｪ縺上※繧ゅ▲縺ｨ蟇ゅ＠縺�ｲ帝浹繧ら┌縺�ｸ也阜縺ｫ闊槭＞髯阪ｊ縺溘\u0080\u0080縺ゅ＞繧上★縺吶�縺�\u0080梧怙蛻昴°繧峨\u0080∫ｧ√＠縺九＞縺ｪ縺�\u0080よュ蝣ｱ縺ｮ莨晞＃縺ｫ鮨滄ｽｬ縺檎匱逕溘☆繧九°繧ゅ＠繧後↑縺�\u0080ゅ〒繧ゅ\u0080∬◇縺�※縲ゅ◎繧後′縲∫ｧ√′縺薙％縺ｫ縺�ｋ逅�罰縲ゅ≠縺ｪ縺溘′縺薙％縺ｫ縺�ｋ逅�罰縲ゆｿ｡縺倥※縲�");
        await Task.Delay(5000);

        await JikuShusei(t, "\n\n\n時空修正が完了しました。");
        await Task.Delay(3000);

        await JikuShusei(t, "\n\n\n目的時間");
        await Task.Delay(1000);
        await JikuShusei(t, "\n三年前の七夕");

        await Task.Delay(6000);

        SceneManager.LoadScene("TitleScene");
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

    async Task JikuShusei(Text t, string tmp)
    {
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += "<color=#4ab13e>" + tmp[i] + "</color>";
            await Task.Delay(17);
        }
    }
}
