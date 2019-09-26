using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlesUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
            switch(cbFigura.SelectedIndex)
            {
                case 0: //Circulo
                    grdParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;
                case 1: //Triangulo
                    grdParametrosFigura.Children.Add(new ParametrosTriangulo());
                    break;
                case 2: //Rectangulo
                    grdParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;
                case 3: //Pentagono
                    grdParametrosFigura.Children.Add(new ParametrosPentagono());
                    break;
                case 4: //Cuadrado
                    grdParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;
                case 5: //Trapecio
                    grdParametrosFigura.Children.Add(new ParametrosTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;

            switch(cbFigura.SelectedIndex)
            {
                case 0: //Circulo
                    double radio = double.Parse(((ParametrosCirculo)(grdParametrosFigura.Children[0])).txtRadio.Text);
                    area = Math.PI * radio * radio;
                    break;
                case 1: //Triangulo
                    double baseTriangulo = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtBaseTriangulo.Text);
                    double alturaTriangulo = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtBaseTriangulo.Text);
                    area = baseTriangulo * alturaTriangulo / 2;
                    break;
                case 2: //Rectangulo
                    double baseRectangulo = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtBaseRectangulo.Text);
                    double alturaRectangulo = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtAlturaRectangulo.Text);
                    area = baseRectangulo * alturaRectangulo;
                    break;
                case 3: //Pentagono
                    double perimetro = double.Parse(((ParametrosPentagono)(grdParametrosFigura.Children[0])).txtPerimetro.Text);
                    double apotema = double.Parse(((ParametrosPentagono)(grdParametrosFigura.Children[0])).txtApotema.Text);
                    area = perimetro * apotema / 2;
                    break;
                case 4: //Cuadrado
                    double lado = double.Parse(((ParametrosCuadrado)(grdParametrosFigura.Children[0])).txtLado.Text);
                    area = lado * lado;
                    break;
                case 5: //Trapecio
                    double baseMayor = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBaseMayor.Text);
                    double baseMenor = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBaseMenor.Text);
                    double alturaTrapecio = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtAlturaTrapecio.Text);
                    area = baseMayor * baseMenor / 2 * alturaTrapecio;
                    break;
                default:
                    break;
            }
            lblResultado.Text = area.ToString();
        }
    }
}
