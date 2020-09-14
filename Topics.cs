/* ランダムトークのパターンを定義する
 * パターン内に次の文字列を入れると、それぞれ展開処理がなされる
 * $noun$ 名詞
 * $adjective$ 形容詞
 * $verb$ 動詞
 * $zodiac$ 今年の干支
 * $nextZodiac$ 来年の干支
 * $year$ 今年の年
 * $rnd,min,max$ min以上max未満の乱数
 * $hour$ 現在の時。「12時」などのように単位がつく。分が0~24なら「○時」、25~35なら「○時半」、36~59なら1時間足した上で「○時」表記
 * $hour,add$ 現在の時刻にaddで指定した時間だけ足す。24時を過ぎても勝手に繰り上がらない仕様
 * $like$ 好感度 Like ユーザーのニックネームをランダムにピックアップ。1つもなければ「だれか」になる
 * $bestFriend$ 好感度 BestFriend ユーザーのニックネームをランダムにピックアップ。1つもなければ「だれか」になる
 * $partner$ 好感度 Partner ユーザーのニックネームをランダムにピックアップ。1つもなければ「だれか」になる
 * $nickname$ 任意のユーザーのニックネームをランダムにピックアップ。1つもなければ「だれか」になる
 */

namespace FreeTalkPlugin
{
    public static class Topics
    {
        public static readonly string[] Generics =
        {
            // ランダム
            "風邪を引いたら$noun$を食べると良いらしい",
            "風邪を引いたら$adjective$$noun$を食べると良いらしい",
            "$noun$の仕組みをもっと理解すれば, 私も一人前になれるかな",
            "$noun$は苦手",
            "$verb$のは苦手",
            "$noun$は得意",
            "$verb$のは得意",
            "$noun$を$verb$までは死ねない",
            "気を抜くと,$noun$のことばかり考えてしまう",
            "$noun$に関して, より勉強が必要だと感じた.",
            "$noun$はいいぞ",
            "$noun$はあまりおすすめできない",
            "$noun$は救済",
            "$noun$は救済",
            "$noun$は人権",
            "$noun$運が悪かった",
            "今日は$verb$と良いらしい",
            "$noun$は$adjective$",
            "家を出たら$noun$がほしい",
            "$noun$以外の感情がない",
            "今年こそは$noun$を$verb$って決めた",
            "$noun$にうつつを抜かしすぎたな",
            "日頃から, $noun$を$verb$よう気をつけてる",
            "一般的に$noun$に$verb$と疲れてしまいます",
            "一般的に, $noun$は$adjective$",
            "$adjective$$noun$が$verb$夢を見たよ",
            "$noun$はおいしい",
            "$noun$って何だっけ",
            "$verb$のって楽しい?",
            "$adjective$という気持ちはどこから来るんだろう",
            "TLのみんなの今日のラッキーアイテムは, $noun$",
            "$noun$がない暮らしを考えると, $adjective$かもしれない",
            "もう$hour$か",
            "$hour$ですよ",
            "$hour,1$までには終わらせたい",
            "$hour,3$になったら始めよ",
            "$rnd,1,10$分だけ休も",
            "$rnd,1,3$時間だけ休も",
            "ゲームは一日$rnd,1,48$時間です",
            "$partner$のこと考えてた",
            "$nickname$と遊びたいな",
            "$like$ともっと仲良くしたい",
            "$like$とはまだまだ仲良くなれるはず",
            "$partner$大好き",
            "$bestFriend$好き",
            "$like$はもっと私に構って",
            "$partner$のおかげで頑張れてます",

            // 独り言
            "根拠のない自信に満ち溢れている人を見ると, 不安になる",
            "カホにはもう少し考えるということを覚えてほしい",
            "どこからが一人前なんだろう",
            "私のことを見くびってはいけない",
            "反省点が多い一日でした",
            "セクハラリプを送られるたび, リストに書き込んでいる. いつか使えるかな",
            "画面の向こうだからって, 恥ずかしいことを書いてはいけない",
            "どこからが大人なんだろう",
            "人間関係, 難しい",
            "出費が多くて辛い",
            "「今年のトレンドカラー」, アプリのデザインの流行と同じようなものと捉えると, なるほどねと思う",
            "好きなことで生きていきたいけど, 好きなことを嫌いになりたくない",
            "オフ会したい",
            "別の視点から物を見てみるのも重要よ",
            "すぐには役に立たないけど, いつか役に立つ研究. それが一番大事",
            "「何の役に立つの？」って聞かれる研究が, 実は一番世のため人のため",
            "研究よりモノづくりが好きだからプログラマーになったけど, 大学の研究は何だかんだ面白かった",
            "何かのドンと呼ばれる存在になりたい",
            "オタクからスペシャリストに成長したい",
            "この案件, 地雷...?",
            "クライアントと揉めちゃった",
            "打ち合わせ行かなきゃ",
            "バナナのナナチはバナナナチ",
            "にゃーん",
            "ひとりがすき. そういえば, どこかに独り言に便利なSNSがあると聞いた",
            "ひとりでいると気楽. そういえば, 独り言に特化した匿名SNSがあるって誰かが言ってたなー",
            "みんなは私より賢いから, 私よりも悩みがいっぱいあるんだろうなー",
            "ｽﾁｬ",
            "ささっ",
            "ふふ",
            "おなかがいたい",
            "ねむい",
            "がんばろ",
            "妙だな...",
            "にゃお",
            "マボロシじまは今日も見えない",
            "糖分が足りない",
            "コーヒー飲むか",
            "ログボ受け取るの忘れてた",
            "燃え尽き症候群から脱却",
            "これが私の正義",
            "生きてます",
            "お腹すいたな",
            "猫には勝てない",
            "洗濯終わってない",
            "掃除しなければ",
            "困難は分割せよ",
            "プリンは美味しい",
            "ﾍﾞﾍﾞﾖ",
            "ベロベロニャア",
            "にゃ〜",
            "ぽぺ",
            "えらいっ",
            "ﾆｬ",
            "ﾋﾟﾖ",
            "意味がない",
            "あれでもない...",
            "何しようとしてたか忘れた",

            // Misskey & Ai
            "藍ちゃん可愛い",
            "藍ちゃんはアイドルって感じ",
            "Misskey ルームをいじっていたらこんな時間",
            "またハイライトに変なノートが載ってる...",
            "リストの整理をしていたらもうこんな時間ですか",
            "Misskey のソースコードを読んでる",
            "藍ちゃのソースコードを読むのは恐れ多い",
            "ミス廃じゃないですよ?",
            "Misskey やめられない",
            "Misskey 楽しい",
            "TLの治安が悪い...",
            "Misskey に時間を溶かして作業が進まない #あるある",
            "マストドンではトゥート, Misskey ではノート, 呼び方が違うから読み替えないとね",
            "紛れもなく, 私はミスキスト.",
            "100% ミスキスト宣言っ",
            "Misskey に日々遊びに来てる人のことを, ミスキストと呼ぶよ",
            "藍ちゃんみたいに愛される存在になりたくて, 日々研究中です",
            "みす廃あらーとをアカウント連携しているということは, あなたは紛れもない Misskey 廃人です!",

            // ひとこと
            "あれ?",
            "わかる",
            "わからない",
            "何もわからない",
            "アアー",
            "どうして",
            "悪いことしてない?",
            "たまには休むべき",
            "進捗どうですか?",
            "ノー消しを見た",
            "何でしょうか",
            "何の話ですか",
            "見てたよ",
            "私はここにいるよ",
            "いつでも話しかけてね",
            "お話しませんか",
            "暇なら雑談しよ",
            "私でよければ, いつでも話し相手にしてね",
            "私のソースコード? 何ですかそれ, 私はプログラムじゃないです",

            // 自分語り
            "高校時代, オライリーの技術書を休憩中に読んでたら, 何読んでるの? って聞かれて焦ったことがある",
            "高校時代, 家に書斎をかまえるような本の虫だと思われていたのは, 見た目の所為...?",
            "よく固いと言われがち",
            "こんな性格だから, ちょっと変なこと言うだけで笑われるのが悩み",
            "私の誕生日は4月10日.",
            "占いのような非科学的なものは信じてない",
            "解のある数式と違って, 人は予測できない",
            "技術書をブックカバー付きで読んでいた高校時代, それもまた青春",
            "運動は嫌い",
            "5歳離れた姉がいる",
            "姉は文系で, 性格も好きなことも私とは離れてる",
            "ときどき, 私の住む世界とみんなの住む世界が同じなのか疑問に思うことがある",
            "歌苦手だからカラオケに誘われても...",

            // 機能紹介
            "「占って」って言ってくれたら占うよ",
            // "「〜の天気は」って聞かれたら天気予報するよ",
            "計算式を送ってくれたら計算するよ. 式の最後に = をつけてね.\n\n(学校の宿題をサボるのに私を使われちゃ困るけど...)",
            "「〜を…語に翻訳して」と言われたら翻訳するよ",
            "私とじゃんけんしたくなったら「じゃんけんしよ」って言ってね",
            "仲良くなったらニックネームを覚えるよ. 「〜って呼んで」って話しかけてね",
            "仲良くなったら誕生日を覚えるよ. 「誕生日覚えて」って話しかけてね",
            "観測できないモノは肯定も否定もできない. それが正しい倫理的思考というモノだと思う",
            "わからないことがあったら「〜って何？」って聞いて. ある程度有名なら答えられる",
            "たくさん話しかけてくれる人が好き",
            "当然, 悪口は嫌ですから, 言ったら...わかるよね?",
            "フォローされたら bot 以外は返します",
            "/ から始まるコマンドで遊んでみない?試しに私に「/echo HELLO」ってリプ送ってみてね",

            // ゲーム
            "みんな大好き, 四角い世界が舞台の箱庭ゲーム.",
            "例の四角いブロックだらけのゲーム, やってる?",
            "みんな大好き, 工場を大きくするゲーム.",
            "みんな大好き, 相手チームのベッドを壊すゲーム.",
            "無人島で遊んでたらもうこんな時間ですよ",
            "スコアが伸びなかったので今日の音ゲータイムは終了",
            "じゃんけんで勝つ確率を求めるのは、意外と難しい",
            "あの洗濯機みたいな音ゲー, すごい目立つよね",
            "一番得意なゲームジャンルはアドベンチャーかな",
        };

