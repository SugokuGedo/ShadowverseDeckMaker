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
            new Card(30,1,CardClass.ヴァンパイア,CardType.スペル,"処刑人の斧",0,0,0,0,CardRank.ブロンズ),
            new Card(31,1,CardClass.ヴァンパイア,CardType.アミュレット,"鮮血の花園",0,0,0,0,CardRank.シルバー),
            new Card(32,1,CardClass.ビショップ,CardType.アミュレット,"詠唱：天馬召喚",0,0,0,0,CardRank.ブロンズ),
            new Card(33,1,CardClass.ビショップ,CardType.アミュレット,"詠唱：白翼への祈り",0,0,0,0,CardRank.ブロンズ),
            new Card(34,1,CardClass.ビショップ,CardType.アミュレット,"詠唱：聖なる願い",0,0,0,0,CardRank.ブロンズ),
            new Card(35,1,CardClass.ビショップ,CardType.アミュレット,"詠唱：夢想の白兎",0,0,0,0,CardRank.ゴールド),
            new Card(36,2,CardClass.ニュートラル,CardType.フォロワー,"ファイター",2,2,4,4,CardRank.ブロンズ),
            new Card(37,2,CardClass.ニュートラル,CardType.フォロワー,"ミノタウロス",2,1,4,3,CardRank.ブロンズ),
            new Card(38,2,CardClass.ニュートラル,CardType.フォロワー,"ベルエンジェル",0,2,2,4,CardRank.シルバー),
            new Card(39,2,CardClass.ニュートラル,CardType.フォロワー,"ユニコーンの踊り手・ユニコ",2,2,4,4,CardRank.シルバー),

            //Page5
            new Card(40,2,CardClass.ニュートラル,CardType.フォロワー,"忌むべき悪魔の像",0,3,2,5,CardRank.ゴールド),
            new Card(41,2,CardClass.ニュートラル,CardType.フォロワー,"天弓の天使・リリエル",2,2,4,4,CardRank.シルバー),
            new Card(42,2,CardClass.ニュートラル,CardType.フォロワー,"セクトール",2,2,4,4,CardRank.ブロンズ),
            new Card(43,2,CardClass.ニュートラル,CardType.フォロワー,"ハンサ",0,2,2,4,CardRank.ブロンズ),
            new Card(44,2,CardClass.ニュートラル,CardType.スペル,"研磨の魔法",0,0,0,0,CardRank.ブロンズ),
            new Card(45,2,CardClass.ニュートラル,CardType.スペル,"光の道筋",0,0,0,0,CardRank.シルバー),
            new Card(46,2,CardClass.ニュートラル,CardType.スペル,"新たなる運命",0,0,0,0,CardRank.ゴールド),
            new Card(47,2,CardClass.ニュートラル,CardType.アミュレット,"運命の泉",0,0,0,0,CardRank.ブロンズ),
            new Card(48,2,CardClass.ニュートラル,CardType.アミュレット,"戦乙女の槍",0,0,0,0,CardRank.ブロンズ),
            new Card(49,2,CardClass.エルフ,CardType.フォロワー,"フェアリーウィスパラー",1,1,3,3,CardRank.ブロンズ),
            new Card(50,2,CardClass.エルフ,CardType.フォロワー,"エルフガード",1,3,3,5,CardRank.ブロンズ),

            //Page6
            new Card(51,2,CardClass.エルフ,CardType.フォロワー,"メタルエルフメイジ",2,1,4,3,CardRank.シルバー),
            new Card(52,2,CardClass.エルフ,CardType.フォロワー,"ダンジョンフェアリー",2,2,4,4,CardRank.ブロンズ),
            new Card(53,2,CardClass.エルフ,CardType.フォロワー,"フェアリーブリンガー",1,3,3,5,CardRank.ブロンズ),
            new Card(54,2,CardClass.エルフ,CardType.フォロワー,"ワンダーエルフメイジ",2,1,4,3,CardRank.ブロンズ),
            new Card(55,2,CardClass.エルフ,CardType.フォロワー,"放浪するエルフ",2,2,4,4,CardRank.ブロンズ),
            new Card(56,2,CardClass.エルフ,CardType.フォロワー,"ブレスフェアリーダンサー",1,1,3,3,CardRank.シルバー),
            new Card(57,2,CardClass.エルフ,CardType.フォロワー,"リノセウス",1,1,3,3,CardRank.ゴールド),
            new Card(58,2,CardClass.エルフ,CardType.フォロワー,"パフュームドワーフ",3,1,5,3,CardRank.ブロンズ),
            new Card(59,2,CardClass.エルフ,CardType.フォロワー,"エルフバード",2,2,4,4,CardRank.ブロンズ),

            //Page7
            new Card(60,2,CardClass.エルフ,CardType.フォロワー,"エルフの少女・リザ",2,2,4,4,CardRank.ゴールド),
            new Card(61,2,CardClass.エルフ,CardType.フォロワー,"クリスタリア・りりィ",2,2,4,4,CardRank.シルバー),
            new Card(62,2,CardClass.エルフ,CardType.スペル,"森荒らしへの報い",0,0,0,0,CardRank.ブロンズ),
            new Card(63,2,CardClass.エルフ,CardType.スペル,"妖精のいたずら",0,0,0,0,CardRank.ブロンズ),
            new Card(64,2,CardClass.エルフ,CardType.スペル,"翅の輝き",0,0,0,0,CardRank.ブロンズ),
            new Card(65,2,CardClass.エルフ,CardType.アミュレット,"まどろみの森",0,0,0,0,CardRank.ブロンズ),
            new Card(66,2,CardClass.ロイヤル,CardType.フォロワー,"オースレスナイト",1,1,3,3,CardRank.ブロンズ),
            new Card(67,2,CardClass.ロイヤル,CardType.フォロワー,"クノイチエッグ",2,1,4,3,CardRank.ブロンズ),
            new Card(68,2,CardClass.ロイヤル,CardType.フォロワー,"不屈の兵士",2,2,4,4,CardRank.ブロンズ),
            new Card(69,2,CardClass.ロイヤル,CardType.フォロワー,"パレスフェンサー",2,1,4,3,CardRank.ブロンズ),

            //Page8
            new Card(70,2,CardClass.ロイヤル,CardType.フォロワー,"サイクロンソルジャー",3,1,5,3,CardRank.ブロンズ),
            new Card(71,2,CardClass.ロイヤル,CardType.フォロワー,"ケンタウロスヴァンガード",2,1,4,3,CardRank.ブロンズ),
            new Card(72,2,CardClass.ロイヤル,CardType.フォロワー,"歴戦のランサー",2,2,4,4,CardRank.ブロンズ),
            new Card(73,2,CardClass.ロイヤル,CardType.フォロワー,"メイドリーダー",1,1,3,3,CardRank.シルバー),
            new Card(74,2,CardClass.ロイヤル,CardType.フォロワー,"アサシン",2,1,4,3,CardRank.シルバー),
            new Card(75,2,CardClass.ロイヤル,CardType.フォロワー,"ルミナスナイト",2,1,3,2,CardRank.シルバー),
            new Card(76,2,CardClass.ロイヤル,CardType.フォロワー,"プリンセスヴァンガード",1,3,3,5,CardRank.シルバー),
            new Card(77,2,CardClass.ロイヤル,CardType.フォロワー,"勇敢なる旗手",2,1,4,3,CardRank.ブロンズ),
            new Card(78,2,CardClass.ロイヤル,CardType.フォロワー,"ガンナーメイド・セリエ",2,2,4,4,CardRank.シルバー),
            new Card(79,2,CardClass.ロイヤル,CardType.フォロワー,"サブリーダー・ゲルト",2,2,4,4,CardRank.シルバー),
            new Card(80,2,CardClass.ロイヤル,CardType.フォロワー,"サムライ",2,2,4,4,CardRank.ブロンズ),

            //Page9
            new Card(81,2,CardClass.ロイヤル,CardType.スペル,"疾風怒濤",0,0,0,0,CardRank.ブロンズ),
            new Card(82,2,CardClass.ロイヤル,CardType.スペル,"兵士徴集",0,0,0,0,CardRank.シルバー),
            new Card(83,2,CardClass.ロイヤル,CardType.スペル,"渾身の一振り",0,0,0,0,CardRank.ブロンズ),
            new Card(84,2,CardClass.ロイヤル,CardType.アミュレット,"鉄壁の城塞",0,0,0,0,CardRank.シルバー),
            new Card(85,2,CardClass.ウィッチ,CardType.フォロワー,"ルーキーマジシャン・サミー",2,2,4,4,CardRank.ブロンズ),
            new Card(86,2,CardClass.ウィッチ,CardType.フォロワー,"ペンギンウィザード",2,2,4,4,CardRank.ブロンズ),
            new Card(87,2,CardClass.ウィッチ,CardType.フォロワー,"クラフトウォーロック",2,1,4,3,CardRank.ブロンズ),
            new Card(88,2,CardClass.ウィッチ,CardType.フォロワー,"ルーキーアルケミスト",2,2,4,4,CardRank.ブロンズ),
            new Card(89,2,CardClass.ウィッチ,CardType.フォロワー,"スカラーウィッチ",2,1,3,2,CardRank.シルバー),
            new Card(90,2,CardClass.ウィッチ,CardType.フォロワー,"古き魔術師・レヴィ",2,2,4,4,CardRank.ゴールド),
            new Card(91,2,CardClass.ウィッチ,CardType.フォロワー,"ドワーフアルケミスト",2,2,3,3,CardRank.シルバー),

            //Page10
            new Card(92,2,CardClass.ウィッチ,CardType.フォロワー,"マナリアウィザード・クレイグ",2,2,4,4,CardRank.ブロンズ),
            new Card(93,2,CardClass.ウィッチ,CardType.スペル,"マジックミサイル",0,0,0,0,CardRank.ブロンズ),
            new Card(94,2,CardClass.ウィッチ,CardType.スペル,"ゴーレムの錬成",0,0,0,0,CardRank.ブロンズ),
            new Card(95,2,CardClass.ウィッチ,CardType.スペル,"ウィンドブラスト",0,0,0,0,CardRank.ブロンズ),
            new Card(96,2,CardClass.ウィッチ,CardType.スペル,"虹の輝き",0,0,0,0,CardRank.ブロンズ),
            new Card(97,2,CardClass.ウィッチ,CardType.アミュレット,"雄大なる教え",0,0,0,0,CardRank.ブロンズ),
            new Card(98,2,CardClass.ウィッチ,CardType.アミュレット,"炎熱の術式",0,0,0,0,CardRank.ブロンズ),
            new Card(99,2,CardClass.ドラゴン,CardType.フォロワー,"ドラゴンライダー",2,2,4,4,CardRank.ブロンズ),
            new Card(100,2,CardClass.ドラゴン,CardType.フォロワー,"大嵐のドラゴン",2,1,4,3,CardRank.ブロンズ),

            //Page11
            new Card(101,2,CardClass.ドラゴン,CardType.フォロワー,"サンドストームドラゴン",1,4,3,6,CardRank.ブロンズ),
            new Card(102,2,CardClass.ドラゴン,CardType.フォロワー,"ファイアーリザード",2,1,4,3,CardRank.ブロンズ),
            new Card(103,2,CardClass.ドラゴン,CardType.フォロワー,"ドラゴニュートスカラー",1,2,3,4,CardRank.ゴールド),
            new Card(104,2,CardClass.ドラゴン,CardType.フォロワー,"変化する魔術師",2,2,4,4,CardRank.ゴールド),
            new Card(105,2,CardClass.ドラゴン,CardType.フォロワー,"ムシュフシュ",2,2,4,4,CardRank.ブロンズ),
            new Card(106,2,CardClass.ドラゴン,CardType.フォロワー,"荒牙の竜少女",2,2,4,4,CardRank.ブロンズ),
            new Card(107,2,CardClass.ドラゴン,CardType.フォロワー,"伊達政宗",2,2,4,4,CardRank.ゴールド),
            new Card(108,2,CardClass.ドラゴン,CardType.フォロワー,"ドラゴンテイマー",2,2,4,2,CardRank.ブロンズ),
            new Card(109,2,CardClass.ドラゴン,CardType.フォロワー,"煌牙の戦士・キット",2,1,4,3,CardRank.ブロンズ),
            new Card(110,2,CardClass.ドラゴン,CardType.スペル,"竜の託宣",0,0,0,0,CardRank.ブロンズ),
            new Card(111,2,CardClass.ドラゴン,CardType.スペル,"竜の翼",0,0,0,0,CardRank.ブロンズ),
            new Card(112,2,CardClass.ドラゴン,CardType.スペル,"ワイルドハント",0,0,0,0,CardRank.ブロンズ),

            //Page12
            new Card(113,2,CardClass.ドラゴン,CardType.スペル,"竜の伝令",0,0,0,0,CardRank.シルバー),
            new Card(114,2,CardClass.ドラゴン,CardType.スペル,"ドラゴニュートフィスト",0,0,0,0,CardRank.シルバー),
            new Card(115,2,CardClass.ドラゴン,CardType.スペル,"サラマンダーブレス",0,0,0,0,CardRank.ゴールド),
            new Card(116,2,CardClass.ドラゴン,CardType.アミュレット,"黄金竜の棲家",0,0,0,0,CardRank.シルバー),
            new Card(117,2,CardClass.ネクロマンサー,CardType.フォロワー,"スパルトイサージェント",2,2,4,4,CardRank.ブロンズ),
            new Card(118,2,CardClass.ネクロマンサー,CardType.フォロワー,"スペクター",2,1,4,3,CardRank.ブロンズ),
            new Card(119,2,CardClass.ネクロマンサー,CardType.フォロワー,"スケルトンヴァイパー",1,3,3,5,CardRank.ブロンズ),
            new Card(120,2,CardClass.ネクロマンサー,CardType.フォロワー,"スカルウィドウ",1,2,3,4,CardRank.ブロンズ),
            new Card(121,2,CardClass.ネクロマンサー,CardType.フォロワー,"ワイト",2,1,4,3,CardRank.ブロンズ),
            new Card(122,2,CardClass.ネクロマンサー,CardType.フォロワー,"レッサーマミー",2,2,4,4,CardRank.ブロンズ),
            new Card(123,2,CardClass.ネクロマンサー,CardType.フォロワー,"デッドリーウィドウ",2,2,4,4,CardRank.シルバー),

            //Page13
            new Card(124,2,CardClass.ネクロマンサー,CardType.フォロワー,"ダークコンジュラー",2,2,4,4,CardRank.ブロンズ),
            new Card(125,2,CardClass.ネクロマンサー,CardType.フォロワー,"シャドウリーパー",1,1,3,3,CardRank.ゴールド),
            new Card(126,2,CardClass.ネクロマンサー,CardType.フォロワー,"よろめく不死者",1,2,3,4,CardRank.シルバー),
            new Card(127,2,CardClass.ネクロマンサー,CardType.フォロワー,"怪犬の墓守",2,2,4,4,CardRank.ブロンズ),
            new Card(128,2,CardClass.ネクロマンサー,CardType.スペル,"消えぬ怨恨",0,0,0,0,CardRank.ブロンズ),
            new Card(129,2,CardClass.ネクロマンサー,CardType.スペル,"死への近道",0,0,0,0,CardRank.ブロンズ),
            new Card(130,2,CardClass.ネクロマンサー,CardType.スペル,"幽体化",0,0,0,0,CardRank.シルバー),
            new Card(131,2,CardClass.ネクロマンサー,CardType.スペル,"死者の帰還",0,0,0,0,CardRank.シルバー),
            new Card(132,2,CardClass.ヴァンパイア,CardType.フォロワー,"ナイトメア",2,2,4,4,CardRank.ブロンズ),

            //Page14
            new Card(133,2,CardClass.ヴァンパイア,CardType.フォロワー,"スウィートヴァンパイア",1,3,3,5,CardRank.ブロンズ),
            new Card(134,2,CardClass.ヴァンパイア,CardType.フォロワー,"リリム",2,1,4,3,CardRank.ブロンズ),
            new Card(135,2,CardClass.ヴァンパイア,CardType.フォロワー,"ヴェノムコブラ",1,3,3,5,CardRank.ブロンズ),
            new Card(136,2,CardClass.ヴァンパイア,CardType.フォロワー,"レイニーデビル",2,1,4,3,CardRank.ブロンズ),
            new Card(137,2,CardClass.ヴァンパイア,CardType.フォロワー,"ブラッドウルフ",2,1,4,3,CardRank.ブロンズ),
            new Card(138,2,CardClass.ヴァンパイア,CardType.フォロワー,"ダークサモナー",2,2,5,5,CardRank.シルバー),
            new Card(139,2,CardClass.ヴァンパイア,CardType.フォロワー,"享楽の悪魔",2,2,4,4,CardRank.ブロンズ),
            new Card(140,2,CardClass.ヴァンパイア,CardType.フォロワー,"サーペントチャーマー",3,2,5,4,CardRank.ブロンズ),
            new Card(141,2,CardClass.ヴァンパイア,CardType.フォロワー,"吸血鬼・ヴァンピィ",2,2,4,4,CardRank.ゴールド),
            new Card(142,2,CardClass.ヴァンパイア,CardType.フォロワー,"レヴィオンデューク・ユリウス",1,3,3,5,CardRank.ブロンズ),
            new Card(143,2,CardClass.ヴァンパイア,CardType.スペル,"血の取引",0,0,0,0,CardRank.ブロンズ),

            //Page15
            new Card(144,2,CardClass.ヴァンパイア,CardType.スペル,"鋭利な一裂き",0,0,0,0,CardRank.ブロンズ),
            new Card(145,2,CardClass.ヴァンパイア,CardType.スペル,"リミルの秘密",0,0,0,0,CardRank.ブロンズ),
            new Card(146,2,CardClass.ヴァンパイア,CardType.スペル,"眷属の召喚",0,0,0,0,CardRank.ブロンズ),
            new Card(147,2,CardClass.ヴァンパイア,CardType.スペル,"鮮血の口付け",0,0,0,0,CardRank.ブロンズ),
            new Card(148,2,CardClass.ヴァンパイア,CardType.スペル,"メデゥーサの魔眼",0,0,0,0,CardRank.シルバー),
            new Card(149,2,CardClass.ヴァンパイア,CardType.スペル,"群れなす飢餓",0,0,0,0,CardRank.シルバー),
            new Card(150,2,CardClass.ヴァンパイア,CardType.アミュレット,"吸血鬼の古城",0,0,0,0,CardRank.ゴールド),
            new Card(151,2,CardClass.ビショップ,CardType.フォロワー,"スネークプリースト",1,3,3,5,CardRank.ブロンズ),
            new Card(152,2,CardClass.ビショップ,CardType.フォロワー,"ラビットヒーラー",2,1,4,3,CardRank.ブロンズ),
            new Card(153,2,CardClass.ビショップ,CardType.フォロワー,"アーデントシスター",2,2,4,4,CardRank.ブロンズ),

            //Page16
            new Card(154,2,CardClass.ビショップ,CardType.フォロワー,"マイニュ",2,2,4,4,CardRank.ブロンズ),
            new Card(155,2,CardClass.ビショップ,CardType.フォロワー,"加護の修道女",1,2,3,4,CardRank.シルバー),
            new Card(156,2,CardClass.ビショップ,CardType.フォロワー,"天界の忠犬",2,2,4,4,CardRank.ブロンズ),
            new Card(157,2,CardClass.ビショップ,CardType.フォロワー,"煌翼の戦士・リノ",2,2,4,4,CardRank.シルバー),
            new Card(158,2,CardClass.ビショップ,CardType.フォロワー,"フロッグクレリック",2,2,4,4,CardRank.ブロンズ),
            new Card(159,2,CardClass.ビショップ,CardType.スペル,"気高き教理",0,0,0,0,CardRank.ブロンズ),
            new Card(160,2,CardClass.ビショップ,CardType.スペル,"漆黒の法典",0,0,0,0,CardRank.ブロンズ),
            new Card(161,2,CardClass.ビショップ,CardType.スペル,"愛の福音",0,0,0,0,CardRank.ゴールド),
            new Card(162,2,CardClass.ビショップ,CardType.スペル,"僧侶の聖水",0,0,0,0,CardRank.ブロンズ),
            new Card(163,2,CardClass.ビショップ,CardType.アミュレット,"詠唱：聖獣への誓い",0,0,0,0,CardRank.ブロンズ),
            new Card(164,2,CardClass.ビショップ,CardType.アミュレット,"詠唱：異端審問",0,0,0,0,CardRank.ブロンズ),
            new Card(165,2,CardClass.ビショップ,CardType.アミュレット,"守護の陽光",0,0,0,0,CardRank.ブロンズ),

            //Page17
            new Card(166,2,CardClass.ビショップ,CardType.アミュレット,"詠唱：聖獅子の牙",0,0,0,0,CardRank.シルバー),
            new Card(167,2,CardClass.ビショップ,CardType.アミュレット,"詠唱：神域の守護者",0,0,0,0,CardRank.ゴールド),
            new Card(168,2,CardClass.ビショップ,CardType.アミュレット,"詠唱：天喰らう聖竜",0,0,0,0,CardRank.ゴールド),
            new Card(169,2,CardClass.ビショップ,CardType.アミュレット,"詠唱：神鉄の翼",0,0,0,0,CardRank.ブロンズ),
            new Card(170,2,CardClass.ビショップ,CardType.アミュレット,"詠唱：獣姫の呼び声",0,0,0,0,CardRank.ブロンズ),



        };
    }
}
