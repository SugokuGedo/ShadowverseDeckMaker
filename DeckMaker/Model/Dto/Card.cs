using DeckMaker.Model.Enums;

namespace DeckMaker.Model.Dto
{
    public class Card
    {
        public Card(int id, int cost, CardClass cardClass, CardType cardType, string name,int attack, int hp, int evolvedAttack, int evolvedHp, CardRank rank)
        {
            Id = id;
            Cost = cost;
            CardClass = cardClass;
            CardType = CardType;
            Name = name;
            Attack = attack;
            Hp = hp;
            EvolvedAttack = evolvedAttack;
            EvolvedHp = evolvedHp;
            Rank = rank;
        }

        public int Id { get; set; }

        public int Cost { get; set; }

        public CardClass CardClass { get; set; }

        public CardType CardType { get; set; }

        public string Name { get; set; }

        public int Attack { get; set; }

        public int Hp { get; set; }

        public int EvolvedAttack { get; set; }

        public int EvolvedHp { get; set; }

        public CardRank Rank { get; set; }
    }
}