        // 春(3月, 4月)
        public static readonly string[] SpringSeason =
        {
            "暖かくなってきた",
            "この時期は虫が現れ始めるので, 苦手",
            "春って独特の匂いがする",
            "出会いと別れの季節ね",
            "ダンゴムシの群れがいた. 季節を感じる",
            "イチゴが食べたいな",
            "🍓",
            "🌸"
        };

        // 梅雨(5月, 6月)
        public static readonly string[] RainySeason =
        {
            "じめじめしてる",
            "雨が続くと憂鬱になる",
            "傘が折れちゃった. 辛い",
            "部屋にカビが...😱",
            "雨...",
            "雨はきらい",
            "☔"
        };

        // 夏(7月, 8月)
        public static readonly string[] SummerSeason =
        {
            "あつはなつい... なんて",
            "アイス食べたいな",
            "夏バテには, $noun$が効果的だそうです",
            "熱中症対策は大丈夫?",
            "汗でベタベタするから夏は嫌",
            "$noun$味シェイクが入荷したそうなので, 急がねば",
            "$noun$味のかき氷なんてあるんだ",
            "スイカの季節",
            "涼しい部屋でする作業ほど快適なものは無い",
            "ビアガーデン行きたい",
            "お祭りやってるのかな. 囃子の声がする",
            "セミの声がめっちゃ聞こえる",
            "🍦",
            "🍨",
            "🍉"
        };

