/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 июля 2026 15:34:03
 * Version: 1.0.270
 */

using System.Windows;

namespace Herodotus.Views
{
    public partial class StepCardView : System.Windows.Controls.UserControl
    {
        public StepCardView()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            // Сбрасываем активную карточку
            if (DataContext is ViewModels.MainWindowViewModel vm)
            {
                vm.ActiveStepCard = null;
            }
        }
    }
}
