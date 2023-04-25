using FannyMath.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FannyMath
{
    public partial class EquationWindow : Form
    {
        private EquationScoreModel _equationScoreModel;
        public EquationWindow(EquationScoreModel equationScoreModel)
        {
            InitializeComponent();
            _equationScoreModel = equationScoreModel;
        }
    }
}