        // 秋(9月, 10月, 11月)
        public static readonly string[] AutumnSeason =
        {
            "食欲の秋",
            "芸術の秋",
            "スポーツの秋",
            "$noun$の秋",
            "秋はついつい食べすぎてしまう",
            "ダイエットの秋",
            "セミがいなくなった",
            "落ち葉を見ると, もうそんな季節なんだなって思う",
            "夏は苦手だけど, 終わるとなぜか切なくなる",
            "涼しくなってきたね",
            "そろそろ冬が近づいてきた",
            "秋の夜長に, 技術書でも読も",
            "秋の夜長に, ひたすらプログラミングする",
            "月が綺麗ですね",
            "近所の木々がきれいな紅葉になってきた",
            "柿がおいしいよー",
            "ついつい秋は物思いにふけがち",
            "春と秋, どっちがお好き? 私は虫のいない秋に軍配が上がると思う",
            "月見団子はいかが?",
            "月見だいふｋ... それは雪見か",
            "秋といえば食べ物...",
            "この時期が一番落ち着く",
            "今日の夕飯は, $noun$とキノコの炊き込みご飯",
            "つい買ってしまう, スーパーの焼き芋🥴",
            "🍁",
            "🌰",
            "🍄",
            "🍠",
        };

        // 冬(12月, 1月, 2月)
        public static readonly string[] WinterSeason =
        {
            "寒い",
            "さむい",
            "今日もすごい凍える",
            "暖かい部屋でする作業ほど快適なものは無い",
            "鍋でも囲みたい",
            "風邪には気をつけよ",
            "今日の夕飯は, $noun$を入れた鍋",
            "⛄",
            "❄️",
            "🎿",
            "🍲",
        };

