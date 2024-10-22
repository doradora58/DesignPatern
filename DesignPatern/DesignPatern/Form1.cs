using DesignPatern.Objects;

namespace DesignPatern
{
    public partial class Form1 : Form
    {
        //private int _marioX = 10;
        //private int _marioY = 10;
        //private int _marioCount = 0;

        //private int _luigX = 10;
        //private int _luigY = 50;
        //private int _luigCount = 0;
        private List<CharaBase> _charas = new List<CharaBase>();
        private CharaBase _selectedChara;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _charas.Add(new Mario());
            _charas.Add(new Luig());
            _selectedChara = _charas[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(
            //    new SolidBrush(Color.Red), _marioX, _marioY, 30, 30);
            //e.Graphics.FillRectangle(
            //    new SolidBrush(Color.Green), _luigX, _luigY, 30, 30);
            foreach (CharaBase chara in _charas)
            {
                e.Graphics.FillRectangle(new SolidBrush(chara.Color), chara.X, chara.Y, 30, 30);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            //    if (MarioRadioButton.Checked)
            //    {
            //        _marioX += 10;
            //        panel1.Refresh();
            //        return;
            //    }
            //    if (LuigRadioButton.Checked)
            //    {
            //        _luigX += 20;
            //        panel1.Refresh();
            //        return;
            //    }
            _selectedChara.Right();
            panel1.Refresh();
        }

        private void AButton_Click(object sender, EventArgs e)
        {

            //if (MarioRadioButton.Checked)
            //{
            //    _marioCount++;
            //    if (_marioCount >= 3)
            //    {
            //        _marioCount = 0;
            //        MessageBox.Show("I am Mario");
            //    }
            //    return;


            //}

            //if (LuigRadioButton.Checked)
            //{
            //    _luigCount++;
            //    if (_luigCount >= 5)
            //    {
            //        _luigCount = 0;
            //        MessageBox.Show("I am Luig");
            //    }
            //    return;
            //}
            if (_selectedChara.IsMessageTiming())
            {
                MessageBox.Show(_selectedChara.GetMessage());
            }

        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (MarioRadioButton.Checked)
            {
                _selectedChara = _charas[0];
                return;
            }
            if (LuigRadioButton.Checked)
            {
                _selectedChara = _charas[1];
                return;
            }
        }
    }
}
