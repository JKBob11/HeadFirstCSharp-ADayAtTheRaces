using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DogRacing
{
    class Greyhound
    {
        private int _startingposition;
        private PictureBox _myPictureBox;
        private int _location = 0;
        private Random _randomizer;
        private int _raceTrackLength;

        public string Number { get; }

        public Greyhound(PictureBox pictureBox, Random randomizer, int raceTrackLength)
        {
            this._myPictureBox = pictureBox;
            this.Number = Regex.Match(pictureBox.Name, @"\d+").Value;
            this._startingposition = _myPictureBox.Left;
            this._randomizer = randomizer;
            this._raceTrackLength = raceTrackLength;
        }

        public bool Run()
        {
            _location += _randomizer.Next(1, 10);
            _myPictureBox.Left = _startingposition + _location;

            if (_myPictureBox.Right > _raceTrackLength)
                return true;

            return false;
        }

        public void TakeStartingPosition()
        {
            _location = 0;
            _myPictureBox.Left = _startingposition;
        }

    }
}