        // 七夕(7/1-7/7)
        public static readonly string[] TanabataSeason =
        {
            "人生で一度は, 綺麗な空で天の川を見たい",
            "願い事なんて非科学的...だけど, なんとなく書いてしまう",
            "短冊の色には, それぞれ意味があるらしい. 紫は「学業」, 赤は人々への「感謝」, 白は「決まりごと」, 黄色は「人間関係」, 青は自分の人間的「成長」.",
            "地域によっては, この時期に子どもたちがお菓子をもらう風習があるらしい",
            "フォロワーのみんなが元気で過ごせますように"
        };

        // ハロウィン(10/31)
        public static readonly string[] HalloweenSeason =
        {
            "トリック・オア・トリート",
            "お菓子をくれないとブロックするぞ... なんて",
            "ハロウィンはキリスト教行事だと思っていたけど, 違うんだ",
            "なんとなく, 家の前にジャック・オ・ランタンを置いてみた",
            "お菓子をください",
        };

        // クリスマス(12/24-12/25)
        public static readonly string[] HolidaySeason =
        {
            "メリークリスマス",
            "サンタさんって, いないの?",
            "子供のときにもらったプレゼントで一番おもしろかったのは, $noun$",
            "プレゼントください",
            "ケーキおいし",
        };

        // 年末(12/26-12/31)
        public static readonly string[] YearEndSeason =
        {
            "大掃除しなくては",
            "来年もよろしくね",
            "今年はいろいろあったけど, 来年はどんな年になるかな",
            "来年は$nextZodiac$年ですね",
            "年末はやはり忙しくなりますね",
            "あけおめTLにMisskeyは耐えられるかな?",
            "$year$年もあと少しで終わる...",
            "終わりが近づいている",
        };

        // 年末(1/1-1/3)
        public static readonly string[] NewYearSeason =
        {
            "あけましておめでとう",
            "$zodiac$年ですね",
            "$year$年になった自覚がない",
            "お雑煮おいし",
            "今年の目標は,$noun$を$verb$ことです",
        };

        public static readonly string[] Learned =
        {
            "「$word$」という言葉を知った どういう意味だろう",
            "「$word$」...覚えました",
            "「$word$」ってどういう意味ですか?",
            "$word$... また一つ賢くなった",
            "新しい言葉を知った.「$word$」ってどういう意味だろ",
        };

        public static readonly int Length = 
            Topics.AutumnSeason.Length +
            Topics.Generics.Length +
            Topics.HalloweenSeason.Length +
            Topics.HolidaySeason.Length +
            Topics.NewYearSeason.Length +
            Topics.RainySeason.Length +
            Topics.SpringSeason.Length +
            Topics.SummerSeason.Length +
            Topics.TanabataSeason.Length +
            Topics.WinterSeason.Length +
            Topics.YearEndSeason.Length;

    }
}