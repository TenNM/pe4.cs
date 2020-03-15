using System;
using System.Windows.Forms;

namespace pe4
{
    public partial class Calc : Form
    {
        const string ERR_INPUT_DATA = "Ошибка: входные данные неверны";
        const string ERR_EMPTY_FIELDS = "Ошибка: пустые поля";
        const string ERR_NO_ROOTS_ON_AB = "Ошибка: на данном отрезке нет корней";
        Function f = new Function();
        double x, a, b, c, e;
        public Calc()
        {
            InitializeComponent();
            f.change_foo(1);
            textBoxBorderA.Text = "-5";
            textBoxBorderB.Text = "5";
            textBoxEps.Text = "0,001";
        }
        //----------------------------------------------------------------service
        void drowOnChart(Function.deledate_foo foo, double a, double b)
        {
            chartFoo.Series[0].Points.Clear();
            for (double i = a; i < b; i+= 0.01) {
                chartFoo.Series[0].Points.AddXY(i, foo(i));
            }
        }
        private bool fieldsIsEmpty()
        {
            return (textBoxBorderA.Text.Length == 0) ||
                   (textBoxBorderB.Text.Length == 0) ||
                   (textBoxEps.Text.Length == 0);
        }
        bool isRootsOnAB(Function.deledate_foo foo, double a, double b)
        {
            return foo(a) * foo(b) < 0;
        }
        //--------------------------------------------------------------------combine
        void searchRoots(char method)
        {
            if (!fieldsIsEmpty()) {
                try
                {
                    a = double.Parse(textBoxBorderA.Text);
                    b = double.Parse(textBoxBorderB.Text);
                    e = double.Parse(textBoxEps.Text);
                }
                catch
                {
                    MessageBox.Show(ERR_INPUT_DATA);
                }

                if (isRootsOnAB(f.d_foo, a, b)) {
                    f.e = e;
                    switch (method)
                    {
                        case 'n': {
                            x = f.Newton( (a+b)/2 + 10*e );
                        } break;
                        case 'd': {
                            x = f.dichotomy(a, b);
                        } break;
                    }
                    textBoxResult.Text = x.ToString();
                    
                } else MessageBox.Show(ERR_NO_ROOTS_ON_AB);
            }
            else MessageBox.Show(ERR_EMPTY_FIELDS);

            drowOnChart(f.d_foo, a, b);
        }
        //--------------------------------------------------------------------------GUI
        void RadioButtonFoo1_CheckedChanged(object sender, EventArgs e){ f.change_foo(1); }
        void RadioButtonFoo2_CheckedChanged(object sender, EventArgs e){ f.change_foo(2); }
        private void ButtonNewton_Click(object sender, EventArgs e)  { searchRoots('n'); }
        private void ButtonDichtomy_Click(object sender, EventArgs e){ searchRoots('d'); }
        //----------------------------------------------------------------------end
    }
}
