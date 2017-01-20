using DeckMaker.Model.Enums;

namespace DeckMaker.Model.Dto
{
    public class Character
    {
        public Character(string roleName, Role role)
        {
            RoleName = roleName;
            Role = role;
        }
        public string RoleName { get; set; }

        public Role Role { get; set; }
    }
}
