using DeckMaker.Model.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckMaker
{
    public partial class DeckMaker : Form
    {
        public DeckMaker()
        {
            InitializeComponent();

            var comboBoxData = new List<Character>
            {
                new Character("エルフ",Model.Enums.Role.エルフ),
                new Character("ロイヤル",Model.Enums.Role.ロイヤル),
                new Character("ウィッチ",Model.Enums.Role.ウィッチ),
                new Character("ドラゴン",Model.Enums.Role.ドラゴン),
                new Character("ネクロマンサー",Model.Enums.Role.ネクロマンサー),
                new Character("ヴァンパイア",Model.Enums.Role.ヴァンパイア),
                new Character("ビショップ",Model.Enums.Role.ビショップ),
            };

            comboBox.DataSource = comboBoxData;
            comboBox.DisplayMember = "RoleName";
            comboBox.ValueMember = "Role";

        }

        private void CreateDeck(object sender, EventArgs e)
        {
            textBox.Text = "ほげ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
