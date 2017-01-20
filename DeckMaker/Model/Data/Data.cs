using DeckMaker.Model.Dto;
using DeckMaker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckMaker.Model.Data
{
    public class Data
    {
        public static List<Card> AllCards = new List<Card> {
            //Page1
            new Card(1,1,CardClass.ニュートラル,CardType.フォロワー,"ゴブリン",1,2,3,4,CardRank.ブロンズ),
            new Card(2,1,CardClass.ニュートラル,CardType.スペル,"エンジェルスナイプ",0,0,0,0,CardRank.シルバー),
            new Card(3,1,CardClass.エルフ,CardType.フォロワー,"ウォーターフェアリー",1,1,3,3,CardRank.ブロンズ),
            new Card(4,1,CardClass.エルフ,CardType.フォロワー,"ベビーエルフ・メイ",1,1,3,3,CardRank.ブロンズ),
            new Card(5,1,CardClass.エルフ,CardType.フォロワー,"ブレイブフェアリー",1,1,3,3,CardRank.ブロンズ),
            new Card(6,1,CardClass.エルフ,CardType.フォロワー,"ベビーフェルパー",1,1,3,3,CardRank.ブロンズ),
            new Card(7,1,CardClass.エルフ,CardType.スペル,"自然の導き",0,0,0,0,CardRank.ブロンズ),
            new Card(8,1,CardClass.エルフ,CardType.スペル,"フェアリーサークル",0,0,0,0,CardRank.ブロンズ),
            new Card(9,1,CardClass.エルフ,CardType.スペル,"絡みつく蔦",0,0,0,0,CardRank.ブロンズ),
            new Card(10,1,CardClass.エルフ,CardType.アミュレット,"森の聖域",0,0,0,0,CardRank.シルバー),
            new Card(11,1,CardClass.ロイヤル,CardType.フォロワー,"クイックブレーダー",1,1,3,3,CardRank.ブロンズ),

            //Page2
            new Card(12,1,CardClass.ロイヤル,CardType.フォロワー,"ニンジャエッグ",1,1,3,3,CardRank.ブロンズ),
            new Card(13,1,CardClass.ロイヤル,CardType.フォロワー,"ヴァンガード",1,2,3,4,CardRank.ブロンズ),
            new Card(14,1,CardClass.ロイヤル,CardType.スペル,"師の教え",0,0,0,0,CardRank.ブロンズ),
            new Card(15,1,CardClass.ロイヤル,CardType.アミュレット,"最前線",0,0,0,0,CardRank.ゴールド),
            new Card(16,1,CardClass.ウィッチ,CardType.スペル,"知恵の光",0,0,0,0,CardRank.ブロンズ),
            new Card(17,1,CardClass.ウィッチ,CardType.スペル,"実験開始",0,0,0,0,CardRank.シルバー),
            new Card(18,1,CardClass.ウィッチ,CardType.アミュレット,"くず鉄の錬成",0,0,0,0,CardRank.ブロンズ),
            new Card(19,1,CardClass.ドラゴン,CardType.フォロワー,"アイボリードラゴン",1,2,3,4,CardRank.ブロンズ),
            new Card(20,1,CardClass.ドラゴン,CardType.スペル,"ブレイジングブレス",0,0,0,0,CardRank.ブロンズ),
            new Card(21,1,CardClass.ネクロマンサー,CardType.フォロワー,"スカルビースト",1,2,3,4,CardRank.ブロンズ),

            //Page3
            new Card(22,1,CardClass.ネクロマンサー,CardType.フォロワー,"スケルトンファイター",1,1,3,3,CardRank.シルバー),
            new Card(23,1,CardClass.ネクロマンサー,CardType.スペル,"ソウルコンバージョン",0,0,0,0,CardRank.ブロンズ),
            new Card(24,1,CardClass.ネクロマンサー,CardType.スペル,"死霊の手",0,0,0,0,CardRank.シルバー),
            new Card(25,1,CardClass.ネクロマンサー,CardType.アミュレット,"集団埋葬地",0,0,0,0,CardRank.シルバー),
            new Card(26,1,CardClass.ネクロマンサー,CardType.アミュレット,"死霊の饗宴",0,0,0,0,CardRank.ゴールド),
            new Card(27,1,CardClass.ヴァンパイア,CardType.フォロワー,"蠢く死霊",1,2,3,4,CardRank.ブロンズ),
            new Card(28,1,CardClass.ヴァンパイア,CardType.フォロワー,"呪剣の吸血鬼",1,2,3,4,CardRank.シルバー),
            new Card(29,1,CardClass.ヴァンパイア,CardType.スペル,"貴き血牙",0,0,0,0,CardRank.シルバー),

            //Page4
        };
    }
}
