using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace DogRacing
{
    class Guy
    {
        private string _name;
        private Label _label;
        private bool _holdBets = false;

        public Bet Bet { get; private set; }
        public RadioButton RadioButton { get; }
        public decimal BankRole { get; private set; }

        public Guy(string name, decimal bankRole, Label label, RadioButton radioButton)
        {
            this.BankRole = bankRole;
            this._name = name;
            this._label = label;
            this.RadioButton = radioButton;
            this.Bet = new Bet(0, 0, _name);
        }

        public void UpdateLabels(bool betOk = true)
        {
            RadioButton.Text = String.Format("{0} has ${1} available", _name, BankRole);

            if (!betOk)
            {
                _label.Text = String.Format("Unable to place this bet");
                return;
            }

            _label.Text = this.Bet.GetDescription();
        }

        public bool PlaceBet(decimal amount, int dog)
        {
            if (_holdBets)
                return false;

            if (amount <= BankRole)
            {
                Bet = new Bet(amount, dog, _name);
                return true;
            }

            ClearBet();
            return false;
        }

        public void ClearBet()
        {
            Bet = new Bet(0, 0, _name);
        }

        public void Collect(bool winner)
        {
            if (winner)
                BankRole += Bet.Amount*2;
            else
                BankRole -= Bet.Amount;
        }

        public void HoldBets()
        {
            this._holdBets = true;
        }

        public void ResumeBets()
        {
            this._holdBets = false;
        }
    }
}