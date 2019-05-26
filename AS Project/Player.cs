using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace AS_Project
{
    public class Player
    {
        private string _username;
        private int _money;
        private int _position;
        private int _questionScore;
        private int _amountOfProperties;
        private Image _avatar;
        private Image _token;
        private Color _pColor;
        private bool _inJail;
        private int _jailCounter;
        private int _timeInJail;

        #region Constructors
        // Constructors
        public Player()
        {
            _username = "";
            _money = 5000;
            _questionScore = 0;
            _avatar = null;
            _position = 0;
        }

        public Player(string PlayerName)
        {
            _username = PlayerName;
            _money = 5000;
            _questionScore = 0;
            _avatar = null;
            _position = 0;
        }
        // End of Constructors
        #endregion

        public string Name
        {
            get
            { return _username; }
            set
            { _username = value; }
        }

        public int Money
        {
            get
            { return _money; }
            set
            { _money = value; }
        }

        public Color Colour
        {
            get { return _pColor; }
            set { _pColor = value; }
        }

        public int Position
        {
            get
            { return _position; }
            set
            { _position = value; }
        }

        public Image Avatar
        {
            get
            { return _avatar; }
            set
            { _avatar = value; }
        }

        public Image Token
        {
            get
            { return _token; }
            set
            { _token = value; }
        }

        public int Score
        {
            get
            { return _questionScore; }
            set
            { _questionScore = value; }
        }

        public int PropertyCount
        {
            get
            { return _amountOfProperties; }
            set
            { _amountOfProperties = value; }
        }

        public bool IsInJail
        {
            get
            { return _inJail; }
            set
            { _inJail = value; }
        }

        public int JailDuration
        {
            get
            { return _jailCounter; }
            set
            { _jailCounter = value; }
        }

        public int GoneToJail
        {
            get { return _timeInJail; }
            set { _timeInJail = value; }
        }
    }
}
